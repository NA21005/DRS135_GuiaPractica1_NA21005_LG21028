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
    /// Clase base que representa un vehículo genérico.
    /// Define el comportamiento común (arrancar y detener) que
    /// cualquier clase derivada puede heredar y reutilizar.
    /// </summary>
    public class Vehiculo
    {
        /// <summary>
        /// Pone en marcha el vehículo.
        /// </summary>
        public void Arrancar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Vehiculo] El motor ha arrancado correctamente.");
            Console.ResetColor();
        }

        /// <summary>
        /// Detiene el funcionamiento del vehículo.
        /// </summary>
        public void Detener()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Vehiculo] El vehículo se ha detenido.");
            Console.ResetColor();
        }
    }
}
