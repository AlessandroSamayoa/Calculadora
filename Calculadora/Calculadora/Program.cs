using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] array1 = new string[100];

            bool ira = true;
            while (ira)
            {

                bool ira2 = true;
                int contar1 = 0;
                double expre = 0, dat1, dat2;
                int contar2 = 0, top = 0;
                char simbolo;

                Console.WriteLine("Selecciona según lo que quieras hacer:\n 1. Ir a calculadora\n 2. Ir a instrucciones\n 3. Salir de la calculadora");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        while (ira2)
                        {
                            for (contar1 = 0; ira2 == true; contar1++)
                            {

                                if (contar2 == 0)
                                {
                                    Console.WriteLine("Ingrese un número y luego presiona Enter para ir al signo");
                                    foreach (string box in array1)
                                    {
                                        Console.Write(box);
                                    }
                                    dat1 = int.Parse(Console.ReadLine());
                                    array1[top] = Convert.ToString(dat1);
                                    top++;
                                    Console.Clear();
                                    Console.WriteLine("Ingresa el signo y luego presiona Enter para ir al número");
                                    foreach (string box in array1)
                                    {
                                        Console.Write(box);
                                    }
                                    simbolo = char.Parse(Console.ReadLine());
                                    array1[top] = Convert.ToString(simbolo);
                                    top++;
                                    foreach (string box in array1)
                                    {

                                        Console.Write(box);

                                    }
                                    Console.Clear();
                                    Console.WriteLine("Ingrese un número y luego presiona Enter para ir al signo");
                                    foreach (string box in array1)
                                    {
                                        Console.Write(box);
                                    }
                                    dat2 = int.Parse(Console.ReadLine());
                                    array1[top] = Convert.ToString(dat2);
                                    top++;

                                    Console.Clear();
                                    switch (simbolo)
                                    {
                                        case '=':
                                            contar1 = 80;
                                            break;
                                        case '/':
                                            expre = dat1 / dat2;
                                            contar2 = contar2 + 1;
                                            break;
                                        case '*':
                                            expre = dat1 * dat2;
                                            contar2 = contar2 + 1;
                                            break;
                                        case '+':
                                            expre = dat1 + dat2;
                                            contar2 = contar2 + 1;
                                            break;
                                        case '-':
                                            expre = dat1 - dat2;
                                            contar2 = contar2 + 1;
                                            break;
                                        default:
                                            Console.WriteLine("Valor invalido, Presiona la tecla Enter.");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else if (contar2 == 1)
                                {
                                    Console.WriteLine("Ingresa el signo y luego presiona Enter para ir al número");
                                    foreach (string box in array1)
                                    {
                                        Console.Write(box);
                                    }
                                    simbolo = char.Parse(Console.ReadLine());
                                    array1[top] = Convert.ToString(simbolo);
                                    top++;
                                    Console.Clear();
                                    if (simbolo == '=')
                                    {
                                        Console.WriteLine("El resultado es:");

                                        foreach (string box in array1)
                                        {
                                            Console.Write(box);
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("es: {0}", expre);
                                        Console.WriteLine("\nPresione la tecla Enter para continuar");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                        Console.Clear();
                                        ira2 = salir(array1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese un número y luego presiona Enter para ir al signo");
                                        foreach (string box in array1)
                                        {
                                            Console.Write(box);
                                        }
                                        dat2 = int.Parse(Console.ReadLine());
                                        array1[top] = Convert.ToString(dat2);
                                        top++;
                                        Console.Clear();

                                        switch (simbolo)
                                        {
                                            case '=':
                                                simbolo = '=';
                                                break;
                                            case '/':
                                                expre = expre / dat2;
                                                break;
                                            case '*':
                                                expre = expre * dat2;
                                                break;
                                            case '-':
                                                expre = expre - dat2;
                                                break;
                                            case '+':
                                                expre = expre + dat2;
                                                break;

                                            default:
                                                Console.WriteLine("Valor invalido, Presiona la tecla Enter.");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                                Console.Clear();
                                                ira2 = salir(array1);
                                                break;
                                        }
                                    }
                                }

                            }
                        }
                        break;

                    case 2:
                        while (ira2)
                        {
                            Console.WriteLine("La calculadora tienes las operaciones de suma, resta, multiplicacion y division.\nTienes que presionar enter despues de cada caracter que ingresas  ya sea numero,\noperadores o signos de agrupación.");
                            Console.WriteLine("\nPresione la tecla Enter para continuar");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            ira2 = salir(array1);
                        }
                        break;

                    case 3:
                        Console.WriteLine("¿Usted desea salir?\n 1. Si\n 2. No");
                        int salida = int.Parse(Console.ReadLine());
                        switch (salida)
                        {
                            case 1:
                                Console.WriteLine("Presiona la tecla Enter para salir.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                ira = false;
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Presiona la tecla Enter para retornar.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                ira = true;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Valor invalido, Presiona la tecla Enter.");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                ira = true;
                                Console.Clear();
                                break;
                        }
                        break;
                    default:

                        break;
                }
            }
        }

        static bool salir(string[] array2)
        {
            int vacio = 0;
            bool numero = true;
            Console.WriteLine("¿Deseas regresar de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());
            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona la tecla Enter para regresar al menú anterior.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; ;
                    numero = true;
                    for (vacio = 0; vacio < 100; vacio++)
                    {
                        array2[vacio] = null;
                    }
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Presiona la tecla Esc para salir.");
                    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                    numero = false;
                    for (vacio = 0; vacio < 100; vacio++)
                    {
                        array2[vacio] = null;
                    }
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("La opción que ingreso es invalido, por favor presione la tecla Enter para regresar");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    numero = false;
                    for (vacio = 0; vacio < 100; vacio++)
                    {
                        array2[vacio] = null;
                    }
                    Console.Clear();
                    break;
            }
            return numero;
        }

    }
}