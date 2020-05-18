using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class MuscleGroup
    {
        public int _muscleId;
        public string _name;

        //public MuscleGroup()
        //{
            
        //}
        public MuscleGroup(int muscleId, string name)
        {
            _muscleId = muscleId;
            _name = name;
        }

        public int Muscles_ID
        {
            get { return _muscleId;}
            set { _muscleId = value;}
        }
        public string mgName
        {
            get { return _name;}
            set { _name = value;}
        }

        public override string ToString()
        {
            return $"{mgName}";
        }
    }
}
