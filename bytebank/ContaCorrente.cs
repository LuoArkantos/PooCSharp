using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Depositar(double valor) // Método para adicionar valor (no programa principal, declaramos a variável como var.Depositar(valor) e inserimos o valor de depósito nos parentesis.
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
