﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    public abstract class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public override bool ValidadorDocumento()
        {
			int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			string digito;
			string tempCnpj;

			Cnpj = Cnpj.Trim();
			Cnpj = Cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

			if (Cnpj.Length != 14)
				return false;

			tempCnpj = Cnpj.Substring(0, 12);

			soma = 0;
			for (int i = 0; i < 12; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = resto.ToString();

			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = digito + resto.ToString();

			return Cnpj.EndsWith(digito);
		}

    }
}
