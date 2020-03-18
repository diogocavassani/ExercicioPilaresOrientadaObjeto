using Cadastro.Models;
using System;
using System.Collections.Generic;

namespace Cadastro.ConsoleApp
{
    class Program : Cliente
    {
        static void Main(string[] args)
        {
            #region Cliente1
            var clienteUm = new Cliente();
            var listaClienteUm = new List<string>() { "Produto 1","Produto 2","Produto 3"};
            clienteUm.Nome = "Diogo";
            clienteUm.Cpf = "298.737.628-68"; //CPF Valido.
            clienteUm.Rg = "95.160.245-5";
            clienteUm.Endereco = "Rua sobe desce, 125, centro";
            clienteUm.Email = "diogo@teste.com.br";
            clienteUm.HistoricoDeVenda = listaClienteUm;

            if (DocumentoValido(clienteUm))
                Console.WriteLine($"Ola, {clienteUm.Nome} o CPF {clienteUm.Cpf} é valido");
            else
                Console.WriteLine($"Ola, {clienteUm.Nome} o CPF {clienteUm.Cpf} não é valido");
            #endregion

            #region Cliente2
            var clienteDois = new Cliente();
            var listaClienteDois = new List<string>() { "Produto 4", "Produto 5", "Produto 6" };
            clienteDois.Nome = "Douglas";
            clienteDois.Cpf = "123.456.456-65"; //CPF invalido
            clienteDois.Rg = "87.856.124-5";
            clienteDois.Endereco = "Rua dobra direita, 124, centro";
            clienteDois.Email = "Douglas@teste.com.br";
            clienteDois.HistoricoDeVenda = listaClienteDois;

            if (DocumentoValido(clienteDois))
                Console.WriteLine($"Ola, {clienteDois.Nome} o CPF {clienteDois.Cpf} é valido");
            else
                Console.WriteLine($"Ola, {clienteDois.Nome} o CPF {clienteDois.Cpf} não é valido");
            #endregion

            #region Funcionario1
            var funcionarioUm = new Funcionario();
            funcionarioUm.Nome = "Gilberto";
            funcionarioUm.Cpf = "607.936.258-90";
            funcionarioUm.Rg = "78.124.576-5";
            funcionarioUm.Endereco = "Rua João Pessoa";
            funcionarioUm.Email = "Gilberto@teste.com.br";
            funcionarioUm.DataAdminissao = DateTime.Now;
            funcionarioUm.Salario = 3000D;
            funcionarioUm.Cargo = "Analista Junior";

            if (DocumentoValido(funcionarioUm))
                Console.WriteLine($"Ola, {funcionarioUm.Nome} o CPF {funcionarioUm.Cpf} é valido");
            else
                Console.WriteLine($"O CPF {funcionarioUm.Cpf} não é valido");
            #endregion

            #region Funcionario2
            var funcionarioDois = new Funcionario();
            funcionarioDois.Nome = "Adalberto";
            funcionarioDois.Cpf = "576.936.258-90";
            funcionarioDois.Rg = "78.124.576-5";
            funcionarioDois.Endereco = "Rua João Pessoa";
            funcionarioDois.Email = "Gilberto@teste.com.br";
            funcionarioDois.DataAdminissao = DateTime.Now;
            funcionarioDois.Salario = 3000D;
            funcionarioDois.Cargo = "Suporte Senior";

            if (DocumentoValido(funcionarioDois))
                Console.WriteLine($"Ola, {funcionarioDois.Nome} o CPF {funcionarioDois.Cpf} é valido");
            else
                Console.WriteLine($"Ola, {funcionarioDois.Nome} o CPF {funcionarioDois.Cpf} não é valido");
            #endregion

            #region Fornecedor1
            var fornecedorUm = new Fornecedor();
            var listaFornecedorUm = new List<string>() { "Produto 1", "Produto 2", "Produto 2" };
            fornecedorUm.HistoricoDeCompra = listaFornecedorUm;
            fornecedorUm.RazaoSocial = "Peça Geral LTDA";
            fornecedorUm.Cnpj = "29.928.902/0001-74"; //CNPJ Valido
            fornecedorUm.InscricaoEstadual = "123.123.132";
            fornecedorUm.Endereco = "Rua São José, 1248, Jardim Primavera";
            fornecedorUm.Email = "suporte@pecageral.com.br";

            if (DocumentoValido(fornecedorUm))
                Console.WriteLine($"Ola, {fornecedorUm.RazaoSocial} o CNPJ {fornecedorUm.Cnpj} é valido");
            else
                Console.WriteLine($"Ola, {fornecedorUm.RazaoSocial} o CNPJ {fornecedorUm.Cnpj} não é valido");
            #endregion

            #region Fornecedor2
            var fornecedorDois = new Fornecedor();
            var listaFornecedorDois = new List<string>() { "Produto 4", "Produto 5", "Produto 6" };
            fornecedorDois.HistoricoDeCompra = listaFornecedorUm;
            fornecedorDois.RazaoSocial = "Peça Geral LTDA";
            fornecedorDois.Cnpj = "29.928.902/6521-74"; //Invalido
            fornecedorDois.InscricaoEstadual = "123.123.132";
            fornecedorDois.Endereco = "Rua São José, 1248, Jardim Primavera";
            fornecedorDois.Email = "suporte@pecageral.com.br";

            if (DocumentoValido(fornecedorDois))
                Console.WriteLine($"Ola, {fornecedorDois.RazaoSocial} o CNPJ {fornecedorDois.Cnpj} é valido");
            else
                Console.WriteLine($"Ola, {fornecedorDois.RazaoSocial} o CNPJ {fornecedorDois.Cnpj} não é valido");
            #endregion
        }

        private static bool DocumentoValido(Pessoa pessoa)
        {
            if (pessoa.ValidadorDocumento())
                return true;
            return false;
        }

        


    }
}
