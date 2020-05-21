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
using FedtFitness.Persistency;
using Windows.UI.Xaml.Controls;

namespace FedtFitness.ViewModel
{
    class TrainingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Excercise> Excercises { get; set; }
        //private ExerciseCatalogSingleton _exerciseCatalogSingleton;
        private ExerciseCatalogSingleton _selectedExercise;
        public ExerciseCatalogSingleton SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                _selectedExercise= value;
                OnPropertyChanged();
            }
        }


        public TrainingViewModel()
        {
            Excercises = new ObservableCollection<Excercise>();
            Excercises = new ObservableCollection<Excercise>(GenericFedtWebAPI<Excercise>.getAll("api/Excercises"));

        }




        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
