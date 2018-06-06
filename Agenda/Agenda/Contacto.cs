using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto
    {
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _edad;
        private string _numero;
        private string _correo;

        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellidoPaterno { get { return _apellidoPaterno; } set { _apellidoPaterno = value; } }
        public string apellidoMaterno { get { return _apellidoMaterno; } set { _apellidoMaterno = value; } }
        public string edad { get { return _edad; } set { _edad = value; } }
        public string numero { get { return _numero; } set { _numero = value; } }
        public string correo { get { return _correo; } set { _correo = value; } }
        
        public Contacto()
        {

        }

        public override string ToString()
        {
            string contacto = nombre + " " + apellidoPaterno + " " + apellidoMaterno + ", " + edad + ", " + numero + ", " + correo;
            return contacto;
        }
    }
}
