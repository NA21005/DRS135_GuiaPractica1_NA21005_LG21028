using System;

// ====================================================================================
// ACTIVIDAD:  Actividad Evaluada 1: Guía de trabajo - POO en C#
// EJERCICIO: 3 - Herencia Simple
// 
// INTEGRANTES:
//   - Cristian Armando Navarro Aguilar  | Carnet: NA21005
//   - Alfredo Alexander Lara Guerra     | Carnet: LG21028
// ====================================================================================
namespace Ejercicio3_HerenciaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3 - Herencia Simple (Vehiculo y Coche)";
            Console.WriteLine("==========================================================");
            Console.WriteLine("  DEMOSTRACIÓN: HERENCIA SIMPLE - VEHICULO Y COCHE        ");
            Console.WriteLine("==========================================================\n");

            // 1. Creación de una instancia de Coche
            Console.WriteLine(">> 1. Creando una instancia de Coche...");
            Coche miCoche = new Coche();
            Console.WriteLine();

            // 2. Uso del método heredado Arrancar()
            Console.WriteLine(">> 2. Llamando al método heredado Arrancar()...");
            miCoche.Arrancar();
            Console.WriteLine();

            // 3. Uso del método propio Conducir()
            Console.WriteLine(">> 3. Llamando al método propio Conducir()...");
            miCoche.Conducir();
            Console.WriteLine();

            // 4. Uso del método heredado Detener()
            Console.WriteLine(">> 4. Llamando al método heredado Detener()...");
            miCoche.Detener();
            Console.WriteLine();

            Console.WriteLine("==========================================================");
            Console.WriteLine("El coche usó correctamente los métodos heredados de");
            Console.WriteLine("Vehiculo (Arrancar, Detener) y su propio método Conducir.");
            Console.WriteLine("==========================================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
