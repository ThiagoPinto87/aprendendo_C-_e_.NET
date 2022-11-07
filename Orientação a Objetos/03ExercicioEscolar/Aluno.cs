class Aluno
{
    // Aluno  -  Atributo
    public string nome;

    // Nota  - Atributo
    public double nota1, nota2;

    // Média  -  Método (Função)
    public double media()
    {
        return (nota1+nota2)/2;
    }

    // Situação  -  Método (Função)
    public string situacao(double media)
    {
        return media >= 7 ? "APROVADO" : "REPROVADO";
    }

    // Mensagem  -  Método (Função)
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter situação
        string ObterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine($"O {nome} está {ObterSituacao} com média {obterMedia}");
    }

}