using System;

// ====================================================================================
// ACTIVIDAD:  Actividad Evaluada 1: Guía de trabajo - POO en C#
// EJERCICIO: 5 - Herencia Multinivel y Sobrescritura de Métodos
// 
// INTEGRANTES:
//   - Cristian Armando Navarro Aguilar  | Carnet: NA21005
//   - Alfredo Alexander Lara Guerra     | Carnet: LG21028
// ====================================================================================
namespace Ejercicio5_HerenciaMultinivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5 - Herencia Multinivel y Sobrescritura";
            Console.WriteLine("=================================================================");
            Console.WriteLine("  DEMOSTRACIÓN: HERENCIA MULTINIVEL (Animal -> Mamifero -> Gato)");
            Console.WriteLine("=================================================================\n");

            // 1. Instancia de la clase base: Animal
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">> 1. Probando la clase base 'Animal':");
            Console.ResetColor();
            Animal animalGenerico = new Animal();
            Console.Write("   - animalGenerico.HacerSonido(): ");
            animalGenerico.HacerSonido();
            Console.WriteLine();

            // 2. Instancia de la clase intermedia: Mamifero
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">> 2. Probando la clase intermedia 'Mamifero' (Hereda de Animal):");
            Console.ResetColor();
            Mamifero mamiferoGenerico = new Mamifero();
            Console.Write("   - mamiferoGenerico.HacerSonido() [Heredado de Animal]: ");
            mamiferoGenerico.HacerSonido();
            Console.Write("   - mamiferoGenerico.Alimentar()   [Método propio de Mamifero]: ");
            mamiferoGenerico.Alimentar();
            Console.WriteLine();

            // 3. Instancia de la clase derivada final: Gato
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(">> 3. Probando la clase derivada 'Gato' (Hereda de Mamifero y Animal):");
            Console.ResetColor();
            Gato miGato = new Gato();
            Console.Write("   - miGato.Alimentar()   [Heredado de Mamifero]: ");
            miGato.Alimentar();
            Console.Write("   - miGato.HacerSonido() [Sobrescrito con override]: ");
            miGato.HacerSonido();
            Console.WriteLine();

            // 4. Demostración polimórfica (referencia base apuntando al objeto derivado)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">> 4. Comprobación Polimórfica (Animal refAnimal = new Gato()):");
            Console.ResetColor();
            Animal referenciaAnimal = new Gato();
            Console.Write("   - referenciaAnimal.HacerSonido(): ");
            referenciaAnimal.HacerSonido(); // Ejecuta el método sobrescrito de Gato por enlace dinámico
            Console.WriteLine();

            Console.WriteLine("=================================================================");
            Console.WriteLine("  EJECUCIÓN COMPLETADA SATISFACTORIAMENTE");
            Console.WriteLine("=================================================================");
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}