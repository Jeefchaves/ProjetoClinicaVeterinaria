using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CRUD_tutor : Form
    {
        private int Codigo = -1;
        public CRUD_tutor()
        {
            InitializeComponent();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        public void AtualizarListView()
        {
            ClienteDAO usuarioDao = new ClienteDAO();
            listviewTutor.Items.Clear();


            List<Cliente> usuarios = usuarioDao.ListarTodosUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Codigo.ToString());
                    lv.SubItems.Add(user.CPF);
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Data_nasc.ToShortDateString());
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Numero);
                    lv.SubItems.Add(user.Bairro);
                    lv.SubItems.Add(user.CEP);
                    lv.SubItems.Add(user.Celular);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Email);

                    listviewTutor.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void CRUD_tutor_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listdouble(object sender, MouseEventArgs e)
        {
            int index;
            index = listviewTutor.FocusedItem.Index;
            Codigo = int.Parse(listviewTutor.Items[index].SubItems[0].Text);

            try
            {
                Cliente cliente = new Cliente
                (
                    int.Parse(listviewTutor.Items[index].SubItems[0].Text),
                    listviewTutor.Items[index].SubItems[1].Text,
                    listviewTutor.Items[index].SubItems[2].Text,
                    DateTime.Now,
                    listviewTutor.Items[index].SubItems[4].Text,
                    listviewTutor.Items[index].SubItems[5].Text,
                    listviewTutor.Items[index].SubItems[6].Text,
                    listviewTutor.Items[index].SubItems[7].Text,
                    listviewTutor.Items[index].SubItems[8].Text,
                    listviewTutor.Items[index].SubItems[9].Text,
                    listviewTutor.Items[index].SubItems[10].Text
                );


                Cadastro cadastro = new Cadastro(cliente);
                cadastro.Show();
                //this.Close();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Você precisa selecionar uma linha cod>"+ Codigo.ToString() + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void EXCLUIR_cli_Click(object sender, EventArgs e)
        {

            if (Codigo != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new ClienteDAO().Excluir(Codigo);
                    }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Aviso de erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    AtualizarListView();
                }
            }
            else
            {
                MessageBox.Show("Erro! nada selecionado...");
            }
        }

        private void listviewTutor_Click(object sender, EventArgs e)
        {
            int index;
            index = listviewTutor.FocusedItem.Index;
            Codigo = int.Parse(listviewTutor.Items[index].SubItems[0].Text);
        }
    }
}
