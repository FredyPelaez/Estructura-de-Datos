using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ListasEnlazadas
{
    class Agenda
    {
        public int tamaño = 4;
        private Contacto[] agenda = new Contacto[5];
        public int contador = 0;
        private Contacto inicio;
        private string cadena = "";

        public void agregarInicio(Contacto nuevo)
        {
            if (inicio == null) inicio = nuevo;
            else
                agregar(nuevo, inicio);
        }

        public void eliminarPrimero()
        {
            inicio = inicio.Siguiente;
        }

        public void eliminarUltimo()
        {
            Contacto x = inicio;

            while (x.Siguiente  != null)
            {
                if (x.Siguiente.Siguiente == null) x.Siguiente = null;
                else
                    x = x.Siguiente;
            }
        }

        public string reporteInversoUno(Contacto x)
        {
            x = inicio;
            cadena = "";
            if (x.Siguiente == null)
            {
                cadena += x.ToString() + Environment.NewLine;
                return cadena;
            }
            else
                reporteInverso(x);
            return cadena;
        }
        public void reporteInverso(Contacto x)
        {
            if (x.Siguiente != null)
            {
                reporteInverso(x.Siguiente);
                cadena += x.ToString() + Environment.NewLine;
            }
            else
            {
                cadena += x.ToString() + Environment.NewLine;
            }
        }

        public void invertir()
        {
            Contacto x = inicio;

            if (x.Siguiente.Siguiente != null)
            {
                Invertir(x);
                
                x.Siguiente = null;
            }
            else
            {
                x.Siguiente.Siguiente = x;
                inicio = x.Siguiente;
                x.Siguiente = null;
            }
        }
                                                                           
        public void Invertir(Contacto x)
        {
            if (x.Siguiente.Siguiente != null)
            {
                Invertir(x.Siguiente);
                x.Siguiente.Siguiente = x;
            }
            else
            {
                x.Siguiente.Siguiente = x;
                inicio = x.Siguiente;
            }
        }

        public void agregar(Contacto nuevo, Contacto x)
        {
            if (x.Siguiente == null) x.Siguiente = nuevo;
            else
                agregar(nuevo, x.Siguiente);
        }

        public Contacto buscar(string telefono)
        {
            Contacto x = inicio;

            while (x != null)
            {
                if (x.Telefono == telefono) return x;
                x = x.Siguiente;
            }

            return null;
        }

        //public void eliminar(string telefono)
        //{
        //    Contacto x = inicio;
        //    while (x.Siguiente.Telefono != telefono)
        //    {
        //        if (x.Siguiente.Siguiente.Telefono != telefono) x.Siguiente = null;
        //        else
        //            x = x.Siguiente;
        //    }
        //}

        public string listar()
        {
            Contacto x = inicio;
            cadena = "";

            while(x != null)
            {
                cadena += x.ToString() + Environment.NewLine;
                x = x.Siguiente;
            }

            return cadena;
        }
    }
}
