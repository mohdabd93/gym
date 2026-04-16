using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double BMI => Weight / (Height * Height);

        private List<WorkoutSession> workoutSessions { get; set; } = new();
        public IReadOnlyCollection<WorkoutSession> workOut => workoutSessions;
        private List<ExerciseType> exerciseTypes { get; set; } = new();
        public IReadOnlyCollection<ExerciseType> exercises => exerciseTypes;
        public bool AddWorkOut(WorkoutSession workoutSession)
        {
            if (workoutSession == null)
                return false;

            workoutSessions.Add(workoutSession);
            return true;
        }
        public bool AddExerciseType(ExerciseType exerciseType)
        {
            bool failed = false;
            if (exercises != null)
                exerciseTypes.Add(exerciseType);
            else
                failed = true;
            return failed;
        }
         
    }
}
