using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Animal
    {
        private int _codigo;
        private string _nome;
        private DateTime _data_nasc_animal;
        private string _especie;
        private string _raca;
        private string _pelagem;
        private string _sexo;
        private int   _codigo_cli;


        public Animal(string nome, DateTime data_nasc_animal, string especie , string raca, string pelagem, string sexo, int codigo_cli)
        {
            Nome = nome;
            Data_nasc_animal = data_nasc_animal;
            Especie = especie;
            Raca = raca;
            Pelagem = pelagem;
            Sexo = sexo;
            Codigo_cli = codigo_cli;
        }
        public Animal(int codigo_animal, string nome, DateTime data_nasc_animal, string especie, string raca, string pelagem, string sexo, int codigo_cli)
        {
            _codigo = codigo_animal;
            Nome = nome;
            Data_nasc_animal = data_nasc_animal;
            Especie = especie;
            Raca = raca;
            Pelagem = pelagem;
            Sexo = sexo;
            Codigo_cli = codigo_cli;
        }

        public int Codigo_animal
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

        public DateTime Data_nasc_animal
        {
            get { return _data_nasc_animal; }
            set
            {
                _data_nasc_animal = value;
            }
        }
        public string Especie
        {
            get { return _especie; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A espécie informada não é válida");
                _especie = value;
            }
        }
        public string Raca
        {
            get { return _raca; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A Raça informada não é um texto válido");
                _raca = value;
            }
        }
        public string Pelagem
        {
            get { return _pelagem; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A pelagem informada não é um texto válido");
                _pelagem = value;
            }
        }
        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O sexo informado não é um texto válido");
                _sexo = value;
            }
        }
        public int Codigo_cli
        {
            get { return _codigo_cli; }
            set
            {
                if (_codigo_cli == null)
                    throw new Exception("O CPF informado não é um texto válido");
                _codigo_cli = value;
            }
        }
    }
}
