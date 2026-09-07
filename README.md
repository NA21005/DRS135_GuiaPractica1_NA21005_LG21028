# Actividad Evaluada 1: Guía de Trabajo - POO en C#

Repositorio correspondiente a la Actividad Evaluada 1 de la asignatura **Desarrollo y Reutilización de Software**, enfocado en la aplicación práctica de los pilares de la programación orientada a objetos (POO) en C# para el desarrollo modular y reutilizable.

---

## Datos Institucionales
* **Institución:** Universidad de El Salvador (UES)
* **Facultad:** Multidisciplinaria de Occidente (FMOcc)
* **Departamento:** Ingeniería y Arquitectura
* **Carrera:** Ingeniería en Desarrollo de Software
* **Ciclo Académico:** Ciclo II - 2026
* **Docente:** Ing. Dinora Virginia Osorio de Melara

## Integrantes
| Nombre Completo | Carnet |
| :--- | :--- |
| Cristian Armando Navarro Aguilar | NA21005 |
| Alfredo Alexander Lara Guerra | LG21028 |

---

## Estructura de la Solución

El proyecto está organizado en una solución de Visual Studio (`.sln`) que contiene cinco proyectos de consola independientes, aislando los espacios de nombres y facilitando la compilación individual de cada requerimiento:

```text
Guia-Practica-1-DRS/
│
├── .gitignore
├── README.md
├── DRS135_GuiaPractica1_NA21005_LG21028.slnx
│
├── Ejercicio1_Abstraccion/
│   ├── CuentaBancaria.cs
│   ├── Program.cs
│   └── Ejercicio1_Abstraccion.csproj
│
├── Ejercicio2_Encapsulacion/
│   ├── Empleado.cs
│   ├── Program.cs
│   └── Ejercicio2_Encapsulacion.csproj
│
├── Ejercicio3_HerenciaSimple/
│   ├── Vehiculo.cs
│   ├── Coche.cs
│   ├── Program.cs
│   └── Ejercicio3_HerenciaSimple.csproj
│
├── Ejercicio4_Polimorfismo/
│   ├── Animal.cs
│   ├── Perro.cs
│   ├── Gato.cs
│   ├── Program.cs
│   └── Ejercicio4_Polimorfismo.csproj
│
└── Ejercicio5_HerenciaMultinivel/
    ├── Animal.cs
    ├── Mamifero.cs
    ├── Perro.cs
    ├── Program.cs
    └── Ejercicio5_HerenciaMultinivel.csproj
