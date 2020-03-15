using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public class Funcionario : PessoaFisica
    {
        public DateTime DataAdminissao { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }

        
    }
}
