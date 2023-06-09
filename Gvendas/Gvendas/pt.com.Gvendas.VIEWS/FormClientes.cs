﻿using Gvendas.pt.com.Gvendas.CONEXAO.Pasta;
using Gvendas.pt.com.Gvendas.DAO.SQL;
using Gvendas.pt.com.Gvendas.VIEWS;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas
{
    public partial class FormClientes : Form
    {
        public int SQLAction { get; set; }
        public Cliente cliente { get; set; }


        public FormClientes(int sqlAction, Cliente cliente)
        {
            SQLAction = sqlAction;
            this.cliente = cliente;
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
            if (formValid(out Cliente cliente))
            {
                cliente.Nome = textBoxNome.Text;
                cliente.Email = textBoxEmail.Text;
                cliente.Morada = textBoxMorada.Text;
                cliente.Telefone = int.Parse(textBoxTelefone.Text);

                SQLClientes.Insert(cliente);
            }
            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private bool formValid(out Cliente cliente)
        {
            cliente = new Cliente();

            if (String.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("O campo nome não pode estar vazio.", "ERRO",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                return false;
            }

            return true;
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

        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormProdutos form = new pt.com.Gvendas.VIEWS.FormProdutos();

            form.ShowDialog();

        }

        private void buttonFornecedores_Click(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormFornecedores form = new pt.com.Gvendas.VIEWS.FormFornecedores();
            form.ShowDialog();
        }

        private void buttonFornecedores_Click_1(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormFornecedores form = new pt.com.Gvendas.VIEWS.FormFornecedores();
            form.ShowDialog();
        }

        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            pt.com.Gvendas.VIEWS.FormEncomendas form = new pt.com.Gvendas.VIEWS.FormEncomendas();
            form.ShowDialog();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormHome form = new FormHome();
            form.ShowDialog();
        }
    }
}
