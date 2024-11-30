class Album
{

    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();


    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add(musica);
    }


    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Músicas do albúm {Nome}: ");
        Console.WriteLine("-------------------------");
        foreach (var musica in musicas)
        {
            Console.WriteLine("");
            Console.WriteLine($"Nome da música: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao}");
        }
        Console.WriteLine("");
        Console.WriteLine($"Duração do albúm completo: {DuracaoTotal}");
    }

}