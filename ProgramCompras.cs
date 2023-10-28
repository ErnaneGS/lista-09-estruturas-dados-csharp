using System;
using System.Collections;

class ProgramCompras
{
    public static void Executar()
    {
        Hashtable carrinho = new Hashtable();

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" Sistema de Carrinhos de Compras ");
        Console.WriteLine("---------------------------------------------");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar produto ao carrinho");
            Console.WriteLine("2 - Visualizar carrinho de compras");
            Console.WriteLine("0 - Finalizar compra");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    AdicionarProduto(carrinho);
                    break;
                case "2":
                    VisualizarCarrinho(carrinho);
                    break;
                case "0":
                    FinalizarCompra(carrinho);
                    return;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }

    static void AdicionarProduto(Hashtable carrinho)
    {
        Console.Write("Informe o nome do produto: ");
        string nomeProduto = Console.ReadLine();

        Console.Write("Informe o valor da produto: ");
        double valorProduto = double.Parse(Console.ReadLine());

        carrinho[nomeProduto] = valorProduto;
    }

    static void VisualizarCarrinho(Hashtable carrinho)
    {
        Console.WriteLine("\n-- Imprimindo produtos do carrinho:");
        foreach (DictionaryEntry entry in carrinho)
        {
            Console.WriteLine($"Produto: {entry.Key}, Valor R$: {entry.Value}");
        }
    }

    static void FinalizarCompra(Hashtable carrinho)
    {
        Console.Write("--- Comprovante de compra --- ");
        double soma = 0;
        foreach (DictionaryEntry entry in carrinho)
        {
            Console.WriteLine($"\nProduto: {entry.Key}, Valor R$: {entry.Value}");
            if (entry.Value is double valor)
            {
                soma += valor;
            }
        }
        Console.WriteLine($"\n>>> Qtd. de produtos: {carrinho.Count}, >>> Valor Total R$: {soma}");

    }
}