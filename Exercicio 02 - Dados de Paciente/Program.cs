using Exercicio_02___Dados_de_Paciente;

Pessoa paciente = new Pessoa();

paciente.nome = "Jose";
paciente.idade = 32;
paciente.altura = 1.71;
paciente.peso = 80;

Console.WriteLine(paciente.nome); //mostrará o valor padrão se não houver atribuição
Console.WriteLine(paciente.idade);
Console.WriteLine(paciente.altura);
Console.WriteLine(paciente.peso);