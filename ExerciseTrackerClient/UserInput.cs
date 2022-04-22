using ExerciseTrackerClient;

internal class UserInput
{
    internal void MainMenu()
    {
        bool closeApp = false;
        while(closeApp == false)
        {
            Console.WriteLine("\n\nEXERCISE TRACKER\n\n");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 1 to View all Workouts");
            Console.WriteLine("Press 2 to Create new Workout");
            Console.WriteLine("Press 3 to Update a Workout");
            Console.WriteLine("Press 4 to Delete a Workout");
            Console.WriteLine("Press 5 to View a Specific Workout");
            Console.WriteLine("Press 0 to Close the Application");

            string commandInput = Console.ReadLine();

            switch(commandInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    ProcessGet();
                    break;
                case "2":
                    ProcessCreate();
                    break;
                case "3":
                    ProcessUpdate();
                    break;
                case "4":
                    ProcessDelete();
                    break;
                case "5":
                    ProcessGetById();
                    break;
                default:
                    Console.Write("Invalid input, please choose a valid input");
                    break;
            }
        }
    }
    //This method does not make sense
    private void ProcessGetById()
    {
        var workoutList = WorkoutController.GetWorkouts();
        WorkoutVizualiserService.ShowWorkout(workoutList);

        Console.WriteLine("Which workout would you like to Look at?");
        int id = InputValidationService.IdValidation(workoutList);

        if(id == -1)
            return;

        Workout workout = WorkoutController.GetWorkoutById(id);
        WorkoutDTO workoutDTO = new()
        {
            WorkoutsId = workout.WorkoutsId,
            Duration = workout.Duration,
            DateStart = workout.DateStart,
            DateEnd = workout.DateEnd,
            Comments = workout.Comments,
            DurationSpan = new()
        };
        Console.WriteLine("\n"+workoutDTO.ToString());
    }

    private void ProcessUpdate()
    {
        var workoutList = WorkoutController.GetWorkouts();
        WorkoutVizualiserService.ShowWorkout(workoutList);

        Console.WriteLine("Which workout would you like to Update?");
        int id = InputValidationService.IdValidation(workoutList);

        if (id == -1)
            return;

        Workout updatedWorkout = CreateWorkoutService.newWorkout();

        updatedWorkout.WorkoutsId = id;

        WorkoutController.UpdateWorkout(updatedWorkout);
    }

    private void ProcessCreate()
    {
        var newWorkout = CreateWorkoutService.newWorkout();

        if (newWorkout == null)
            return;

        WorkoutController.CreateWorkout(newWorkout);
    }

    private void ProcessDelete()
    {
        var workoutList = WorkoutController.GetWorkouts();
        WorkoutVizualiserService.ShowWorkout(workoutList);

        Console.WriteLine("Which workout would you like to Delete?");
        int id = InputValidationService.IdValidation(workoutList);

        WorkoutController.RemoveWorkout(id);
    }

    private async void ProcessGet()
    {
        var workoutList = WorkoutController.GetWorkouts();
        WorkoutVizualiserService.ShowWorkout(workoutList);
    }
}