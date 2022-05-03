using System.Text.RegularExpressions;
using ExerciseTrackerClient;

public class InputValidationService
{

    public static bool IdValidation(List<Workout> workouts, string id)
    {
        if (id == "return")
            return true;

        if(!int.TryParse(id, out int result) || (workouts.Exists(id => id.WorkoutsId == result) == false))
        {
            return false;
        }

        return true;
    }

    public static bool DateValidation(string input)
    {
        string pattern = @"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d))$";
        Regex regex = new Regex(pattern);
        if(input == "return")
            return true;

        return regex.IsMatch(input);
    }
}