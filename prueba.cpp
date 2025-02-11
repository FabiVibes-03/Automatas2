using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

static void Main(string[] args)
{


// -------------------------------
// Caso 1: Asignación errónea a un entero
// Se declara un entero 'a' e intenta asignarle el resultado de 1 + 2.5.
// La expresión 1 + 2.5 tiene maximoTipo = Float, y dado que Float no es compatible con Int,
// se lanzará un error semántico indicando la línea y la columna.
//int a = 1 + 2.5;  // Error esperado: "Semántico: no se puede asignar un Float a un Int"

// -------------------------------
// Caso 2: Uso correcto de casteo para asignación a entero
// Se utiliza el casteo a int para convertir el resultado de la expresión a un tipo compatible.
int b = (int)(1 + 2.5);  // Correcto: se fuerza la conversión a Int

// -------------------------------
// Caso 3: Asignación correcta a una variable float
// La variable 'c' es de tipo float, por lo que la expresión 1 + 2.5 (maximoTipo = Float)
// es compatible y se asigna sin problemas.
float c = 1 + 2.5;  // Correcto

// -------------------------------
// Caso 4: Asignación correcta a una variable char con valor dentro del rango
// La expresión 65 + 10 da 75, que es menor o igual a 255, por lo que se considera de tipo Char.
char d = 65 + 10;  // Correcto

// -------------------------------
// Caso 5: Asignación errónea a una variable char
// Se intenta asignar a 'e' el valor 300. Dado que 300 es mayor que 255, se clasifica como Int,
// lo que provoca error al asignarlo a un char (maximoTipo Int > Char).
//char e = 300;  // Error esperado: "Semántico: no se puede asignar un Int a un Char"

// -------------------------------
// Caso 6: Uso de Console para mostrar un mensaje
// Si las asignaciones anteriores no interrumpen la ejecución (o se prueban individualmente),
// se imprime un mensaje de confirmación.
Console.WriteLine("Pruebas completadas correctamente.");

}