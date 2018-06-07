using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares_Rutas
{
    class Base
    {
        private string _nombre;
        private int _minutos;
        Base siguiente, anterior;

        public Base(string nombre, int minutos)
        {
            _nombre = nombre;
            _minutos = minutos;
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public int minutos
        {
            get { return _minutos; }
        }
        public Base Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Base Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public override string ToString()
        {
            return string.Format("{0, -20} {1, -15}", _nombre, _minutos);
        }
    }
}
