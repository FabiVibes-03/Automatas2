using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxis_1
{
    public class Variable
    {
        public enum TipoDato
        {
            Char, Int, Float
        }
        TipoDato tipo;
        string nombre;
        float valor;
        public Variable(TipoDato tipo, string nombre, float valor = 0)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.valor = valor;
        }

        //SECTION - Se modifico los parametros de SetValor para dar linea de error
        public void setValor(float valor, int linea, int columna, StreamWriter log, TipoDato MaxTipo)
        {
            if (MaxTipo <= tipo)
            {
                this.valor = valor;
            }
            else
            {
                throw new Error("Semántico: no se puede asignar un " + MaxTipo + " a un " + tipo, log, linea, columna);
            }
        }
        //!SECTION

        public float getValor()
        {
            return valor;
        }
        public string getNombre()
        {
            return nombre;
        }
        public TipoDato GetTipoDato()
        {
            return tipo;
        }
        public static TipoDato valorTipoDato(float valor)
        {
            //REVIEW - IsInteger daba error, asi que lo cambie
            if (valor % 1 != 0)
            {
                return TipoDato.Float;
            }
            else if (valor <= 255)
            {
                return TipoDato.Char;
            }
            else if (valor <= 65535)
            {
                return TipoDato.Int;
            }
            else
            {
                return TipoDato.Float;
            }
        }
    }

}