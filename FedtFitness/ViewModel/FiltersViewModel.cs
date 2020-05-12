using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Model;

namespace FedtFitness.ViewModel
{
    class FiltersViewModel
    {
        //EQUIPMENT

        public EquipmentCatalogSingleton EquipmentCatalogSingleton { get; set; }
        public int eqId { get; set; }
        public string eqName { get; set; }
        public ObservableCollection<Equipment> AllEquipments { get; set; }

        private Equipment _selectedEquipment;

        public Equipment SelectedEquipment
        {
            get { return _selectedEquipment; }
            set { _selectedEquipment = value; }
        }



        //MUSCLE GROUP

        public MuscleGroupCatalogSingleton MuscleGroupCatalogSingleton { get; set; }
        public int mgId { get; set; }
        public string mgName { get; set; }
        public ObservableCollection<MuscleGroup> AllMuscleGroups { get; set; }

        private MuscleGroup _selectedMuscleGroup;

        public MuscleGroup SelectedMuscleGroup
        {
            get { return _selectedMuscleGroup; }
            set { _selectedMuscleGroup = value; }
        }


        //FILTERS

        public FiltersViewModel()
        {
            EquipmentCatalogSingleton = EquipmentCatalogSingleton.Instance;
            _selectedEquipment = new Equipment(eqId, eqName);
            AllEquipments = EquipmentCatalogSingleton.Equipments;

            MuscleGroupCatalogSingleton = MuscleGroupCatalogSingleton.Instance;
            _selectedMuscleGroup = new MuscleGroup(mgId, mgName);
            AllMuscleGroups = MuscleGroupCatalogSingleton.MuscleGroups;
        }
    }
}
