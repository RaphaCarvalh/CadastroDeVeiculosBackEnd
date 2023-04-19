public class Proprietario
{
    // Atributos da classe Proprietario
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }

    // Construtor da classe Proprietario
    public Proprietario(string nome, string cpf, string telefone)
    {
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
    }

    // Método para exibir os dados do proprietário
    public void ExibirDadosProprietario()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Telefone: {Telefone}");
    }
}
