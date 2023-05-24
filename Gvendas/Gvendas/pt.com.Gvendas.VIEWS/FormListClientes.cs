using Gvendas.pt.com.Gvendas.CONEXAO.Pasta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormListClientes : Form
    {

        List<Cliente> clienteLista = new List<Cliente>();

        public int Table { get; set; }

        public FormListClientes()
        {
            InitializeComponent();
        }

        private void FormListClientes_Load(object sender, EventArgs e)
        {
            /**
             * 1 identificar as tabelas que iremos utilizar
             * 2 - definir as colunas
             * 3 - preencher as linhas
             *
             * */
            switch (Table)
            {
                case 1:

                    clienteLista = SQLClientes.getAll();

                    //Definir colunas
                    // Definição dos nomes das colunas
                    listView.Columns[0].Text = "#";
                    listView.Columns[1].Text = "Nome";
                    listView.Columns[2].Text = "Morada";
                    listView.Columns[3].Text = "Email";
                    listView.Columns[4].Text = "Telefone";

                    // Definição das colunas da listview. 
                    // NOTA: Os valores percentuais da largura das colunas tem de somar 100
                    listView.Columns[0].Width = (5 * listView.Width) / 100; // ID -> sempre escondido
                    listView.Columns[1].Width = (40 * listView.Width) / 100;
                    listView.Columns[2].Width = (55 * listView.Width) / 100;
                    listView.Columns[3].Width = 0;
                    listView.Columns[4].Width = 0; // Coluna não usada

                    foreach (Cliente cliente in clienteLista)
                    {
                        ListViewItem row = new ListViewItem(new[] {
                            cliente.Id.ToString(),
                            cliente.Nome,
                            cliente.Morada,
                        });
                        listView.Items.Add(row);
                    }
                    break;
            }
        }
    }
}
