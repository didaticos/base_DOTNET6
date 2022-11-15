Console.WriteLine("Estou rodando no .NET6 - C# 10");

var nome = "Diogo";
byte[] nomeBytes = System.Text.Encoding.UTF8.GetBytes(nome);
ReadOnlySpan<byte> nomeSpan = nomeBytes;

Console.WriteLine(IsDiogo(nomeSpan));

//switch nos ReadOnly
static bool IsDiogo(ReadOnlySpan<byte> span)
{
    if (System.Text.Encoding.UTF8.GetString(span) == "Diogo")
    {
        return true;
    }

    if (System.Text.Encoding.UTF8.GetString(span) == "Dida")
    {
        return true;
    }

    return false;
}