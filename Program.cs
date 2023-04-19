using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<Carro> listaCarros = new List<Carro>(); // Lista de carros

        static void Main(string[] args)
        {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Bem-vindo ao sistema de carros!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Cadastrar Carro");
            Console.WriteLine("2 - Consultar Carros");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarCarro();
                    break;
                case "2":
                    ExibirCarrosCadastrados();
                    break;
                case "3":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CadastrarCarro()
        {
            Console.WriteLine("Cadastro de Carro");
            Console.WriteLine("-------------------");

            // Solicitar os atributos do proprietário
            Console.WriteLine("Digite o nome do proprietário:");
            string nomeProprietario = Console.ReadLine();

            Console.WriteLine("Digite o CPF do proprietário:");
            string cpfProprietario = Console.ReadLine();

            Console.WriteLine("Digite o telefone do proprietário:");
            string telefoneProprietario = Console.ReadLine();

            // Criar instância do proprietário
            Proprietario proprietario = new Proprietario(nomeProprietario, cpfProprietario, telefoneProprietario);

            // Solicitar os atributos do carro
            Console.WriteLine("Digite a marca do carro:");
            string marcaCarro = Console.ReadLine();

            Console.WriteLine("Digite o modelo do carro:");
            string modeloCarro = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro:");
            string placaCarro = Console.ReadLine();

            Console.WriteLine("Digite a cor do carro:");
            string corCarro = Console.ReadLine();

            // Criar instância do carro com o proprietário
            Carro carro = new Carro(marcaCarro, modeloCarro, placaCarro, corCarro, proprietario);

            // Adicionar carro à lista de carros
            listaCarros.Add(carro);

            Console.WriteLine("Carro cadastrado com sucesso!");
        }

    static void ExibirCarrosCadastrados()
        {
            Console.WriteLine("Carros Cadastrados");
            Console.WriteLine("-------------------");

            // Exibir detalhes de todos os carros cadastrados
            foreach (var carro in listaCarros)
            {
                Console.WriteLine("Marca: " + carro.Marca);
                Console.WriteLine("Modelo: " + carro.Modelo);
                Console.WriteLine("Placa: " + carro.Placa);
                Console.WriteLine("Cor: " + carro.Cor);
                Console.WriteLine("Proprietário: " + carro.Proprietario.Nome);
                Console.WriteLine("CPF: " + carro.Proprietario.CPF);
                Console.WriteLine("Telefone: " + carro.Proprietario.Telefone);
                Console.WriteLine("-------------------");
            }
        }
        
        
    }
}