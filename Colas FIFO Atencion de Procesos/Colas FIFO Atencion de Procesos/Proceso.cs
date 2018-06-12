using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atencion_de_Procesos
{
    class Proceso
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        Proceso siguiente;
        public int ciclos;
        public Proceso Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Proceso()
        {
            ciclos = random.Next(4, 15);
        }

        public override string ToString()
        {
            string proceso;
            if (siguiente == null) return proceso = Convert.ToString(ciclos);
            else return proceso = Convert.ToString(ciclos) + "siguiente: " + siguiente.ToString(); ;
        }
    }
}
