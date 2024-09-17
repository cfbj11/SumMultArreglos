using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private bool[] asientos = new bool[10]; //  Arreglo para los asientos del avion (10)
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFumar_Click(object sender, EventArgs e)
        {
            AsignarAsiento(1, 5, "Fumar");  //  Se asigna asiento en la seccion 'Fumar'
        }

        private void btnNoFumar_Click(object sender, EventArgs e)
        {
            AsignarAsiento(6, 10, "No Fumar");  //  Se asigna asiento en la seccion 'No Fumar'
        }

        private void AsignarAsiento(int inicio, int final, string seccion)
        {
            int asiento;
            asiento = EncontrarAsiento(inicio, final);

            if (asiento != -1)
            {
                asientos[asiento - 1] = true;   //  Se asigna el asiento como ocupado
                label2.Text = $"Pase de Abordaje: \n\nN° de Asiento: {asiento}\n\nSeccion: {seccion}";
            }
            else
            {
                //  Si no hay asiento disponible se pregunta al usuario si desea ir a la otra seccion
                if (seccion == "Fumar")
                {
                    PreguntarPorFumar();
                }
                else if (seccion == "No Fumar")
                {
                    PreguntarPorNoFumar();
                }
            }
        }

        private int EncontrarAsiento(int inicio, int final)
        {
            for (int i = inicio - 1; i < final;i++)
            {
                if (!asientos[i])
                {
                    return i + 1;   //  Retorna el numero del asiento
                }
            }
            return -1;  //  Retorna -1 si no hay asientos disponibles
        }

        private void PreguntarPorNoFumar()
        {
            //  Se pregunta al usuario si desea cambiar de seccion
            var result = MessageBox.Show("La seccion 'Fumar' esta llena. ¿Desearia ser colocado en la seccion 'No Fumar'?", "Seccion llena", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                AsignarAsiento(1, 5, "Fumar"); //  Se asigna en la otra seccion
            }
            else
            {
                label2.Text = "El siguiente vuelo sale en 3 horas.";
            }
        }

        private void PreguntarPorFumar()
        {
            //  Se pregunta al usuario si desea cambiar de seccion
            var result = MessageBox.Show("La seccion 'No Fumar' esta llena. ¿Desearia ser colocado en la seccion 'Fumar'?", "Seccion llena", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                AsignarAsiento(6, 10, "No Fumar");   //  Se asigna en la otra seccion
            }
            else
            {
                label2.Text = "El siguiente vuelo sale en 3 horas.";
            }
        }
    }
}
