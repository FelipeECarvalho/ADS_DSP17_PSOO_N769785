namespace ProjetoIMC.Model;

public static class IMC
{
    private static double CalcularIMC(Pessoa pessoa)
    {
        return pessoa.Peso / (pessoa.Altura * pessoa.Altura);
    }

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

    public static string ClassificarIMC(Pessoa pessoa)
    {
        double imc = CalcularIMC(pessoa);
        string classificacao = ClassificarFaixaIMC(imc);

        return $"{pessoa.Nome}, seu IMC é de {imc:F2} ({classificacao})";
    }
}
