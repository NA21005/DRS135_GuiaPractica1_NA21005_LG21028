using System;
using System.Collections.Generic;
using System.Text;


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
    /// <summary>
    /// Representa un coche que extiende el comportamiento de Vehiculo.
    /// Hereda Arrancar() y Detener(), y añade su propio método Conducir()
    /// para demostrar la reutilización de código mediante herencia simple.
    /// </summary>
    public class Coche : Vehiculo
    {
        /// <summary>
        /// Permite conducir el coche. Es un comportamiento exclusivo
        /// de esta clase, no heredado de Vehiculo.
        /// </summary>
        public void Conducir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Coche] El coche está en marcha, conduciendo por la carretera.");
            Console.ResetColor();
        }
    }
}
