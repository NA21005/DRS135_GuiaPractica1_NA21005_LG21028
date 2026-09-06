using System;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1 - Abstracción de Datos (Cuenta Bancaria)";
            Console.WriteLine("==========================================================");
            Console.WriteLine("  DEMOSTRACIÓN: ABSTRACCIÓN DE DATOS - CUENTA BANCARIA   ");
            Console.WriteLine("==========================================================\n");

            // 1. Creación de una cuenta con saldo inicial de $100.00
            Console.WriteLine(">> 1. Apertura de cuenta con saldo inicial de $100.00...");
            CuentaBancaria miCuenta = new CuentaBancaria(100.00m);
            Console.WriteLine($"Saldo consultado con ObtenerSaldo(): {miCuenta.ObtenerSaldo():C}\n");

            // 2. Depósito válido
            Console.WriteLine(">> 2. Intentando realizar un depósito válido de $50.00...");
            miCuenta.Depositar(50.00m);
            Console.WriteLine();

            // 3. Validación de depósito con monto inválido (negativo o cero)
            Console.WriteLine(">> 3. Intentando depositar un monto negativo (-$20.00)...");
            miCuenta.Depositar(-20.00m);
            Console.WriteLine();

            // 4. Retiro válido
            Console.WriteLine(">> 4. Intentando realizar un retiro válido de $40.00...");
            miCuenta.Retirar(40.00m);
            Console.WriteLine();

            // 5. Validación de retiro con monto inválido (monto cero)
            Console.WriteLine(">> 5. Intentando retirar un monto inválido ($0.00)...");
            miCuenta.Retirar(0.00m);
            Console.WriteLine();

            // 6. Validación de fondos insuficientes
            Console.WriteLine(">> 6. Intentando retirar más de lo disponible ($200.00)...");
            miCuenta.Retirar(200.00m);
            Console.WriteLine();

            // 7. Consulta final de saldo
            Console.WriteLine("==========================================================");
            Console.WriteLine($"SALDO FINAL COMPROBADO: {miCuenta.ObtenerSaldo():C}");
            Console.WriteLine("==========================================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}