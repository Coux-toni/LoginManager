using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManager
{
    public class Passwort
    {
        public string Titel { get; protected set; }
        public string Pwd { get; protected set; }
        public Passwort(string titel, string pwd) 
        {
            this.Titel = titel;
            this.Pwd = pwd;
        }   
    }
}
