using System;
using System.Globalization;

namespace ContaBancaria
{
    class conta
    {
        private int _numeroConta;
        private string _nome;
        private double _valor;

        public void CriandoConta(int Numero, string  Nome, double Valor) {
            _numeroConta = Numero;
            _nome = Nome;
            _valor = Valor; 
        }

        public void Deposito(double Valor) {
            _valor = _valor + Valor;
        }

        public void Saque(double Valor) {
            _valor = _valor - Valor;
        }

        public string DadosDaConta() {
            return "Conta: "+ _numeroConta +
                   ", Titular: " + _nome +
                   ", Saldo: "+ _valor.ToString("F2") +
                   "." ;
             
        }
        
        
    }
}
