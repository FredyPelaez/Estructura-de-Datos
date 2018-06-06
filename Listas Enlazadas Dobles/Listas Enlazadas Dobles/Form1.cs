using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Enlazadas_Dobles
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

            agenda.agregar(cX);
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
                txtBoxListar.Text = contacto.ToString();
                MessageBox.Show("Contacto Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void cmdListarInverso_Click(object sender, EventArgs e)
        {
            txtBoxListar.Clear();
            txtBoxListar.Text = agenda.listarInverso();
        }
    }
}
