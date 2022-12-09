using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = usuario.Text, senha = senha_login.Text;
            bool vdd;
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

  

            vdd = funcionarioDAO.Login(email, senha);

            if (vdd)
            {
                MessageBox.Show("Bem-vindo ao sistema Pet Health Care!!");
                Menu outronone = new Menu();
                this.Visible = false;
                outronone.ShowDialog();

            }
            else if (senha_login.Text == string.Empty || usuario.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios!");
                usuario.Clear();
                senha_login.Clear();
                usuario.Focus();
            }
            else
            {
                MessageBox.Show("Dados incorretos!\nSeu usuário ou senha estão incorretos!");
                usuario.Clear();
                senha_login.Clear();
                usuario.Focus();
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = usuario.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Usuário_Click(object sender, EventArgs e)
        {
            usuario.Clear();
        }

        private void textbox_senha(object sender, EventArgs e)
        {
            senha_login.PasswordChar = '*';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            senha_login.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
