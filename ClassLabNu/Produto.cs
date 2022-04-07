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
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } } 
        public string Unidade { get { return unidade; } set { unidade = value;} }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value;} }

        // Construtores
        public Produto()
        {
        }

        public Produto(int id, string descricao, string unidade, double valor)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            Valor = valor;
        }

        public Produto(int id, string descricao, string unidade, string codbar, double valor, double desconto)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            Codbar = codbar;
            Valor = valor;
            Desconto = desconto;
        }

        // Métodos da Classe
        public void Inserir(Produto produto)
        {

        }
        public static Produto ConsultarPorId(int _id)
        {
            Produto produto = new Produto();
            // cenas dos próximos capítulos... (dnv)
            return produto;
        }
        public static Produto ConsultarPorCodbar(string _codbar)
        {
            Produto produto = new Produto();
            // cenas dos próximos capítulos... (dnv)
            return produto;
        }
        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            // cenas dos próximos capítulos...
            return produtos;
        }



    }
}
