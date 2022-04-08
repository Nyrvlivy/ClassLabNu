using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class ItemPedido
    {
        // idped_ip    idprod_ip    valor    quantidade    desconto

        // Atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;

        // Propriedades
        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }

        // Construtores
        public ItemPedido() { }
        public ItemPedido(Produto produto, double valor, double quantidade, double desconto) 
        { 
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Desconto = desconto;

        }

        // Métodos da Classe

        public void Inserir() { }
        public void Alterar(ItemPedido item)
        {

        }
        public static List<ItemPedido> Listar()
        {
            List<ItemPedido> itens = new List<ItemPedido>();
           return itens;



        }
    }
}
