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
        // atributos
        private int id;
        private string nome;
        private string email;
        private string password;
        private bool ativo;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } } 
        public string Email { get { return email; } set { email = value; } }
        public string Password { get 
            { 
                return password; 
            } set { password = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        // métodos construtores

        // métodos da classe 

    }
}
