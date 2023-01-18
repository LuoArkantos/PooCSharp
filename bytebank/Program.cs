using bytebank;

////// criando obj Andre
////ContaCorrente contaDoAndre = new ContaCorrente();

////contaDoAndre.titular = "André";
////contaDoAndre.agencia = 15;
////contaDoAndre.conta = "1010-x";
////contaDoAndre.saldo = 100;

////Console.WriteLine($"Saldo Inicial de {contaDoAndre.titular} é R${contaDoAndre.saldo}");

////// criando obj Maria
////ContaCorrente contaDaMaria = new ContaCorrente();

////contaDaMaria.titular = "Maria";
////contaDaMaria.agencia = 17;
////contaDaMaria.conta = "1010-5";
////contaDaMaria.saldo = 350;

////Console.WriteLine($"Saldo Inicial de {contaDaMaria.titular} é R${contaDaMaria.saldo}");

////// Mtd para tranferir valores entre contas
////contaDoAndre.Transferir(50, contaDaMaria);

////Console.WriteLine($"Saldo final da conta do Andre: {contaDoAndre.saldo}");
////Console.WriteLine($"Saldo final da conta do Andre: {contaDaMaria.saldo}");

////// Para mostrar valores padrão do obj
////ContaCorrente contaDoPedro = new ContaCorrente();

////Console.WriteLine(contaDoPedro.titular);
////Console.WriteLine(contaDoPedro.agencia);
////Console.WriteLine(contaDoPedro.conta);
////Console.WriteLine(contaDoPedro.saldo);

//////SAQUE E DEPOSITO

////Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);

////contaDoAndre.Depositar(150);
////Console.WriteLine("Saldo Atualizado: " + contaDoAndre.saldo);

////if (contaDoAndre.Sacar(400) == true)
////{
////    Console.WriteLine($"{contaDoAndre.titular} sacou R$ 100 ");
////}
////else
////{
////    Console.WriteLine("Saldo Insuficiente para Saque");
////}

////Console.WriteLine();
////Console.WriteLine("Saldo Atualizado: " + contaDoAndre.saldo);


////Console.ReadLine();


//////metodo q exibe os dados do cliente
////contaDaMaria.exibirInformações();


//Cliente cliente = new Cliente();
//cliente.nome = "Andre";
//cliente.cpf = "123 123 123";
//cliente.profissao = "Radiologista";

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = cliente;
//contaDoAndre.agencia = 10;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Nome do Titular: " + contaDoAndre.titular.nome);
//Console.WriteLine("CPF do Titular: " + contaDoAndre.titular.cpf);
//Console.WriteLine("Profissão: " + contaDoAndre.titular.profissao);
//Console.WriteLine("N. Agencia: " + contaDoAndre.agencia);
//Console.WriteLine("N. Conta: " + contaDoAndre.conta);
//Console.WriteLine("Saldo: " + contaDoAndre.saldo);

//ContaCorrente conta3 = new ContaCorrente(10, "0505-Z"); //Obrigado inserir agencia e conta porque a classe construtora requer parametro. Assim evitar

//conta3.SetSaldo(500);
//conta3.Titular = new Cliente();

//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Agencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta4 = new ContaCorrente(123, "123-A");
Console.WriteLine(ContaCorrente.TotalDeContas);

ContaCorrente conta5 = new ContaCorrente(124, "124-A");
Console.WriteLine(ContaCorrente.TotalDeContas);

ContaCorrente conta6 = new ContaCorrente(125, "125-A");
Console.WriteLine(ContaCorrente.TotalDeContas);

ContaCorrente conta7 = new ContaCorrente(126, "126-A");
Console.WriteLine(ContaCorrente.TotalDeContas);
