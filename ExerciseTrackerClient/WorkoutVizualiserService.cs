using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace ExerciseTrackerClient
{
    internal class WorkoutVizualiserService
    {
        internal static void ShowWorkout<T>(List<T> tableData) where T : class
        {
            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tableData)
                .ExportAndWriteLine();
            Console.WriteLine("\n\n");
        }
    }
}
