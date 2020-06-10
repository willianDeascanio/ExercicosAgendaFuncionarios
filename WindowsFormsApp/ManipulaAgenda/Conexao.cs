using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp.ManipulaAgenda
{
    class Conexao
    {
        public static SqlConnection Conectar(){
            string conexao = @"Data Source=DESKTOP-U8NPKH2\SQLEXPRESS;Initial Catalog=agendaparcial;Integrated Security=True";
            SqlConnection conection = new SqlConnection(conexao);
            conection.Open();
            return conection;

            }

    }
}
