using System;

class Program
{
    static void Main()
    {
        string[] empleados = new string[5];
        string[] departamentos = new string[5];
        string[] resultado = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre del empleado: ");
            empleados[i] = Console.ReadLine();
            Console.Write("Ingrese el nombre del departamento: ");
            departamentos[i] = Console.ReadLine();
        }

        for (int i = 0; i < 5; i++)
        {
            resultado[i] = empleados[i] + " - " + departamentos[i];
        }

        Console.WriteLine("\nResultado:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(resultado[i]);
        }
    }
}
