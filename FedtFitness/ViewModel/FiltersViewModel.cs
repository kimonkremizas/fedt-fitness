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
    public class FiltersViewModel : INotifyPropertyChanged
    {

        public FiltersViewModel()
        {
            EquipmentCatalogSingleton = EquipmentCatalogSingleton.Instance;
            _selectedEquipment = new Equipment(Equipment_ID, Name);
            AllEquipments = EquipmentCatalogSingleton.Equipments;

            MuscleGroupCatalogSingleton = MuscleGroupCatalogSingleton.Instance;
            _selectedMuscleGroup = new MuscleGroup(Muscles_ID, MGName);
            AllMuscleGroups = MuscleGroupCatalogSingleton.MuscleGroups;

            ecs = ExerciseCatalogSingleton.Instance;


        }




        //EQUIPMENT

        public EquipmentCatalogSingleton EquipmentCatalogSingleton { get; set; }
        public int Equipment_ID { get; set; }
        public string Name { get; set; }
        public ObservableCollection<Equipment> AllEquipments { get; set; }

        private Equipment _selectedEquipment;

        public Equipment SelectedEquipment
        {
            get
            {
                return _selectedEquipment;
            }
            set
            {
                _selectedEquipment = value;
                OnPropertyChanged(nameof(F1));
            }
        }
        
        //MUSCLE GROUP

        public MuscleGroupCatalogSingleton MuscleGroupCatalogSingleton { get; set; }
        public int Muscles_ID { get; set; }
        public string MGName { get; set; }
        public ObservableCollection<MuscleGroup> AllMuscleGroups { get; set; }

        private MuscleGroup _selectedMuscleGroup;

        public MuscleGroup SelectedMuscleGroup
        {
            get { return _selectedMuscleGroup; }
            set
            {
                _selectedMuscleGroup = value;
                OnPropertyChanged(nameof(F1));
            }
        }

        public ExerciseViewModel abs { get; set; }

        //REFERENCES

        public ExerciseCatalogSingleton ecs { get; set; }
        public ObservableCollection<Excercise> AllExercises
        {
            get
            {
                return ecs.Exercises;
            }
        }

        
        //CHECK IF ANY EXERCISES APPLY BOTH FILTERS AND CREATE FILTERED COLLECTION

        public ObservableCollection<Excercise> F1
       {
           get
           {
               IEnumerable<Excercise>  filtered= AllExercises.Where(ex => ex.Equipment_ID == SelectedEquipment.Equipment_ID
                                                                         && ex.Muscles_ID == SelectedMuscleGroup.Muscles_ID);
                return new ObservableCollection<Excercise>(filtered);

           }

        }



        private Excercise _selectedExercise;
        public Excercise SelectedExercise
        {
            get
            {
                return _selectedExercise;
            }
            set
            {
                _selectedExercise = value;
                OnPropertyChanged(nameof(SelectedExercise));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
       }
    }
}
