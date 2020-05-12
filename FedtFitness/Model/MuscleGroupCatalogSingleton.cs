using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    class MuscleGroupCatalogSingleton
    {
        public ObservableCollection<MuscleGroup> MuscleGroups { get; set; }
        private static MuscleGroupCatalogSingleton _instance;

        private MuscleGroupCatalogSingleton()
        {
            MuscleGroups = new ObservableCollection<MuscleGroup>();
            MuscleGroups = new ObservableCollection<MuscleGroup>(GenericFedtWebAPI<MuscleGroup>.getAll("api/MuscleGroups"));
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
