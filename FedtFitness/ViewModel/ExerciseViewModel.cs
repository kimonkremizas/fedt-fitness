using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Model;

namespace FedtFitness.ViewModel
{
    class ExerciseViewModel
    {
        public ExerciseCatalogSingleton exerciseCatalogSingleton { get; set; }
        public int exId { get; set; }
        public string exName { get; set; }
        public int exLength { get; set; }
        public int eqId { get; set; }
        public int mgId { get; set; }
        public string exDescr { get; set; }

        private Exercise _selectedExercise;
        public Exercise SelectedExercise
        {
            get { return _selectedExercise; }
            set { _selectedExercise = value; }
        }

        public ObservableCollection<Exercise> AllExercises { get; set; }

        public ExerciseViewModel()
        {
            exerciseCatalogSingleton = ExerciseCatalogSingleton.Instance;
            _selectedExercise = new Exercise(exId, exName, exLength, eqId, mgId, exDescr);
            AllExercises = exerciseCatalogSingleton.Exercises;
           //var generateexercise =  AllExercises.Where(ex => ex._musclesId == SelectedmgId && ex._equipmentId == SelectedeqId);
        }

        
    }
}
