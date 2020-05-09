using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class Exercise
    {
        public int _workoutId;
        public int _exerciseId;
        public string _name;
        public int _length;
        public int _equipmentId;
        public int _musclesId;
        public string _description;

        public Exercise()
        {
            
        }

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

        public int EwID
        {
            get { return _workoutId;}
            set { _workoutId = value;}
        }

        public int EeID
        {
            get { return _exerciseId;}
            set { _exerciseId = value; }
        }

        public string EName
        {
            get { return _name;}
            set { _name = value;}
        }

        public int ELenght
        {
            get { return _length;}
            set { _length = value;}
        }

        public int EeqID
        {
            get { return _equipmentId;}
            set { _equipmentId = value;}
        }

        public int EmgID
        {
            get { return _musclesId;}
            set { _musclesId = value;}
        }

        public string EDescrip
        {
            get { return _description;}
            set { _description = value;}
        }




    }
}
