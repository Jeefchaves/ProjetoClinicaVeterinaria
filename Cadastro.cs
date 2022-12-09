using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastro: Form
    {
        private int CODIGO;
        public Cadastro()
        {
            InitializeComponent();
        }
        public Cadastro(Cliente cliente)
        {
            InitializeComponent();
            CODIGO = cliente.Codigo;
            nome_tutor.Text = cliente.Nome;
            cpf_tutor.Text = cliente.CPF;
            data_tutor.Value = cliente.Data_nasc;
            endereco_tutor.Text = cliente.Endereco;
            bairro_tutor.Text = cliente.Bairro;
            cep_tutor.Text = cliente.CEP;
            tel_tutor.Text = cliente.Telefone;
            cel_tutor.Text = cliente.Celular;
            email_tutor.Text = cliente.Email;
            numero_tutor.Text = cliente.Numero;
        }


        private void limpar_tutor_Click(object sender, EventArgs e)
        {
            Codigo_tutor.Clear();
            cpf_tutor.Clear();
            nome_tutor.Clear();
            endereco_tutor.Clear();
            numero_tutor.Clear();
            bairro_tutor.Clear();
            cep_tutor.Clear();
            cel_tutor.Clear();
            tel_tutor.Clear();
            email_tutor.Clear();
        }
                                                                                                                                                                                                                        
        private void voltar_tutor_Click(object sender, EventArgs e)
        {
            Menu Men = new Menu();
            this.Visible = false;
            
            this.Close();
            Men.Visible = true;
        }

        private void cadastrar_tutor_Click(object sender, EventArgs e)
            {
            CRUD_tutor crud = new CRUD_tutor();
                try
                {
                    Cliente cli = new Cliente(
                    nome_tutor.Text,
                    cpf_tutor.Text,
                    data_tutor.Value,
                    endereco_tutor.Text,
                    bairro_tutor.Text,
                    cep_tutor.Text,
                    tel_tutor.Text,
                    cel_tutor.Text,
                    email_tutor.Text,
                    numero_tutor.Text);
                    ClienteDAO usuarioInserir = new ClienteDAO();
                    usuarioInserir.Inserir(cli);
                    MessageBox.Show("Usuário " + cli.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    crud.AtualizarListView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
