using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera_de_Erastoteles
{
    public partial class Form1 : Form
    {
        Numeros_Primos coladera;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdObtenerPrimos_Click(object sender, EventArgs e)
        {
            coladera = new Numeros_Primos();

            txtBoxResultado.Text = coladera.ObtenerPrimos();
        }
    }
}
