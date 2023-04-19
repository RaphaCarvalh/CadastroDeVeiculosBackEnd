public class Carro
{
    // Atributos da classe Carro
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public Proprietario Proprietario { get; set; }

    // Construtor da classe Carro
    public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Cor = cor;
        Proprietario = proprietario;
    }

    // Método para exibir os dados do carro
    public void ExibirDadosCarro()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine("Proprietário:");
        Proprietario.ExibirDadosProprietario();
    }

}





