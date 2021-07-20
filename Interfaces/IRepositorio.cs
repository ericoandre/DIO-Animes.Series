using System.Collections.Generic;

namespace DIO_Animes.Animes.Interfaces {
    public interface IRepositorio <T> {
        void Atualiza(int id, T entidade);
        void Exclui(int id);
        void Insere(T entidade);
        List<T> Lista();
        int ProximoId();
        T RetornaPorId(int id);
    }
}