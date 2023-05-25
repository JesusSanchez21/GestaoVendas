namespace Gvendas.pt.com.Gvendas.VIEWS
{
    partial class FormHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.buttonVerDados = new System.Windows.Forms.Button();
            this.buttonManipular = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gvendas.Properties.Resources.JDB;
            this.pictureBox1.Location = new System.Drawing.Point(188, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(230, 9);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(126, 25);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "HomePage";
            // 
            // buttonVerDados
            // 
            this.buttonVerDados.BackColor = System.Drawing.Color.Gray;
            this.buttonVerDados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonVerDados.FlatAppearance.BorderSize = 2;
            this.buttonVerDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerDados.ForeColor = System.Drawing.Color.White;
            this.buttonVerDados.Location = new System.Drawing.Point(38, 284);
            this.buttonVerDados.Name = "buttonVerDados";
            this.buttonVerDados.Size = new System.Drawing.Size(106, 35);
            this.buttonVerDados.TabIndex = 31;
            this.buttonVerDados.Text = "Ver Dados";
            this.buttonVerDados.UseVisualStyleBackColor = false;
            this.buttonVerDados.Click += new System.EventHandler(this.buttonVerDados_Click);
            // 
            // buttonManipular
            // 
            this.buttonManipular.BackColor = System.Drawing.Color.Gray;
            this.buttonManipular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonManipular.FlatAppearance.BorderSize = 2;
            this.buttonManipular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManipular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManipular.ForeColor = System.Drawing.Color.White;
            this.buttonManipular.Location = new System.Drawing.Point(206, 284);
            this.buttonManipular.Name = "buttonManipular";
            this.buttonManipular.Size = new System.Drawing.Size(157, 35);
            this.buttonManipular.TabIndex = 32;
            this.buttonManipular.Text = "Manipular Dados";
            this.buttonManipular.UseVisualStyleBackColor = false;
            this.buttonManipular.Click += new System.EventHandler(this.buttonManipular_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(433, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 35);
            this.button3.TabIndex = 33;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonManipular);
            this.Controls.Add(this.buttonVerDados);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button buttonVerDados;
        private System.Windows.Forms.Button buttonManipular;
        private System.Windows.Forms.Button button3;
    }
}