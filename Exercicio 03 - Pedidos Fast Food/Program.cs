using exercicio3;

Cliente cliente = new Cliente();
cliente.nome = "Bruno Feitosa";
cliente.endereco = "Rua Das Pintosas";

Produtos produtos = new Produtos();
produtos.cliente = cliente;
produtos.produto1 = "Champinho";
produtos.produto2 = "Pantufa";
produtos.produto3 = "Suco de vaca";

Console.WriteLine("COMPRA");
Console.WriteLine();
Console.WriteLine($"Carrinho de compras de {produtos.cliente.nome}");
Console.WriteLine();
Console.WriteLine(produtos.produto1 + "/ Valor: R$ "+ produtos.valorProd1);
Console.WriteLine(produtos.produto2 + "/ Valor: R$ " + produtos.valorProd2);
Console.WriteLine(produtos.produto3 + "/ Valor: R$ " + produtos.valorProd3);
Console.WriteLine();
Console.WriteLine(produtos.valorTotal(produtos.valorProd1, produtos.valorProd2, produtos.valorProd3));
Console.WriteLine();
Console.WriteLine($"Endereço de enterega: {produtos.cliente.endereco}");

//Console.WriteLine(venda.produto1);
//Console.WriteLine(venda.produto2);
//Console.WriteLine(venda.produto3);

