using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public abstract class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

		public override bool ValidadorDocumento()
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;

			Cpf = Cpf.Trim();
			Cpf = Cpf.Replace(".", "").Replace("-", "");

			if (Cpf.Length != 11)
				return false;

			tempCpf = Cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = resto.ToString();

			tempCpf = tempCpf + digito;

			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = digito + resto.ToString();

			return Cpf.EndsWith(digito);
		}
	}
}
