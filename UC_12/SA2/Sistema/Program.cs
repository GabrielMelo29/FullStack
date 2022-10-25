
namespace Sistema {
    class program {
        static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro = "Rua x";
            end.numero = 100;
            end.complemento = "D";
            end.endComercial = false;

            PessoaFisica pf = new PessoaFisica();
            pf.endereco = end;
            pf.nome = "Gabriel";
            pf.CPF = "245647453";
            pf.dtNascimento = new DateTime(1999, 10, 29);


            Console.WriteLine($"Rua: {pf.endereco.logradouro},{pf.endereco.numero}");
        
            Console.WriteLine(pf.validarDataNascimento(pf.dtNascimento));

            bool idadeValida = pf.validarDataNascimento(pf.dtNascimento);

            if (idadeValida == true) {
                System.Console.WriteLine("Cadastro Aprovado");
            } else {
                Console.WriteLine("Cadastro Reprovado");
            }
        }
    } 
}

