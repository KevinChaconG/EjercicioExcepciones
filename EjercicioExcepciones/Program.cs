﻿

using EjercicioExcepciones;
using System.ComponentModel.Design;

int opcion = 0;

Console.WriteLine("---Calculadora---");
Console.WriteLine("Bienvenido a nuestro servicio de calculadora");

try
{
    do
    {
        Menu();
        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                try
                {
                    Console.WriteLine("---Opción Suma----");
                    Operaciones Suma = new Operaciones();
                    Console.WriteLine("Ingrese el primer numero");
                    Suma.n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    Suma.n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El resultado es: {Suma.Suma()}");
                    Console.W riteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El valor ingresado no es un numero valido");
                    Console.WriteLine();
                }

                break;

            case 2:

                try
                {
                    Console.WriteLine("---Opción Resta----");
                    Operaciones Resta = new Operaciones();
                    Console.WriteLine("Ingrese el primer numero");
                    Resta.n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    Resta.n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El resultado es: {Resta.Resta()}");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El valor ingresado no es un numero valido");
                    Console.WriteLine();
                }

                break;

            case 3:

                try
                {
                    Console.WriteLine("---Opción Multiplicacion----");
                    Operaciones Multiplicacion = new Operaciones();
                    Console.WriteLine("Ingrese el primer numero");
                    Multiplicacion.n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    Multiplicacion.n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El resultado es: {Multiplicacion.Multiplicacion()}");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El valor ingresado no es un numero valido");
                    Console.WriteLine();
                }

                break;

            case 4:

                try
                {
                    Console.WriteLine("---Opción Multiplicacion----");
                    Operaciones Division = new Operaciones();
                    Console.WriteLine("Ingrese el primer numero");
                    Division.n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    Division.n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"El resultado es: {Division.Division()}");
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El valor ingresado no es un numero valido");
                    Console.WriteLine();
                }

                break;

            case 9:
                Console.WriteLine("Gracias por utilizar nuestro servicio");
                break;

            default:
                Console.WriteLine("Opcion Invalida");

                break;
        }
    } while (opcion != 9);
}
catch (Exception ex) 
{ 
    Console.WriteLine("El valor ingresado no es valido"); 
}

    Console.ReadLine();

    static void Menu()
    {
        Console.WriteLine("Por favor escoga una opción: ");
        Console.WriteLine();
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("9. Salir");
        Console.WriteLine();
    }

