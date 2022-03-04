namespace MCL.Series
{
    public class Series : EntityBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero " + Genero + Environment.NewLine;
            retorno += "Título " + Titulo + Environment.NewLine;
            retorno += "Descrição " + Descricao + Environment.NewLine;
            retorno += "Ano de Início " + Ano;
            retorno += "Excluído: " + Excluido; 
            return retorno;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

    }
}
