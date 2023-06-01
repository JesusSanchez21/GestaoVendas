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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEscolhaManipulacao form = new FormEscolhaManipulacao();
            form.ShowDialog();
             
        }

        private void buttonEditarRemover_Click(object sender, EventArgs e)
        {
            FormUpdateDelete form = new FormUpdateDelete(1);
            form.ShowDialog();
        }
    }
}
