using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class WorkoutSession
    {
        public Guid UserId { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime? EndTime { get; private set; }
        public string? Notes { get; private set; }
        public int DurationMinutes => EndTime.HasValue ? (int)(EndTime.Value - StartTime).TotalMinutes : 0;

        private List<Exercise> Exercises { get; } = [];
        public IReadOnlyCollection<Exercise> muscles => Exercises;
        public static WorkoutSession Start(Guid userId, DateTime? startTime = null)
        {
            if (userId != Guid.Empty)
                return new WorkoutSession
                {
                    UserId = userId,
                    StartTime = startTime ?? DateTime.UtcNow
                };
            else
                throw new ArgumentException("UserId is required."); // should log it instead, dont throw exceptions, do something
        }
        public void Finish(DateTime? endTime = null)
        {
            if (EndTime.HasValue)
                endTime = endTime ?? DateTime.UtcNow;

            else if (StartTime > endTime)
                throw new ArgumentException("End time cannot be before start time.");

            else
                throw new ArgumentException("UserId is required."); // should log it instead, dont throw exceptions, do something
        }
        public void AddExercise(Exercise exercise)
        {
            ArgumentNullException.ThrowIfNull(exercise);
            Exercises.Add(exercise);
        }

        public void AddNote(string notes)
        {
            Notes = notes?.Trim();
        }

        private WorkoutSession() { }
    }
}
