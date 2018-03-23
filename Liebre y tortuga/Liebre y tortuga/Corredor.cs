using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga
{
    abstract class Corredor
    {
        protected static Random random = new Random();
        protected int _pasos;
        public int pasos { get { return _pasos; } }

        public virtual void avanzar() {}
    }
}
