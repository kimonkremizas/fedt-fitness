﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using FedtFitness.Annotations;
using FedtFitness.Model;
using FedtFitness.View;

namespace FedtFitness.ViewModel
{
    class RALVM : INotifyPropertyChanged
    {
        private RALCatalogSingleton ralCatalogSingleton { get; set; }
        public string Username
        {
            get { return _username;}
            set { _username = value; } }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email { get; set; }
        public ICommand AddUserCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        private RegisterAndLogin _selecteedd;
        private bool isLogedin = true;
        private string _username;
        private string _password;
        public ObservableCollection<RegisterAndLogin> AllUsers { get; set; }

        public RALVM()
        {
            ralCatalogSingleton = RALCatalogSingleton.Instance;
            _selecteedd = null;
            AllUsers = ralCatalogSingleton.rAl;
            AddUserCommand = new RelayCommand.RelayCommand(AddUser);
            //LoginCommand = new RelayCommand.RelayCommand(CanNavigate(Username, Password),CanNavigate(Username,Password));
        }
        public void AddUser()
        {
            ralCatalogSingleton.Register(new RegisterAndLogin(Username, Password, Email));
        }

        public bool CanNavigate()
        {
          return ralCatalogSingleton.LoginCheck(Username, Password);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
}
