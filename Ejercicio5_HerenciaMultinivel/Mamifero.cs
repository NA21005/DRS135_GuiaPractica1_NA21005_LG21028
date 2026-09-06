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
    /// Representa un mamífero dentro de la jerarquía.
    /// Hereda las características de Animal y añade comportamientos propios de su clase biológica.
    /// </summary>
    public class Mamifero : Animal
    {
        /// <summary>
        /// Simula el proceso de alimentación específico de los mamíferos.
        /// Este método se propaga y queda disponible para todas las clases derivadas de Mamifero.
        /// </summary>
        public void Alimentar()
        {
            Console.WriteLine("El mamífero se alimenta mediante amamantamiento/leche materna.");
        }
    }
}
