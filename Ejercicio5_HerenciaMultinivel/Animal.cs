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
    /// Representa la clase base fundamental en la jerarquía biológica de animales.
    /// Expone el comportamiento básico de emisión de sonido para ser adaptado por clases derivadas.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Emite un sonido general característico de un animal genérico.
        /// Se define como virtual para permitir su sobrescritura (override) en las subclases.
        /// </summary>
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal emite un sonido genérico.");
        }
    }
}
