using System;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private double[,] ventas = new double[5, 4]; // Arreglo de ventas

        public Form1()
        {
            InitializeComponent();
            InitLb();
        }

        //  Añadir los encabezados a las listbox
        private void InitLb()   //  Metodo para inicializar los encabezados
        {
            lbVend1.Items.Add("Producto 1");
            lbVend2.Items.Add("Producto 2");
            lbVend3.Items.Add("Producto 3");
            lbVend4.Items.Add("Producto 4");
            lbTotal.Items.Add("Total Vendedor");
        }

        //  Evento para agregar ventas
        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int vendedor, producto;
                double monto;
                //  Leer los datos ingresados
                vendedor = int.Parse(tbVendedor.Text) - 1;
                producto = int.Parse(tbProducto.Text) - 1;
                monto = double.Parse(tbMonto.Text);

                //  Verificar que los valores esten en el rango valido
                if (vendedor >= 0 && vendedor < 4 && producto >= 0 && producto < 5)
                {
                    ventas[producto, vendedor] += monto; // Sumar la venta que corresponda
                    LimpiarCampos();    //  Se limpian los campos de ent
                }
                else
                {
                    MessageBox.Show("Vendedor o producto inválido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: No se ha podido agregar la venta: " + ex.Message);
            }
        }

        private void LimpiarCampos()    //  Metodo para limpiar los campos de texto
        {
            tbVendedor.Text = "";
            tbProducto.Text = "";
            tbMonto.Text = "";
        }

        //  Evento para calcular y mostrar los totales por producto y vendedor
        private void btnTotales_Click(object sender, EventArgs e)
        {
            // Limpiar cada listbox antes de mostrar los resultados
            lbVend1.Items.Clear();
            lbVend2.Items.Clear();
            lbVend3.Items.Clear();
            lbVend4.Items.Clear();
            lbTotal.Items.Clear();

            InitLb();

            double[] totalesPorProducto = new double[5]; // Arreglo para el total de ventas por producto
            double[] totalesPorVendedor = new double[4]; // Arreglo para el total de ventas por vendedor

            for (int i = 0; i < 5; i++) //  Calculo del total de ventas por producto
            {
                lbVend1.Items.Add(ventas[i, 0]);
                lbVend2.Items.Add(ventas[i, 1]);
                lbVend3.Items.Add(ventas[i, 2]);
                lbVend4.Items.Add(ventas[i, 3]);

                totalesPorProducto[i] = ventas[i, 0] + ventas[i, 1] + ventas[i, 2] + ventas[i, 3];
            }

            for (int j = 0; j < 4; j++) //  Calculo del total de ventas por vendedor
            {
                for (int i = 0; i < 5; i++)
                {
                    totalesPorVendedor[j] += ventas[i, j];
                }
            }

            // Mostrar los totales por cada vendedor
            lbVend1.Items.Add(totalesPorVendedor[0]);
            lbVend2.Items.Add(totalesPorVendedor[1]);
            lbVend3.Items.Add(totalesPorVendedor[2]);
            lbVend4.Items.Add(totalesPorVendedor[3]);

            // Mostrar los totales por cada producto
            for (int i = 0; i < 5; i++)
            {
                lbTotal.Items.Add(totalesPorProducto[i]);
            }
        }
    }
}
