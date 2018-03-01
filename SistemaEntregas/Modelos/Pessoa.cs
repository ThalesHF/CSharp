using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Pessoa
    {
        public int PessoaID { get; set; }

        public String Nome { get; set; }

        public int Cpf { get; set; }

        public int EnderecoID { get; set; }

        public Endereco _Endereco { get; set; }

    }
}
