using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public abstract class Pessoa
    {
        
        public string Endereco { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; } = true;

        public abstract bool ValidadorDocumento();

    }
}
