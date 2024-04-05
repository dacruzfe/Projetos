using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto},  " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);

// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);


// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


//new ExemploExcecao().Metodo1();

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado."
//     + ex.Message);
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }


// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm", 
//                       CultureInfo.InvariantCulture, 
//                       DateTimeStyles.None, out DateTime data);

// //DateTime data = DateTime.Parse("17/04/2022 18:00");
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//   Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));





// double numero1 = 2192.30;
// double numero2 = 1800;

// double resultado = numero1 + numero2;
// double newResultado = resultado * 0.10;

// Console.WriteLine(resultado);
// Console.WriteLine(newResultado);


// Pessoa p1 = new Pessoa(nome: "Felipe", sobrenome: "Cruz");

// Pessoa p2 = new Pessoa(nome: "Bernardo", sobrenome: "Cruz");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();