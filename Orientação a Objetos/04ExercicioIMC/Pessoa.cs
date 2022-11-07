using System;

class Pessoa
{
    // Atributos da Pessoa
    public string nome;
    public double peso, altura;

    // IMC  -  Método
    public double imc()
    {
        return peso / (altura * altura);
    }

    // Situação  -  Método
    public string situacao(double imc)
    {
        // Variável de retorno.
        string retorno;

        // Condicionais.

        if (imc <= 18.5)
        {
            retorno = "ABAIXO DO NORMAL";
        }
        else if (imc < 25)
        {
            retorno = "com peso normal";
        }
        else if (imc < 30)
        {
            retorno = "acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "com Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "com Obesidade II";
        }
        else //(imc >= 40)
        {
            retorno = "com OBESIDADE III";
        }

        // Retorno
        return retorno;
    }

    // Mensagem
    public void mensagem()
    {
        // Variáveis
        double obterIMC = imc();
        string obterSituacao = situacao(obterIMC);


        Console.WriteLine($"O {nome}, que pesou {peso}Kg, tem IMC de {obterIMC} e portanto está {obterSituacao}.");
    }

    // Mensagem

    
}