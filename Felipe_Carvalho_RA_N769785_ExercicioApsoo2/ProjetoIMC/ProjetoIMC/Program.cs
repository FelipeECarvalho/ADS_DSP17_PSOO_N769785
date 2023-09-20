using ProjetoIMC.Model;
using System.Globalization;

var pessoa = new Pessoa();

Console.Write("Entre com seu nome: ");
pessoa.Nome = Console.ReadLine();

Console.Write("Entre com sua altura(m): ");
pessoa.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Entre com sua peso(Kg): ");
pessoa.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string resultado = IMC.ClassificarIMC(pessoa);
Console.WriteLine(resultado);