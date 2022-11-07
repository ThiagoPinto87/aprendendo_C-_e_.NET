using System;

class Pessoa
{

    // Atributos

    public string nome;
    public int idade;

    // Métodos
    public void mensagem()  // void (nulo) quer dizer que não haverá retorno. Será basicamente para exibição, não armazenará dados.
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
    }

}