using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }

        public string Senha

        {
            get
            {
                return senha;
            }
        }
        public Nivel Nivel { get { return nivel; } }
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
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Senha);
            cmd.Parameters.AddWithValue("_nivel", Nivel);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            // OBS.: Lembrar de fazer tratamento quando da erro de duplicação
        }
        public static bool EfetuarLogin(string email, string senha)
        {
            // realiza validação e devolve verdadeiro ou falso
            return false;
        }
        public static List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir(); // Objeto de conexão MySQL
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
