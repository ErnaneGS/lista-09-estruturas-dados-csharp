using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" Lista de Exercícios IX");
        Console.WriteLine("---------------------------------------------");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Atividade Hash de CPF");
            Console.WriteLine("2 - Atividade Hash de Compras");
            Console.WriteLine("0 - Encerrar");

            string opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    ProgramCpf.Executar();
                    break;
                case "2":
                    ProgramCompras.Executar();
                    break;
                case "0":
                    Console.WriteLine("---> Encerrado");
                    return;
                default:
                    Console.WriteLine("---> Opção inválida!");
                    break;
            }
        }
    }
}