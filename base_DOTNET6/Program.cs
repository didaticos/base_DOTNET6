Console.WriteLine("Estou rodando no .NET6 - C# 10");


var canal = new Canal();

Console.WriteLine($"O primeiro inscrito foi {canal.Inscritos.First()}");
Console.WriteLine($"Este canal tem {canal.Quantidade} inscritos");

//Quer saber se o DevNelson é o primeiro inscrito
var devNelsonPrimeirInscrito = canal.Inscritos.First() == "DevNelson";
Console.WriteLine($"DevNelson é o primeiro inscrito? :{devNelsonPrimeirInscrito}");

//Quero saber se o DevNelson é o primeiro inscrito e a Agatha foi a última inscrita
var devNelsonPrimeiroAgathaUltima = canal.Inscritos.First() == "DevNelson" &&
    canal.Inscritos.Last() == "Agatha";

Console.WriteLine($"DevNelson é o primeiro inscrito e a Agatha foi a última inscrita? :{devNelsonPrimeiroAgathaUltima}");

//quero recuperar os inscritos entre o devNelson e Agatha [sem loop, posicionando]
var inscritosEntrePrimeiroUltimo = canal.Inscritos.GetRange(
    canal.Inscritos.IndexOf("DevNelson") + 1, //pego a posica do primeiro
    canal.Inscritos.IndexOf("Agatha") - 1 - canal.Inscritos.IndexOf("DevNelson") //pego a posicao da ultima, menos o primeiro, para dar a quantidade correta
    );

foreach (var item in inscritosEntrePrimeiroUltimo)
{
    Console.WriteLine(item);
}

public class Canal
{
    public int Quantidade => Inscritos.Count;

    public List<string> Inscritos = new List<string>()
    {
        "DevNelson",
        "Maxaxxi",
        "Esequias",
        "Clau",
        "Agatha"
    };

    public Canal()
    {

    }
}