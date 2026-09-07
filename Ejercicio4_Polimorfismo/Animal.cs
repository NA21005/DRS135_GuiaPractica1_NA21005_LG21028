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
    /// Clase base que representa un animal genérico.
    /// Define el método HacerSonido() como virtual para que las clases
    /// derivadas puedan sobrescribirlo y demostrar polimorfismo.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Produce el sonido genérico de un animal.
        /// Puede ser sobrescrito por las clases derivadas.
        /// </summary>
        public virtual void HacerSonido()
        {
            Console.WriteLine("[Animal] El animal hace un sonido genérico.");
        }
    }
}
