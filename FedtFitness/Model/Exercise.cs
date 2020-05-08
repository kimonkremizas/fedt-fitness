using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class Exercise
    {
        public int Workout_id { get; set; }
        public int Exercise_id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Equipment_id { get; set; }
        public int Muscles_id { get; set; }
        public string Description { get; set; }

        public Exercise(int workoutId, int exerciseId, string name, int length, int equipmentId, int musclesId,
            string description)
        {
            Workout_id = workoutId;
            Exercise_id = exerciseId;
            Name = name;
            Length = length;
            Equipment_id = equipmentId;
            Muscles_id = musclesId;
            Description = description;
        }
    }
}
