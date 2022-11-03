
namespace Sistema
{
    class program
    {
        static void Main(string[] args)
        {
            List <PessoaFisica> listaPF = new List<PessoaFisica>();

            static void BarraCarregamento(string texto)
            {

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.Write(texto);
                Thread.Sleep(600);
                for (var contador = 0; contador < 7; contador++)
                {
                    Console.Write(">");
                    Thread.Sleep(600);
                }

            }

            Console.WriteLine(@$"
            ========================================
            |                                      |
            |         Bem vindo ao Sistema         |
            |        de Cadastro de Pessoa         |
            |          Física e Jurídica           |
            |                                      |
            ========================================
            ");

            BarraCarregamento("Iniciando ");

            string? opcao;
            do
            {
                Console.WriteLine(@$"
            ========================================
            |       Escolha uma das opções         |
            ----------------------------------------
            |                                      |
            |            PESSOA FÍSICA             |
            |    1 - Cadastrar Pessoa Física       |
            |    2 - Listar Pessoa Física          |
            |    3 - Remover Pessoa Física         |
            |                                      |
            |            PESSOA JURÍDICA           |
            |    4 - Cadastrar Pessoa Jurídica     |
            |    5 - Listar Pessoa Jurídica        |
            |    6 - Remover Pessoa Jurídica       |
            |                                      |
            |              0 - Sair                |
            |                                      |
            ========================================
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Cadastrar pessoa fisica
                        Endereco endPF = new Endereco();

                        Console.WriteLine("Digite seu logradouro");
                        endPF.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número");
                        endPF.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o complemento se tiver");
                        endPF.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereço é comercial? S / N");
                        string endComercial = Console.ReadLine().ToUpper();

                        if (endComercial == "S")
                        {
                            endPF.endComercial = true;
                        } else {
                            endPF.endComercial = false;
                        }

                        PessoaFisica pf = new PessoaFisica();
                        pf.endereco = endPF;

                        Console.WriteLine("Digite o seu CPF:");
                        pf.CPF = Console.ReadLine();

                        Console.WriteLine("Digite o seu nome:");
                        pf.nome = Console.ReadLine();

                        Console.WriteLine("Digite o valor do seu salário:");
                        pf.salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a data de nascimento (AA, MM, DD):");
                        pf.dtNascimento = DateTime.Parse(Console.ReadLine());

                        bool idadeValida = pf.validarDataNascimento(pf.dtNascimento);
                        if (idadeValida == true) {
                            Console.WriteLine("Cadastro aprovado");
                            listaPF.Add(pf);
                            Console.WriteLine(pf.pagarImposto(pf.salario));
                        } 

                        break;
                    case "2":
                        // Listar pessoa fisica
                        foreach (var cadaItem in listaPF) {
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.CPF}");
                        }

                        break;
                    case "3":
                        // Remover pessoa fisica
                        Console.WriteLine("Digite o CPF de quem deseja remover");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPF.Find(cadaItem => cadaItem.CPF == cpfProcurado);
                        
                        if (pessoaEncontrada != null) {
                            listaPF.Remove(pessoaEncontrada);
                            Console.WriteLine("Removido com sucesso");
                        } else {
                            Console.WriteLine("CPF não encontrado");
                        }
                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "0":
                        Console.WriteLine("Obrigado por utilizar o nosso sistema");
                        BarraCarregamento("Finalizando ");
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

