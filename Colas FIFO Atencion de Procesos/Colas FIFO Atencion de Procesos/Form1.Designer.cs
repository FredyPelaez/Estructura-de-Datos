namespace Colas_FIFO_Atencion_de_Procesos
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
            this.cmdProcesar = new System.Windows.Forms.Button();
            this.txtBoxCiclosVacios = new System.Windows.Forms.TextBox();
            this.txtBoxProcesosAtendidos = new System.Windows.Forms.TextBox();
            this.txtBoxProcesosPendientes = new System.Windows.Forms.TextBox();
            this.txtBoxCiclosPendientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdProcesar
            // 
            this.cmdProcesar.Location = new System.Drawing.Point(89, 31);
            this.cmdProcesar.Name = "cmdProcesar";
            this.cmdProcesar.Size = new System.Drawing.Size(107, 23);
            this.cmdProcesar.TabIndex = 0;
            this.cmdProcesar.Text = "Procesar";
            this.cmdProcesar.UseVisualStyleBackColor = true;
            this.cmdProcesar.Click += new System.EventHandler(this.cmdProcesar_Click);
            // 
            // txtBoxCiclosVacios
            // 
            this.txtBoxCiclosVacios.Location = new System.Drawing.Point(153, 79);
            this.txtBoxCiclosVacios.Name = "txtBoxCiclosVacios";
            this.txtBoxCiclosVacios.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCiclosVacios.TabIndex = 1;
            // 
            // txtBoxProcesosAtendidos
            // 
            this.txtBoxProcesosAtendidos.Location = new System.Drawing.Point(156, 120);
            this.txtBoxProcesosAtendidos.Name = "txtBoxProcesosAtendidos";
            this.txtBoxProcesosAtendidos.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProcesosAtendidos.TabIndex = 2;
            // 
            // txtBoxProcesosPendientes
            // 
            this.txtBoxProcesosPendientes.Location = new System.Drawing.Point(156, 163);
            this.txtBoxProcesosPendientes.Name = "txtBoxProcesosPendientes";
            this.txtBoxProcesosPendientes.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProcesosPendientes.TabIndex = 3;
            // 
            // txtBoxCiclosPendientes
            // 
            this.txtBoxCiclosPendientes.Location = new System.Drawing.Point(153, 205);
            this.txtBoxCiclosPendientes.Name = "txtBoxCiclosPendientes";
            this.txtBoxCiclosPendientes.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCiclosPendientes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ciclos Vacio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Procesos Completados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Procesos Incompletos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciclos Pendientes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCiclosPendientes);
            this.Controls.Add(this.txtBoxProcesosPendientes);
            this.Controls.Add(this.txtBoxProcesosAtendidos);
            this.Controls.Add(this.txtBoxCiclosVacios);
            this.Controls.Add(this.cmdProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProcesar;
        private System.Windows.Forms.TextBox txtBoxCiclosVacios;
        private System.Windows.Forms.TextBox txtBoxProcesosAtendidos;
        private System.Windows.Forms.TextBox txtBoxProcesosPendientes;
        private System.Windows.Forms.TextBox txtBoxCiclosPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

