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
        public int EwID { get; set; }
        public int EeID { get; set; }
        public string EName { get; set; }
        public int ELength { get; set; }
        public int EeqId { get; set; }
        public int EmgId { get; set; }
        public string EDescrip { get; set; }

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
