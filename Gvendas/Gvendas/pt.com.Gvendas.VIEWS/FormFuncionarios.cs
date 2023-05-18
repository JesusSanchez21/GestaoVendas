using Gvendas.pt.com.Gvendas.CONEXAO.Pasta;
using Gvendas.pt.com.Gvendas.DAO.SQL;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormFuncionarios : Form
    {
        public int SQLAction { get; set; }

        public FormFuncionarios(int sqlAction = 0)
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
            textBoxEmail.Enabled = false;
            textBoxMorada.Enabled = false;
            textBoxNome.Enabled = false;
            textBoxTelefone.Enabled = false;
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios form = new FormFuncionarios(2);

            form.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            switch (SQLAction)
            {
                case 1:
                    if(formValid())
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
            } else
            {
                MessageBox.Show("Ligação DB com erro", "DB não ligada", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
    }
}
