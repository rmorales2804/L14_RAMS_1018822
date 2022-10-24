internal class Program
{
    private static void Main(string[] args)
    {
        string opcion;
        string[] nombres = new string[5];
        string[] puesto = new string[5];
        int[] año = new int[5];
        int[] salario = new int[5];
        int edad = 0;

        Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
        Console.WriteLine("Presione 1 -------> Opcion 1");
        Console.WriteLine("Presione 2 -------> Opcion 2");
        Console.WriteLine("Presione 3 -------> Opcion 3");

        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese el nombre del empleado: ");
                    nombres[i] = Console.ReadLine();
                    Console.Write("Ingrese el año de nacimiento del empleado: ");
                    año[i] = int.Parse(Console.ReadLine());
                }
                for(int i = 0; i < 5; i++)
                {
                    edad = 2022 - año[i];
                    Console.WriteLine();
                    Console.WriteLine(" La edad de " + nombres[i] + " es de " + edad);
                }
                
                break;

            case "2":
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese el nombre del puesto: ");
                    puesto[i] = Console.ReadLine();
                    Console.Write("Ingrese el salario del puesto: ");
                    salario[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(" El puesto " + puesto[i] + " tiene un salario de " + salario[i]);
                }
                break;

            case "3":
                Console.WriteLine("Programa terminado");
                Environment.Exit(0);
                break;
        }
    }
}