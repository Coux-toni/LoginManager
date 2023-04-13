using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManager
{
    public class ErweiterterGenerator : Generator
    {
        public override string Generieren()
        {
            Random r = new Random();

            return base.Generieren() + r.Next(1,10);
        }
    }
}
