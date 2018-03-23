using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Erastoteles
{
    class Numeros_Primos
    {
        private int[] _elementos = new int [1000];

        public string ObtenerPrimos()
        {
            string resultado = "";
            for (int i = 1; i < 1000; i++) _elementos[i] = 1; //Se inicilizan las posiciones en 1

            for (int x = 2; x < 1000; x++) 
            {
                int div = 1; //variable que almacena la cantidad de divisores
                for (int y = 2; y <= x; y++) 
                {
                    if ((x % y) == 0) div++; // Valida si x modulo es igual a 0
                }
                if (div == 2)
                    for (int z = x + x; z < 1000; z += x)
                        _elementos[z] = 0;
            } //si div es 2 el numero es primo

            for (int i = 2; i < 1000; i++)
            {
                if (_elementos[i] == 1) resultado += i + " ,";
            }

            return resultado;
        }
    }
}
