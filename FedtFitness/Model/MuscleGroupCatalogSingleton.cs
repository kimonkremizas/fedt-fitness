using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    public class MuscleGroupCatalogSingleton
    {
        public ObservableCollection<MuscleGroup> MuscleGroups { get; set; }
        private static MuscleGroupCatalogSingleton _instance;

        private MuscleGroupCatalogSingleton()
        {
            MuscleGroups = new ObservableCollection<MuscleGroup>();
            MuscleGroups = new ObservableCollection<MuscleGroup>(GenericFedtWebAPI<MuscleGroup>.getAll("api/MuscleGroups"));
            //MuscleGroups.Add(new MuscleGroup(1, "Bicep"));
            //MuscleGroups.Add(new MuscleGroup(2, "tricep"));
            //MuscleGroups.Add(new MuscleGroup(3, "back"));
            //MuscleGroups.Add(new MuscleGroup(4, "legs"));
            //MuscleGroups.Add(new MuscleGroup(5, "abs"));
            //MuscleGroups.Add(new MuscleGroup(6, "chest"));
            //MuscleGroups.Add(new MuscleGroup(7, "shoulders"));
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
