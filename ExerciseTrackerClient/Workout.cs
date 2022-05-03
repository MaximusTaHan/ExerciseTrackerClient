using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTrackerClient
{
    public class Workout
    {
        public int WorkoutsId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long Duration { get; set; }
        public string Comments { get; set; }

        public override string ToString()
        {
            return $"WorkoutsID: {WorkoutsId}, Start: {DateStart}, End: {DateEnd}, Duration: {Duration}, Comments: {Comments}";
        }
    }
}
