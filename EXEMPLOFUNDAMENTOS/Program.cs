using EXEMPLOFUNDAMENTOS.Models;
//Atalho para comentar Ctrl + K + C
// Cast - Casting Conversões de Variáveis

// Operador lógico NOT
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
 Console.WriteLine("Vou pedalar outro dia");
}



// Operador lógico AND
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//   Console.WriteLine("Reprovado!");
// }


// Operador lógico OR
// bool ehMaiorDeIsade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIsade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }


//Estrutura Switch Case 
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;
    
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

//Estrutura condicional
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda Inválida");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda Realizada.");
// }else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// string a = "15";
// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// double a = 4 / (2 + 2);
// Console.WriteLine(a);

// double a = 4 / 2 + 2;

// Console.WriteLine(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);


//int a = Convert.ToInt32("5");
// int a = int.Parse("5");


// Console.WriteLine(a);



/*int a = 10;
int b = 20;

int c = a + b;

//c = c + 5;

//c += 5;

c -= 5;

Console.WriteLine(c);*/


/*string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da váriavel quantidade: " + quantidade);
Console.WriteLine("Valor da váriavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da váriavel preço: " + preco);
Console.WriteLine("Valor da váriavel condição: " + condicao);
Console.WriteLine("A data atual é: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));*/



//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Felipe";
//pessoa1.Idade = 38;
//pessoa1.Apresentar();

//Pessoa pessoa_FisicaRepresentacao = new Pessoa();