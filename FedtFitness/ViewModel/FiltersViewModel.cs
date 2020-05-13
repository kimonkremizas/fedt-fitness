using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Annotations;
using FedtFitness.Model;
using FedtFitness.View;

namespace FedtFitness.ViewModel
{
    class FiltersViewModel : INotifyPropertyChanged
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
            set
            {
                _selectedEquipment = value;
                OnPropertyChanged(nameof(F1));
            }
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


        public FiltersViewModel()
        {
            EquipmentCatalogSingleton = EquipmentCatalogSingleton.Instance;
            _selectedEquipment = new Equipment(eqId, eqName);
            AllEquipments = EquipmentCatalogSingleton.Equipments;

            MuscleGroupCatalogSingleton = MuscleGroupCatalogSingleton.Instance;
            _selectedMuscleGroup = new MuscleGroup(mgId, mgName);
            AllMuscleGroups = MuscleGroupCatalogSingleton.MuscleGroups;

            ecs = ExerciseCatalogSingleton.Instance;
        }

        //FILTERS
        public ExerciseCatalogSingleton ecs { get; set; }
        public ObservableCollection<Exercise> AllExercises
        {
            get
            {
                return ecs.Exercises;
            }
        }

        public ObservableCollection<Exercise> F1
       {
           get
           {
               
               
               IEnumerable<Exercise>  filtered= AllExercises.Where(ex => ex.EeqID == SelectedEquipment.eqId);
               return new ObservableCollection<Exercise>(filtered);
           }
       }
       public ObservableCollection<Exercise> F2 { get; set; }

       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }
    }
}
