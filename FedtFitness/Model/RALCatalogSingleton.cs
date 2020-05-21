﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Sockets;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    class RALCatalogSingleton
    {
        public ObservableCollection<RegisterAndLogin> rAl { get; set; }
        private static RALCatalogSingleton _instance;
        private static string serverURL = "http://localhost:63830/";
        private static string url = "api/Tables";

        private RALCatalogSingleton()
        {
            rAl = new ObservableCollection<RegisterAndLogin>();
        }

        public static RALCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new RALCatalogSingleton());

            }
        }

        GenericFedtWebAPI<RegisterAndLogin> registerWebApiAsync= new GenericFedtWebAPI<RegisterAndLogin>(serverURL, url);
        

        public RegisterAndLogin CurrentUser { get; set; }

        public void Register(RegisterAndLogin us)
        {
            registerWebApiAsync.createNewOne(us);
        }

        public bool LoginCheck(string username, string password)
        {
            bool status = false;
            foreach (var v in rAl)
            {
                if (v.Username == username && v.Password == password)
                {
                    CurrentUser = rAl.FirstOrDefault(data => data.Username == username && data.Password == password);
                    status = true;
                }
            }
            return status;
           
        }

        public void LogIn(string username, string password)
        {
            CurrentUser = rAl.FirstOrDefault(data => data.Username == username && data.Password == password);
        }

        public void LogOut()
        {
            CurrentUser = null;
        }
    }
}
