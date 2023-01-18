using classe;

Cliente clientData = new Cliente();
ContaCorrente conta = new ContaCorrente();
conta.titular = clientData.nome;
conta.agencia = 01;
conta.conta = "1010-x";
conta.saldo = 100;

conta.titular = "Frederico";
Console.WriteLine(conta);