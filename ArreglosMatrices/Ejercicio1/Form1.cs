using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private Random rand = new Random(); //  Generar numeros aleatorios
        private int tiros = 36000;  //  Numero de veces que se tiraran los dados
        private int[] sumas = new int[13];  //  Arreglo para contar las sumas de los dados

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirarDados_Click(object sender, EventArgs e)
        {
            Array.Clear(sumas,0,sumas.Length);  //  Limpia el arreglo de las sumas
            int dado1, dado2, suma; //  Declarar variables

            for (int i = 0; i < tiros;i++)
            {
                dado1 = rand.Next(1,7); //  Lanzamiento del primer dado
                dado2 = rand.Next(1,7); //  Lanzamiento del segundo dado
                suma = dado1 + dado2;   //  Suma de los dos dados
                sumas[suma]++;  //  Incrementar contador en el arreglo
            }

            ImprimirResultados();
        }

        private void ImprimirResultados()   //  Metodo para mostrar los resultados
        {
            double porcentaje;
            lbResultados.Items.Clear(); //  Limpiar los elementos del listBox

            for (int suma = 2; suma < sumas.Length; suma++)
            {
                porcentaje = ((double)sumas[suma] / tiros) * 100;   //  Calcular el porcentaje de veces que ocurre cada suma
                lbResultados.Items.Add($"Suma: {suma}\t\tFrecuencia: {sumas[suma]}\t\tPorcentaje: {porcentaje:F2}%");
            }

            //  Verificar la razonabilidad de los resultados
            label1.Text = $"Numero de veces para 7: {sumas[7]}  //  Aproximado: {tiros / 6}";
        }
    }
}
