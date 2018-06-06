using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ListasEnlazadas
{
    public partial class Form1 : Form
    {

        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtBoxNumero.Text = "";
            txtBoxNombre.Text = "";
            txtBoxCorreo.Text = "";
            txtBoxEdad.Text = "";
            txtBoxAP.Text = "";
            txtBoxAM.Text = "";
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Contacto cX = new Contacto();

            cX.Nombre = txtBoxNombre.Text;
            cX.APaterno = txtBoxAP.Text;
            cX.AMaterno = txtBoxAM.Text;
            cX.Telefono = txtBoxNumero.Text;
            cX.Edad = txtBoxEdad.Text;
            cX.Email = txtBoxCorreo.Text;

            agenda.agregarInicio(cX);
            MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Contacto contacto = agenda.buscar(txtBoxNumero.Text);

            if (agenda.buscar(txtBoxNumero.Text) == null)
            {
                MessageBox.Show("Contacto No Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                txtBoxNombre.Text = contacto.Nombre;
                txtBoxAP.Text = contacto.APaterno;
                txtBoxAM.Text = contacto.AMaterno;
                txtBoxNumero.Text = contacto.Telefono;
                txtBoxEdad.Text = contacto.Edad;
                txtBoxCorreo.Text = contacto.Email;
                MessageBox.Show("Contacto Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            agenda.eliminar(txtBoxNumero.Text);
            MessageBox.Show("Contacto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Clear();
            txtBoxListar.Text = agenda.listar();
        }

        private void cmdEliminarPrimero_Click(object sender, EventArgs e)
        {
            agenda.eliminarPrimero();
        }

        private void cmdEliminarUltimo_Click(object sender, EventArgs e)
        {
            agenda.eliminarUltimo();
        }

        private void cmdReporteInverso_Click(object sender, EventArgs e)
        {
            Contacto cX = new Contacto();
            txtBoxListar.Clear();
            txtBoxListar.Text = agenda.reporteInversoUno(cX);
        }

        private void cmdInvertir_Click(object sender, EventArgs e)
        {
            agenda.invertir();
        }
    }
}
