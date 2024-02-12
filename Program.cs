// See https://aka.ms/new-console-template for more information
Console.WriteLine("Números enteros");
Console.WriteLine();

{
    int[] numeros = new int[10];


    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ingrese el número entero " + (i + 1) + ":");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
    }

    
    int[] sumaAcumulativa = new int[10];

    
    sumaAcumulativa[0] = numeros[0];
    for (int i = 1; i < 10; i++)
    {
        sumaAcumulativa[i] = sumaAcumulativa[i - 1] + numeros[i];
    }

 
    Console.WriteLine("\nNúmeros ingresados:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Número " + (i + 1) + ": " + numeros[i]);
    }

    Console.WriteLine("\nSuma acumulativa:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Suma hasta el número " + (i + 1) + ": " + sumaAcumulativa[i]);
    }
}

