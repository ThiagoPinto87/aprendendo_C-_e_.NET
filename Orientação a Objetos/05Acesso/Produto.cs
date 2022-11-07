class Produto
{
    /*
        Há 3 (três) tipos de MODIFICADORES DE ACESSO que permitem que os atributos e métodos fiquem visíveis aos serem "chamados"...:

        MODIFICADORES   -> ... METODOLOGIA
        public          -> ... em qualquer classe;
        private         -> ... somente na classe onde forem criados.
        protected       -> ... somente na classe onde forem criados ou hedados. (que será ensinado mais para frente.)

        Esses modificadores de acesso são interessantes para que se possa controlar as informações ou até mesmo protegê-las em seus usos.
    */

    // Exemplo:

    public string nome;
    private double valor;
}