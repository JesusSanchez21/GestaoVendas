using Gvendas.pt.com.Gvendas.DAO.SQL;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormEscolhaManipulacao : Form
    {
        public FormEscolhaManipulacao()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
            this.Close();
        }
        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {

            FormFuncionarios form = new FormFuncionarios(2);

            form.ShowDialog();
            this.Close();

        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();

            form.ShowDialog();
            this.Close();

        }

        private void buttonFornecedores_Click_1(object sender, EventArgs e)
        {
            FormFornecedores form = new FormFornecedores();
            form.ShowDialog();
            this.Close();
        }

        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            FormEncomendas form = new FormEncomendas();
            form.ShowDialog();
            this.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            form.ShowDialog();
            this.Close();
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
    }
}
