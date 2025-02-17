using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

static void Main(string[] args)
{
  //PRUEBAS CON CHAR
  char a;

  //REVIEW - Si descomento este bloque ya no me da el error en la fila 22
  //char + int = int -> Error
  a = 1;
  int b = 2;
  //a = a + b; //Error
  a = (char) (a + b); //Bien
  

  //char + float = float -> Error
  a = 1;
  float c = 3;
  //a = a + c; //FIXME - este error no lo marca Error
  //a = (int) (a + c); //FIXME -Error
  a = (char) (a + c); //Bien

  //char + char = char -> Bien
  a = 1;
  char d = 4;
  a = a + d;

  //PRUEBAS CON INT
  int e = 256;

  //int + char = int -> Bien
  char f = 2;
  e = e + f; //Bien

  //int + float = float -> Error
  e = 256;
  float g = 5;
  e = e + g; //FIXME - este error no lo marca Error
  e = (int) (e + g); // Bien

  //int + int = int -> Bien
  e = 256;
  int h = 2;
  e = e + h; //Bien
  e = (char) (e + h); // Bien

}