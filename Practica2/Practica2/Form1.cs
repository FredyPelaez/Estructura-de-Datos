using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CrearXml(XmlDocument doc, string nombre, string edad, string telefono, string escuela, string cuenta)
        {
            XmlDeclaration documento = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlElement element = doc.DocumentElement;
            doc.InsertBefore(documento, element);


            XmlNode node = doc.CreateElement("ALumno");
            doc.AppendChild(node);
            XmlNode usNode = doc.CreateElement("Registros");
            XmlAttribute name = doc.CreateAttribute("Nombre");
            name.Value = nombre;
            usNode.Attributes.Append(name);
            XmlAttribute age = doc.CreateAttribute("Edad");
            age.Value = edad;
            usNode.Attributes.Append(age);
            XmlAttribute Telefono = doc.CreateAttribute("Telefono");
            Telefono.Value = telefono;
            usNode.Attributes.Append(Telefono);
            XmlAttribute Escuela = doc.CreateAttribute("Escuela");
            Escuela.Value = escuela;
            usNode.Attributes.Append(Escuela);
            XmlAttribute Cuenta = doc.CreateAttribute("Cuenta");
            Cuenta.Value = cuenta;
            usNode.Attributes.Append(Cuenta);
            node.AppendChild(usNode);
        }
        private void cmdCrearXML_Click(object sender, EventArgs e)
        {
            saveFile.Filter = ".xml|*.xml";
            saveFile.ShowDialog();
            XmlDocument xml = new XmlDocument();

            CrearXml(xml, txtBoxNombre.Text, txtBoxEdad.Text, txtBoxTelefono.Text, txtBoxEscuela.Text, txtBoxCuenta.Text);

            txtBoxNombre.Clear();
            txtBoxTelefono.Clear();
            txtBoxEdad.Clear();
            txtBoxEscuela.Clear();
            txtBoxCuenta.Clear();

            xml.Save(saveFile.FileName);
        }

        private void cmdAbrir_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            FileStream archivo = new
                FileStream(openFile.FileName, FileMode.Open);

            BinaryReader leer = new BinaryReader(archivo);

            Int16 bm = 0;
            bm = leer.ReadInt16();
            if (bm == 0x4D42)
                txtBoxShow.Text = "BM" + Environment.NewLine;

            Int32 size = 0;
            size = leer.ReadInt32();
            txtBoxShow.Text += size.ToString() + Environment.NewLine;

            Int32 width = 0;
            archivo.Seek(18, SeekOrigin.Begin);
            width = leer.ReadInt32();
            txtBoxShow.Text += width.ToString() + Environment.NewLine;

            Int32 heigth = 0;
            heigth = leer.ReadInt32();
            txtBoxShow.Text += heigth.ToString() + Environment.NewLine;

            archivo.Seek(28, SeekOrigin.Begin);

            Int16 pixels = 0;
            pixels = leer.ReadInt16();
            txtBoxShow.Text += pixels.ToString() + Environment.NewLine;

            leer.Close();
            archivo.Close();
        }
    }
}
