using System;
using System.Collections.Generic;
using System.Text;


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
    /// <summary>
    /// Representa a un empleado aplicando encapsulación y control de acceso.
    /// Los atributos nombre y edad están protegidos y solo se modifican o consultan
    /// mediante propiedades que validan los datos antes de asignarlos.
    /// </summary>
    public class Empleado
    {
        // Atributos Privados: protegidos de modificaciones externas no autorizadas
        private string _nombre;
        private int _edad;

        /// <summary>
        /// Inicializa un nuevo empleado con nombre y edad válidos.
        /// </summary>
        /// <param name="nombre">Nombre completo del empleado.</param>
        /// <param name="edad">Edad del empleado (debe ser mayor que 0 y menor que 100).</param>
        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        /// <summary>
        /// Propiedad de acceso controlado al nombre del empleado.
        /// Valida que no se asigne un valor vacío o nulo.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Error] El nombre no puede estar vacío. Valor intentado: \"{value}\"");
                    Console.ResetColor();
                    return;
                }

                _nombre = value;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[Éxito] Nombre asignado correctamente: {_nombre}");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Propiedad de acceso controlado a la edad del empleado.
        /// Solo permite valores mayores que 0 y menores que 100.
        /// </summary>
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value <= 0 || value >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Error] La edad debe ser mayor a 0 y menor a 100. Valor intentado: {value}");
                    Console.ResetColor();
                    return;
                }

                _edad = value;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[Éxito] Edad asignada correctamente: {_edad}");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Muestra en consola la información actual del empleado (nombre y edad).
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {_nombre} | Edad: {_edad}");
        }
    }
}