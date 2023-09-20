namespace ProjetoIMC.Model;

public class Validacao
{
    public string Mensagem { get; set; }

    /// <summary>
    /// Método utilizado para validar a pessoa
    /// </summary>
    /// <param name="pessoa"></param>
    public void ValidarPessoa(Pessoa pessoa)
    {
        Mensagem = "";

        if (pessoa == null)
            Mensagem = "Pessoa inválida";

        if (string.IsNullOrEmpty(pessoa.Nome))
            Mensagem = "Nome inválido";

        if (pessoa.Peso.Equals(default))
            Mensagem = "Peso inválido";

        if (pessoa.Altura.Equals(default))
            Mensagem = "Altura inválida";
    }
}