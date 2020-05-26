using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Agenda
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Agenda()
        {

        }

        public void Salvar(string nome, string endereco, string telefone, string email)
        {
            Pessoa pessoa = new Pessoa(nome, endereco, telefone, email);
            pessoas.Add(pessoa);
        }

        public void Excluir(string nome)
        {
            pessoas.RemoveAll(p => p.nome == nome);
        }

        public void Ordenar()
        {
            pessoas = pessoas.OrderBy(p => p.nome).ToList();
            pessoas = pessoas.OrderByDescending(p => p.nome).ToList();
        }

        public void Editar(string nome, string endereco, string telefone, string email, int indice)
        {
            pessoas[indice].nome = nome;
            pessoas[indice].endereco = endereco;
            pessoas[indice].telefone = telefone;
            pessoas[indice].email = email;
        }
        public int Size()
        {
            return pessoas.Count;
        }

        public Pessoa RetornaPessoas(int index)
        {
            var pessoa = pessoas[index];
            return pessoa;
        }

    }

}

