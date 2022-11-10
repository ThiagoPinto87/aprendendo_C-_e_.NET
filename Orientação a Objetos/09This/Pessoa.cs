using System;

class Pessoa{

    // Atributo
    private string nome = "João Vitor";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);        // Este Console.WriteLine, está sendo usado como parte do "Construtor" Pessoa
        Console.WriteLine(this.nome);   // Este Console.WriteLine, está sendo usado como "This". O This está puxando as informações do atributo e não do método e essa é a sua característica.
    }

}