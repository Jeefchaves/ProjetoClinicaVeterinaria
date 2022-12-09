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
    public partial class Exibir_Cadastro_Animal : Form
    {
        private int Codigo = -1;
        public Exibir_Cadastro_Animal()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void AtualizarListView()
        {
            AnimalDAO usuarioDao = new AnimalDAO();
            listView1 .Items.Clear();


            List<Animal> usuarios = usuarioDao.ListarTodosUsuarios();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Codigo_animal.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Data_nasc_animal.ToShortDateString());
                    lv.SubItems.Add(user.Especie);
                    lv.SubItems.Add(user.Raca);
                    lv.SubItems.Add(user.Pelagem);
                    lv.SubItems.Add(user.Sexo);
                    lv.SubItems.Add(user.Codigo_cli.ToString());

                    listView1.Items.Add(lv);  //Adiciona a linha criada ao listView.
                }
            }
            // Se não houver elementos, mesclar as colunas e exibir apenas um texto para o usuário.
        }

        private void liv(object sender, EventArgs e)
        {
            AtualizarListView();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {

            if (Codigo != -1)
            {
                DialogResult resultado = MessageBox.Show("Deseja excluir?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        new AnimalDAO().Excluir(Codigo);
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

        private void ListView1(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Codigo = int.Parse(listView1.Items[index].SubItems[0].Text);
        }
    }
}
