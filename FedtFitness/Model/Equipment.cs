using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    public class Equipment
    {
        public int _equipmentId;
        public string _name;

        //public Equipment()
        //{

        //}

        public Equipment(int equipmentId, string name)
        {
            _equipmentId = equipmentId;
            _name = name;
        }

        public int eqId
        {
            get { return _equipmentId;}
            set { _equipmentId = value;}
        }

        public string eqName
        {
            get { return _name;}
            set { _name = value;}
        }

        public override string ToString()
        {
            return $"{eqName}";
        }
    }
}
