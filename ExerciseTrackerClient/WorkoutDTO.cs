using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTrackerClient
{
    internal class WorkoutDTO
    {
        public int WorkoutsId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long Duration { get; set; }

        private TimeSpan duration;
        public TimeSpan DurationSpan
        {
            get { return duration; }
            set { duration = TimeSpan.FromTicks(Duration); }
        }
        public string Comments { get; set; }

        public override string ToString()
        {
            return $"WorkoutsID: {WorkoutsId}, Start: {DateStart}, End: {DateEnd}, Duration: {duration}, Comments: {Comments}";
        }
    }
}
