// See https://aka.ms/new-console-template for more information

// Por ter criado métodos para a classe pessoa e mesmo que tenha o mesmo nome "apresentar", por terem parâmetros diferentes, executam os diferentes métodos quando instanciados. No caso abaixo, temos o método apresentado de 3 formas diferentes. Ao executar o "dotnet run" no terminal verá que será executado 3 métodos da mesma classe.

Pessoa obj = new Pessoa();
obj.apresentar();

obj.apresentar("Thiago Pinto");

obj.apresentar("Thiago Pinto", 35);