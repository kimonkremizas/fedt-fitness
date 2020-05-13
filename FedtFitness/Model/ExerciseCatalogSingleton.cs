using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class ExerciseCatalogSingleton
    {
        public ObservableCollection<Exercise> Exercises { get; set; }
        private static ExerciseCatalogSingleton _instance;

        private ExerciseCatalogSingleton()
        {
           Exercises = new ObservableCollection<Exercise>();
           Exercises.Add(new Exercise(1,"pushups",15, 1, 1, "Train your chest"));
           Exercises.Add(new Exercise(2, "lifts", 15, 2, 1, "Train your chest"));
           Exercises.Add(new Exercise(3, "pushs", 15, 2,1, "Train your chest"));

        }

        public static ExerciseCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new ExerciseCatalogSingleton());
            }
        }




    }
}
