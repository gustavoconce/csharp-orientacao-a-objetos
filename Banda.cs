class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }

    private List<Album> albums = new List<Album>(); 
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirAlbums()
    {
        Console.WriteLine($"Albums de {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} - Duração: {album.DuracaoTotal}");
            Console.WriteLine("");
        }
    }

}