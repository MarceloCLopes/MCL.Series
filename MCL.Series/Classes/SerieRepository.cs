using MCL.Series.Interfaces;

namespace MCL.Series
{
    public class SerieRepository : IRepository<Series>
    {
        private readonly List<Series> listaSerie = new();
        public void Atualiza(int id, Series objeto) => listaSerie[id] = objeto;

        public void Exclui(int id) => listaSerie[id].Excluir();
        
        public void Insere(Series objeto) => listaSerie.Add(objeto);

        public List<Series> Lista() => listaSerie;

        public int ProximoId() => listaSerie.Count;

        public Series RetornaPorId(int id) => listaSerie[id];
        
    }
}
