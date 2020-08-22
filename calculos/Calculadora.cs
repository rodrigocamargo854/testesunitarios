using System;

namespace calculos
{
    public class CalculadoraSoma//receber generic types
    //refatorar nome da classe no arquivo
    {
        //usar verbos para formular metodos
        public int Soma(int operador1, int operador2) => operador1 + operador2;

    }

    public class CalculadoraSubscrib
    {
        public int Subtracao(int operador1, int operador2) => operador1 - operador2;

    }

    public class CalculadoraMultis
    {
        public int Multiplicacao(int operador1, int operador2) => operador1 * operador2;

    }

    public class CalculadoraDiv
    {
        public int Divisao(int dividendo, int divisor) => dividendo / divisor;
    }

}
