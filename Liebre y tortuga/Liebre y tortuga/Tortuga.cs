using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga
{
    class Tortuga : Corredor
    {
        
        public Tortuga()
        {
            _pasos = 0;
        }

        public override void avanzar()
        {
            int avanzar = random.Next(1,11);

            if (avanzar < 6) _pasos += 3;
            else if (avanzar < 8) _pasos -= 6;
            else _pasos += 1;
            if (_pasos < 0) _pasos = 0;
        }

        public override string ToString()
        {
            return "La tortuga está en " + this.pasos;
        }
    }
}
