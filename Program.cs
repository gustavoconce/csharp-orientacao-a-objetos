Banda banda1 = new Banda("Matuê");

Album albumMatue = new Album("333");

//Primeira musica
Musica musica1 = new Musica(banda1, "Crack com mussilon")
{
    Duracao = 234,
    Disponivel = true,
};

//Segunda musica
Musica musica2 = new Musica(banda1, "Imagina esse cenário")
{
    Duracao = 235,
    Disponivel = true,
};



albumMatue.AdicionarMusica(musica1);
albumMatue.AdicionarMusica(musica2);

albumMatue.ExibirMusicasAlbum();

banda1.AdicionarAlbum(albumMatue);
Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");
musica1.ExibirFichaTecnica();
Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");
musica2.ExibirFichaTecnica();
Console.WriteLine("");
Console.WriteLine("--------------------------------");
Console.WriteLine("");
banda1.ExibirAlbums();
