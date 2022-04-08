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
        private List<ItemPedido> Itens;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public DateTime DataPed { get { return dataPed; } set { dataPed = value; } }
        public string Status { get { return status; } set { status = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public List<ItemPedido> Itens { get { return itens; } set { itens = value; } }

        // Construtores


        // Métodos da Classe



    }
}
