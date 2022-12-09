using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ClienteDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public ClienteDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Cliente usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO CLIENTE(CPF_cli, Data_nasc_cli, Nome_cli, Endereco_cli, Numero_cli,
            Bairro_cli, CEP_cli, Celular_cli, Telefone_cli, Email_cli) VALUES (@CPF, @Data_nasc, @Nome, 
            @Endereco, @Numero, @Bairro, @CEP, @Celular, @Telefone, @Email )";

            Cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
            Cmd.Parameters.AddWithValue("@Data_nasc",usuario.Data_nasc);
            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
            Cmd.Parameters.AddWithValue("@Bairro", usuario.Bairro);
            Cmd.Parameters.AddWithValue("@CEP", usuario.CEP);
            Cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
            Cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@Email", usuario.Email);

            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Cliente> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM CLIENTE";

            List<Cliente> listaDeUsuarios = new List<Cliente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cliente usuario = new Cliente(
                         (int)rd["Codigo_cli"], (string)rd["CPF_cli"], (string)rd["Nome_cli"], (DateTime)rd["Data_nasc_cli"], (string)rd["Endereco_cli"],
                        (string)rd["Numero_cli"], (string)rd["Bairro_cli"], (string)rd["CEP_cli"], (string)rd["Celular_cli"], (string)rd["Telefone_cli"], (string)rd["Email_cli"]);
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }
        public void Atualizar(Cliente clienteatual)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Update CLIENTE set Nome_cli = @Nome, CPF_cli = @CPF,CEP_cli = @CEP,Celular_cli = @Celular, Data_nasc_cli = @Datanascimento, Endereco_cli = @Endereco, Numero_cli = @Numero, Bairro_cli = @Bairro, Email_cli = @Email, Telefone_cli = @Telefone WHERE Codigo_cli = @Codigo";

            Cmd.Parameters.AddWithValue("@Codigo", clienteatual.Codigo);
            Cmd.Parameters.AddWithValue("@Nome", clienteatual.Nome);
            Cmd.Parameters.AddWithValue("@CPF", clienteatual.CPF);
            Cmd.Parameters.AddWithValue("@Datanascimento", clienteatual.Data_nasc);
            Cmd.Parameters.AddWithValue("@CEP", clienteatual.CEP);
            Cmd.Parameters.AddWithValue("@Endereco", clienteatual.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", clienteatual.Numero);
            Cmd.Parameters.AddWithValue("@Bairro", clienteatual.Bairro);
            Cmd.Parameters.AddWithValue("@Email", clienteatual.Email);
            Cmd.Parameters.AddWithValue("@Telefone", clienteatual.Telefone);
            Cmd.Parameters.AddWithValue("@Celular", clienteatual.Celular);


            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas na atualização do banco de dados usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Excluir(int Codigo_cli)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM CLIENTE WHERE Codigo_cli = @Codigo";
            Cmd.Parameters.AddWithValue("@Codigo", Codigo_cli);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
