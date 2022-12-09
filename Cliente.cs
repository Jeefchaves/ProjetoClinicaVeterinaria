using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cliente
    {
        private int _codigo;
        private string _cpf;
        private DateTime _data_nasc;
        private string _nome;
        private string _endereco;
        private string _numero;
        private string _bairro;
        private string _cep;
        private string _celular;
        private string _telefone;
        private string _email;

        public Cliente( string cpf, string nome, DateTime data_nasc, string endereco , string bairro, string cep, string celular, string telefone, string email, string numero)
        {
            CPF = cpf;
            Nome = nome;
            Data_nasc = data_nasc;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Celular = celular;
            Telefone = telefone;
            Email = email;
        }
        public Cliente(int codigo, string cpf, string nome, DateTime data_nasc, string endereco, string bairro, string cep, string celular, string telefone, string email, string numero)
        {
            _codigo = codigo;
            CPF = cpf;
            Nome = nome;
            Data_nasc = data_nasc;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Celular = celular;
            Telefone = telefone;
            Email = email;
        }
        static bool validarCelular(string Celular)
        {

            Celular = Celular.Trim();
            Celular = Celular.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (Celular.Length < 11)// (12) 99700*0000
                return false;

            return true;
        }


        static bool validarTelefone(string Telefone)
        {

            Telefone = Telefone.Trim();
            Telefone = Telefone.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (Telefone.Length < 11)// (12) 99700*0000
                return false;

            return true;
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

        static bool ValidarCPF(string CPF)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma = 0;
            int resto;
            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF.Length != 11)
                return false;
            tempCpf = CPF.Substring(0, 9);


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
            return CPF.EndsWith(digito);
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
        //Validação do Email
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O email informado não é um texto válido");
                _email = value;
               // if(ValidarEMAIL(Email) == false)
                 //   throw new Exception("O email informado não é um texto válido");
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
                //if(validarTelefone(Telefone) == false)
                  //   throw new Exception("O telefone informado não é um texto válido");

            }
        }
        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O CPF informado não é válido");
                _cpf = value;

               // if(ValidarCPF(_cpf) == false)
                 //   throw new Exception("O CPF informado não é válido");
            }
        }
        public DateTime Data_nasc
        {
            get { return _data_nasc; }
            set
            {
                _data_nasc = value;
            }
        }
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O endereco informado não é um válido");
                _endereco = value;
            }
        }
        public string CEP
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
                    throw new Exception("O Bairro informado não é um texto válido");
                _bairro = value;
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
        public string Celular
        {
            get { return _celular; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O celular informado não é um texto válido");
                _celular = value;
                //if (validarCelular(value) == false)
                  //  throw new Exception("O celular informado contém menos de 11 digitos!");
            }
        }
    }
}
