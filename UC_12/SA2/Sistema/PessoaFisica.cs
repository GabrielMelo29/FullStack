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

        public override void pagarImposto(float rendimento) {}
        public bool validarDataNascimento(DateTime dataNascimento) {
            DateTime dataAtual = DateTime.Today;

            double anos = +(dataAtual - dataNascimento).TotalDays /365;

            if (anos >= 18) {
                return true;
            } else {
                return false;
            }
        }
    }
}