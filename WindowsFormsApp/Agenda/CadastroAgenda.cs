using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.ManipulaAgenda;
using WindowsFormsApp.agendaparcialDataSetTableAdapters;

namespace WindowsFormsApp
{
    public partial class CadastroAgenda : Form
    {
        private int sortColumn = -1;

        Agenda listaAgenda = new Agenda();

        public CadastroAgenda()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Nome Inválido", "Atenção");
                return false;
            }

            if (tbEndereco.Text == "")
            {
                MessageBox.Show("Endereço Inválido", "Atenção");
                return false;
            }

            if (tbTelefone.Text == "")
            {
                MessageBox.Show("Telefone Inválido", "Atenção");
                return false;
            }

            if (!tbEmail.Text.Contains("@") || tbEmail.Text == "")
            {
                MessageBox.Show("Email Inválido", "Atenção");
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbEndereco.Text = "";
            tbTelefone.Text = "";
            tbEmail.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                listaAgenda.Salvar(tbNome.Text, tbEndereco.Text, tbTelefone.Text, tbEmail.Text);

                ListViewItem item = new ListViewItem(new[] { tbNome.Text,
                                                            tbEndereco.Text,
                                                            tbTelefone.Text,
                                                            tbEmail.Text


                });

                // adicionando o objeto item na listview
                listViewAgenda.Items.Add(item);

                MessageBox.Show($"Usuário adicionado {tbNome.Text}", "Atenção");

                ManipulaAgenda.Manipulacao.InserirRegistro(tbNome.Text, tbEndereco.Text, tbTelefone.Text, tbEmail.Text);

            }



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            for (int itemList = listViewAgenda.SelectedItems.Count - 1; itemList >= 0; itemList--)
            {

                ListViewItem lista = listViewAgenda.SelectedItems[itemList];
                listViewAgenda.Items.Remove(lista);

                string nome = lista.SubItems[0].Text;
                listaAgenda.Excluir(nome);

                ManipulaAgenda.Manipulacao.ExcluirRegistro(nome);
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listViewAgenda.SelectedIndices.Count > 0)
            {
                int indice;


                var lvi = listViewAgenda.SelectedItems[0];
                string nomeOriginal = lvi.SubItems[0].Text;

                lvi.SubItems[0].Text = tbNome.Text;
                lvi.SubItems[1].Text = tbEndereco.Text;
                lvi.SubItems[2].Text = tbTelefone.Text;
                lvi.SubItems[3].Text = tbEmail.Text;


                indice = listViewAgenda.Items.IndexOf(listViewAgenda.SelectedItems[0]);


                listaAgenda.Editar(tbNome.Text, tbEndereco.Text, tbTelefone.Text, tbEmail.Text, indice);

                ManipulaAgenda.Manipulacao.AtualizarRegistro(tbNome.Text, tbEndereco.Text, tbTelefone.Text, tbEmail.Text,nomeOriginal);
            }

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (listViewAgenda.SelectedIndices.Count > 0)
            {
                var lvi = listViewAgenda.SelectedItems[0];
                tbNome.Text = lvi.SubItems[0].Text;
                tbEndereco.Text = lvi.SubItems[1].Text;
                tbTelefone.Text = lvi.SubItems[2].Text;
                tbEmail.Text = lvi.SubItems[3].Text;
            }

        }



        private void CadastroAgenda_Load(object sender, EventArgs e)
        {
           
            List<Pessoa> pessoasRegistros = ManipulaAgenda.Manipulacao.SelecionarRegistro();

            for(int i = 0; i < pessoasRegistros.Count; i++)
            {
                ListViewItem item = new ListViewItem(new[] { pessoasRegistros[i].nome,
                                                             pessoasRegistros[i].endereco,
                                                             pessoasRegistros[i].telefone,
                                                             pessoasRegistros[i].email


                });

                listViewAgenda.Items.Add(item);

                listaAgenda.Salvar(pessoasRegistros[i].nome,pessoasRegistros[i].endereco, pessoasRegistros[i].telefone, pessoasRegistros[i].email);

            }
        }


        private void lvAgenda_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != Nome.Index)
            {
                sortColumn = e.Column;

                listViewAgenda.Sorting = SortOrder.Ascending;
            }

            else
            {
                if (listViewAgenda.Sorting == SortOrder.Ascending)

                    listViewAgenda.Sorting = SortOrder.Descending;

                else
                    listViewAgenda.Sorting = SortOrder.Ascending;
            }
        }

        private void lvAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
