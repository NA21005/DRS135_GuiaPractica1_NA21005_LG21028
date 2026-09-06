using System;
using System.Collections.Generic;
using System.Text;

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
    /// <summary>
    /// Representa a un gato como especialización final de la jerarquía (Animal -> Mamifero -> Gato).
    /// Hereda los métodos de sus clases antecesoras y redefine el sonido con un maullido específico.
    /// </summary>
    public class Gato : Mamifero
    {
        /// <summary>
        /// Sobrescribe el método HacerSonido de la clase raíz Animal para emitir un maullido propio de un gato.
        /// </summary>
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maulla: ¡Miau, Miau!");
        }
    }
}
