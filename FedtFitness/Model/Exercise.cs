using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class Exercise
    {
        public int _workoutId { get; set; }
        public int _exerciseId { get; set; }
        public string _name { get; set; }
        public int _length { get; set; }
        public int _equipmentId { get; set; }
        public int _musclesId { get; set; }
        public string _description { get; set; }

        public Exercise(int workoutId, int exerciseId, string name, int length, int equipmentId, int musclesId,
            string description)
        {
            _workoutId = workoutId;
            _exerciseId = exerciseId;
            _name = name;
            _length = length;
            _equipmentId = equipmentId;
            _musclesId = musclesId;
            _description = description;
        }
    }
}
