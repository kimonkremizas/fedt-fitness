using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class MuscleGroupCatalogSingleton
    {
        public ObservableCollection<MuscleGroup> MuscleGroups { get; set; }
        private static MuscleGroupCatalogSingleton _instance;

        private MuscleGroupCatalogSingleton()
        {
            MuscleGroups = new ObservableCollection<MuscleGroup>();
        }

        public static MuscleGroupCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new MuscleGroupCatalogSingleton());
            }
        }
    }
}
