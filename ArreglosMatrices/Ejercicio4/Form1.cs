using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private int[] cont = new int[9];    //  Arreglo para contar la cantidad de salarios
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularVentas_Click(object sender, EventArgs e)    //  Evento para calcular ventas
        {
            Array.Clear(cont, 0, cont.Length);  //  Se reinicia el contador

            string ventasTxt;
            ventasTxt = tbVentasBrutas.Text;
            //  Convertir el texto en un arreglo
            double[] ventasBrutas = ventasTxt.Split(',').Select(v => double.TryParse(v.Trim(), out var result) ? result : 0).ToArray();
            // Procesar cada venta
            foreach (var ventas in ventasBrutas)
            {
                double salario;
                salario = CalcSalario(ventas);  //  Calcular salario
                ClasfSalario(salario);  //  Clasificar salario
            }

            Resultados();   //  Mostrar resultados
        }

        private double CalcSalario(double ventasBrutas) //  Metodo para calcular el salario
        {
            //  Calcular el salario entero del vendedor
            double salarioBase, comision;
            salarioBase = 200;
            comision = ventasBrutas * 0.09;
            return salarioBase + comision;  //  Retornar salario total
        }

        private void ClasfSalario(double salario)   //  Metodo para clasificar el salario
        {
            int salarioEntero = (int)salario;   //  Convertir salario a entero

            //  Determinar en que rango cae el salario
            if (salarioEntero >= 200 && salarioEntero < 300) cont[0]++;
            else if (salarioEntero >= 300 && salarioEntero < 400) cont[1]++;
            else if (salarioEntero >= 400 && salarioEntero < 500) cont[2]++;
            else if (salarioEntero >= 500 && salarioEntero < 600) cont[3]++;
            else if (salarioEntero >= 600 && salarioEntero < 700) cont[4]++;
            else if (salarioEntero >= 700 && salarioEntero < 800) cont[5]++;
            else if (salarioEntero >= 800 && salarioEntero < 900) cont[6]++;
            else if (salarioEntero >= 900 && salarioEntero < 1000) cont[7]++;
            else if (salarioEntero >= 1000) cont[8]++;

        }

        private void Resultados()    //  Metodo para mostrar los resultados
        {
            lbResultadosVentas.Items.Clear(); // Limpiar los resultados anteriores
            //  Imprimir los resultados
            lbResultadosVentas.Items.Add("$200 - $299: " + cont[0]);
            lbResultadosVentas.Items.Add("$300 - $399: " + cont[1]);
            lbResultadosVentas.Items.Add("$400 - $499: " + cont[2]);
            lbResultadosVentas.Items.Add("$500 - $599: " + cont[3]);
            lbResultadosVentas.Items.Add("$600 - $699: " + cont[4]);
            lbResultadosVentas.Items.Add("$700 - $799: " + cont[5]);
            lbResultadosVentas.Items.Add("$800 - $899: " + cont[6]);
            lbResultadosVentas.Items.Add("$900 - $999: " + cont[7]);
            lbResultadosVentas.Items.Add("$1000 o superior: " + cont[8]);

        }
    }
}
