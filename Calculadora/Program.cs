using System.Dynamic;
using System.Reflection.Emit;
using EspacioCalculadora;

// Calculadora cal1 = new Calculadora();
// Console.WriteLine($"Valor original = {cal1.resultado}");

// cal1.Sumar(75);
// Console.WriteLine($"Valor despues de SUMAR = {cal1.resultado}");

// cal1.Restar(5);
// Console.WriteLine($"Valor despues de RESTAR = {cal1.resultado}");

// cal1.Multiplicar(4);
// Console.WriteLine($"Valor despues de MULTIPLICAR = {cal1.resultado}");

// cal1.Dividir(2);
// Console.WriteLine($"Valor despues de DIVIDIR = {cal1.resultado}");

// cal1.Limpiar();
// Console.WriteLine($"Valor de la variable original despues de LIMPIAR = {cal1.resultado}");

int opcion;
double numero;
bool esIntOpcion, esDoubleNumero;

Calculadora cal1 = new Calculadora();
Console.WriteLine($"Valor original = {cal1.resultado}");

Console.WriteLine("******************************* CALCULADORA *******************************");

do
{
    do
    {
        Console.WriteLine(" Ingrese el numero que corresponde a la operacion que desee realizar");
        Console.WriteLine("     SUMAR --------------------->     1");
        Console.WriteLine("     RESTAR -------------------->     2");
        Console.WriteLine("     MULTIPLICAR --------------->     3");
        Console.WriteLine("     DIVIDIR ------------------->     4");
        Console.WriteLine("     LIMPIAR ------------------->     5");
        Console.WriteLine("     SALIR --------------------->     0");
        esIntOpcion = int.TryParse(Console.ReadLine(), out opcion);

        if (!esIntOpcion)
        {
            Console.WriteLine("El valor ingresado no es un numero entero\n");
        }

        if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 5 && opcion != 0)
        {
            Console.WriteLine("El numero ingresado no corresponde a ninguna de las opciones\n");
        }

    } while (!esIntOpcion || (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 5 && opcion != 0));

    if (opcion != 0)
    {
        if (opcion != 5)
        {
            do
            {
                Console.WriteLine("Ingrese un numero para realizar la operacion");
                esDoubleNumero = double.TryParse(Console.ReadLine(), out numero);

                if (esDoubleNumero)
                {
                    switch (opcion)
                    {
                        case 1:
                            cal1.Sumar(numero);
                            Console.WriteLine($"Valor despues de SUMAR = {cal1.resultado}");
                            break;
                        case 2:
                            cal1.Restar(numero);
                            Console.WriteLine($"Valor despues de RESTAR = {cal1.resultado}");
                            break;
                        case 3:
                            cal1.Multiplicar(numero);
                            Console.WriteLine($"Valor despues de MULTIPLICAR = {cal1.resultado}");
                            break;
                        case 4:
                            cal1.Dividir(numero);
                            Console.WriteLine($"Valor despues de DIVIDIR = {cal1.resultado}");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un numero");
                }
            } while (!esDoubleNumero);
        }
        else
        {
            cal1.Limpiar();
            Console.WriteLine($"Valor despues de LIMPIAR = {cal1.resultado}");
        }
    }
    else
    {
        Console.WriteLine("************************* FIN DE LA CALCULADORA *************************");
    }
} while (opcion != 0);