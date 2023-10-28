using System;
using System.Collections;

class ProgramCpf
{
    public static void Executar()
    {
        Hashtable cpfTelefone = new Hashtable();

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Sistema de Registro de Telefone por CPF");
        Console.WriteLine("---------------------------------------------");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Registrar um novo telefone");
            Console.WriteLine("2 - Imprimir todos os telefones registrados");
            Console.WriteLine("3 - Buscar telefone por CPF");
            Console.WriteLine("0 - Encerrar sistema");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("---> Sistema encerrado!");
                    return;
                case "1":
                    Registrar(cpfTelefone);
                    break;
                case "2":
                    Imprimir(cpfTelefone);
                    break;
                case "3":
                    BuscaPorCPF(cpfTelefone);
                    break;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }

    static void Registrar(Hashtable cpfTelefone)
    {
        if (cpfTelefone.Count < 5)
        {
            Console.Write("Informe o cpf da pessoa: ");
            string cpf = Console.ReadLine();

            Console.Write("Informe o telefone da pessoa: ");
            string telefone = Console.ReadLine();

            cpfTelefone[cpf] = telefone;
        }
        else
        {
            Console.Write("\nVocê atingiu o limite de 5 registros");
        }
    }

    static void Imprimir(Hashtable cpfTelefone)
    {
        Console.WriteLine("\n-- Imprimindo telefones registrados:");
        foreach (DictionaryEntry entry in cpfTelefone)
        {
            Console.WriteLine($"CPF: {entry.Key}, Telefone: {entry.Value}");
        }
    }

    static void BuscaPorCPF(Hashtable cpfTelefone)
    {
        Console.Write("Informe o CPF a ser pesquisado: ");
        string cpfPesquisa = Console.ReadLine();

        if (cpfTelefone.ContainsKey(cpfPesquisa))
        {
            Console.WriteLine($"Telefone encontrado para CPF {cpfPesquisa}: {cpfTelefone[cpfPesquisa]}");
        }
        else
        {
            Console.WriteLine("CPF não encontrado.");
        }
    }
}

