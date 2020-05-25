using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    public class ExerciseCatalogSingleton
    {
        public ObservableCollection<Excercise> Exercises { get; set; }
        private static ExerciseCatalogSingleton _instance;

        private ExerciseCatalogSingleton()
        {
           Exercises = new ObservableCollection<Excercise>();
           Exercises = new ObservableCollection<Excercise>(GenericFedtWebAPI<Excercise>.getAll("api/Excercises"));
            //Exercises.Add(new Exercise(1, "T Raises", 15, 2, 1, "Train your chest"));
            //Exercises.Add(new Exercise(2, "Single-Arm Dumbbell Rows", 15, 2, 2, "Train your chest"));
            //Exercises.Add(new Exercise(3, "Delt Raise", 15, 2, 2, "Train your chest"));
            //Exercises.Add(new Exercise(4, "Plank with Lateral Arm Raise", 15, 2, 3, "Train your chest"));
            //Exercises.Add(new Exercise(13, "Arm Circles", 15, 3, 1, "Train your chest"));
            //Exercises.Add(new Exercise(25, "Side leg raises", 15, 4, 4, "Train your chest"));
            //Exercises.Add(new Exercise(26, "Lying leg curl", 15, 4, 2, "Train your chest"));
            //Exercises.Add(new Exercise(31, "Medicine ball slam ", 15, 5, 3, "Train your chest"));
        }

        public static ExerciseCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new ExerciseCatalogSingleton());
            }
        }

        public string _name;
        public string ExName
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsSelected { get; internal set; }
    }
}
