using System.Collections.Generic;
using DIO_Animes.Animes.Interfaces;

namespace DIO_Animes.Animes {
    public class AnimeRepositorio : IRepositorio<Anime> {
        private List<Anime> listaAnimes = new List<Anime>();
        public void Atualiza(int id, Anime entidade) {
            listaAnimes[id]= entidade;
        }
        public void Exclui(int id) {
            listaAnimes[id].setExcluir();
        }

        public void Insere(Anime entidade) {
            listaAnimes.Add(entidade);
        }

        public List<Anime> Lista() {
            return listaAnimes;
        }

        public int ProximoId() {
            return listaAnimes.Count;
        }

        public Anime RetornaPorId(int id) {
            return listaAnimes[id];
        }
    }
}