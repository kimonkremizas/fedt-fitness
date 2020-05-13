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
           Exercises.Add(new Exercise(1, "T Raises", 15, 2, 1, "Train your chest"));
           Exercises.Add(new Exercise(2, "Single-Arm Dumbbell Rows", 15, 2, 1, "Train your chest"));
           Exercises.Add(new Exercise(3, "Delt Raise", 15, 2,1, "Train your chest"));
           Exercises.Add(new Exercise(4, "Plank with Lateral Arm Raise", 15, 1, 1, "Train your chest"));
           Exercises.Add(new Exercise(13, "Arm Circles", 15, 3, 1, "Train your chest"));
           Exercises.Add(new Exercise(25, "Side leg raises", 15, 4, 1, "Train your chest"));
           Exercises.Add(new Exercise(26, "Lying leg curl", 15, 4, 1, "Train your chest"));
           Exercises.Add(new Exercise(31, "Medicine ball slam ", 15, 5, 1, "Train your chest"));
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
