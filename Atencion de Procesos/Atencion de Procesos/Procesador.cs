using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_Procesos
{
    class Procesador
    {
        Proceso inicio, aux, fin, procesoEnCurso;
        Random random = new Random(Guid.NewGuid().GetHashCode());
        public int Ciclos;
        public int CV = 0; //Ciclos Vacio
        public int PAC = 0; //Procesos Atendidos Completamente
        public int PP = 0; //Procesos Pendientes
        public int SCP = 0; //Suma de Ciclos Pendientes

        public Procesador()
        {
            Ciclos = 300;
        }

        private void eliminarInicio()
        {
            fin.Siguiente = inicio.Siguiente;
            inicio.Siguiente.Anterior = fin;
            inicio = inicio.Siguiente;
        }

        private void eliminarFinal()
        {
            inicio.Anterior = fin.Anterior;
            fin.Anterior.Siguiente = inicio;
            fin = fin.Anterior;
        }

        private void eliminarActual()
        {
            if (procesoEnCurso == inicio) eliminarInicio();
            else if (procesoEnCurso == fin) eliminarFinal();
            else
            {
                procesoEnCurso.Anterior.Siguiente = procesoEnCurso.Siguiente;
                procesoEnCurso.Siguiente.Anterior = procesoEnCurso.Anterior;
            }
        }

        public void Procesar()
        {
            for (int i = 0; i < Ciclos; i++)
            {
                int probabilidad = random.Next(1, 101);

                if (probabilidad < 35)
                {
                    Proceso aux = new Proceso();
                    if (inicio == null)
                    {
                        inicio = aux;
                        fin = aux;
                        inicio.Siguiente = fin;
                        inicio.Anterior = fin;
                        fin.Anterior = inicio;
                        fin.Siguiente = inicio;
                        procesoEnCurso = inicio;
                    }
                    else
                    {
                        aux.Anterior = fin;
                        fin.Siguiente = aux;
                        fin = aux;
                        fin.Siguiente = inicio;
                    }
                }

                if (inicio == null) CV++;
                else
                {
                    procesoEnCurso.ciclos--;
                    if (procesoEnCurso.ciclos <= 0)
                    {
                        eliminarActual();
                        PAC++;
                    }
                    procesoEnCurso = procesoEnCurso.Siguiente;
                }
            }

            aux = inicio;
            do
            {
                SCP += aux.ciclos;
                aux = aux.Siguiente;
                PP++;
            }
            while (aux != inicio);
        }

        public void limpiarCache()
        {
            inicio = null;
            fin = null;
            CV = 0;
            SCP = 0;
            PP = 0;
            PAC = 0;
        }
        public string CiclosVacio()
        {
            string Ciclos = Convert.ToString(CV);
            return Ciclos;
        }

        public string ProcesosAntendidos()
        {
            string Procesos = Convert.ToString(PAC);
            return Procesos;
        }

        public string ProcesosPendientes()
        {
            string Procesos = Convert.ToString(PP);
            return Procesos;
        }

        public string SumaCiclosPendientes()
        {
            string Suma = Convert.ToString(SCP);
            return Suma;
        }
    }
}
