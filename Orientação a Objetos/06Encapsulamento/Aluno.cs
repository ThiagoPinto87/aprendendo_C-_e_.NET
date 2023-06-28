using System;

class Aluno
{
    // Nota
    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    /*
        O colocarmos os atributos acima como private e posteriormente colocarmos somente a mensagem como público, estamos encapsulando,
        demonstrando somente o que queremos ao usuários. Pode também notar que na mensagem, solicitamos ao usuário, inputs utilizando o
        "Console.ReadLine()" convertendo tudo para número inteiro usando o "Convert.ToInt32".
    */

    // Mensagem
    public void mensagem()
    {
        // Captura as informações de nota pelo usuário.
        Console.WriteLine("Informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        // Mensagem
        Console.WriteLine($"A média é {media()}");

    }
}
