namespace Ejercicio2
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
            this.btnFumar = new System.Windows.Forms.Button();
            this.btnNoFumar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione su seccion";
            // 
            // btnFumar
            // 
            this.btnFumar.Location = new System.Drawing.Point(322, 97);
            this.btnFumar.Name = "btnFumar";
            this.btnFumar.Size = new System.Drawing.Size(116, 31);
            this.btnFumar.TabIndex = 1;
            this.btnFumar.Text = "Fumar";
            this.btnFumar.UseVisualStyleBackColor = true;
            this.btnFumar.Click += new System.EventHandler(this.btnFumar_Click);
            // 
            // btnNoFumar
            // 
            this.btnNoFumar.Location = new System.Drawing.Point(322, 148);
            this.btnNoFumar.Name = "btnNoFumar";
            this.btnNoFumar.Size = new System.Drawing.Size(116, 30);
            this.btnNoFumar.TabIndex = 2;
            this.btnNoFumar.Text = "No Fumar";
            this.btnNoFumar.UseVisualStyleBackColor = true;
            this.btnNoFumar.Click += new System.EventHandler(this.btnNoFumar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pase de Abordaje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNoFumar);
            this.Controls.Add(this.btnFumar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFumar;
        private System.Windows.Forms.Button btnNoFumar;
        private System.Windows.Forms.Label label2;
    }
}

