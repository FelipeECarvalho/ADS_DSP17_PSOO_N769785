namespace ExercicioApsoo.Model;

public abstract class Pessoa
{
    public Pessoa(string nome, int idade, char sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public char Sexo { get;}
}
