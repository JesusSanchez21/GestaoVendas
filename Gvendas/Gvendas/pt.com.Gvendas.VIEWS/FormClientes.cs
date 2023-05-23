using Gvendas.pt.com.Gvendas.CONEXAO.Pasta;
using Gvendas.pt.com.Gvendas.DAO.SQL;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas
{
    public partial class FormClientes : Form
    {
        public int SQLAction { get; set; }
        public FormClientes(int sqlAction = 0)
        {
            SQLAction = sqlAction;
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            switch (SQLAction)
            {
                case 1:
                    buttonSalvar.Text = "Inserir";
                    break;
                case 2:
                    buttonSalvar.Text = "Editar";
                    break;
                case 3:
                    buttonSalvar.Text = "Remover";

                    blockUI();
                    break;

            }
        }

        private void blockUI()
        {
            textBoxEmail.Enabled = false;
            textBoxMorada.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxTelefone.Enabled = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nome = textBoxNome.Text,
                Email = textBoxEmail.Text,
                Morada = textBoxMorada.Text,
                Telefone = int.Parse(textBoxTelefone.Text)
            };
        }

        private void buttonTestDB_Click(object sender, EventArgs e)
        {
            DbConnection connectionIsSuccess = null;
            connectionIsSuccess = SqLConnection.OpenConnection();

            if (connectionIsSuccess != null)
            {
                MessageBox.Show("Ligação DB com sucesso", "DB ligada com sucesso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ligação DB com erro", "DB não ligada", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        // Botões side menu

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {

            pt.com.Gvendas.VIEWS.FormFuncionarios form = new pt.com.Gvendas.VIEWS.FormFuncionarios(2);

            form.ShowDialog();
            this.Close();

        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormProdutos form = new pt.com.Gvendas.VIEWS.FormProdutos();

            form.ShowDialog();
            this.Close();
            
        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormFornecedores form = new pt.com.Gvendas.VIEWS.FormFornecedores();
            form.ShowDialog();
            this.Close();
        }

        private void buttonFornecedores_Click_1(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormFornecedores form = new pt.com.Gvendas.VIEWS.FormFornecedores();
            form.ShowDialog();
            this.Close();
        }
    }
}
