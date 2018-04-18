using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    class Agenda
    {
        private Contacto[] agenda = new Contacto[15];
        public int tamaño = 14;
        public int contador = 0;

        public void agregar(Contacto contacto)
        {
            if (contador < tamaño)
            {
                agenda[contador] = contacto;
                contador++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más elementos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string buscar(string numero)
        {
            string buscar = "";
            for (int x = 0; x != tamaño; x++)
            {
                if (agenda[x].numero == numero)
                {
                    buscar = agenda[x].nombre + " " + agenda[x].apellidoPaterno + " " + agenda[x].apellidoMaterno + " " + agenda[x].edad + " " + agenda[x].numero + " " + agenda[x].correo;

                    return buscar;
                }
            }
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

        public void insertar(int posicion, Contacto contacto)
        {
            if (contador < tamaño)
            {
                for (int x = tamaño; x >= posicion; x--)
                {
                    agenda[x] = agenda[x - 1];
                }
                agenda[posicion] = contacto;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override string ToString()
        {
            string lista = "";

            for( int x = 0; x < contador; x++)
            {
                lista += agenda[x].nombre + " " + agenda[x].apellidoPaterno + " " + agenda[x].apellidoMaterno + " " + agenda[x].edad + " " + agenda[x].numero + " " + agenda[x].correo + Environment.NewLine;
            }

            return lista;
        }
    }
}
