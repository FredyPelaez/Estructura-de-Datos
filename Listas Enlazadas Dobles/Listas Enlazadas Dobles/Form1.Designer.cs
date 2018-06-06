namespace Listas_Enlazadas_Dobles
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
            this.cmdListarInverso = new System.Windows.Forms.Button();
            this.cmdEliminarUltimo = new System.Windows.Forms.Button();
            this.txtBoxListar = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtBoxCorreo = new System.Windows.Forms.TextBox();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.txtBoxAM = new System.Windows.Forms.TextBox();
            this.txtBoxAP = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdListarInverso
            // 
            this.cmdListarInverso.Location = new System.Drawing.Point(384, 120);
            this.cmdListarInverso.Name = "cmdListarInverso";
            this.cmdListarInverso.Size = new System.Drawing.Size(89, 23);
            this.cmdListarInverso.TabIndex = 10;
            this.cmdListarInverso.Text = "Listar Inverso";
            this.cmdListarInverso.UseVisualStyleBackColor = true;
            this.cmdListarInverso.Click += new System.EventHandler(this.cmdListarInverso_Click);
            // 
            // cmdEliminarUltimo
            // 
            this.cmdEliminarUltimo.Location = new System.Drawing.Point(384, 178);
            this.cmdEliminarUltimo.Name = "cmdEliminarUltimo";
            this.cmdEliminarUltimo.Size = new System.Drawing.Size(89, 23);
            this.cmdEliminarUltimo.TabIndex = 12;
            this.cmdEliminarUltimo.Text = "Eliminar Ultimo";
            this.cmdEliminarUltimo.UseVisualStyleBackColor = true;
            this.cmdEliminarUltimo.Click += new System.EventHandler(this.cmdEliminarUltimo_Click);
            // 
            // txtBoxListar
            // 
            this.txtBoxListar.Location = new System.Drawing.Point(57, 251);
            this.txtBoxListar.Multiline = true;
            this.txtBoxListar.Name = "txtBoxListar";
            this.txtBoxListar.Size = new System.Drawing.Size(427, 172);
            this.txtBoxListar.TabIndex = 13;
            this.txtBoxListar.TabStop = false;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(391, 91);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 9;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(391, 62);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(384, 149);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(89, 23);
            this.cmdEliminar.TabIndex = 11;
            this.cmdEliminar.Text = "Eliminar Primero";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminarPrimero_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(391, 33);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 7;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtBoxCorreo
            // 
            this.txtBoxCorreo.Location = new System.Drawing.Point(139, 189);
            this.txtBoxCorreo.Name = "txtBoxCorreo";
            this.txtBoxCorreo.Size = new System.Drawing.Size(136, 20);
            this.txtBoxCorreo.TabIndex = 6;
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(139, 156);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(136, 20);
            this.txtBoxNumero.TabIndex = 5;
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(139, 125);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(136, 20);
            this.txtBoxEdad.TabIndex = 4;
            // 
            // txtBoxAM
            // 
            this.txtBoxAM.Location = new System.Drawing.Point(139, 93);
            this.txtBoxAM.Name = "txtBoxAM";
            this.txtBoxAM.Size = new System.Drawing.Size(136, 20);
            this.txtBoxAM.TabIndex = 3;
            // 
            // txtBoxAP
            // 
            this.txtBoxAP.Location = new System.Drawing.Point(139, 62);
            this.txtBoxAP.Name = "txtBoxAP";
            this.txtBoxAP.Size = new System.Drawing.Size(136, 20);
            this.txtBoxAP.TabIndex = 2;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(139, 30);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(136, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Correro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 453);
            this.Controls.Add(this.cmdListarInverso);
            this.Controls.Add(this.cmdEliminarUltimo);
            this.Controls.Add(this.txtBoxListar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtBoxCorreo);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.txtBoxAM);
            this.Controls.Add(this.txtBoxAP);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListarInverso;
        private System.Windows.Forms.Button cmdEliminarUltimo;
        private System.Windows.Forms.TextBox txtBoxListar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtBoxCorreo;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.TextBox txtBoxAM;
        private System.Windows.Forms.TextBox txtBoxAP;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

