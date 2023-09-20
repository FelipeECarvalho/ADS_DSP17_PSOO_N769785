namespace ProjetoIMC.Model;

public static class IMC
{

    /// <summary>
    /// Método utilizado para calcular o IMC da pessoa
    /// </summary>
    private static double CalcularIMC(Pessoa pessoa)
    {
        return pessoa.Peso / (pessoa.Altura * pessoa.Altura);
    }


    /// <summary>
    /// Método utilizado para classificar o IMC da pessoa
    /// </summary>
    private static string ClassificarFaixaIMC(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 24.9)
            return "Peso normal";
        else if (imc < 29.9)
            return "Sobrepeso";
        else if (imc < 34.9)
            return "Obesidade Grau I";
        else if (imc < 39.9)
            return "Obesidade Grau II";
        else
            return "Obesidade Grau III";
    }

    /// <summary>
    /// Método responsável por apresentar os resultados do calculo do IMC da pessoa
    /// </summary>
    public static string ClassificarIMC(Pessoa pessoa)
    {
        double imc = CalcularIMC(pessoa);
        string classificacao = ClassificarFaixaIMC(imc);

        return $"{pessoa.Nome}, seu IMC é de {imc:F2} ({classificacao})";
    }
}
