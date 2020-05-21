using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedtFitness.Model
{
    class RegisterAndLogin
    {
        private string _username;
        private string _password;
        private string _email;

       public RegisterAndLogin()
        {

        }

        public RegisterAndLogin(string usn, string pass, string email)
        {
            _username = usn;
            _password = pass;
            _email = email;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
