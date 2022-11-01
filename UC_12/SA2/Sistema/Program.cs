
namespace Sistema
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.Write("Iniciando ");
            Thread.Sleep(600);
            for (var contador = 0; contador < 7; contador++)
            {
                Console.Write(">");
                Thread.Sleep(600);
            }
            Console.Clear();


            string? opcao;
            do
            {
                Console.WriteLine(@$"
            ========================================
            |       Escolha uma das opções         |
            ----------------------------------------
            |                                      |
            |         1 - Pessoa Física            |
            |         2 - Pessoa Jurídica          |
            |                                      |
            |         0 - Sair                     |
            |                                      |
            ----------------------------------------
            ");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha uma das opções");
                        break;
                }
            } while (opcao != "0");

            Console.ResetColor();
        }
    }
}

