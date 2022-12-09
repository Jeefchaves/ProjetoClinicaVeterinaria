using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    
        public class Funcionario
        {
            private int _codigo;
            private string _senha;
            private string _nome;
            private string _cpf;
            private string _dt_nasc_funcionario;
            private string _endereco;
            private string _numero;
            private string _bairro;
            private string _cep;
            private string _cargo;
            private string _celular;
            private string _email;


            public Funcionario(string senha, string nome, string cpf, string dt_nasc_funcionario, string endereco, string numero, string bairro, string cep, string cargo, string celular, string email)
            {
                Senha = senha;
                Nome = nome;
                Cpf = cpf;
                Dt_nasc_funcionario = dt_nasc_funcionario;
                Endereco = endereco;
                Numero = numero;
                Bairro = bairro;
                Cep = cep;
                Cargo = cargo;
                Celular = celular;
                Email = email;
            }

            public Funcionario(int codigo, string senha, string nome, string cpf, string dt_nasc_funcionario, string endereco, string numero, string bairro, string cep,  string cargo, string celular, string email)
            {
                _codigo = codigo;
                Senha = senha;
                Nome = nome;
                Cpf = cpf;
                Endereco = endereco;
                Numero = numero;
                Bairro = bairro;
                Cep = cep;
                Cargo = cargo;
                Celular = celular;
                Email = email;
            }

            static bool ValidarEMAIL(string Email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(Email);
                    return addr.Address == Email;
                }
                catch (Exception)
                {
                    return false;
                }
            }


            static bool validarCELULAR(string celular)
            {

                celular = celular.Trim();
                celular = celular.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                if (celular.Length < 11)// (12) 99700*0000
                    return false;

                return true;
            }

            static bool validarCPF(string Cpf)
            {

                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma = 0;
                int resto;
                Cpf = Cpf.Trim();
                Cpf = Cpf.Replace(".", "").Replace("-", "");
                if (Cpf.Length != 11)
                    return false;
                tempCpf = Cpf.Substring(0, 9);


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


            public int Codigo
            {
                get { return _codigo; }
            }
            //Validação do Nome.
            public string Nome
            {
                get { return _nome; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O nome informado não é um texto válido");
                    _nome = value;
                }
            }

            public string Cpf
            {
                get { return _cpf; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O CPF informado não é um texto válido");
                    _cpf = value;

                    if (validarCPF(_cpf) == false)
                        throw new ArgumentException("O CPF informado não é um texto válido");
                }
            }

            public string Dt_nasc_funcionario
            {
                get { return _dt_nasc_funcionario; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("A data de nascimento informado não é um texto válido");
                    _dt_nasc_funcionario = value;
                }
            }

      
            public string Endereco
            {
                get { return _endereco; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O endereço informado não é um texto válido");
                    _endereco = value;
                }
            }

            public string Numero
            {
                get { return _numero; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O numero informado não é um texto válido");
                    _numero = value;
                }
            }

        public string Cep
        {
            get { return _cep; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O CEP informado não é um texto válido");
                _cep = value;
            }
        }

        public string Bairro
            {
                get { return _bairro; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O bairro informado não é um texto válido");
                    _bairro = value;
                }
            }

            //Validação do Email
            public string Email
            {
                get { return _email; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O E-Mail fornecido não é valido!");
                    _email = value;

                    if (ValidarEMAIL(Email) == false)
                        throw new ArgumentException("O E-Mail fornecido não é valido!");
                }
            }

            //Validação do Telefone
            public string Celular
            {
                get { return _celular; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O celular informado não é um texto válido");
                    _celular = value;

                    if (validarCELULAR(Celular) == false)
                        throw new ArgumentException("O celular informado não é um texto válido\nEntre com o DDD mais 9 digitos do telefone");

                }
            }

            public string Senha
            {
                get { return _senha; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("A senha informado não é um texto válido");
                    _senha = value;
                }
            }
            public string Cargo
            {
                get { return _cargo; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("O cargo informado não é um texto válido");
                    _cargo = value;
                }
            }
        }
    
}
