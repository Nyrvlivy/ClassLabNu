using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ClassLabNu;

namespace ClassLabNu
{
    public class Endereco
    {
        // Atributos
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string complemento;
        private string tipologradouro;
        private int idCli;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string TipoLogradouro { get { return tipologradouro; } set { tipologradouro = value; } }
        public int IdCli { get { return idCli; } set { idCli = value; } }
        // Construtores
        public Endereco()
        {
        }

        public Endereco(string cep, string logradouro, string numero, string bairro, string cidade, string estado, string uf, int idCli)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            IdCli = idCli;
        }
        public Endereco(int id, string cep, string logradouro, string numero, string bairro, string cidade, string estado, string uf, int idCli)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            IdCli = idCli;
        }


        public Endereco(string cep, string logradouro, string numero, string bairro, string cidade, string estado, string uf, string complemento, string tipologradouro, int idCli)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Complemento = complemento;
            TipoLogradouro = tipologradouro;
            IdCli = idCli;
        }

        public Endereco(int id, string cep, string logradouro, string numero, string bairro, string cidade, string estado, string uf, string complemento, string tipologradouro, int idCli)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Complemento = complemento;
            TipoLogradouro = tipologradouro;
            IdCli = idCli;
        }


        // Métodos da Classe
        public void Inserir() // chamadas de banco e grava o registro

        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_inserir";
            cmd.Parameters.AddWithValue("_cep", Cep);
            cmd.Parameters.AddWithValue("_logradouro", Logradouro);
            cmd.Parameters.AddWithValue("_numero", Numero);
            cmd.Parameters.AddWithValue("_bairro", Bairro);
            cmd.Parameters.AddWithValue("_cidade", Cidade);
            cmd.Parameters.AddWithValue("_estado", Estado);
            cmd.Parameters.AddWithValue("_uf", Uf);
            cmd.Parameters.AddWithValue("_complemento", Complemento);
            cmd.Parameters.AddWithValue("_tipologradouro", TipoLogradouro);
            cmd.Parameters.AddWithValue("_idCli", IdCli);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação

        }
        public bool Alterar(int _id, string cep, string logradouro, string numero, string bairro, string cidade, string estado, string uf, string tipologradouro, int idCli)
        {
            bool resultado = false;
            try
            {
                MySqlCommand cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Recebe o nome da procedure
                cmd.CommandText = "sp_endereco_alterar";
                // Recebe os parâmetros da procedure - Lá do MySQL
                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                // USA-SE ESSE^^ de forma mais técnica e é necessário saber exatamente o tipo de valor do parametro
                cmd.Parameters.Add("_cep", MySqlDbType.VarChar).Value = Cep;
                cmd.Parameters.Add("_logradouro", MySqlDbType.VarChar).Value = Logradouro;
                // LEMBRETE: o valor remete ao nome do campo construído da PROCEDURE, logo é VarChar e não String!!
                cmd.Parameters.Add("_numero", MySqlDbType.VarChar).Value = Numero;
                cmd.Parameters.Add("_bairro", MySqlDbType.VarChar).Value = Bairro;
                cmd.Parameters.Add("_cidade", MySqlDbType.VarChar).Value = Cidade;
                cmd.Parameters.Add("_estado", MySqlDbType.Decimal).Value = Estado;
                cmd.Parameters.Add("_uf", MySqlDbType.VarChar).Value = Uf;
                cmd.Parameters.Add("_complemento", MySqlDbType.Decimal).Value = Complemento;
                cmd.Parameters.Add("_tipologradouro", MySqlDbType.VarChar).Value = TipoLogradouro;
                cmd.Parameters.Add("_idCli", MySqlDbType.Int32).Value = IdCli;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }
        public static List<Endereco> Listar()
        {
            List<Endereco> enderecos = new List<Endereco>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from enderecos for order 10"; 
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new Endereco(
                    dr.GetInt32(0),                                 // IDPROD
                    dr.GetString(1),                                // CEP
                    dr.GetString(2),                                // LOGRADOURO
                    dr.GetString(3),                                // NUMERO
                    dr.GetString(4),                                // BAIRRO
                    dr.GetString(5),                                // CIDADE
                    dr.GetString(6),                                // ESTADO
                    dr.GetString(7),                                // UF
                    dr.GetString(8),                                // COMPLEMENTO
                    dr.GetString(9),                                // TIPOLOGRADOURO
                    dr.GetInt32(10)                                 // IDCLI
                    ));
            }
            return enderecos;
        }
        
        

    }   // Fim da classe produto
}
