using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar um objeto.   -  O nome instanciar quer dizer que vou criar alguma coisa a partir de um molde (Classe).
            Pessoa loiroAlto = new Pessoa();
            loiroAlto.nome = "Thiago Pinto";
            loiroAlto.idade = 35;
            loiroAlto.mensagem();

        }
    }
}