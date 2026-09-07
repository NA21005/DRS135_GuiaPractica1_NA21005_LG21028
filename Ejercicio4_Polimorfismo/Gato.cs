using System;
using System.Collections.Generic;
using System.Text;


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
    /// <summary>
    /// Representa un gato que sobrescribe el sonido heredado de Animal,
    /// demostrando polimorfismo mediante la palabra clave override.
    /// </summary>
    public class Gato : Animal
    {
        /// <summary>
        /// Sobrescribe el sonido genérico de Animal con el sonido propio de un gato.
        /// </summary>
        public override void HacerSonido()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[Gato] ¡Miau!");
            Console.ResetColor();
        }
    }
}
