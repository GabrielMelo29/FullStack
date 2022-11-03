using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public DateTime dtNascimento { get; set; }

        public float salario {get; set;}

        public override float pagarImposto(float salario)
        {
            if (salario <= 1500)
            {
                return 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                return salario * 3 / 100;
            }
            else
            {
                return salario * 5 / 100;
            }
        }

        public bool validarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = +(dataAtual - dataNascimento).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}