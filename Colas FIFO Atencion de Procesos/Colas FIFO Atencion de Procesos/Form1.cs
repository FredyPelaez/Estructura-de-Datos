using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO_Atencion_de_Procesos
{
    public partial class Form1 : Form
    {
        Procesador lentium = new Procesador();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            lentium.Procesar();
            txtBoxCiclosVacios.Text = lentium.CiclosVacio();
            txtBoxProcesosAtendidos.Text = lentium.ProcesosAntendidos();
            txtBoxProcesosPendientes.Text = lentium.ProcesosPendientes();
            txtBoxCiclosPendientes.Text = lentium.SumaCiclosPendientes();
            lentium.limpiarCache();
        }
    }
}
