using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exercise
    {
        public Guid WorkoutSessionId { get; private set; }
        public string Name { get; private set; } = default!;
        public ExerciseType Type { get; private set; }
        public MuscleGroup MuscleGroup { get; private set; }
        public int Sets { get; private set; }
        public int Reps { get; private set; }
        public float? WeightKg { get; private set; }   // null 
        public int? DurationSeconds { get; private set; }   // null 
        public string? Notes { get; private set; }

        public static Exercise Create(
            Guid workoutSessionId,
            string name,
            ExerciseType type,
            MuscleGroup muscleGroup,
            int sets,
            int reps,
            float? weightKg = null,
            int? durationSeconds = null)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            if (sets <= 0) throw new ArgumentException("Sets must be greater than 0.");
            if (reps <= 0) throw new ArgumentException("Reps must be greater than 0.");

            return new Exercise
            {
                WorkoutSessionId = workoutSessionId,
                Name = name.Trim(),
                Type = type,
                MuscleGroup = muscleGroup,
                Sets = sets,
                Reps = reps,
                WeightKg = weightKg,
                DurationSeconds = durationSeconds
            };
        }

        public void UpdatePerformance(int sets, int reps, float? weightKg)
        {
            Sets = sets;
            Reps = reps;
            WeightKg = weightKg;
        }

        private Exercise() { }
    }
}
