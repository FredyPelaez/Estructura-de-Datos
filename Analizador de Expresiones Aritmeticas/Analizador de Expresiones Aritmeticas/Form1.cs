using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_de_Expresiones_Aritmeticas
{
    public partial class Form1 : Form
    {
        Analizador analizador = new Analizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnalizar_Click(object sender, EventArgs e)
        {
            string[] vector = txtBoxAnalizar.Text.Split(' ');
            foreach (string s in vector)
            {
                Raiz x = new Raiz(s);
                analizador.agregarInicio(x);
            }
            txtBoxMostrar.Text = analizador.analizar();
        }
    }
}
