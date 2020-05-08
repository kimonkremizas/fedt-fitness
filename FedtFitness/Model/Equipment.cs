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
        public int Equipment_id { get; set; }
        public string Name { get; set; }

        public Equipment(int equipmentId, string name)
        {
            Equipment_id = equipmentId;
            Name = name;
        }
    }
}
