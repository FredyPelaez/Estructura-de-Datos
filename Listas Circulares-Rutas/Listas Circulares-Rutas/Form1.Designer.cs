namespace Listas_Circulares_Rutas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmbBoxBase = new System.Windows.Forms.ComboBox();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMinutos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxPosicion = new System.Windows.Forms.TextBox();
            this.txtBoxNombreBuscar = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdEliminarPrimera = new System.Windows.Forms.Button();
            this.cmdEliminarUltima = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dtHoraFin = new System.Windows.Forms.DateTimePicker();
            this.cmdMostrarRuta = new System.Windows.Forms.Button();
            this.txtBoxLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(83, 32);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(92, 85);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 3;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmbBoxBase
            // 
            this.cmbBoxBase.FormattingEnabled = true;
            this.cmbBoxBase.Location = new System.Drawing.Point(83, 159);
            this.cmbBoxBase.Name = "cmbBoxBase";
            this.cmbBoxBase.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxBase.TabIndex = 6;
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.CustomFormat = "hh:mm";
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraInicio.Location = new System.Drawing.Point(368, 157);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.ShowUpDown = true;
            this.dtHoraInicio.Size = new System.Drawing.Size(47, 20);
            this.dtHoraInicio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minutos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre a buscar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fin:";
            // 
            // txtBoxMinutos
            // 
            this.txtBoxMinutos.Location = new System.Drawing.Point(83, 59);
            this.txtBoxMinutos.Name = "txtBoxMinutos";
            this.txtBoxMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMinutos.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Posicion:";
            // 
            // txtBoxPosicion
            // 
            this.txtBoxPosicion.Location = new System.Drawing.Point(92, 120);
            this.txtBoxPosicion.Name = "txtBoxPosicion";
            this.txtBoxPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPosicion.TabIndex = 4;
            // 
            // txtBoxNombreBuscar
            // 
            this.txtBoxNombreBuscar.Location = new System.Drawing.Point(436, 27);
            this.txtBoxNombreBuscar.Name = "txtBoxNombreBuscar";
            this.txtBoxNombreBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreBuscar.TabIndex = 7;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(340, 52);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(461, 52);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdEliminarPrimera
            // 
            this.cmdEliminarPrimera.Location = new System.Drawing.Point(340, 81);
            this.cmdEliminarPrimera.Name = "cmdEliminarPrimera";
            this.cmdEliminarPrimera.Size = new System.Drawing.Size(90, 23);
            this.cmdEliminarPrimera.TabIndex = 10;
            this.cmdEliminarPrimera.Text = "Eliminar Primera";
            this.cmdEliminarPrimera.UseVisualStyleBackColor = true;
            this.cmdEliminarPrimera.Click += new System.EventHandler(this.cmdEliminarPrimera_Click);
            // 
            // cmdEliminarUltima
            // 
            this.cmdEliminarUltima.Location = new System.Drawing.Point(452, 81);
            this.cmdEliminarUltima.Name = "cmdEliminarUltima";
            this.cmdEliminarUltima.Size = new System.Drawing.Size(84, 23);
            this.cmdEliminarUltima.TabIndex = 11;
            this.cmdEliminarUltima.Text = "Eliminar Ultima";
            this.cmdEliminarUltima.UseVisualStyleBackColor = true;
            this.cmdEliminarUltima.Click += new System.EventHandler(this.cmdEliminarUltima_Click);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.Location = new System.Drawing.Point(219, 114);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertar.TabIndex = 5;
            this.cmdInsertar.Text = "Insertar";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(407, 118);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 12;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dtHoraFin
            // 
            this.dtHoraFin.CustomFormat = "hh:mm";
            this.dtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraFin.Location = new System.Drawing.Point(515, 157);
            this.dtHoraFin.Name = "dtHoraFin";
            this.dtHoraFin.ShowUpDown = true;
            this.dtHoraFin.Size = new System.Drawing.Size(47, 20);
            this.dtHoraFin.TabIndex = 14;
            // 
            // cmdMostrarRuta
            // 
            this.cmdMostrarRuta.Location = new System.Drawing.Point(257, 203);
            this.cmdMostrarRuta.Name = "cmdMostrarRuta";
            this.cmdMostrarRuta.Size = new System.Drawing.Size(85, 23);
            this.cmdMostrarRuta.TabIndex = 15;
            this.cmdMostrarRuta.Text = "Mostrar Ruta";
            this.cmdMostrarRuta.UseVisualStyleBackColor = true;
            this.cmdMostrarRuta.Click += new System.EventHandler(this.cmdMostrarRuta_Click);
            // 
            // txtBoxLista
            // 
            this.txtBoxLista.Location = new System.Drawing.Point(52, 232);
            this.txtBoxLista.Multiline = true;
            this.txtBoxLista.Name = "txtBoxLista";
            this.txtBoxLista.Size = new System.Drawing.Size(494, 178);
            this.txtBoxLista.TabIndex = 0;
            this.txtBoxLista.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 422);
            this.Controls.Add(this.txtBoxLista);
            this.Controls.Add(this.cmdMostrarRuta);
            this.Controls.Add(this.dtHoraFin);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdEliminarUltima);
            this.Controls.Add(this.cmdEliminarPrimera);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtBoxNombreBuscar);
            this.Controls.Add(this.txtBoxPosicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxMinutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHoraInicio);
            this.Controls.Add(this.cmbBoxBase);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.ComboBox cmbBoxBase;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMinutos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPosicion;
        private System.Windows.Forms.TextBox txtBoxNombreBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdEliminarPrimera;
        private System.Windows.Forms.Button cmdEliminarUltima;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DateTimePicker dtHoraFin;
        private System.Windows.Forms.Button cmdMostrarRuta;
        private System.Windows.Forms.TextBox txtBoxLista;
    }
}

