using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares_Rutas
{
    class Ruta
    {
        Base inicio, fin, aux, eliminada;

        public void agregar(Base x)
        {
            if (inicio == null)
            {
                inicio = x;
                fin = x;
                inicio.Siguiente = fin;
                inicio.Anterior = fin;
            }
            else
            {
                fin.Siguiente = x;
                x.Anterior = fin;
                fin = fin.Siguiente;
                fin.Siguiente = inicio;
                inicio.Anterior = fin;
            }
        }

        public Base buscar(string nombre)
        {
            if (inicio == fin)
            {
                if (nombre == inicio.nombre) return inicio;
                else return null;
            }
            else
            {
                aux = inicio;
                while (aux != fin)
                {
                    if (nombre == aux.nombre) return aux;
                    aux = aux.Siguiente;
                }
                return null;
            }
        }

        public Base eliminar(string nombre)
        {
            eliminada = buscar(nombre);
            eliminada.Siguiente.Anterior = eliminada.Anterior;
            eliminada.Anterior.Siguiente = eliminada.Siguiente;

            return eliminada;
        }

        public Base eliminarPrimero()
        {
            if (inicio.Siguiente == fin)
            {
                eliminada = inicio;
                inicio = null;
                fin = null;
            }
            else
            {
                eliminada = inicio;
                eliminada.Siguiente.Anterior = eliminada.Anterior;
                eliminada.Anterior.Siguiente = eliminada.Siguiente;
                inicio = eliminada.Siguiente;
            }

            return eliminada;
        }

        public Base eliminarUltimo()
        {
            if (fin.Siguiente == inicio)
            {
                eliminada = fin;
                inicio = null;
                fin = null;
            }
            else
            {
                eliminada = fin;
                eliminada.Siguiente.Anterior = eliminada.Anterior;
                eliminada.Anterior.Siguiente = eliminada.Siguiente;
                fin = inicio.Anterior;
            }

            return eliminada;
        }

        public void insertar(Base x, int posicion)
        {
            aux = inicio;
            for (int i = 0; i < posicion; i++)
                aux = aux.Siguiente;
            x.Siguiente = aux.Siguiente;
            aux.Siguiente.Anterior = x;
            x.Anterior = aux;
            aux.Siguiente = x;
            if (posicion == 1)
                inicio = x;
        }

        public string ruta(Base x, DateTime horaInicio, DateTime horaFinal)
        {
            string ruta = "";
            aux = inicio;

            while (aux.nombre != x.nombre) aux = aux.Siguiente;

            ruta += "Base " + "Hora" + Environment.NewLine + aux.nombre + "   " + horaInicio.Hour + ":" + horaFinal.Minute + Environment.NewLine;

            while (horaInicio < horaFinal)
            {
                aux = aux.Siguiente;
                horaInicio = horaInicio.AddMinutes(aux.minutos);
                ruta += aux.nombre + "    " + horaInicio.Hour + ":" + horaInicio.Minute + Environment.NewLine;
            }

            return ruta;
        }

        public string listar()
        {
            string listar;
            if (inicio == null) listar = "No hay bases";
            else
            {
                aux = inicio;
                listar = string.Format("{0, -20} {1, -15}", "Base", "Minutos");
                listar += Environment.NewLine + inicio.ToString() + Environment.NewLine;

                while (aux != fin)
                {
                    aux = aux.Siguiente;
                    listar += aux.ToString() + Environment.NewLine;
                }
            }

            return listar;
        }
    }
}
