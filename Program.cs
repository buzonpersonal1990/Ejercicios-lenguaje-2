
using System;

namespace TallerClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable para controlar la opción seleccionada por el usuario en el menú
            int opcion = 0;

            // Bucle 'do-while' para mantener el menú abierto hasta que el usuario decida salir
            do
            {
                // Limpiar la consola en cada iteración para mantener la pantalla ordenada (opcional)
                // Console.Clear();

                Console.WriteLine("\n=================================");
                Console.WriteLine("       TALLER CLASE 1 - C#");
                Console.WriteLine("=================================");
                Console.WriteLine("Por favor selecciona una opción (1-4): ");
                Console.WriteLine("1. Ejercicio 1: Calculadora básica");
                Console.WriteLine("2. Ejercicio 2: ¿Aprobó o no aprobó?");
                Console.WriteLine("3. Ejercicio 3: Tabla de multiplicar");
                Console.WriteLine("4. Salir");
                
                
                // Leer la opción elegida por el usuario y convertirla a entero
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------------------");

                // Estructura de selección múltiple (switch) para redirigir al ejercicio elegido
                switch (opcion)
                {
                    case 1:
                        // --- EJERCICIO 1: CALCULADORA ---
                               
                        int a, b;
            
                        Console.WriteLine("===================");
                        Console.WriteLine("CALCULADORA BÁSICA");
                        Console.WriteLine("===================");

                        Console.Write("Por favor ingresa el primer número:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Por favor ingresa el segundo numero:");
                        b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"La suma es: {a+b}");
                        Console.WriteLine($"La resta es: {a-b}");
                        Console.WriteLine($"La multiplicación es: {a*b}");
                        
                        // Validación rápida para evitar división por cero
                        if (b != 0)
                        {
                            Console.WriteLine($"La división es: {(double)a / b}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        break;

                    case 2:
                        // --- EJERCICIO 2: APROBÓ O NO APROBÓ ---
                        Console.WriteLine(">>> EJECUTANDO: EVALUACIÓN DE DESEMPEÑO <<<");
                        string nombreEstudiante;
                        double notaFinal;

                        Console.Write("Por favor ingresa el nombre del estudiante: ");
                        nombreEstudiante = Console.ReadLine() ?? string.Empty;
                        Console.Write("Por favor ingresa la nota final (entre 0 y 5): ");
                        notaFinal = Convert.ToDouble(Console.ReadLine());

                        // Validación del rango de la nota
                        if (notaFinal >= 0 && notaFinal <= 5)
                        {
                            if (notaFinal < 3.0)
                            {
                                Console.WriteLine($"Estudiante: {nombreEstudiante} - Nota: {notaFinal}");
                                Console.WriteLine("Resultado: Reprobó.");
                            }
                            else if (notaFinal >= 3.0 && notaFinal <= 3.9)
                            {
                                Console.WriteLine($"Estudiante: {nombreEstudiante} - Nota: {notaFinal}");
                                Console.WriteLine("Resultado: Aprobó.");
                            }
                            else if (notaFinal >= 4.0 && notaFinal <= 4.5)
                            {
                                Console.WriteLine($"Estudiante: {nombreEstudiante} - Nota: {notaFinal}");
                                Console.WriteLine("Resultado: Muy buen desempeño.");
                            }
                            else if (notaFinal >= 4.6 && notaFinal <= 5.0)
                            {
                                Console.WriteLine($"Estudiante: {nombreEstudiante} - Nota: {notaFinal}");
                                Console.WriteLine("Resultado: Excelente desempeño.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: La nota ingresada no es válida. Debe estar entre 0 y 5.");
                        }
                        break;

                    case 3:
                        // --- EJERCICIO 3: TABLA DE MULTIPLICAR ---
                        Console.WriteLine(">>> EJECUTANDO: TABLA DE MULTIPLICAR <<<");
                        int numeroBase, limiteTabla;

                        Console.Write("Por favor ingresa el número para generar su tabla: ");
                        numeroBase = Convert.ToInt32(Console.ReadLine());
                        Console.Write("¿Hasta qué número deseas generar la tabla? ");
                        limiteTabla = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Generando la tabla del {numeroBase} hasta el {limiteTabla}:");
                        
                        for (int i = 1; i <= limiteTabla; i++)
                        {
                            Console.WriteLine($"{numeroBase} x {i} = {numeroBase * i}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("¡Gracias por utilizar el programa! Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor elige un número entre 1 y 4.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 4); // El ciclo se repite mientras la opción no sea 4 (Salir)
 


            
        }
    }
}