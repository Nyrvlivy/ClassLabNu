﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Tipo
    {
        // Atributos
        private int id;
        private string nome;
        private string sigla;
        

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Sigla { get { return sigla; } set { sigla = value; } }
       

        // Construtores
        public Tipo()
        {
        }

        public Tipo(string nome)
        {
            Nome = nome;
        }

        public Tipo(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Tipo(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // Métodos da Classe
        public void Inserir() // chamadas de banco e grava o registro

        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipo_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação
        }
        public bool Alterar(Tipo tipo)
        {
            return true;
        }
        public static Tipo ConsultarPorId(int _id)
        {
            Tipo tipo = new Tipo();
            // conecta banco e realiza consulta por Id do Tipo
            return tipo;
        }
        public static Tipo ConsultarPorSigla(string _sigla)
        {
            Tipo tipo = new Tipo();
            // conecta banco e realiza consulta por sigla do Tipo
            return tipo;
        }
        public static List<Tipo> Listar()
        {
            List<Tipo> tipos = new List<Tipo>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from tipos order by 2"; // Colocar em ordem na coluna 2 (alfabética)
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipos.Add(new Tipo(
                    dr.GetInt32(0),        // IDTIPO
                    dr.GetString(1),       // NOME
                    dr.GetString(2)        // SIGLA
                    ));
            }
            return tipos;
        }

    }
}
