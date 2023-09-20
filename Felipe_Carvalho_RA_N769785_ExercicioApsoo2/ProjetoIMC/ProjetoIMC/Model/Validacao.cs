namespace ProjetoIMC.Model;

public class Validacao
{
    public static bool ValidarPessoa(Pessoa pessoa)
    {
        if (pessoa == null)
            return false;

        if (string.IsNullOrEmpty(pessoa.Nome))
            return false;

        if (pessoa.Peso.Equals(default))
            return false;

        if (pessoa.Altura.Equals(default))
            return false;

        return true;
    }
}