using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atencion_de_Procesos
{
    class Procesador
    {
        Proceso inicio, aux, fin;
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
                    }
                    else
                    {
                        fin.Siguiente = aux;
                        fin = aux;
                    } 
                }

                if (inicio == null)
                {
                    CV++;
                }
                else if (inicio.ciclos == 0)
                {
                    aux = inicio.Siguiente;
                    inicio.Siguiente = null;
                    inicio = aux;
                    PAC++;
                }
                else
                {
                    inicio.ciclos--;
                }
            }
            aux = inicio;
            while (aux != null)
            {
                SCP += aux.ciclos;
                aux = aux.Siguiente;
                PP++;
            }
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
