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

namespace FedtFitness.ViewModel
{
    class TrainingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Excercise> Exercises { get; set; }
        private ExerciseCatalogSingleton _exerciseCatalogSingleton;




        public TrainingViewModel()
        {
            Exercises = new ObservableCollection<Excercise>();
            Exercises = new ObservableCollection<Excercise>(GenericFedtWebAPI<Excercise>.getAll("api/Excercises"));

        }




        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
