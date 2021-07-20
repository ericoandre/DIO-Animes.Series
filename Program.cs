using System;

namespace DIO_Animes.Animes {
    class Program {
        static AnimeRepositorio repositorio = new AnimeRepositorio();
        static void Main(string[] args) {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() !="X") {
                switch (opcaoUsuario) {
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        InserirAnimes();
                        break;
                    case "3":
                        AtualizarAnimes();
                        break;
                    case "4":
                        ExcluirAnimes();
                        break;
                    case "5":
                        VisualizarAnimes();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();              
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        public static void ListarAnimes(){
            Console.WriteLine("Listar Animes");
            var lista = repositorio.Lista();

            if(lista.Count == 0 ){
                Console.WriteLine("Não a Animes cadastrados!");
                return;
            }
            foreach (var anime in lista) {
                Console.WriteLine("#ID {0}: - {1} {2}", anime.getId(), anime.getTitulo(), (anime.getExcluir() ? "*Excluído*" : ""));
            }
        }
        public static void InserirAnimes(){
            Console.WriteLine("Inserir Animes");
            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Anime: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Anime: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Anime: ");
            string entradaDescricao = Console.ReadLine();

            Anime novoAnime = new Anime(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            repositorio.Insere(novoAnime);
        }
        public static void AtualizarAnimes(){
            Console.Write("Digite o id da Anime: ");
            int indiceAnime = int.Parse(Console.ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Anime: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Anime: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Anime: ");
            string entradaDescricao = Console.ReadLine();

            Anime atualizaAnime = new Anime(id: indiceAnime, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            repositorio.Atualiza(indiceAnime, atualizaAnime);

        }
        public static void ExcluirAnimes() {
            Console.Write("Digite o id da Anime: ");
            repositorio.Exclui(int.Parse(Console.ReadLine()));
        }
        public static void VisualizarAnimes() {
            Console.Write("Digite o id da Anime: ");
            Console.WriteLine(repositorio.RetornaPorId(int.Parse(Console.ReadLine())));
        }
        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Animes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Animes");
            Console.WriteLine("2- Inserir nova Anime");
            Console.WriteLine("3- Atualizar Anime");
            Console.WriteLine("4- Excluir Anime");
            Console.WriteLine("5- Visualizar Anime");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
