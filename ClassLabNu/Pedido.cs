using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Pedido
    {
        // idped    data    status_ped    desconto    idcli_ped    iduser_ped

        // Atributos
        private int id;
        private DateTime dataPed;
        private string status;
        private double desconto;
        private Cliente cliente;
        private Usuario usuario;
        private List<ItemPedido> itens;
        
        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public DateTime DataPed { get { return dataPed; } set { dataPed = value; } }
        public string Status { get { return status; } set { status = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public List<ItemPedido> Itens { get { return itens; } set { itens = value; } }


        // Construtores
        public Pedido()
        {
        }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }


        // Métodos da Classe
        public void Inserir() { } // void ~porque não recupera valor
        public bool Alterar(Pedido pedido) 
        { 
            return false;
        }
        public Pedido ConsultarPorId(int _id)
        {
            Pedido pedido = new Pedido();
            // conecta banco e realiza consulta por Id do pedido
            return pedido;
        }
               public List<Pedido> ConsultarPorClienteId(int _Cliente)
        {
            List<Pedido> pedidos = new List<Pedido>();
            // conecta banco e realiza consulta por Id do cliente e retorna todos os pedidos
            return pedidos;
        }



    }
}
