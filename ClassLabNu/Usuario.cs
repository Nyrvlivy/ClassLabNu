using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    // Documentação de classes de projeto. - XML Docs
    public class Usuario
    {
        // Atributos
        private int id;
        private string nome;
        private string email;
        private string senha;
        private Nivel nivel; // é um objeto do tipo nível dentro de usuário

        private bool ativo;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }

        public string Senha { get { return senha; } set { senha = value; } }
        public Nivel Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        // Métodos Construtores
        public Usuario()
        {

        }
        public Usuario(string nome, string email, string senha, Nivel nivel)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivel = nivel;
            ativo = true;
        }

        public Usuario(int id, string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivel = nivel;
            this.ativo = ativo;
        }


        // Métodos da Classe 
        public void Inserir() // chamadas de banco e grava o registro

        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_nivel", Nivel.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação
        }

        public bool Alterar(int _id, string nome, string email, string senha, Nivel nivel)
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
                cmd.Parameters.Add("_nome", MySqlDbType.VarChar).Value = Nome;
                cmd.Parameters.Add("_email", MySqlDbType.VarChar).Value = Email;
                // LEMBRETE: o valor remete ao nome do campo construído da PROCEDURE, logo é VarChar e não String!!
                cmd.Parameters.Add("_senha", MySqlDbType.VarChar).Value = Senha;
                cmd.Parameters.Add("_idNv", MySqlDbType.VarChar).Value = Nivel.Id;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }

        public static Usuario ConsultarPorId(int _id)
        {
            Usuario usuario = new Usuario();
            // conecta banco e realiza consulta por Id do Usuario
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios where idUser =" + _id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                usuario.Id = Convert.ToInt32(dr["idUser"]);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Senha = dr.GetString(3);
                usuario.Nivel = Nivel.Consultar(dr.GetInt32(4));
                usuario.Ativo = dr.GetBoolean(5);
            }
            return usuario;
        }
        public static Usuario ConsultarPorEmail(int _email)
        {
            Usuario usuario = new Usuario();
            // conecta banco e realiza consulta por Email do Usuario
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios where email =" + _email;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) // dr data reader
            {
                usuario.Id = Convert.ToInt32(dr["idUser"]);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Senha = dr.GetString(3);
                usuario.Nivel = Nivel.Consultar(dr.GetInt32(4));
                usuario.Ativo = dr.GetBoolean(5);
            }
            return usuario;
        }


        public static bool EfetuarLogin(string email, string senha)
        {
            // realiza validação e devolve verdadeiro ou falso
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where email = '" + email + "' and senha = md5('" + senha + "')'";
            var dr = cmd.ExecuteReader();                         
           return dr.Read();
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            MySqlCommand cmd = Banco.Abrir(); // Objeto de conexão MySQL
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios order by 2"; // Colocar em ordem na coluna 2 (alfabética)
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new Usuario(
                    dr.GetInt32(0),             // IDUSER
                    dr.GetString(1),            // NOME
                    dr.GetString(2),            // EMAIL
                    dr.GetString(3),            // SENHA
                    new Nivel(dr.GetString(4)), // NIVEL
                    dr.GetBoolean(5)            // ATIVO
                    ));
            }
            return usuarios;
        }



    }
}
