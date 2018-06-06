using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas_Dobles
{
    class Agenda
    {
        public int tamaño = 4;
        private Contacto[] agenda = new Contacto[5];
        public int contador = 0;
        private Contacto inicio, final, aux;
        private string cadena = "";

        public void agregar(Contacto nuevo)
        {
            int tel = int.Parse(nuevo.Telefono);
            if (inicio == null) inicio = nuevo;
            else if (tel < int.Parse(inicio.Telefono))
            {
                aux = inicio;
                inicio = nuevo;
                aux.Anterior = inicio;
                inicio.Siguiente = aux;
            }
            else
                agregar(nuevo, inicio);
        }

        public void agregar(Contacto nuevo, Contacto x)
        {
            if (x == null)
            {
                aux.Siguiente = nuevo;
                nuevo.Anterior = aux;
                final = nuevo;
            }
            else if (int.Parse(x.Telefono) > int.Parse(nuevo.Telefono))
            {
                nuevo.Anterior = x.Anterior;
                nuevo.Siguiente = x;
                x.Anterior.Siguiente = nuevo;
                x.Anterior = nuevo;
                final = nuevo;
            }
            else
            {
                aux = x;
                agregar(nuevo, x.Siguiente);
            }
        }

        public Contacto buscar(string telefono)
        {
            aux = inicio;
            int tel = int.Parse(telefono);
            
            while (int.Parse(aux.Telefono) <= tel)
            {
                if (tel == int.Parse(aux.Telefono))
                    return aux;
                aux = aux.Siguiente;
            }
            return null;
        }

        public void eliminar(string telefono)
        {
            int tel = int.Parse(telefono);
            bool encontrado = false;
            aux = inicio;

            if (aux.Telefono == telefono) eliminarPrimero();
            else
            {
                while (aux != null && encontrado != true)
                {
                    if (int.Parse(aux.Siguiente.Telefono) >= tel)
                    {
                        encontrado = true;
                        if (int.Parse(aux.Siguiente.Telefono) == tel)
                        {
                            aux.Siguiente = aux.Siguiente.Siguiente;
                            aux.Siguiente.Anterior = aux;
                        }
                    }
                    aux = aux.Siguiente;
                }
            }
        }

        public void eliminarPrimero()
        {
            if (inicio.Siguiente == null) inicio = null;
            else
            {
                inicio = inicio.Siguiente;
                inicio.Anterior = null;
            }
        }

        public void eliminarUltimo()
        {
            if (final.Anterior == null) final = null;
            else
            {
                final = final.Anterior;
                final.Siguiente = null;
            }
        }

        public string listar()
        {
            Contacto x = inicio;
            cadena = "";

            while (x != null)
            {
                cadena += x.ToString() + Environment.NewLine;
                x = x.Siguiente;
            }

            return cadena;
        }

        public string listarInverso()
        {
            Contacto x = final;
            cadena = "";

            while (x != null)
            {
                cadena += x.ToString() + Environment.NewLine;
                x = x.Anterior;
            }

            return cadena;
        }
    }
}
