using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public Endereco endereco { get; set; }


        public abstract float pagarImposto(float salario);

        public void verificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(caminho))
            {
                using (File.Create(caminho))
                {

                }
            }
        }
    }
}