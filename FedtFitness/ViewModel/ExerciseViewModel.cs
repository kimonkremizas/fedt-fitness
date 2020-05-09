using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Model;

namespace FedtFitness.ViewModel
{
    class ExerciseViewModel
    {
        public ExerciseCatalogSingleton exerciseCatalogSingleton { get; set; }
        public int wId { get; set; }
        public int exId { get; set; }
        public string eName { get; set; }
        public int length { get; set; }
        public int eqId { get; set; }
        public int mId { get; set; }
        public string eDescription { get; set; }

        private Exercise _selectedExercise;
        public Exercise SelectedExercise
        {
            get { return _selectedExercise; }
            set { _selectedExercise = value; }
        }

        public ExerciseViewModel()
        {
            exerciseCatalogSingleton = ExerciseCatalogSingleton.Instance;
            _selectedExercise = new Exercise();
        }
    }
}
