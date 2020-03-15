using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public class Fornecedor : PessoaJuridica
    {
        public List<string> HistoricoDeCompra { get; set; }

       
    }
}
