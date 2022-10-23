using EXEMPLOFUNDAMENTOS.Common.Models;
//Atalho para comentar Ctrl + K + C

// Instancia da classe pessoa
Pessoa p = new Pessoa();

/*
 Atribui o nome e a idade para pessoa
 Passando o Nome Felipe
 e passando a idade 38
*/

p.Nome = "Felipe";
p.Idade = 38;

// faz a classe pessoa se apresentar
p.Apresentar();


p.CadastraNoERPXYZDaEmpresa();



Calculadora c = new Calculadora();
c.Somar(3, 5);
c.Subtrair(5, 3);




// Trabalhando com Listas 
/*List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Bahia");
listaString.Add("Minas Gerais");

Console.WriteLine($"Itens na minha lista : {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("Santa Catarina");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("Minas Gerais");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");*/


// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//   Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//   contadorForeach++;
// }




// // Redimencionar Array
//  int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// // Copiar array para novo array
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array Resize dobra o tamanho do array e copia os dados antigos
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com FOREACH");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//   Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//   contadorForeach++;
// }



// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Felipe";
// pessoa1.Idade = 38;
// pessoa1.Apresentar();

//Menu interativo
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//   Console.Clear();
//   Console.WriteLine("Digite a sua Opção: ");
//   Console.WriteLine("1 - Cadastrar Cliente");
//   Console.WriteLine("2 - Buscar Cliente");
//   Console.WriteLine("3 - Apagar Cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao)
//   {
//     case "1":
//     Console.WriteLine("Cadastro de Cliente");
//     break;

//     case "2":
//     Console.WriteLine("Busca de Cliente");
//     break;

//     case "3":
//     Console.WriteLine("Apagar Cliente");
//     break;

//     case "4":
//     Console.WriteLine("Encerrar");
//     //Environment.Exit(0);
//     exibirMenu = false;
//     break;

//     default:
//     Console.WriteLine("Opção Inválida");
//     break;
//   }
// }

// Console.WriteLine("O programa se encerrou");




// Estrutura DO WHILE
// int soma = 0, numero = 0;

// do
// {
//  Console.WriteLine("Digite um número (0 para parar)");
//  numero = Convert.ToInt32(Console.ReadLine());

//  soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


//Estrutura de Laço WHILE
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//   Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6)
//   {
//     break;
//   }
// }



// Estrutura de Repetição FOR
// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroIncremento++;

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);
// Console.WriteLine(numeroIncremento);

//calc.RaizQuadrada(9);

// Operador lógico NOT
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//  Console.WriteLine("Vou pedalar outro dia");
// }


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

// Cast - Casting Conversões de Variáveis
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