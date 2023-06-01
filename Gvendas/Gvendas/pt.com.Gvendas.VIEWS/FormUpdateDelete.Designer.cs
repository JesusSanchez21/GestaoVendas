namespace Gvendas.pt.com.Gvendas.VIEWS
{
    partial class FormUpdateDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonConfirmUpdate = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(233, 47);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.BackColor = System.Drawing.Color.Gray;
            this.buttonProcurar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonProcurar.FlatAppearance.BorderSize = 2;
            this.buttonProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.ForeColor = System.Drawing.Color.White;
            this.buttonProcurar.Location = new System.Drawing.Point(72, 89);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(80, 39);
            this.buttonProcurar.TabIndex = 28;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = false;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Gray;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditar.FlatAppearance.BorderSize = 2;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(244, 89);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(80, 39);
            this.buttonEditar.TabIndex = 29;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.Gray;
            this.buttonRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRemover.FlatAppearance.BorderSize = 2;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.ForeColor = System.Drawing.Color.White;
            this.buttonRemover.Location = new System.Drawing.Point(418, 89);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(80, 39);
            this.buttonRemover.TabIndex = 30;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 267);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(555, 118);
            this.listView2.TabIndex = 31;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxMorada.Location = new System.Drawing.Point(448, 173);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(100, 20);
            this.textBoxMorada.TabIndex = 39;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxEmail.Location = new System.Drawing.Point(311, 173);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 38;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxTelefone.Location = new System.Drawing.Point(174, 170);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefone.TabIndex = 37;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxNome.Location = new System.Drawing.Point(37, 170);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Email:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(35, 145);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 17);
            this.labelNome.TabIndex = 32;
            this.labelNome.Text = "Nome:";
            // 
            // buttonConfirmUpdate
            // 
            this.buttonConfirmUpdate.BackColor = System.Drawing.Color.Gray;
            this.buttonConfirmUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmUpdate.FlatAppearance.BorderSize = 2;
            this.buttonConfirmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmUpdate.Location = new System.Drawing.Point(218, 209);
            this.buttonConfirmUpdate.Name = "buttonConfirmUpdate";
            this.buttonConfirmUpdate.Size = new System.Drawing.Size(128, 39);
            this.buttonConfirmUpdate.TabIndex = 40;
            this.buttonConfirmUpdate.Text = "Confirmar Editar";
            this.buttonConfirmUpdate.UseVisualStyleBackColor = false;
            this.buttonConfirmUpdate.Click += new System.EventHandler(this.buttonConfirmUpdate_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(208, 50);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 41;
            this.labelId.Text = "Id:";
            // 
            // FormUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonConfirmUpdate);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.textBoxId);
            this.Name = "FormUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateDelete";
            this.Load += new System.EventHandler(this.FormUpdateDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button buttonConfirmUpdate;
        private System.Windows.Forms.Label labelId;
    }
}