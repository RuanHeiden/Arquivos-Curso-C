using System;

namespace CalculandoTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area(){ //public(para qualquer arquivo usalo), double (o valor de saida é um numero),Area(nome do metodo),(entrada de dados).
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

        }
    }
}
