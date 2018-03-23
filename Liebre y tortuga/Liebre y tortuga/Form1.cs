using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liebre_y_tortuga
{
    public partial class Form1 : Form
    {
        Liebre libro;
        Tortuga tortilla;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCompetir_Click(object sender, EventArgs e)
        {
            txtBoxCarrera.Clear();
           
            libro = new Liebre();
            tortilla = new Tortuga();

            do
            {
                libro.avanzar();
                tortilla.avanzar();

                txtBoxCarrera.Text += libro.ToString() + Environment.NewLine;
                txtBoxCarrera.Text += tortilla.ToString() + Environment.NewLine;
            }
            while (libro.pasos < 80 && tortilla.pasos < 80);

            if (libro.pasos == tortilla.pasos)
            {
                txtBoxGanador.Text = "Empate";
            }
            else if (libro.pasos >= 80)
            {
                txtBoxGanador.Text = "Liebre";
            }
            else
            {
                txtBoxGanador.Text = "Tortuga";
            }
        }
    }
}
