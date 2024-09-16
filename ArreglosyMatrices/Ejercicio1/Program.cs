namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //  Declarar clase Random para generar numeros aleatorios
            double[] sumas = new double[13];    //  Declarar arreglo para las sumas de los dos dados
            int dado1, dado2, suma, siete;  //  Declarar variables
            int tiros = 36000;   //  Numero de veces que se tirarán los dados
            double porcentaje;

            Console.WriteLine("Lanzamiento de dos dados.\n");

            //  Bucle para tirar los dados
            for (int i = 0; i < tiros; i++)
            {
                dado1 = rand.Next(1, 7); //  Lanzamiento del primer dado
                dado2 = rand.Next(1, 7); //  Lanzamiento del segundo dado
                suma = dado1 + dado2;   //  Suma de los dos dados
                sumas[suma]++;  //  Incrementa contador en el arreglo sumas
            }

            //  Bucle para imprimir los resultados
            Console.WriteLine("Suma\tVeces\tPorcentaje");
            for (suma = 2; suma <= 12; suma++)
            {
                porcentaje = sumas[suma] / tiros * 100; //  Porcentaje de veces que aparece cada suma
                Console.WriteLine($"{suma}\t{sumas[suma]}\t{porcentaje:F2}%");
            }

            //  Verificacion de los resultados
            siete = tiros / 6;
            Console.WriteLine($"\nNumero de veces que se espera para 7: {siete}");
            Console.WriteLine($"Numero de veces para 7: {sumas[7]}");
        }
    }
}
