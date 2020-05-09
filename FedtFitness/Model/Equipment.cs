using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class Equipment
    {
        public int _equipmentId;
        public string _name;

        public Equipment()
        {
            
        }

        public Equipment(int equipmentId, string name)
        {
            _equipmentId = equipmentId;
            _name = name;
        }

        public int TeqID
        {
            get { return _equipmentId;}
            set { _equipmentId = value;}
        }

        public string TName
        {
            get { return _name;}
            set { _name = value;}
        }
    }
}
