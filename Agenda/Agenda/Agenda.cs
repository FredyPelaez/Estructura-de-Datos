using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private Contacto[] agenda = new Contacto[15];
        public int tamaño = 14;
        public int contador;

        public Agenda()
        {
            contador = 0;
        }

        public void agregar(Contacto contacto)
        {
            agenda[contador] = contacto;
            if (contador > 0)
            {
                ordenar();
            }

            contador++; 
        }

        public void ordenar()
        {
            Contacto temporal;
            for (int i = 0; i < contador; i++)
            {
                for (int x = 0; x < contador -i; x++)
                {
                    if (Convert.ToInt32(agenda[x].numero) > Convert.ToInt32(agenda[x + 1].numero))
                    {
                        temporal = agenda[x];
                        agenda[x] = agenda[x + 1];
                        agenda[x + 1] = temporal;
                    }
                }
            }
        }

        public Contacto buscar(string numero)
        {
            for (int x = 0; x < contador; x++)
                if (agenda[x].numero == numero)
                    return agenda[x];

            return null;
        }

        public void eliminar(int posicion)
        {
            for (int x = contador; x >= posicion; x--)
            {
                agenda[posicion] = agenda[posicion + 1];
                agenda[contador] = null;
                posicion++;
            }
            contador--;
        }

        public bool insertar(int posicion, Contacto contacto)
        {
            if (contador < tamaño)
            {
                for (int x = tamaño; x >= posicion; x--)
                {
                    agenda[x] = agenda[x - 1];
                }
                agenda[posicion] = contacto;
                contador++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string lista = "";

            for( int x = 0; x < contador; x++)
            {
                lista += agenda[x].ToString() + Environment.NewLine;
            }

            return lista;
        }
    }
}
