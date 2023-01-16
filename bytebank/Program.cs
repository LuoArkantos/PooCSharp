using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André";
contaDoAndre.agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);

contaDoAndre.Depositar(150);
Console.WriteLine("Saldo Atualizado: " + contaDoAndre.saldo);

if (contaDoAndre.Sacar(400) == true)
{
    Console.WriteLine($"{contaDoAndre.titular} sacou R$ 100 ");
}
else
{
    Console.WriteLine("Saldo Insuficiente para Saque");
}
Console.WriteLine();
Console.WriteLine("Saldo Atualizado: " + contaDoAndre.saldo);


Console.ReadLine();


