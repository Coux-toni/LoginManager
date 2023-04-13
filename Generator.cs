using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManager
{
    public class Generator
    {
        protected string passwort = "Schulübung";

        public void Set(string p)
        {
            this.passwort = p;
        }
        public virtual string Generieren()
        {
            return this.passwort;
        }

    }
}
