using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    public class Operacoes
    {
        public double Soma(double x , double y)
        {
            double valorSoma = x + y;
            return valorSoma;
        }
        public double Subtracao(double x, double y)
        {
            double valorSubtracao = x - y;
            return valorSubtracao;
        }
        public double Mult(double x, double y)
        {
            double valorMult = x * y;
            return valorMult;
        }
        public double Divisao(double x, double y)
        {
            double valorDivisao = x / y;
            return valorDivisao;
        }       
    }
}
