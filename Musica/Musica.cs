
using System.Diagnostics.SymbolStore;

class Musica


{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A Musica {Nome} pertence ao {Artista}";
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");

        

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano \n");
        }
        else
        {
            Console.WriteLine("Adquirir o plano Plus+");
        }

        Console.WriteLine("Albuns disponiveis: \n");

        Album AlbumDoQueen = new Album();
        AlbumDoQueen.Nome = "A night at the opera";

        Musica musica2 = new Musica();
        musica2.Nome = "Love of my life";

        Musica musica3 = new Musica();
        musica3.Nome = "Bohemian Rhapsody";

        AlbumDoQueen.AdicionarMusica(musica2);
        AlbumDoQueen.AdicionarMusica(musica3);

        AlbumDoQueen.ExibirMusicaDoAlbum();

        Banda queen = new Banda();
        queen.Nome = "Queen";
        queen.AdicionarAlbum(AlbumDoQueen);
        queen.ExibirDiscografia();

    }

}