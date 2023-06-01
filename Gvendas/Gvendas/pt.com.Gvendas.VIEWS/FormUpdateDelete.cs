using Gvendas.pt.com.Gvendas.CONEXAO.Pasta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormUpdateDelete : Form
    {
        List<Cliente> clienteLista = new List<Cliente>();
        public int Table { get; set; }
        private Cliente selectedCliente;

        public FormUpdateDelete(int table)
        {

            Table = table;
            InitializeComponent();
        }

        private void FormUpdateDelete_Load(object sender, EventArgs e)
        {

            switch (Table)
            {
                case 1:

                    clienteLista = SQLClientes.getAll();

                    //Definir colunas
                    // Definição dos nomes das colunas
                    listView2.Columns[0].Text = "#";
                    listView2.Columns[1].Text = "Nome";
                    listView2.Columns[2].Text = "Morada";
                    listView2.Columns[3].Text = "Email";
                    listView2.Columns[4].Text = "Telefone";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listView2.Columns[0].Width = (15 * listView2.Width) / 100; // ID -> sempre escondido
                    listView2.Columns[1].Width = (10 * listView2.Width) / 100;
                    listView2.Columns[2].Width = (15 * listView2.Width) / 100;
                    listView2.Columns[3].Width = (15 * listView2.Width) / 100;
                    listView2.Columns[4].Width = (15 * listView2.Width) / 100;

                    foreach (Cliente cliente in clienteLista)
                    {
                        ListViewItem row = new ListViewItem(new[] {
                            cliente.Id.ToString(),
                            cliente.Nome,
                            cliente.Morada,
                            cliente.Email,
                            cliente.Telefone.ToString()
                        });
                        listView2.Items.Add(row);
                    }
                    break;
            }
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            // Buscar ID à textBox
            int id;
            if (!int.TryParse(textBoxId.Text, out id))
            {
                MessageBox.Show("Insira um valor de id válido.");
                return;
            }

            // Faz a pesquisa
            switch (Table)
            {
                case 1:
                    // Limpa a listView
                    listView2.Items.Clear();

                    
                    List<Cliente> clienteLista = SQLClientes.getAll();

                    // Encontra o Cliente
                    Cliente cliente = clienteLista.FirstOrDefault(c => c.Id == id);

                    if (cliente != null)
                    {
                        // Adiciona o Cliente a partir da linha
                        ListViewItem row = new ListViewItem(new[]
                        {
                    cliente.Id.ToString(),
                    cliente.Nome,
                    cliente.Morada,
                    cliente.Email,
                    cliente.Telefone.ToString()
                });
                        listView2.Items.Add(row);
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                    break;
                default:
                    
                    break;
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Buscar ID à textBox
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Cliente não selecionado.");
                return;
            }

            // Extrai id 
            int id;
            if (!int.TryParse(listView2.SelectedItems[0].SubItems[0].Text, out id))
            {
                MessageBox.Show("Id inválido.");
                return;
            }

            // Busca a informação do cliente
            selectedCliente = SQLClientes.getClienteById(id);

            if (selectedCliente != null)
            {
                // Display the details in the appropriate input controls
                textBoxNome.Text = selectedCliente.Nome;
                textBoxMorada.Text = selectedCliente.Morada;
                textBoxEmail.Text = selectedCliente.Email;
                textBoxTelefone.Text = selectedCliente.Telefone.ToString();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        private void buttonConfirmUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCliente == null)
            {
                MessageBox.Show("Selecione na lista o cliente para Editar.");
                return;
            }

            // Atualiza a informação do cliente
            selectedCliente.Nome = textBoxNome.Text;
            selectedCliente.Morada = textBoxMorada.Text;
            selectedCliente.Email = textBoxEmail.Text;
            if (int.TryParse(textBoxTelefone.Text, out int telefone))
            {
                selectedCliente.Telefone = telefone;
            }
            else
            {
                MessageBox.Show("Telefone inválido.");
                return;
            }

            // Faz a atualização na base de dados
            bool success = SQLClientes.updateCliente(selectedCliente);

            if (success)
            {
                MessageBox.Show("Cliente editado com sucesso.");
                // Limpa os dados apos atualizar
                textBoxNome.Clear();
                textBoxMorada.Clear();
                textBoxEmail.Clear();
                textBoxTelefone.Clear();
                selectedCliente = null;
            }
            else
            {
                MessageBox.Show("Falha ao editar cliente.");
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            // Buscar ID à textBox
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Cliente não selecionado.");
                return;
            }

            // Extrai o id
            int id;
            if (!int.TryParse(listView2.SelectedItems[0].SubItems[0].Text, out id))
            {
                MessageBox.Show("Id inválido.");
                return;
            }

            // Confirmar o remover
            DialogResult result = MessageBox.Show("Tens a certeza que queres remover este cliente?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Faz a operação delete
                bool success = SQLClientes.deleteCliente(id);

                if (success)
                {
                    MessageBox.Show("Cliente removido com sucesso.");
                    // Remove o cliente
                    listView2.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Falha ao remover cliente.");
                }
            }
        }
    }
}
