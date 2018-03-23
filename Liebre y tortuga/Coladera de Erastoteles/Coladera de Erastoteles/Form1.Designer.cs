namespace Coladera_de_Erastoteles
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
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.cmdObtenerPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(32, 71);
            this.txtBoxResultado.Multiline = true;
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(220, 178);
            this.txtBoxResultado.TabIndex = 0;
            // 
            // cmdObtenerPrimos
            // 
            this.cmdObtenerPrimos.Location = new System.Drawing.Point(78, 28);
            this.cmdObtenerPrimos.Name = "cmdObtenerPrimos";
            this.cmdObtenerPrimos.Size = new System.Drawing.Size(121, 23);
            this.cmdObtenerPrimos.TabIndex = 1;
            this.cmdObtenerPrimos.Text = "Obtener Primos";
            this.cmdObtenerPrimos.UseVisualStyleBackColor = true;
            this.cmdObtenerPrimos.Click += new System.EventHandler(this.cmdObtenerPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdObtenerPrimos);
            this.Controls.Add(this.txtBoxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.Button cmdObtenerPrimos;
    }
}

