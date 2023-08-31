using ExercicioApsoo.Model;

// Foi feito em .NET 7, por isso não tem o método Main

var alunos = new List<Aluno>()
{
    new Aluno("Felipe", 21, 'M', "N769785", "DS4P17"),
    new Aluno("Ana", 20, 'F', "L12394D", "DS3P17"),
    new Aluno("Marcos", 19, 'M', "R342123", "DS4Q17"),
    new Aluno("Luiz", 32, 'M', "P123123", "DS3P17")
};

Console.WriteLine("Entre com seu RA: ");
var ra = Console.ReadLine();

var alunoEncontrado = alunos.FirstOrDefault(x => x.RA.Equals(ra));

if (alunoEncontrado == null)
    Console.WriteLine("Aluno não encontrado");
else
    Console.WriteLine(alunoEncontrado.ToString());