namespace Analizador_de_Expresiones_Aritmeticas
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
            this.cmdAnalizar = new System.Windows.Forms.Button();
            this.txtBoxAnalizar = new System.Windows.Forms.TextBox();
            this.txtBoxMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAnalizar
            // 
            this.cmdAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmdAnalizar.Location = new System.Drawing.Point(430, 39);
            this.cmdAnalizar.Name = "cmdAnalizar";
            this.cmdAnalizar.Size = new System.Drawing.Size(75, 23);
            this.cmdAnalizar.TabIndex = 0;
            this.cmdAnalizar.Text = "Analizar";
            this.cmdAnalizar.UseVisualStyleBackColor = true;
            this.cmdAnalizar.Click += new System.EventHandler(this.cmdAnalizar_Click);
            // 
            // txtBoxAnalizar
            // 
            this.txtBoxAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxAnalizar.Location = new System.Drawing.Point(24, 39);
            this.txtBoxAnalizar.Name = "txtBoxAnalizar";
            this.txtBoxAnalizar.Size = new System.Drawing.Size(389, 23);
            this.txtBoxAnalizar.TabIndex = 1;
            // 
            // txtBoxMostrar
            // 
            this.txtBoxMostrar.Location = new System.Drawing.Point(24, 78);
            this.txtBoxMostrar.Multiline = true;
            this.txtBoxMostrar.Name = "txtBoxMostrar";
            this.txtBoxMostrar.Size = new System.Drawing.Size(481, 116);
            this.txtBoxMostrar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 215);
            this.Controls.Add(this.txtBoxMostrar);
            this.Controls.Add(this.txtBoxAnalizar);
            this.Controls.Add(this.cmdAnalizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnalizar;
        private System.Windows.Forms.TextBox txtBoxAnalizar;
        private System.Windows.Forms.TextBox txtBoxMostrar;
    }
}

