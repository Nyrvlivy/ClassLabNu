using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Banco
    {
        // Propriedade de Conexão | string
        public static string StrConexao { get; set; }

        // Método Abrir Conexao
        public static MySqlCommand Abrir() 
        { 
            MySqlCommand cmd = new MySqlCommand();

            //(Conexão do Host do senac)
                // StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306";     
            //(Conexão pelo nome do Host do computador do senac)
                // StrConexao = @"ITQ0626037W10-1";      
            //(Conexão do Host do domínio)
                // StrConexao = @"senac.com etc etc";    
            // Máquina local
                 StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306";       
            MySqlConnection cn = new MySqlConnection(StrConexao);
            cn.Open();
            cmd.Connection = cn;

            return cmd;
        }

    }

}
