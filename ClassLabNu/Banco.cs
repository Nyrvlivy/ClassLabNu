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

            /* __________________________________________________________________________________________________________________

            >>>>> POSSÍVEIS CONEXÕES AO BANCO DE DADOS <<<<<<<<<<<<<<<<
            Obs.:Intruções:
                    1. Busque a localização exata do banco de dados entres as opções (e/ou modelo de opções) abaixo:
                    2. Copie a opção desejada;
                    3. Cole na linha 42 ou em "StrConexao = "


            > Conexão do Host da 'minha casa':
                StrConexao = @"server=201.52.8.187;database=comercialdb0191;user id=root;password=mysql54Hf7-;port=3306"; internet
            
            > Conexão pelo nome do Host do computador do senac:
                StrConexao = @"ITQ0626037W10-1";     
            
            > Conexão do Host do domínio:
                StrConexao = @"senac.com etc etc";    

            > Máquina local:
                StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=;port=3306";

            ________________________________________________________________________________________________________________ */

            StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=mysql54Hf7-;port=3306";
            MySqlConnection cn = new MySqlConnection(StrConexao);
            // Será necessário a criação de uma classe de exceção para notificar ocasionais problemas
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                
            }

            cmd.Connection = cn;
            return cmd;
        }

    }

}
