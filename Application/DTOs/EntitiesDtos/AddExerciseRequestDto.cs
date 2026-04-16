using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.EntitiesDtos
{
    public class AddExerciseRequestDto
    {
        public Guid WorkoutSessionId { get; set; }
        public string Name { get; set; }
        public ExerciseType Type { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float? WeightKg { get; set; }
        public int? DurationMinutes { get; set; }
    }
}
