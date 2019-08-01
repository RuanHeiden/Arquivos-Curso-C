using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraComVetorEFor
{
    class Calculator{

        public static int Sum(int[] numbers) {

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;

        }

    }
}
