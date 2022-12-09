using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class AnimalDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public AnimalDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Animal usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO ANIMAL(Nome_animal, Data_nasc_animal, Especie_animal, Raca_animal, Pelagem_animal,
            Sexo_animal, Codigo_cli) VALUES (@Nome, @Data_nasc_animal, @Especie, 
            @Raca, @Pelagem, @Sexo, @Codigo_cli)";

            Cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@Data_nasc_animal",usuario.Data_nasc_animal);
            Cmd.Parameters.AddWithValue("@Especie", usuario.Especie);
            Cmd.Parameters.AddWithValue("@Raca", usuario.Raca);
            Cmd.Parameters.AddWithValue("@Pelagem", usuario.Pelagem);
            Cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
            Cmd.Parameters.AddWithValue("@Codigo_cli", usuario.Codigo_cli);
           
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
        public List<Animal> ListarTodosUsuarios()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM ANIMAL";

            List<Animal> listaDeUsuarios = new List<Animal>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Animal usuario = new Animal(
                        (int)rd["Codigo_animal"], (string)rd["Nome_animal"], (DateTime)rd["Data_nasc_animal"], (string)rd["Especie_animal"], (string)rd["Raca_animal"],
                        (string)rd["Pelagem_animal"], (string)rd["Sexo_animal"],(int)rd["Codigo_cli"]);
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
        public void Atualizar(Animal clienteatual)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"Update ANIMAL set Nome_animal = @Nome, Data_nasc_animal = @Data_nasc_animal, Especie_animal = @Especie, Raca_animal = @Raca,
            Pelagem_animal = @Pelagem, Sexo_animal = @Sexo, Codigo_cli = @Codigo_cli WHERE Codigo_animal = @Codigo_animal";

            Cmd.Parameters.AddWithValue("@Codigo_animal", clienteatual.Codigo_animal);
            Cmd.Parameters.AddWithValue("@Nome", clienteatual.Nome);
            Cmd.Parameters.AddWithValue("@Data_nasc_animal", clienteatual.Data_nasc_animal);
            Cmd.Parameters.AddWithValue("@Especie", clienteatual.Especie);
            Cmd.Parameters.AddWithValue("@Pelagem", clienteatual.Pelagem);
            Cmd.Parameters.AddWithValue("@Sexo", clienteatual.Sexo);
            Cmd.Parameters.AddWithValue("@Codigo_cli", clienteatual.Codigo_cli);


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
        public void Excluir(int Codigo_animal)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM ANIMAL WHERE Codigo_animal = @Codigo_animal";
            Cmd.Parameters.AddWithValue("@Codigo_animal", Codigo_animal);
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

