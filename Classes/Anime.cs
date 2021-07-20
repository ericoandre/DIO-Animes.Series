using System;

namespace DIO_Animes.Animes {
    public class Anime : EntidadeBase {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Anime(int id, Genero genero, string titulo, string descricao, int ano ){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString() {
            string retorno = "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido; 
            return retorno;
        }

        public string getTitulo() {
            return this.Titulo;
        }
        public int getId() {
            return this.Id;
        }
        public void setExcluir() {
            this.Excluido = true;
        }
        public bool getExcluir(){
            return this.Excluido;
        }
    }
}