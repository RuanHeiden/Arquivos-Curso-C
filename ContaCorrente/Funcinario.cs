using System;
using System.Globalization;

namespace ContaCorrente
{
    class Funcinario{
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double porcento) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcento / 100);
        }
        public override string ToString()
        {
            return "Funcionario:"
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("F2");

        }

    }
}
