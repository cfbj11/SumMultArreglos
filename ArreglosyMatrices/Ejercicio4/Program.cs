namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salarios = new double[9];  //  Declarar arreglo para contar salarios en cada rango
            double[] ventasTotales = {3000,5000,7000,4000,9000,1500,6000,2500,7000,1000};  //  Declarar arreglo de datos ficticios de las ventas de los vendedores
            int salarioTotal = 0;   //  Declarar variable de salario

            //  Procesar cada venta de los vendedores
            foreach (double ventas in ventasTotales)
            {
                salarioTotal = (int)(200 + (0.09 * ventas));    //  Calculo del salario que le corresponde a cada vendedor

                //  Determinar el rango en el que cae el salario
                if (salarioTotal >= 200 && salarioTotal < 300) salarios[0]++;
                if (salarioTotal >= 300 && salarioTotal < 400) salarios[1]++;
                if (salarioTotal >= 400 && salarioTotal < 500) salarios[2]++;
                if (salarioTotal >= 500 && salarioTotal < 600) salarios[3]++;
                if (salarioTotal >= 600 && salarioTotal < 700) salarios[4]++;
                if (salarioTotal >= 700 && salarioTotal < 800) salarios[5]++;
                if (salarioTotal >= 800 && salarioTotal < 900) salarios[6]++;
                if (salarioTotal >= 900 && salarioTotal < 1000) salarios[7]++;
                if (salarioTotal >= 1000) salarios[8]++;
            }

            //  Imprimir los resultados de la distribucion de salarios
            Console.WriteLine("Distribucion de Salarios\n");
            Console.WriteLine($"$200 - $299: {salarios[0]}");
            Console.WriteLine($"$300 - $399: {salarios[1]}");
            Console.WriteLine($"$400 - $499: {salarios[2]}");
            Console.WriteLine($"$500 - $599: {salarios[3]}");
            Console.WriteLine($"$600 - $699: {salarios[4]}");
            Console.WriteLine($"$700 - $799: {salarios[5]}");
            Console.WriteLine($"$800 - $899: {salarios[6]}");
            Console.WriteLine($"$900 - $999: {salarios[7]}");
            Console.WriteLine($"$1000 o mas: {salarios[8]}");
        }
    }
}
