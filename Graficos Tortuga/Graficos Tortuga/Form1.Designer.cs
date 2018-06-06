namespace Graficos_Tortuga
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
            this.cmdSubirPluma = new System.Windows.Forms.Button();
            this.cmdBajarPluma = new System.Windows.Forms.Button();
            this.cmdGirarIzquierda = new System.Windows.Forms.Button();
            this.cmdGirarDerecha = new System.Windows.Forms.Button();
            this.txtPosiciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdFin = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.cmdAvanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSubirPluma
            // 
            this.cmdSubirPluma.Location = new System.Drawing.Point(200, 414);
            this.cmdSubirPluma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSubirPluma.Name = "cmdSubirPluma";
            this.cmdSubirPluma.Size = new System.Drawing.Size(112, 32);
            this.cmdSubirPluma.TabIndex = 0;
            this.cmdSubirPluma.Text = "Subir Pluma";
            this.cmdSubirPluma.UseVisualStyleBackColor = true;
            this.cmdSubirPluma.Click += new System.EventHandler(this.cmdSubirPluma_Click);
            // 
            // cmdBajarPluma
            // 
            this.cmdBajarPluma.Location = new System.Drawing.Point(346, 414);
            this.cmdBajarPluma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBajarPluma.Name = "cmdBajarPluma";
            this.cmdBajarPluma.Size = new System.Drawing.Size(112, 32);
            this.cmdBajarPluma.TabIndex = 1;
            this.cmdBajarPluma.Text = "Bajar Pluma";
            this.cmdBajarPluma.UseVisualStyleBackColor = true;
            this.cmdBajarPluma.Click += new System.EventHandler(this.cmdBajarPluma_Click);
            // 
            // cmdGirarIzquierda
            // 
            this.cmdGirarIzquierda.Location = new System.Drawing.Point(122, 454);
            this.cmdGirarIzquierda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGirarIzquierda.Name = "cmdGirarIzquierda";
            this.cmdGirarIzquierda.Size = new System.Drawing.Size(142, 32);
            this.cmdGirarIzquierda.TabIndex = 2;
            this.cmdGirarIzquierda.Text = "Girar a Izquierda";
            this.cmdGirarIzquierda.UseVisualStyleBackColor = true;
            this.cmdGirarIzquierda.Click += new System.EventHandler(this.cmdGirarIzquierda_Click);
            // 
            // cmdGirarDerecha
            // 
            this.cmdGirarDerecha.Location = new System.Drawing.Point(273, 454);
            this.cmdGirarDerecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdGirarDerecha.Name = "cmdGirarDerecha";
            this.cmdGirarDerecha.Size = new System.Drawing.Size(142, 32);
            this.cmdGirarDerecha.TabIndex = 3;
            this.cmdGirarDerecha.Text = "Girar a Derecha";
            this.cmdGirarDerecha.UseVisualStyleBackColor = true;
            this.cmdGirarDerecha.Click += new System.EventHandler(this.cmdGirarDerecha_Click);
            // 
            // txtPosiciones
            // 
            this.txtPosiciones.Location = new System.Drawing.Point(200, 364);
            this.txtPosiciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosiciones.Name = "txtPosiciones";
            this.txtPosiciones.Size = new System.Drawing.Size(148, 24);
            this.txtPosiciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Posiciones:";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Location = new System.Drawing.Point(424, 454);
            this.cmdImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(142, 32);
            this.cmdImprimir.TabIndex = 6;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdFin
            // 
            this.cmdFin.Location = new System.Drawing.Point(273, 494);
            this.cmdFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdFin.Name = "cmdFin";
            this.cmdFin.Size = new System.Drawing.Size(142, 32);
            this.cmdFin.TabIndex = 7;
            this.cmdFin.Text = "Fin";
            this.cmdFin.UseVisualStyleBackColor = true;
            this.cmdFin.Click += new System.EventHandler(this.cmdFin_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrar.Location = new System.Drawing.Point(40, 17);
            this.txtMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(560, 314);
            this.txtMostrar.TabIndex = 8;
            // 
            // cmdAvanzar
            // 
            this.cmdAvanzar.Location = new System.Drawing.Point(358, 361);
            this.cmdAvanzar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAvanzar.Name = "cmdAvanzar";
            this.cmdAvanzar.Size = new System.Drawing.Size(142, 32);
            this.cmdAvanzar.TabIndex = 9;
            this.cmdAvanzar.Text = "Avanzar";
            this.cmdAvanzar.UseVisualStyleBackColor = true;
            this.cmdAvanzar.Click += new System.EventHandler(this.cmdAvanzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 569);
            this.Controls.Add(this.cmdAvanzar);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.cmdFin);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosiciones);
            this.Controls.Add(this.cmdGirarDerecha);
            this.Controls.Add(this.cmdGirarIzquierda);
            this.Controls.Add(this.cmdBajarPluma);
            this.Controls.Add(this.cmdSubirPluma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSubirPluma;
        private System.Windows.Forms.Button cmdBajarPluma;
        private System.Windows.Forms.Button cmdGirarIzquierda;
        private System.Windows.Forms.Button cmdGirarDerecha;
        private System.Windows.Forms.TextBox txtPosiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdFin;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button cmdAvanzar;
    }
}

