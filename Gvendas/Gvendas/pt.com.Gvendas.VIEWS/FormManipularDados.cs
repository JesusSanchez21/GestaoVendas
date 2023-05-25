using System;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormManipularDados : Form
    {
        public FormManipularDados()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
             
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEscolhaManipulacao form = new FormEscolhaManipulacao();
            form.ShowDialog();
             
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
