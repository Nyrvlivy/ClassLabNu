using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Produto
    {
        // Atributos
        private int id;
        private string descricao;
        private double unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Unidade { get { return unidade; } set { unidade = value; } }
        public string CodBar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public bool Descontinuado { get { return descontinuado; } set { descontinuado = value; } }

        // Construtores
        public Produto()
        {
        }

        public Produto(string descricao, double unidade, string codBar, double valor, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }

        public Produto(string descricao, double unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codbar;
            Valor = valor;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(int id, string descricao, double unidade, string codbar, double valor, double desconto)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codbar;
            Valor = valor;
            Desconto = desconto;
        }

        public Produto(int id, string descricao, double unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codbar;
            Valor = valor;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        // Métodos da Classe
        public void Inserir() // chamadas de banco e grava o registro

        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_inserir";
            cmd.Parameters.AddWithValue("_descricao", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_codbar", CodBar);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.Parameters.AddWithValue("_descontinuado", Descontinuado);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação
        }
        public bool Alterar(int _id, string descricao, double unidade, string codbar, double valor, double desconto)
        {
            bool resultado = false;
            try
            {
                MySqlCommand cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Recebe o nome da procedure
                cmd.CommandText = "sp_produto_alterar";
                // Recebe os parâmetros da procedure - Lá do MySQL
                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                // USA-SE ESSE^^ de forma mais técnica e é necessário saber exatamente o tipo de valor do parametro
                cmd.Parameters.Add("_descricao", MySqlDbType.VarChar).Value = Descricao;
                cmd.Parameters.Add("_unidade", MySqlDbType.VarChar).Value = Unidade;
                // LEMBRETE: o valor remete ao nome do campo construído da PROCEDURE, logo é VarChar e não String!!
                cmd.Parameters.Add("_codbar", MySqlDbType.VarChar).Value = CodBar;
                cmd.Parameters.Add("_valor", MySqlDbType.Decimal).Value = Valor;
                cmd.Parameters.Add("_desconto", MySqlDbType.Decimal).Value = Desconto;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }
        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Id do Produto
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where idProd =" + _id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                produto.Id = Convert.ToInt32(dr["idProd"]);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetDouble(2);
                produto.CodBar = dr.GetString(3);
                produto.Valor = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }
            return produto;
        }

        public static Produto ConsultarPorCodbar(string _codbar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Id do Produto
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where codbar =" + _codbar;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                produto.Id = Convert.ToInt32(dr["idProd"]);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetDouble(2);
                produto.CodBar = dr.GetString(3);
                produto.Valor = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }
            return produto;
        }
        public static Produto ConsultarPorDescricao(string _descricao)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Id do Produto
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos where descricao =" + _descricao;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                produto.Id = Convert.ToInt32(dr["idProd"]);
                produto.Descricao = dr.GetString(1);
                produto.Unidade = dr.GetDouble(2);
                produto.CodBar = dr.GetString(3);
                produto.Valor = dr.GetDouble(4);
                produto.Desconto = dr.GetDouble(5);
                produto.Descontinuado = dr.GetBoolean(6);
            }
            return produto;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos order by 2"; // Colocar em ordem na coluna 2 (alfabética)
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new Produto(
                    dr.GetInt32(0),     // IDPROD
                    dr.GetString(1),    // DESCRICAO
                    dr.GetDouble(2),    // UNIDADE
                    dr.GetString(3),    // CODBAR
                    dr.GetDouble(4),    // VALOR
                    dr.GetDouble(5),    // DESCONTO
                    dr.GetBoolean(6)    // DESCONTINUADO
                    ));
            }
            return produtos;
        }



    }   // Fim da classe produto
}
