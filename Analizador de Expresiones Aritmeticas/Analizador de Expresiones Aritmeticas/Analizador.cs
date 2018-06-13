using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_de_Expresiones_Aritmeticas
{
    class Analizador
    {
        Raiz inicio, aux;

        public void agregarInicio(Raiz a)
        {
            if (inicio == null) inicio = a;
            else agregar(inicio, a);
        }
        
        public void agregar(Raiz inicio, Raiz nuevo)
        {
            if (inicio.Siguiente == null)
            {
                inicio.Siguiente = nuevo;
                nuevo.Anterior = inicio;
            }
            else agregar(inicio.Siguiente, nuevo);
        }

        private void ramificar(Raiz raiz)
        {
            raiz.HIzquierdo = raiz.Anterior;
            raiz.HDerecho = raiz.Siguiente;
            raiz.Anterior = raiz.Anterior.Anterior;
            if (raiz.HIzquierdo == inicio)
                inicio = raiz;
            else
                raiz.Anterior.Siguiente = raiz;
            raiz.Siguiente = raiz.Siguiente.Siguiente;
            if (raiz.Siguiente != null)
                raiz.Siguiente.Anterior = raiz;
        }

        public string analizar()
        {
            aux = inicio;
            string preorden = "";
            string postorden = "";
            while (aux != null)
            {
                string x = aux.ToString();
                if (x == "/" || x == "*") ramificar(aux);
                aux = aux.Siguiente;
            }
            aux = inicio;
            while (aux != null)
            {
                string x = aux.ToString();
                if (x == "+" || x == "-") ramificar(aux);
                aux = aux.Siguiente;
            }
            preOrden(inicio, ref preorden);
            postOrden(inicio, ref postorden);
            return "Pre-Orden: " + preorden + Environment.NewLine + "Post-Orden: " + postorden;
        }

        private void preOrden(Raiz x, ref string cadena)
        {
            if (x != null)
            {
                cadena += x.ToString() + " ";
                preOrden(x.HIzquierdo, ref cadena);
                preOrden(x.HDerecho, ref cadena);
            }
        }

        private void postOrden(Raiz x, ref string cadena)
        {
            if (x != null)
            {
                postOrden(x.HIzquierdo, ref cadena);
                postOrden(x.HDerecho, ref cadena);
                cadena += x.ToString() + " ";
            }
        }
    }
}
