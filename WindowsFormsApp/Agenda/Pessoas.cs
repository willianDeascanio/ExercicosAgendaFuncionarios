using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Pessoa
    {
        public string nome;
        public string endereco;
        public string telefone;
        public string email;

        public Pessoa()
        {

        }

        public Pessoa(string nome, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
