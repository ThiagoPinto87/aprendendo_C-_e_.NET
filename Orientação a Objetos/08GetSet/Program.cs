// See https://aka.ms/new-console-template for more information

/*
    O Get e Set, servem para enviar e receber informações de atributos em classes que não estão publicas e com isso, poder acessá-las usando o get para retornar os valores desses atributos e o set para enviá-los.
*/

Pessoa p = new Pessoa();
p.Nome = "Thiago";  // Repare que ao colocar o "." logo após o "p", ele aparece o "Nome" utilizando o get. Porém, quando eu coloco para ele receber meu nome, ele estará enviando-o (set) como valor.

Console.WriteLine(p.Nome);
