using System.Text.RegularExpressions;
using ExerciseTrackerClient;

internal class InputValidationService
{

    internal static int IdValidation(List<Workout> workouts)
    {
        int id = 0;

        Console.Write("Please enter Workout ID: ");

        string input = Console.ReadLine();

        if (ReturnCheck(input))
            return -1;

        while (!int.TryParse(input, out id) || workouts.Exists(workout => workout.WorkoutsId == id) == false)
        {
            Console.WriteLine($"Id: {input}, does not exist");
            Console.WriteLine("Try again: ");
            input = Console.ReadLine();
        }
        return id;
    }

    internal static DateTime DateValidation()
    {
        string pattern = @"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d))$";
        Regex regex = new Regex(pattern);
        var start = DateTime.Now.ToShortDateString();

        Console.WriteLine("Time: ");
        string input = Console.ReadLine();

        if (ReturnCheck(input))


        while (!regex.IsMatch(input))
        {
            Console.WriteLine("Unrecogniseable format, try again (HH:mm)");
            input = Console.ReadLine();
        }

        return DateTime.Parse(start + " " +input);
    }

    internal static bool ReturnCheck(string input)
    {
        if(input == "return")
        {
            return true;
        }
        return false;
    }
}