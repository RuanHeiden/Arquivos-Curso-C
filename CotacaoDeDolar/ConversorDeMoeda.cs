using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDeDolar
{
    class ConversorDeMoeda
    {

        public static double Iof = 6.0;
        public static double Converter(double cont,double quant) {
            double total = cont * quant;
            return total + total * Iof / 100;

        }

        

    }
}
