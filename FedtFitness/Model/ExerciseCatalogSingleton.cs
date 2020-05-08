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
