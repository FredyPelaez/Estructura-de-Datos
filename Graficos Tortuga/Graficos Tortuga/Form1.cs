using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_Tortuga
{
    public partial class Form1 : Form
    {
        Tortuga ninja = new Tortuga();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = ninja.ToString();
        }

        private void cmdSubirPluma_Click(object sender, EventArgs e)
        {
            ninja.subirPluma();
        }

        private void cmdBajarPluma_Click(object sender, EventArgs e)
        {
            ninja.bajarPluma();
        }

        private void cmdGirarDerecha_Click(object sender, EventArgs e)
        {
            ninja.girarDerecha();
        }

        private void cmdGirarIzquierda_Click(object sender, EventArgs e)
        {
            ninja.girarIzquierda();
        }

        private void cmdAvanzar_Click(object sender, EventArgs e)
        {
            ninja.avanzar(int.Parse(txtPosiciones.Text));
        }

        private void cmdFin_Click(object sender, EventArgs e)
        {
            ninja.fin();
        }
    }
}
