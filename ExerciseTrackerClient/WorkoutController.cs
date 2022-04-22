using System.Net.Http.Json;
using ExerciseTrackerClient;
using Newtonsoft.Json;

internal class WorkoutController
{
    private static readonly string connectionString = "https://localhost:7271/api/Workouts";
    internal static List<Workout> GetWorkouts()
    {
        using var client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(connectionString).Result;

        if(response.IsSuccessStatusCode)
        {
            var resp = response.Content.ReadAsStringAsync().Result;
            List<Workout> workouts = JsonConvert.DeserializeObject<List<Workout>>(resp);
            return workouts;
        }
        else
        {
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
        }
        return null;
    }

    internal static void RemoveWorkout(int id)
    {
        using var client = new HttpClient();
        var response = client.DeleteAsync(connectionString + $"/{id}").Result;

        if (response.IsSuccessStatusCode)
            Console.WriteLine("Success");

        else
            Console.WriteLine("Error");
    }

    internal static void CreateWorkout(object newWorkout)
    {
        using var client = new HttpClient();
        var response = client.PostAsJsonAsync(connectionString, newWorkout).Result;

        if (response.IsSuccessStatusCode)
            Console.WriteLine("Success");

        else
            Console.WriteLine("Error");
    }

    internal static Workout GetWorkoutById(int id)
    {
        using var client = new HttpClient();

        HttpResponseMessage response = client.GetAsync(connectionString + $"/{id}").Result;

        if (response.IsSuccessStatusCode)
        {
            var resp = response.Content.ReadAsStringAsync().Result;
            Workout workout = JsonConvert.DeserializeObject<Workout>(resp);
            return workout;
        }
        else
        {
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
        }
        return null;
    }

    internal static void UpdateWorkout(Workout updatedWorkout)
    {
        using var client = new HttpClient();
        var response = client.PutAsJsonAsync(connectionString + $"/{updatedWorkout.WorkoutsId}", updatedWorkout).Result;

        if (response.IsSuccessStatusCode)
            Console.WriteLine("Success");

        else
            Console.WriteLine("Error");
    }
}