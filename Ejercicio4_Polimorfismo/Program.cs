using System;

// ====================================================================================
// ACTIVIDAD:  Actividad Evaluada 1: Guía de trabajo - POO en C#
// EJERCICIO: 4 - Polimorfismo
// 
// INTEGRANTES:
//   - Cristian Armando Navarro Aguilar  | Carnet: NA21005
//   - Alfredo Alexander Lara Guerra     | Carnet: LG21028
// ====================================================================================
namespace Ejercicio4_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4 - Polimorfismo (Animal, Perro y Gato)";
            Console.WriteLine("==========================================================");
            Console.WriteLine("  DEMOSTRACIÓN: POLIMORFISMO - ANIMAL, PERRO Y GATO       ");
            Console.WriteLine("==========================================================\n");

            // 1. Creación de instancias de Perro y Gato
            Console.WriteLine(">> 1. Creando instancias de Perro y Gato...");
            Perro miPerro = new Perro();
            Gato miGato = new Gato();
            Console.WriteLine();

            // 2. Uso de una referencia de tipo Animal para llamar al método
            Console.WriteLine(">> 2. Usando una referencia de tipo Animal para invocar HacerSonido()...\n");

            Animal animal1 = miPerro;
            Animal animal2 = miGato;

            animal1.HacerSonido(); // Se ejecuta la versión sobrescrita en Perro
            animal2.HacerSonido(); // Se ejecuta la versión sobrescrita en Gato
            Console.WriteLine();

            Console.WriteLine("==========================================================");
            Console.WriteLine("Aunque ambas variables son de tipo Animal, cada una ejecutó");
            Console.WriteLine("el sonido propio de su clase real (Perro o Gato).");
            Console.WriteLine("Esto demuestra el polimorfismo en tiempo de ejecución.");
            Console.WriteLine("==========================================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}