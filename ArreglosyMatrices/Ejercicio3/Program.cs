namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] sales = new double[5, 4]; //  Declarar arreglo de ventas
            double[] totalVendedor = new double[4]; //  Declarar arreglo para guardar los totales por cada vendedor
            double[] totalProducto = new double[5]; //  Declarar arreglo para guardar los totales por cada producto
            int vendedor, producto, valor;  //  Declarar variables

            //  Arreglo de datos ficticios de las ventas del mes anterior
            int[,] datos = {
            {1, 1, 250}, {2, 1, 600}, {3, 1, 400}, {4, 1, 300},
            {1, 2, 500}, {2, 2, 500}, {3, 2, 450}, {4, 2, 700},
            {1, 3, 600}, {2, 3, 100}, {3, 3, 800}, {4, 3, 350},
            {1, 4, 900}, {2, 4, 700}, {3, 4, 200}, {4, 4, 600},
            {1, 5, 400}, {2, 5, 300}, {3, 5, 500}, {4, 5, 800}
            };

            //  Procesar los datos de las ventas
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                vendedor = datos[i,0] - 1;
                producto = datos[i,1] - 1;
                valor = datos[i, 2];

                sales[producto, vendedor] += valor; //  Acumular el valor de las ventas
            }

            Console.WriteLine("Ventas del mes anterior\n");
            Console.WriteLine("\t\tVendedor1\tVendedor2\tVendedor3\tVendedor4\tTotal Producto");

            //  Imprimir datos de las ventas
            for (producto = 0; producto < 5; producto++)
            {
                Console.Write("Producto " + (producto + 1));
                for (vendedor = 0; vendedor < 4; vendedor++)
                {
                    Console.Write("\t" + sales[producto, vendedor] + "$" + "\t");

                    //  Acumular el total de las ventas por producto y vendedor
                    totalProducto[producto] += sales[producto,vendedor];
                    totalVendedor[vendedor] += sales[producto,vendedor];
                }
                //  Imprimir total por producto
                Console.WriteLine("\t" + totalProducto[producto] + "$");
            }

            Console.Write("Total Vendedor");

            //  Imprimir total por vendedor
            for (vendedor = 0; vendedor < 4;vendedor++)
            {
                Console.Write("\t" + totalVendedor[vendedor] + "$" + "\t");
            }

            Console.WriteLine("");
        }
    }
}
