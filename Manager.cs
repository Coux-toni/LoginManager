using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManager
{
    public class Manager
    {
        List<Passwort> passwoerter = new();
        public void Speichern(Passwort p)
        {
            this.passwoerter.Add(p);
        }
    }
}
