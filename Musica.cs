
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { set; get; }
    public bool Disponivel { set; get; }

    public string Descricao => 
        $"A música {Nome}, do artista {Artista}, possui uma duração de {Duracao} minutos!";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("A música está disponível");
        } else
        {
            Console.WriteLine("Adiquira o plano Plus!");
        }

    }

}




