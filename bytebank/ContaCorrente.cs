using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public static int TotalDeContas{ get; private set; } //Static significa q ela só pode ser usada dentro da classe, não do objeto. Dispensa o "this." / O PRIVATE SET significa que não pode ser atribuido valor manualmente pelo programa. Então TotalDeContas só devolve valor, não recebe nada manualmente, só quando incrementado por metodo ou propriedade.

        // Propriedade com validação
        private int agencia = 0000; //valores definido no obj são valores padroes
        public int Agencia
        {
            get { return this.agencia; }
            private set
            {
                if (value > 0)
                {
                    this.agencia = value;
                }
            }
        }

        // Propriedade sem validaçao
        public string Conta { get; set; } //Cria uma propriedade publica q manipula uma var privada internamente (propriedade autoimplementada)

        private double saldo = 100;

        public Cliente Titular;

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
                Console.WriteLine($"Foi transferido R${valor} da conta de {this.Titular} para a conta de {Destino.Titular}");
                return true;
            }
        }

        public void exibirInformações() // metodo para exibir dados dos clientes;
        {
            Console.WriteLine("Titular :" + Titular);
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContas++;
        }
    }
}
