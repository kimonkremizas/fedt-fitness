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
        private int _eqId;
        private string _eqName;

        //public Equipment()
        //{

        //}

        public Equipment(int equipmentId, string name)
        {
            _eqId = equipmentId;
            _eqName = name;
        }

        public int Equipment_ID
        {
            get { return _eqId; }
            set { _eqId = value;}
        }

        public string Name
        {
            get { return _eqName; }
            set { _eqName = value;}
        }

        public override string ToString()
        {
            return $"{_eqName}";
        }
    }
}
