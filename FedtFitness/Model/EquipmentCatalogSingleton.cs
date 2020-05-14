using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    class EquipmentCatalogSingleton
    {
        public ObservableCollection<Equipment> Equipments { get; set; }
        private static EquipmentCatalogSingleton _instance;

        private EquipmentCatalogSingleton()
        {
            Equipments = new ObservableCollection<Equipment>();
            //Equipments = new ObservableCollection<Equipment>(GenericFedtWebAPI<Equipment>.getAll("api/Equipments"));
            Equipments.Add(new Equipment(1, "None"));
            Equipments.Add(new Equipment(2, "Dumbbells"));
            Equipments.Add(new Equipment(3, "Chair"));
            Equipments.Add(new Equipment(4, "Resistance band"));
            Equipments.Add(new Equipment(5, "Medicine ball"));
            Equipments.Add(new Equipment(6, "Sandbag"));
            Equipments.Add(new Equipment(7, "Ab wheel"));
        }

        public static EquipmentCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new EquipmentCatalogSingleton());
            }
        }
    }
}
