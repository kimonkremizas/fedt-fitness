using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class MuscleGroup
    {
        public int _muscleId { get; set; }
        public string _name { get; set; }

        public MuscleGroup(int muscleId, string name)
        {
            _muscleId = muscleId;
            _name = name;
        }
    }
}
