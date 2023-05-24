using Gvendas.pt.com.Gvendas.VIEWS;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Gvendas.pt.com.Gvendas.VIEWS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonManipular_Click(object sender, EventArgs e)
        {
            FormManipularDados form = new FormManipularDados();
            form.ShowDialog();
            this.Close();
        }
    }
}
