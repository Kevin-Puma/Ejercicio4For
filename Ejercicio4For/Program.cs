Console.Write("Ingrese un número máximo:");
int numeroMaximo = int.Parse(Console.ReadLine());

Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Mostrar números pares");
Console.WriteLine("2. Mostrar números impares");
Console.WriteLine("3. Mostrar factorial");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
case 1:
MostrarNumerosPares(numeroMaximo);
break;
case 2:
MostrarNumerosImpares(numeroMaximo);
break;
case 3:
MostrarFactorial(numeroMaximo);
break;
default:
Console.WriteLine("Opción no válida");
break;
}
   
    static void MostrarNumerosPares(int numeroMaximo)
    {
        Console.WriteLine("Números pares:");
        for (int i = 2; i <= numeroMaximo; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void MostrarNumerosImpares(int numeroMaximo)
    {
        Console.WriteLine("Números impares:");
        for (int i = 1; i <= numeroMaximo; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void MostrarFactorial(int numeroMaximo)
    {
        long factorial = 1;
        for (int i = 1; i <= numeroMaximo; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial de " +numeroMaximo+ " es " +factorial+ "");
    }

