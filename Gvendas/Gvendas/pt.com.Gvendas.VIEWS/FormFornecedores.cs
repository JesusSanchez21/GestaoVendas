using Gvendas.pt.com.Gvendas.DAO.SQL;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormFornecedores : Form
    {
        public int SQLAction { get; set; }

        public FormFornecedores(int sqlAction = 0)
        {
            SQLAction = sqlAction;
            InitializeComponent();
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
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
            textBoxNumeroInterno.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxNomeEmpresa.Enabled = false;
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // 
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            switch (SQLAction)
            {
                case 1:
                    if (formValid())
                    {
                        //SQLClientes.Insert()
                    }
                    break;
            }
        }

        private bool formValid()
        {
            throw new NotImplementedException();
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

        //Botões Side menu

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            // 
            FormFuncionarios form = new FormFuncionarios(2);

            form.ShowDialog();

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            //FormClientes form = new FormClientes(2);
            //form.ShowDialog();
            // 
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos form = new FormProdutos();

            form.ShowDialog();
             
        }

        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            FormEncomendas form = new FormEncomendas();
            form.ShowDialog();
             
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            form.ShowDialog();
             
        }
    }
}
