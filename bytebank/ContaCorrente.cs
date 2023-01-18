using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int agencia = 0000; //valores definido no obj são valores padroes
        public string conta = "Sem Conta";
        public double saldo = 100;

        public Cliente titular;

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

        public bool Transferir(double valor, ContaCorrente Destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                Destino.Depositar(valor);
                Console.WriteLine();
                Console.WriteLine($"Foi transferido R${valor} da conta de {this.titular} para a conta de {Destino.titular}");
                return true;
            }
        }

        public void exibirInformações() // metodo para exibir dados dos clientes;
        {
            Console.WriteLine("Titular :" + titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

    }
}
