using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    public class Produtos
    {
        public string produto1 = "";
        public string produto2 = "";
        public string produto3 = "";
        public double valorProd1 = 3.5;
        public double valorProd2 = 2;
        public double valorProd3 = 5;
        public Cliente cliente; 

        public double valorTotal(double valor1, double valor2,double valor3)
        {
            double total = valor1 + valor2 + valor3;
            Console.WriteLine();
            Console.WriteLine("Total: " + total);
            return total;
        }    
    }
}
