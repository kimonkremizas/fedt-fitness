using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Model;

namespace FedtFitness.ViewModel
{
    class EquipmentViewModel
    {
        public EquipmentCatalogSingleton equipmentCatalogSingleton { get; set;}
        public int TeqED { get; set; }
        public string TName { get; set; }
        private ObservableCollection<Equipment> allEquipments { get; set; }

        private Equipment _selectedEquipment;

        public Equipment SelectedEquipment
        {
            get { return _selectedEquipment; }
            set { _selectedEquipment = value; }
        }

        public EquipmentViewModel()
        {
            equipmentCatalogSingleton = EquipmentCatalogSingleton.Instance;
            _selectedEquipment = new Equipment();
            allEquipments = equipmentCatalogSingleton.Equipments;
        }



    }
}
