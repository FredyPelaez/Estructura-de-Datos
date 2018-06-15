using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_Procesos
{
    class Proceso
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        Proceso siguiente;
        Proceso anterior;
        public int ciclos;

        public Proceso Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Proceso Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Proceso()
        {
            ciclos = random.Next(4, 15);
        }
    }
}
