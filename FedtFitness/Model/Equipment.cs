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
        public int _equipmentId { get; set; }
        public string _name { get; set; }

        public Equipment(int equipmentId, string name)
        {
            _equipmentId = equipmentId;
            _name = name;
        }
    }
}
