using ExerciseTrackerClient;

internal class CreateWorkoutService
{
    internal static Workout newWorkout()
    {
        DateTime start;
        DateTime end;
        Workout newWorkout;
        long duration;
        TimeSpan timeSpan;
        string comment;

        Console.WriteLine("Write your start time (HH:mm)");
        string input = Console.ReadLine();

        while(!InputValidationService.DateValidation(input))
        {
            Console.WriteLine("Unrecogniseable format (HH:mm). Try again");
            input = Console.ReadLine();
        }

        if (input == "return")
            return null;

        start = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + input);

        Console.WriteLine("Write your end time (HH:mm)");
        input = Console.ReadLine();

        while (!InputValidationService.DateValidation(input))
        {
            Console.WriteLine("Unrecogniseable format (HH:mm). Try again");
            input = Console.ReadLine();
        }

        if (input == "return")
            return null;

        end = DateTime.Parse(DateTime.Now.ToShortDateString() + " " + input);

        timeSpan = end - start;
        duration = timeSpan.Ticks;

        Console.WriteLine("Would you like to make a Note for this workout");
        Console.WriteLine("Type 0 to leave it blank");
        comment = Console.ReadLine();

        if(comment == "" || comment == "0")
        {
            comment = "";
        }

        newWorkout = new Workout
        {
            DateStart = start,
            DateEnd = end,
            Duration = duration,
            Comments = comment
        };

        return newWorkout;
    }
}