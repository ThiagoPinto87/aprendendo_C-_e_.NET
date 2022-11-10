using System;

/*
    O método de um construtor tem o mesmo nome de sua classe, além de ser sempre "public".
*/


class Pessoa
{
    // Construtor A
    public Pessoa()
    {
        Console.WriteLine("Construtor executado.");
    }

    // Construtor B
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}, o Construtor foi executado.");
    }
}