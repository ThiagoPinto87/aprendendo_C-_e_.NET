using System;
class Pessoa
{
    // Atributo que será utilizado.
    private string nome;

    // Get e Set
    public string Nome          // Todo GetSet é publico, tem o mesmo tipo que o atributo (string, boolean, integer,...) e como boas práticas é utilizado o mesmo nome que o atributo, porém com a primeira letra maiúscula.
    {
        // Essas são as ações, onde temos:
        get{return nome;}   // no get ele retorna o valor do atributo.
        set{nome = value;}  // no set ele envie o valor que o usuário irá colocar na classe quando solicitado.
    }
}