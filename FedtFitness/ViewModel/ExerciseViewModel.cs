using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web.Core;
using FedtFitness.Annotations;
using FedtFitness.Model;


namespace FedtFitness.ViewModel
{
    class ExerciseViewModel : INotifyPropertyChanged
    {
        public ExerciseCatalogSingleton exerciseCatalogSingleton { get; set; }
        public int Exercise_ID { get; set; }
        public string ExName { get; set; }
        public int Length { get; set; }
        public int Equipment_ID { get; set; }
        public int Muscles_ID { get; set; }
        public string Description { get; set; }

        //ObservableCollection<Excercise> F1 = new ObservableCollection<Excercise>();
        public ObservableCollection<Excercise> F1 { get; set; }



        private Excercise _selectedExercise;

        public ExerciseViewModel()
        {
            exerciseCatalogSingleton = ExerciseCatalogSingleton.Instance;
            _selectedExercise = new Excercise(Exercise_ID, ExName, Length, Equipment_ID, Muscles_ID, Description);
            AllExercises = exerciseCatalogSingleton.Exercises;



        }





        //private Exercise _clickedExercise;
        //public Exercise ClickedExercise { get; set; }
        //public IList<object> SelectedItemsList { get; }

        public Excercise SelectedExercise
        {
            get
            {
                return _selectedExercise;
            }
            set
            {
                _selectedExercise = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Excercise> AllExercises { get; set; }

        //public ObservableCollection<Exercise> SelectedListViewItemCollection
        //{
        //    get
        //    {


        //        IEnumerable<Exercise> filtered = AllExercises.Where(ex => ex.Equipment_ID == SelectedEquipment.Equipment_ID);
        //        return new ObservableCollection<Exercise>(filtered);
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
