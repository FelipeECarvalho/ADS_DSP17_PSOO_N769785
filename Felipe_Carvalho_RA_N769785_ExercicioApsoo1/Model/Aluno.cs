namespace ExercicioApsoo.Model;

public class Aluno : Pessoa
{
    public Aluno(string nome, int idade, char sexo, string rA, string turma) : base(nome, idade, sexo)
    {
        RA = rA;
        Turma = turma;
    }

    public string RA { get; set; }
    public string Turma { get; set; }

    public override string ToString()
    {
        return $"Olá, meu nome é {this.Nome}, minha turma é a {this.Turma} e tenho {this.Idade} anos.";
    }
}

public record AlunoDto(string Nome, int Teste);