using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ParaCasa1
{
    class PessoaDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch(Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }
            
        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inseriUmaPessoa(Pessoa umapessoa)
        {
            String aux = "insert into TabPessoa(codigo,nome,sexo,idade) values (@codigo,@nome,@sexo,@idade)";
            strSQL = new OleDbCommand(aux, conn);
            
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umapessoa.getCodigo();
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umapessoa.getNome();
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = umapessoa.getSexo();
            strSQL.Parameters.Add("@idade", OleDbType.VarChar).Value = umapessoa.getIdade();            
            strSQL.ExecuteNonQuery();
        }

        public static void consultaUmLivro(Pessoa umapessoa)
        {
            String aux = "select * from TabPessoa where codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);
            
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umapessoa.getCodigo();



            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                umapessoa.setNome(result.GetString(1));
                umapessoa.setSexo(result.GetString(2));
                umapessoa.setIdade(result.GetString(3));
            }
            else
                Erro.setMsg("Pessoa não cadastrada!");
        }
        public static void atualizaUmLivro(Pessoa umapessoa)
        {
            String aux = "update TabPessoa set nome=@nome, sexo=@sexo, idade=@idade where codigo =@codigo";

            strSQL = new OleDbCommand(aux, conn);
            
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = umapessoa.getNome();
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = umapessoa.getSexo();
            strSQL.Parameters.Add("@idade", OleDbType.VarChar).Value = umapessoa.getIdade();
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umapessoa.getCodigo();
            strSQL.ExecuteNonQuery();
        }

        public static void excluiUmLivro(Pessoa umlivro)
        {
            String aux = "delete from TabPessoa where codigo = @codigo";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = umlivro.getCodigo();
            strSQL.ExecuteNonQuery();
        }

    }
}
