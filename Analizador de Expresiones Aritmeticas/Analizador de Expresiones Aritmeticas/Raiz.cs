using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_de_Expresiones_Aritmeticas
{
    class Raiz
    {
        Raiz anterior, siguiente, hIzquierdo, hDerecho;
        string caracter;

        public Raiz Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Raiz Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Raiz HIzquierdo
        {
            get { return hIzquierdo; }
            set { hIzquierdo = value; }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

        public Raiz HDerecho
        {
            get { return hDerecho; }
            set { hDerecho = value; }
        }

        public Raiz(string d)
        {
            caracter = d;
        }

        public override string ToString()
        {
            return caracter;
        }
    }
}
