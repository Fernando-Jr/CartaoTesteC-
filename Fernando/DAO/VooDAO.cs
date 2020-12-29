using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Fernando.DAO
{
    class VooDAO :Interface.ICrud
    {
        public static void criarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"c:\teste\teste\acme.sqlite");
            }
            catch
            {
                throw;
            }
        }

        public static void criarTabelaSQlite()
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            try
            {
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "CREATE TABLE TB_VOO(" +
                    "id_voo INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "data_voo dateTime, " +
                    "custo numeric(10,2)," +
                    "distancia int," +
                    "captura char(1)," +
                    "nivel_dor int);";
                cmd = new SQLiteCommand(querySQLite, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public void inserir(Object voo)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            Entidade.Voo v = null;
            try
            {
                v = (Entidade.Voo) voo;
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "insert into tb_voo" +
                    "(data_voo, custo, distancia, captura, nivel_dor) " +
                    "values" +
                    "(@data_voo,@custo,@distancia,@captura,@nivel_dor)";
                cmd = new SQLiteCommand(querySQLite, conn);
                cmd.Parameters.AddWithValue("@data_voo", Convert.ToDateTime(v.Data));
                cmd.Parameters.AddWithValue("@custo", v.Custo);
                cmd.Parameters.AddWithValue("@distancia", v.Distancia);
                cmd.Parameters.AddWithValue("@captura", v.Captura);
                cmd.Parameters.AddWithValue("@nivel_dor", v.NivelDor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public void editar(Object voo)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            Entidade.Voo v = null;
            try
            {
                v = (Entidade.Voo)voo;
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "update tb_voo set " +

                    "data_voo = @data_voo, " +
                    "custo = @custo," +
                    "distancia = @distancia," +
                    "captura = @captura," +
                    "nivel_dor= @nivel_dor " +

                    "where id_voo = @id_voo";
                cmd = new SQLiteCommand(querySQLite, conn);
                cmd.Parameters.AddWithValue("@data_voo", v.Data);
                cmd.Parameters.AddWithValue("@custo", v.Custo);
                cmd.Parameters.AddWithValue("@distancia", v.Distancia);
                cmd.Parameters.AddWithValue("@captura", v.Captura);
                cmd.Parameters.AddWithValue("@nivel_dor", v.NivelDor);
                cmd.Parameters.AddWithValue("@id_voo", v.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public void deletar(int id)
        {
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            try
            {
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "delete from tb_voo where id_voo = @id_voo";
                cmd = new SQLiteCommand(querySQLite, conn);
                cmd.Parameters.AddWithValue("@id_voo", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Object> listaVoo()
        {
            SQLiteConnection conn = null;
            Entidade.Voo voo = null;
            List<Entidade.Voo> listVoo = null;
            SQLiteCommand cmd = null;
            SQLiteDataReader dr = null;
            List<Object> listObj = null;
            try
            {
                listObj = new List<object>();
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "select * from tb_voo";
                cmd = new SQLiteCommand(querySQLite, conn);
                dr = cmd.ExecuteReader();

                listVoo = new List<Entidade.Voo>();
                while (dr.Read())
                {
                    voo = new Entidade.Voo();
                    voo.Id = Convert.ToInt32(dr[0]);
                    voo.Data = Convert.ToDateTime(dr[1].ToString());
                    voo.Custo = dr[2].ToString().Equals(String.Empty) ? 0 : double.Parse(dr[2].ToString());
                    voo.Distancia = dr[3].ToString().Equals(String.Empty) ? 0 : int.Parse(dr[3].ToString());
                    voo.Captura = dr[4].ToString().Equals(String.Empty) ? "N" : dr[4].ToString();
                    voo.NivelDor = dr[5].ToString().Equals(String.Empty) ? 0 : int.Parse(dr[5].ToString());
                    listVoo.Add(voo);
                }
                foreach (Entidade.Voo e in listVoo) {
                    listObj.Add(e);
                }
                /*Object o = listVoo.Find(delegate(Entidade.Voo vo) {
                    return vo.Id.Equals(1);
                    }
                );*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return listObj;
        }

        public Entidade.Voo vooPorId(int id)
        {
            SQLiteConnection conn = null;
            Entidade.Voo voo = null;
            SQLiteCommand cmd = null;
            SQLiteDataReader dr = null;
            try
            {
                conn = new SQLiteConnection(Utils.StringConexao.conexao());
                conn.Open();
                string querySQLite = "select * from tb_voo where id_voo = @id_voo";

                cmd = new SQLiteCommand(querySQLite, conn);
                cmd.Parameters.AddWithValue("@id_voo", id);
                dr = cmd.ExecuteReader();
                voo = new Entidade.Voo();
                while (dr.Read())
                {
                    voo.Id = Convert.ToInt32(dr[0]);
                    voo.Data = Convert.ToDateTime(dr[1].ToString());
                    voo.Custo = dr[2].ToString().Equals(String.Empty) ? 0 : double.Parse(dr[2].ToString());
                    voo.Distancia = dr[3].ToString().Equals(String.Empty) ? 0 : int.Parse(dr[3].ToString());
                    voo.Captura = dr[4].ToString().Equals(String.Empty) ? "N" : dr[4].ToString();
                    voo.NivelDor = dr[5].ToString().Equals(String.Empty) ? 0 : int.Parse(dr[5].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return voo;
        }
    }
}
