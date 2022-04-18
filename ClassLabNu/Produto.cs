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
        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Id do produto
            return produto;
        }
        public static Produto ConsultarPorCodbar(string _codbar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Código de Barras do produto
            return produto;
        }
        public static Produto ConsultarPorDescricao(string _descricao)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por Descrição do produto
            return produto;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from produtos order by 2"; // Colocar em ordem na coluna 2 (alfabética)
            var dr = cmd.ExecuteReader();
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
        public bool Alterar()
        {
            return true;
        }


    }   // Fim da classe produto
}
