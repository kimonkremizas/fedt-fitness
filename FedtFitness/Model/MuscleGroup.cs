﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class MuscleGroup
    {
        public int Muscle_id { get; set; }
        public string Name { get; set; }

        public MuscleGroup(int muscleId, string name)
        {
            Muscle_id = muscleId;
            Name = name;
        }
    }
}
