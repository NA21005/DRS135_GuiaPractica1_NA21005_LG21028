using System;
using System.Collections.Generic;
using System.Text;


// ====================================================================================
// ACTIVIDAD:  Actividad Evaluada 1: Guía de trabajo - POO en C#
// EJERCICIO: 1 - Implementación de Abstracción de Datos
// 
// INTEGRANTES:
//   - Cristian Armando Navarro Aguilar  | Carnet: NA21005
//   - Alfredo Alexander Lara Guerra     | Carnet: LG21028
// ====================================================================================
namespace Ejercicio1_Abstraccion
{
    /// <summary>
    /// Representa una cuenta bancaria aplicando abstracción y ocultamiento de datos.
    /// Los detalles de almacenamiento del saldo se mantienen privados y solo se modifican
    /// o consultan mediante métodos públicos que aplican reglas de negocio.
    /// </summary>
    public class CuentaBancaria
    {
        // Atributo Privado: El saldo está protegido de modificaciones externas no autorizadas
        private decimal _saldo;

        /// <summary>
        /// Inicializa una nueva cuenta bancaria con un saldo inicial opcional.
        /// </summary>
        /// <param name="saldoInicial">Monto inicial con el que abre la cuenta (debe ser mayor o igual a cero).</param>
        public CuentaBancaria(decimal saldoInicial = 0)
        {
            if (saldoInicial > 0)
            {
                _saldo = saldoInicial;
            }
            else
            {
                _saldo = 0;
            }
        }

        /// <summary>
        /// Permite ingresar fondos a la cuenta bancaria.
        /// </summary>
        /// <param name="monto">Cantidad de dinero a depositar (debe ser un valor positivo).</param>
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error] El monto a depositar debe ser mayor a $0.00. Monto intentado: {monto:C}");
                Console.ResetColor();
                return;
            }

            _saldo += monto;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Éxito] Se depositaron {monto:C}. Saldo actual: {_saldo:C}");
            Console.ResetColor();
        }

        /// <summary>
        /// Permite extraer fondos de la cuenta bancaria previa validación de fondos y monto.
        /// </summary>
        /// <param name="monto">Cantidad de dinero a retirar (debe ser positivo y no exceder el saldo disponible).</param>
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error] El monto a retirar debe ser mayor a $0.00. Monto intentado: {monto:C}");
                Console.ResetColor();
                return;
            }

            if (monto > _saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error] Fondos insuficientes. Intento de retiro: {monto:C} | Saldo disponible: {_saldo:C}");
                Console.ResetColor();
                return;
            }

            _saldo -= monto;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Éxito] Se retiraron {monto:C}. Saldo actual: {_saldo:C}");
            Console.ResetColor();
        }

        /// <summary>
        /// Proporciona acceso de solo lectura al saldo actual de la cuenta bancaria.
        /// </summary>
        /// <returns>El monto decimal correspondiente al saldo actual.</returns>
        public decimal ObtenerSaldo()
        {
            return _saldo;
        }
    }
}
