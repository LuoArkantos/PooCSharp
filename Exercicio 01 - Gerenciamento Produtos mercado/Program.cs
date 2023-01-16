using Exercicio_01___Gerenciamento_Produtos_mercado;

Produtos produtos = new Produtos();

produtos.nome = "Shampoo";
produtos.fabricante = "Unilever";
produtos.codigoDeBarras = 1234512345123452145;
produtos.valorUnitario = 10.5;
produtos.valorDeCompra = 6.75;
produtos.quantidadeEmEstoque = 320;

Console.WriteLine("Nome do produto: " + produtos.nome);
Console.WriteLine("Nome do fabricante: " + produtos.fabricante);
Console.WriteLine("Cod de barras: " + produtos.codigoDeBarras);
Console.WriteLine("Valor unitário: " + produtos.valorUnitario);
Console.WriteLine("Valor de compra: " + produtos.valorDeCompra);
Console.WriteLine("Qtd em estoque: " + produtos.quantidadeEmEstoque);

Console.ReadLine();
