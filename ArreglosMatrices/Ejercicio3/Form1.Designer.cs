namespace Ejercicio3
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
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lbVend1 = new System.Windows.Forms.ListBox();
            this.lbVend2 = new System.Windows.Forms.ListBox();
            this.lbVend3 = new System.Windows.Forms.ListBox();
            this.lbVend4 = new System.Windows.Forms.ListBox();
            this.lbTotal = new System.Windows.Forms.ListBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(15, 74);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(168, 22);
            this.tbProducto.TabIndex = 0;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(15, 252);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(168, 29);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Agregar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(15, 287);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(168, 30);
            this.btnTotales.TabIndex = 2;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // lbVend1
            // 
            this.lbVend1.FormattingEnabled = true;
            this.lbVend1.ItemHeight = 16;
            this.lbVend1.Location = new System.Drawing.Point(376, 86);
            this.lbVend1.Name = "lbVend1";
            this.lbVend1.Size = new System.Drawing.Size(99, 116);
            this.lbVend1.TabIndex = 3;
            // 
            // lbVend2
            // 
            this.lbVend2.FormattingEnabled = true;
            this.lbVend2.ItemHeight = 16;
            this.lbVend2.Location = new System.Drawing.Point(503, 86);
            this.lbVend2.Name = "lbVend2";
            this.lbVend2.Size = new System.Drawing.Size(106, 116);
            this.lbVend2.TabIndex = 4;
            // 
            // lbVend3
            // 
            this.lbVend3.FormattingEnabled = true;
            this.lbVend3.ItemHeight = 16;
            this.lbVend3.Location = new System.Drawing.Point(640, 86);
            this.lbVend3.Name = "lbVend3";
            this.lbVend3.Size = new System.Drawing.Size(100, 116);
            this.lbVend3.TabIndex = 5;
            // 
            // lbVend4
            // 
            this.lbVend4.FormattingEnabled = true;
            this.lbVend4.ItemHeight = 16;
            this.lbVend4.Location = new System.Drawing.Point(770, 86);
            this.lbVend4.Name = "lbVend4";
            this.lbVend4.Size = new System.Drawing.Size(100, 116);
            this.lbVend4.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.FormattingEnabled = true;
            this.lbTotal.ItemHeight = 16;
            this.lbTotal.Location = new System.Drawing.Point(902, 86);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(105, 116);
            this.lbTotal.TabIndex = 7;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(15, 196);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(168, 22);
            this.tbMonto.TabIndex = 8;
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(15, 133);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(168, 22);
            this.tbVendedor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresa el numero del vendedor (1 - 4)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingresa el numero del producto (1 - 5)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingresa el monto de la venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVend4);
            this.Controls.Add(this.lbVend3);
            this.Controls.Add(this.lbVend2);
            this.Controls.Add(this.lbVend1);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.tbProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.ListBox lbVend1;
        private System.Windows.Forms.ListBox lbVend2;
        private System.Windows.Forms.ListBox lbVend3;
        private System.Windows.Forms.ListBox lbVend4;
        private System.Windows.Forms.ListBox lbTotal;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

