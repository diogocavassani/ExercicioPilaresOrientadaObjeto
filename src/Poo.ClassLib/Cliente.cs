using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public class Cliente : PessoaFisica
    {
        public List<string> HistoricoDeVenda { get; set; }

       
    }
}
