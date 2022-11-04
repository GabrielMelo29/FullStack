using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        public override float pagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento * 6 / 100;
            }
            else if (rendimento > 5000 && rendimento <= 10000)
            {
                return rendimento * 8 / 100;
            }
            else
            {
                return rendimento * 10 / 100;
            }
        }

        public bool validarCNPJ(string CNPJ)
        {
            if (CNPJ.Length >= 14 && (CNPJ.Substring(CNPJ.Length - 4)) == "0001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Inserir(PessoaJuridica pj)
        {
            verificarPastaArquivo(caminho);

            string[] pjString = { $"{pj.nome}, {pj.CNPJ}, {pj.razaoSocial}" };

            File.AppendAllLines(caminho, pjString);
        }

        public List<PessoaJuridica> ler()
        {

            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.CNPJ = atributos[1];
                cadaPj.razaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }
            return listaPj;
        }
    }
}