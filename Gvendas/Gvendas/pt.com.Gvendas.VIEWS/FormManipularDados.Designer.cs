namespace Gvendas.pt.com.Gvendas.VIEWS
{
    partial class FormManipularDados
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
            this.buttonEditarRemover = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.labelManipularDados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditarRemover
            // 
            this.buttonEditarRemover.BackColor = System.Drawing.Color.Gray;
            this.buttonEditarRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEditarRemover.FlatAppearance.BorderSize = 2;
            this.buttonEditarRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarRemover.ForeColor = System.Drawing.Color.White;
            this.buttonEditarRemover.Location = new System.Drawing.Point(295, 293);
            this.buttonEditarRemover.Name = "buttonEditarRemover";
            this.buttonEditarRemover.Size = new System.Drawing.Size(240, 35);
            this.buttonEditarRemover.TabIndex = 37;
            this.buttonEditarRemover.Text = "Editar e Remover";
            this.buttonEditarRemover.UseVisualStyleBackColor = false;
            this.buttonEditarRemover.Click += new System.EventHandler(this.buttonEditarRemover_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.Gray;
            this.buttonAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdicionar.FlatAppearance.BorderSize = 2;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.ForeColor = System.Drawing.Color.White;
            this.buttonAdicionar.Location = new System.Drawing.Point(17, 293);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(269, 35);
            this.buttonAdicionar.TabIndex = 36;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // labelManipularDados
            // 
            this.labelManipularDados.AutoSize = true;
            this.labelManipularDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManipularDados.Location = new System.Drawing.Point(199, 21);
            this.labelManipularDados.Name = "labelManipularDados";
            this.labelManipularDados.Size = new System.Drawing.Size(190, 25);
            this.labelManipularDados.TabIndex = 35;
            this.labelManipularDados.Text = "Manipular Dados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gvendas.Properties.Resources.JDB;
            this.pictureBox1.Location = new System.Drawing.Point(186, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormManipularDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 393);
            this.Controls.Add(this.buttonEditarRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.labelManipularDados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormManipularDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManipularDados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEditarRemover;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label labelManipularDados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}