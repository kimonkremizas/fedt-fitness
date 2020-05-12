using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using FedtFitness.Model;

namespace FedtFitness.ViewModel
{
    class MuscleGroupViewModel
    {
        public MuscleGroupCatalogSingleton musclegroupCatalogSingleton { get; set;}

        public int MGId { get; set; }
        public string MGName { get; set; }
        public ObservableCollection<MuscleGroup> allMuscleGroups { get; set; }


        private MuscleGroup _selectedMuscleGroup;

        public MuscleGroup SelectedMuscleGroup
        {
            get { return _selectedMuscleGroup; }
            set { _selectedMuscleGroup = value; }
        }

        public MuscleGroupViewModel()
        {
            musclegroupCatalogSingleton = MuscleGroupCatalogSingleton.Instance;
            _selectedMuscleGroup = new MuscleGroup(MGId, MGName);
            allMuscleGroups = musclegroupCatalogSingleton.MuscleGroups;
        }

    }
}
