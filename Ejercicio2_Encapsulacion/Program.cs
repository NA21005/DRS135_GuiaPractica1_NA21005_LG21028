using System;

// ====================================================================================
// ACTIVIDAD:  Actividad Evaluada 1: Guía de trabajo - POO en C#
// EJERCICIO: 2 - Encapsulación y Control de Acceso
// 
// INTEGRANTES:
//   - Cristian Armando Navarro Aguilar  | Carnet: NA21005
//   - Alfredo Alexander Lara Guerra     | Carnet: LG21028
// ====================================================================================
namespace Ejercicio2_Encapsulacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2 - Encapsulación (Empleado)";
            Console.WriteLine("==========================================================");
            Console.WriteLine("  DEMOSTRACIÓN: ENCAPSULACIÓN Y CONTROL DE ACCESO         ");
            Console.WriteLine("==========================================================\n");

            // 1. Creación de un empleado con datos válidos
            Console.WriteLine(">> 1. Registrando empleado con nombre y edad válidos...");
            Empleado empleado1 = new Empleado("Alejandra Pérez", 28);
            Console.WriteLine();

            // 2. Consulta de información mediante método público
            Console.WriteLine(">> 2. Consultando información con MostrarInformacion()...");
            empleado1.MostrarInformacion();
            Console.WriteLine();

            // 3. Modificación válida de la edad
            Console.WriteLine(">> 3. Actualizando edad a un valor válido (30)...");
            empleado1.Edad = 30;
            Console.WriteLine();

            // 4. Validación de edad inválida (mayor o igual a 100)
            Console.WriteLine(">> 4. Intentando asignar una edad inválida (150)...");
            empleado1.Edad = 150;
            Console.WriteLine();

            // 5. Validación de nombre vacío
            Console.WriteLine(">> 5. Intentando asignar un nombre vacío...");
            empleado1.Nombre = "";
            Console.WriteLine();

            // 6. Consulta final de información
            Console.WriteLine("==========================================================");
            Console.WriteLine("INFORMACIÓN FINAL COMPROBADA:");
            empleado1.MostrarInformacion();
            Console.WriteLine("==========================================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
