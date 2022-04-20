using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Nivel
    {
        // Atributos
        private int id;
        private string nome;
        private string sigla;

        public readonly bool ativo;

        // Criando Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return sigla; } set { sigla = value; } }


        // Métodos Construtores

        public Nivel()
        {
        }

        public Nivel(string nome)
        {
            this.nome = nome;
        }

        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }

        public Nivel(int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }

        // Métodos da Classe

        public void inserirNovo()
        {
            //inserir um novo nível
        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administrados.
        /// </summary>
        /// <param name="id">identificação do nível</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor par teste lógico, confirmando a alteração</returns>

        public bool Alterar(int _id, string _sigla)
        {
            return true;
        }

        public static Nivel Consultar(int _id)
        {
            Nivel nivel = new Nivel();
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from nivel where idNv =" + _id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                nivel.Id = Convert.ToInt32(dr["idNv"]);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }


    }
}
