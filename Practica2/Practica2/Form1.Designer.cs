namespace Practica2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.txtBoxShow = new System.Windows.Forms.TextBox();
            this.cmdAbrir = new System.Windows.Forms.Button();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxEscuela = new System.Windows.Forms.TextBox();
            this.txtBoxCuenta = new System.Windows.Forms.TextBox();
            this.cmdCrearXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // txtBoxShow
            // 
            this.txtBoxShow.Location = new System.Drawing.Point(12, 24);
            this.txtBoxShow.Multiline = true;
            this.txtBoxShow.Name = "txtBoxShow";
            this.txtBoxShow.Size = new System.Drawing.Size(100, 96);
            this.txtBoxShow.TabIndex = 0;
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.Location = new System.Drawing.Point(21, 172);
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrir.TabIndex = 1;
            this.cmdAbrir.Text = "Abrir";
            this.cmdAbrir.UseVisualStyleBackColor = true;
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(150, 24);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(172, 20);
            this.txtBoxNombre.TabIndex = 2;
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(150, 50);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(172, 20);
            this.txtBoxEdad.TabIndex = 3;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(150, 76);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(172, 20);
            this.txtBoxTelefono.TabIndex = 4;
            // 
            // txtBoxEscuela
            // 
            this.txtBoxEscuela.Location = new System.Drawing.Point(150, 102);
            this.txtBoxEscuela.Name = "txtBoxEscuela";
            this.txtBoxEscuela.Size = new System.Drawing.Size(172, 20);
            this.txtBoxEscuela.TabIndex = 5;
            // 
            // txtBoxCuenta
            // 
            this.txtBoxCuenta.Location = new System.Drawing.Point(150, 128);
            this.txtBoxCuenta.Name = "txtBoxCuenta";
            this.txtBoxCuenta.Size = new System.Drawing.Size(172, 20);
            this.txtBoxCuenta.TabIndex = 6;
            // 
            // cmdCrearXML
            // 
            this.cmdCrearXML.Location = new System.Drawing.Point(183, 172);
            this.cmdCrearXML.Name = "cmdCrearXML";
            this.cmdCrearXML.Size = new System.Drawing.Size(98, 23);
            this.cmdCrearXML.TabIndex = 7;
            this.cmdCrearXML.Text = "Guardar XML";
            this.cmdCrearXML.UseVisualStyleBackColor = true;
            this.cmdCrearXML.Click += new System.EventHandler(this.cmdCrearXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.cmdCrearXML);
            this.Controls.Add(this.txtBoxCuenta);
            this.Controls.Add(this.txtBoxEscuela);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.cmdAbrir);
            this.Controls.Add(this.txtBoxShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TextBox txtBoxShow;
        private System.Windows.Forms.Button cmdAbrir;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxEscuela;
        private System.Windows.Forms.TextBox txtBoxCuenta;
        private System.Windows.Forms.Button cmdCrearXML;
    }
}

