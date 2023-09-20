using ProjetoIMC.Model;
using System.Globalization;

var pessoa = new Pessoa();
var validacao = new Validacao();

Console.Write("Entre com seu nome: ");
pessoa.Nome = Console.ReadLine();

Console.Write("Entre com sua altura(m): ");
pessoa.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Entre com sua peso(Kg): ");
pessoa.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

validacao.ValidarPessoa(pessoa);

if (string.IsNullOrEmpty(validacao.Mensagem))
{
    string resultado = IMC.ClassificarIMC(pessoa);
    Console.WriteLine(resultado);
}
else
{
    Console.WriteLine(validacao.Mensagem);
}