using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares_Rutas
{
    public partial class Form1 : Form
    {
        Ruta rata = new Ruta();
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtBoxMinutos.Text = "";
            txtBoxLista.Text = "";
            txtBoxNombre.Text = "";
            txtBoxNombreBuscar.Text = "";
            txtBoxPosicion.Text = "";
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            Base vaso = new Base(txtBoxNombre.Text, int.Parse(txtBoxMinutos.Text));

            rata.agregar(vaso);
            clear();
            cmbBoxBase.Items.Add(vaso.nombre);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            Base vaso = new Base(txtBoxNombre.Text, int.Parse(txtBoxMinutos.Text));

            rata.insertar(vaso, int.Parse(txtBoxPosicion.Text));
            clear();
            cmbBoxBase.Items.Add(vaso.nombre);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Base vaso = rata.buscar(txtBoxNombreBuscar.Text);

            if (vaso == null)
            {
                clear();
                txtBoxLista.Text = "No encontrado";
            }
            else
            {
                txtBoxLista.Text = vaso.ToString();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Base vaso = rata.eliminar(txtBoxNombreBuscar.Text);
            txtBoxLista.Text = "Base eliminada  " + vaso.ToString();
            cmbBoxBase.Items.Remove(vaso.nombre);
        }

        private void cmdEliminarPrimera_Click(object sender, EventArgs e)
        {
            Base vaso = rata.eliminarPrimero();
            txtBoxLista.Text = "Base eliminada  " + vaso.ToString();
            cmbBoxBase.Items.Remove(vaso.nombre);
        }

        private void cmdEliminarUltima_Click(object sender, EventArgs e)
        {
            Base vaso = rata.eliminarUltimo();
            txtBoxLista.Text = "Base eliminada  " + vaso.ToString();
            cmbBoxBase.Items.Remove(vaso.nombre);
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtBoxLista.Text = rata.listar();
        }

        private void cmdMostrarRuta_Click(object sender, EventArgs e)
        {
            Base vaso = rata.buscar(cmbBoxBase.SelectedItem.ToString());
            txtBoxLista.Text = rata.ruta(vaso, dtHoraInicio.Value, dtHoraFin.Value);
        }
    }
}
