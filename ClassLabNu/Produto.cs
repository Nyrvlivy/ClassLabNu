using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    internal class Produto
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
            CodBar = codBar;
            Descricao = descricao;
            Unidade = unidade;
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
        public void Inserir(Produto produto) { }
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
            // cenas dos próximos capítulos...
            return produtos;
        }
        public bool Alterar()
        {
            return true;
        }


    }   // Fim da classe produto
}
