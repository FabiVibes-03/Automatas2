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
        public void setValor(float valor){

            //Aqui checar como saber si tiene . punto decimal
            if(float.IsInteger(valor) && tipo!= TipoDato.Float){
                this.valor = valor;

                if(tipo == TipoDato.Char && valor < 255)
                {
                this.valor = valor;
                }
                else if(tipo == TipoDato.Int && valor <= Math.Pow(2,16)){
                    this.valor = valor;
                }
                else{
                    throw new Error("Semántico: no se puede asignar un " + valorToTipoDato(valor) + " a un " + tipo);
                }
            }
            else if(tipo == TipoDato.Float){ 
                this.valor = valor;
            }
            else{
                    throw new Error("Semántico: no se puede asignar un " + valorToTipoDato(valor) + " a un " + tipo);
                }
        }

        public static TipoDato valorToTipoDato(float valor){
            if(!float.IsInteger(valor)){
                return TipoDato.Float;
            }
            if(valor <= 255){
                return TipoDato.Char;
            }
            else if(valor <= Math.Pow(2,16)){
                return TipoDato.Int;
            }
            else{
                return TipoDato.Float;
            }
        }
        public float getValor()
        {
            return valor;
        }
        public string getNombre()
        {
            return nombre;
        }
        public TipoDato GetTipoDato(){
            return tipo;
        }
    }
}