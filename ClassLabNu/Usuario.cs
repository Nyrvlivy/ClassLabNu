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
        private string password;
        private Nivel nivel; // é um objeto do tipo nível dentro de usuário

        private bool ativo;

        // Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }

        public string Password

        {
            get
            {
                return password;
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
            this.password = senha;
            this.nivel = nivel;
            ativo = true;
        }

        public Usuario(int id, string nome, string email, string password, Nivel nivel, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;
            this.ativo = ativo;
        }


        // Métodos da Classe 
        public int Inserir()
        {
            // chamadas de banco e gravo o registro
            return id;
        }
        public static bool EfetuarLogin(string email, string senha) 
        {
            // realiza validação e devolve verdaddeiro ou falso
            return false;
        }




    }
}
