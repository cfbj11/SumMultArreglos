namespace Ejercicio2
{
    internal class Program
    {
        static int AsignarAsiento(bool[] asientos, int inicio, int final, string seccion)   //  Metodo para asignar asiento
        {
            //  Rango de asientos entre inicio y final
            for (int i = inicio; i < final; i++)
            {
                //  Si hay un asiento disponible, se asigna al usuario
                if (!asientos[i])
                {
                    asientos[i] = true; //  Asignar asiento como ocupado
                    return i;   //  Retorna el asiento asignado para el usuario
                }
            }
            return -1;  //  Retorna -1 si no hay asientos disponibles
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de reservaciones de aerolinea.\n");

            bool[] asientos = new bool[10]; //  Declarar arreglo de asientos del avion (10)
            int asiento, opcion = 0;    //  Declarar variables
            string respuesta, seccion;

            //  Bucle para procesar las reservaciones
            while (true)
            {
                Console.WriteLine("Ingrese 1 para la seccion 'Fumar'");
                Console.WriteLine("Ingrese 2 para la seccion 'No Fumar'");
                Console.WriteLine("Ingresar 0 para salir");
                Console.Write("$: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)    //  Si se ingresa '0' termina el programa
                {
                    return;
                }

                if (opcion == 1)    //  Seccion 'Fumar'
                {
                    asiento = AsignarAsiento(asientos,0,5,"fumar");  //  Asigna el asiento en la seccion 'Fumar'
                    if (asiento != -1)
                    {
                        seccion = "Fumar";
                        Console.WriteLine("Pase de Abordaje");
                        Console.WriteLine($"N° de Asiento: {asiento + 1}\tSeccion: {seccion}");
                    }
                    else
                    {
                        Console.WriteLine("Seccion 'Fumar' llena. ¿Desearia ser colocado en la seccion 'No Fumar'? (SI/NO)");
                        respuesta = Console.ReadLine();
                        if (respuesta == "SI")
                        {
                            //  Se asigna un asiento en la seccion 'No Fumar', si no hay asientos disponibles en la seccion 'Fumar'
                            asiento = AsignarAsiento(asientos,5,10,"no fumar");
                            if (asiento != -1)
                            {
                                seccion = "No Fumar";
                                Console.WriteLine("Pase de Abordaje");
                                Console.WriteLine($"N° de Asiento: {asiento + 1}\t Seccion: {seccion}\n");
                            }
                            else
                            {
                                //  Si no hay asientos disponibles en el avion, termina el programa
                                Console.WriteLine("\nEl avion alcanzo su capacidad maxima. El siguiente vuelo sale en 3 horas.");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El siguiente vuelo sale en 3 horas.");
                        }
                    }
                }
                else if (opcion == 2)   //  Seccion 'No Fumar'
                {
                    asiento = AsignarAsiento(asientos,5,10,"no fumar"); //  Asigna el asiento en la seccion 'No Fumar'
                    if (asiento != -1)
                    {
                        seccion = "No Fumar";
                        Console.WriteLine("Pase de Abordaje");
                        Console.WriteLine($"N° de Asiento: {asiento + 1}\tSeccion: {seccion}");
                    }
                    else
                    {
                        Console.WriteLine("Seccion 'No Fumar' llena. ¿Desearia ser colocado en la seccion 'Fumar'? (SI/NO)");
                        respuesta = Console.ReadLine();
                        if (respuesta == "SI")
                        {
                            //  Se asigna un asiento en la seccion 'Fumar', si no hay asientos disponibles en la seccion 'No Fumar'
                            asiento = AsignarAsiento(asientos,0,5,"fumar");
                            if (asiento != -1)
                            {
                                seccion = "Fumar";
                                Console.WriteLine("Pase de Abordaje");
                                Console.WriteLine($"N° de Asiento: {asiento + 1}\t Seccion: {seccion}\n");
                            }
                            else
                            {
                                //  Si no hay asientos disponibles en el avion, termina el programa
                                Console.WriteLine("\nEl avion alcanzo su capacidad maxima. El siguiente vuelo sale en 3 horas.");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El siguiente vuelo sale en 3 horas.");
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
