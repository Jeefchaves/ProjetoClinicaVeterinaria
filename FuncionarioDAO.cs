using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class FuncionarioDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public FuncionarioDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public SqlDataReader rd;
        public bool Login(string email, string senha)
        {
            bool tem = false;
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM FUNCIONARIO WHERE Email_funcionario = @Email AND Senha_funcionario = @senha";
            Cmd.Parameters.AddWithValue("@Email", email);
            //Cmd.Parameters.AddWithValue("@cargo", cargo);
            Cmd.Parameters.AddWithValue("@senha", senha);

            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(dt);
                da.Dispose();


                //if (!(senhaveri == ""))
                //vdd = BCrypt.Net.BCrypt.Verify(senha, senhaveri);

                rd = Cmd.ExecuteReader();                
                    if (rd.HasRows)
                        tem = true;
                

            }
            catch (SqlException err)
            {
                throw new Exception("Erro: Problemas no banco de dados.\n" + err.Message);
            }
            rd.Close();

            return tem;
        }



        //public void Inserir(Funcionario usuario)
        //{
        //    Cmd.Connection = Con.ReturnConnection();
        //    Cmd.CommandText = @"INSERT INTO FUNCIONARIO(Senha_funcionario, Nome_funcionario,CPF_funcionario, Dt_nasc_funcionario, Endereco_funcionariio, Numero_funcionario, Bairro_funcionario, CEP_funcionario, Cargo_funcionario, Celular_funcionario, Email_funcionario) VALUES(@Senha, @Nome, @CPF, @Dt_nasc_funcionario, @Endereco, @Numero, @Bairro, @Cep, @Cargo, @Celular, @Email)";
        
        //    Cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
        //    Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
        //    Cmd.Parameters.AddWithValue("@CPF", usuario.Cpf);
        //    Cmd.Parameters.AddWithValue("@Dt_nasc_funcionario", usuario.Dt_nasc_funcionario);
        //    Cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
        //    Cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
        //    Cmd.Parameters.AddWithValue("@Bairro", usuario.Bairro);
        //    Cmd.Parameters.AddWithValue("@CEP", usuario.Cep);
        //    Cmd.Parameters.AddWithValue("@Cargo", usuario.Cargo);
        //    Cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
        //    Cmd.Parameters.AddWithValue("@Email", usuario.Email);

        //    try
        //    {
        //        //Executa query definida acima.
        //        Cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
        //    }
        //    finally
        //    {
        //        Con.CloseConnection();
        //    }
        //}

        //public void Atualizar(Funcionario usuarioatual)
        //{
        //    Cmd.Connection = Con.ReturnConnection();
        //    Cmd.CommandText = @"Update FUNCIONARIO set Nome_funcionario = @Nome, CPF_funcionario = @CPF, Dt_nasc_funcionario = @Dt_nasc_funcionario, Endereco_funcionario = @Endereco, Numero_funcionario = @Numero, Bairro_funcionario = @Bairro, CEP_funcionario = @Cep, Cargo_funcionario = @Cargo, Celular_funcionario = @Celular, Email_funcionario = @Email WHERE Codigo_funcionario = @codigo";

        //    Cmd.Parameters.AddWithValue("@Codigo", usuarioatual.codigo);
        //    Cmd.Parameters.AddWithValue("@Senha", usuarioatual.Senha);
        //    Cmd.Parameters.AddWithValue("@Nome", usuarioatual.Nome);
        //    Cmd.Parameters.AddWithValue("@CPF", usuarioatual.Cpf);
        //    Cmd.Parameters.AddWithValue("@Dt_nasc_funcionario", usuarioatual.Dt_nasc_funcionario);
        //    Cmd.Parameters.AddWithValue("@Endereco", usuarioatual.Endereco);
        //    Cmd.Parameters.AddWithValue("@Numero", usuarioatual.Numero);
        //    Cmd.Parameters.AddWithValue("@Bairro", usuarioatual.Bairro);
        //    Cmd.Parameters.AddWithValue("@CEP", usuarioatual.Cep);
        //    Cmd.Parameters.AddWithValue("@Cargo", usuarioatual.Cargo);
        //    Cmd.Parameters.AddWithValue("@Celular", usuarioatual.Celular);
        //    Cmd.Parameters.AddWithValue("@Email", usuarioatual.Email);

        //    try
        //    {
        //        //Executa query definida acima.
        //        Cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro: Problemas na atualização do banco de dados usuario no banco.\n" + err.Message);
        //    }
        //    finally
        //    {
        //        Con.CloseConnection();
        //    }
        //}


    //    public List<Funcionario> ListarTodosUsuarios()
    //    {

    //        Cmd.Connection = Con.ReturnConnection();

    //        Cmd.CommandText = "SELECT * FROM FUNCIONARIO";

    //        List<Funcionario> listaDeUsuarios = new List<Funcionario>(); //Instancio a list com o tamanho padrão.
    //        try
    //        {
    //            SqlDataReader rd = Cmd.ExecuteReader();

    //            while (rd.Read())
    //            {
    //                Funcionario usuario = new Funcionario((int)rd["Codigo_funcionario"], (string)rd["Senha_funcionario"], (string)rd["Nome_funcionario"],
    //                    (string)rd["CPF_funcionario"], (string)rd["Dt_nasc_funcionario_funcionario"], (string)rd["Endereco_funcionario"],
    //                    (string)rd["Numero_funcionario"], (string)rd["Bairro_funcionario"], (string)rd["CEP_funcionario"], (string)rd["Cargo_funcionario_"], (string)rd["Celular_funcionario"], (string)rd["Email_funcionario"]);
    //                listaDeUsuarios.Add(usuario);
    //            }
    //            rd.Close();
    //        }
    //        catch (Exception err)
    //        {
    //            throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
    //        }
    //        finally
    //        {
    //            Con.CloseConnection();
    //        }

    //        return listaDeUsuarios;
    //    }


    //    public void Excluir(int IdUsuario)
    //    {
    //        Cmd.Connection = Con.ReturnConnection();
    //        Cmd.CommandText = @"DELETE FROM FUNCIONARIO WHERE Codigo_funcionario = @codigo";
    //        Cmd.Parameters.AddWithValue("@id", IdUsuario);
    //        try
    //        {
    //            Cmd.ExecuteNonQuery();
    //        }
    //        catch (Exception err)
    //        {
    //            throw new Exception("Erro: Problemas ao excluir usuário no banco\n" + err.Message);
    //        }
    //        finally
    //        {
    //            Con.CloseConnection();
    //        }
    //    }


    //    public List<Funcionario> ListarFUC(string consulta)
    //    {
    //        Cmd.Connection = Con.ReturnConnection();
    //        Cmd.CommandText = consulta;

    //        List<Funcionario> listaDeUsuarios = new List<Funcionario>(); //Instancio a list com o tamanho padrão.
    //        try
    //        {
    //            SqlDataReader rd = Cmd.ExecuteReader();

    //            //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
    //            while (rd.Read())
    //            {
    //                Funcionario usuario = new Funcionario((int)rd["Codigo_funcionario"], (string)rd["Senha_funcionario"], (string)rd["Nome_funcionario"],
    //                     (string)rd["CPF_funcionario"], (string)rd["Dt_nasc_funcionario_funcionario"], (string)rd["Endereco_funcionario"],
    //                     (string)rd["Numero_funcionario"], (string)rd["Bairro_funcionario"], (string)rd["CEP_funcionario"], (string)rd["Cargo_funcionario_"], (string)rd["Celular_funcionario"], (string)rd["Email_funcionario"]);
    //                listaDeUsuarios.Add(usuario);
    //            }
    //            rd.Close();
    //        }
    //        catch (Exception err)
    //        {
    //            throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
    //        }
    //        finally
    //        {
    //            Con.CloseConnection();
    //        }

    //        return listaDeUsuarios;
    //    }
    }
}
