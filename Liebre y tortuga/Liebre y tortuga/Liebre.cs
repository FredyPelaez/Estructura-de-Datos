using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_y_tortuga
{
    class Liebre : Corredor
    {
        public Liebre()
        {
            _pasos = 0;
        }

        public override void avanzar()
        {
            int avanzar = random.Next(1, 11);

            if (avanzar < 3) _pasos += 0;
            else if (avanzar < 5) _pasos += 9;
            else if (avanzar < 6) _pasos -= 12;
            else if (avanzar < 9) _pasos += 1;
            else _pasos += 2;
            if (_pasos < 0) _pasos = 0;
        }

        public override string ToString()
        {
            return "La liebre está en " + this.pasos;
        }
    }
}
