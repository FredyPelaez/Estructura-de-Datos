using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        Contacto contact;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            contact = new Contacto();

            contact.nombre = txtBoxNombre.Text;
            contact.apellidoPaterno = txtBoxAP.Text;
            contact.apellidoMaterno = txtBoxAM.Text;
            contact.edad = txtBoxEdad.Text;
            contact.numero = txtBoxNumero.Text;
            contact.correo = txtBoxCorreo.Text;

            if (agenda.contador >= agenda.tamaño)
                MessageBox.Show("No se pueden agregar más elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            txtBoxNombre.Clear();
            txtBoxAP.Clear();
            txtBoxAM.Clear();
            txtBoxEdad.Clear();
            txtBoxNumero.Clear();
            txtBoxCorreo.Clear();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            agenda.eliminar(Convert.ToInt16(txtBoxPosicion.Text));
            txtBoxPosicion.Clear();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            contact = new Contacto();

            contact.numero = txtBoxNumero.Text;
            contact.correo = txtBoxCorreo.Text;

            if(!agenda.insertar(Convert.ToInt16(txtBoxPosicion.Text), contact))
                MessageBox.Show("No se pueden agregar más elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            txtBoxNombre.Clear();
            txtBoxAP.Clear();
            txtBoxAM.Clear();
            txtBoxEdad.Clear();
            txtBoxNumero.Clear();
            txtBoxCorreo.Clear();
            txtBoxPosicion.Clear();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Clear();
            if (agenda.buscar(txtBoxNumero.Text) == null)
            {
                txtBoxListar.Text += "No existe";
            }
            else
            {
                txtBoxListar.Text = contact.ToString();
            }
            txtBoxNombre.Clear();
            txtBoxAP.Clear();
            txtBoxAM.Clear();
            txtBoxEdad.Clear();
            txtBoxNumero.Clear();
            txtBoxCorreo.Clear();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Clear();
            txtBoxListar.Text = agenda.ToString();
        }
    }
}
