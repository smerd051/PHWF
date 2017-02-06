using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHelperWF
{
    class PassHelp
    {
        public List<PassHelp> PHList = new List<PassHelp>();

        private string pass;
        public string Pass { get { return pass; } set { pass = value; } }
        private string login;
        public string Login { get { return login; } set { login = value; } }
        private string site;
        public string Site { get { return site; } set { site = value; } }

        public PassHelp(string login, string pass, string site)
        {
            PHList.Add(new PassHelp() { Login = login, Pass = pass, Site = site });
        }

        public PassHelp(){}

        
    }
}
