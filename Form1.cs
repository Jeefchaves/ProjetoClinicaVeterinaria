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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal(
                nome_animal.Text,
                data_nasc_animal.Value,
                especie_animal.Text,
                raca_animal.Text,
                pelagem_animal.Text,
                sexo_animal.Text,
                (int)comboBox1.SelectedValue);
                AnimalDAO usuarioInserir = new AnimalDAO();
                usuarioInserir.Inserir(animal);
                MessageBox.Show("Animal " + animal.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //crud.AtualizarListView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cLINICA_VETERINARIADataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.cLINICA_VETERINARIADataSet.CLIENTE);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                nome_animal.Clear();
            raca_animal.Clear();
        }
    }
}
