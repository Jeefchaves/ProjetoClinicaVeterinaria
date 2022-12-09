namespace WindowsFormsApp1
{
    partial class CRUD_tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_tutor));
            this.listviewTutor = new System.Windows.Forms.ListView();
            this.Coluna1_Codigo_Cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna2_CPF_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna_Data_nasc_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna4_Nome_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna5_Endereco_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna6_Numero_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna7_Bairro_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna8_CEP_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna9_Celular_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna10_Telefone_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna11_Email_cli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EXCLUIR_cli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewTutor
            // 
            this.listviewTutor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listviewTutor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Coluna1_Codigo_Cli,
            this.Coluna2_CPF_cli,
            this.Coluna_Data_nasc_cli,
            this.Coluna4_Nome_cli,
            this.Coluna5_Endereco_cli,
            this.Coluna6_Numero_cli,
            this.Coluna7_Bairro_cli,
            this.Coluna8_CEP_cli,
            this.Coluna9_Celular_cli,
            this.Coluna10_Telefone_cli,
            this.Coluna11_Email_cli});
            this.listviewTutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listviewTutor.FullRowSelect = true;
            this.listviewTutor.HideSelection = false;
            this.listviewTutor.Location = new System.Drawing.Point(0, 168);
            this.listviewTutor.Name = "listviewTutor";
            this.listviewTutor.Size = new System.Drawing.Size(649, 282);
            this.listviewTutor.TabIndex = 0;
            this.listviewTutor.UseCompatibleStateImageBehavior = false;
            this.listviewTutor.View = System.Windows.Forms.View.Details;
            this.listviewTutor.Click += new System.EventHandler(this.listviewTutor_Click);
            this.listviewTutor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listdouble);
            // 
            // Coluna1_Codigo_Cli
            // 
            this.Coluna1_Codigo_Cli.Text = "Código";
            // 
            // Coluna2_CPF_cli
            // 
            this.Coluna2_CPF_cli.Text = "CPF";
            // 
            // Coluna_Data_nasc_cli
            // 
            this.Coluna_Data_nasc_cli.Text = "Data de Nascimento";
            // 
            // Coluna4_Nome_cli
            // 
            this.Coluna4_Nome_cli.Text = "Nome";
            // 
            // Coluna5_Endereco_cli
            // 
            this.Coluna5_Endereco_cli.Text = "Endereço";
            // 
            // Coluna6_Numero_cli
            // 
            this.Coluna6_Numero_cli.Text = "Número";
            // 
            // Coluna7_Bairro_cli
            // 
            this.Coluna7_Bairro_cli.Text = "Bairro";
            // 
            // Coluna8_CEP_cli
            // 
            this.Coluna8_CEP_cli.Text = "CEP";
            // 
            // Coluna9_Celular_cli
            // 
            this.Coluna9_Celular_cli.Text = "Celular";
            // 
            // Coluna10_Telefone_cli
            // 
            this.Coluna10_Telefone_cli.Text = "Telefone";
            this.Coluna10_Telefone_cli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Coluna11_Email_cli
            // 
            this.Coluna11_Email_cli.Text = "E-mail";
            // 
            // EXCLUIR_cli
            // 
            this.EXCLUIR_cli.BackColor = System.Drawing.Color.Transparent;
            this.EXCLUIR_cli.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EXCLUIR_cli.FlatAppearance.BorderSize = 0;
            this.EXCLUIR_cli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.EXCLUIR_cli.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EXCLUIR_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXCLUIR_cli.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXCLUIR_cli.ForeColor = System.Drawing.Color.Black;
            this.EXCLUIR_cli.Image = ((System.Drawing.Image)(resources.GetObject("EXCLUIR_cli.Image")));
            this.EXCLUIR_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EXCLUIR_cli.Location = new System.Drawing.Point(12, 84);
            this.EXCLUIR_cli.Name = "EXCLUIR_cli";
            this.EXCLUIR_cli.Size = new System.Drawing.Size(122, 30);
            this.EXCLUIR_cli.TabIndex = 1;
            this.EXCLUIR_cli.Text = "EXCLUIR";
            this.EXCLUIR_cli.UseVisualStyleBackColor = false;
            this.EXCLUIR_cli.Click += new System.EventHandler(this.EXCLUIR_cli_Click);
            // 
            // CRUD_tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.EXCLUIR_cli);
            this.Controls.Add(this.listviewTutor);
            this.Name = "CRUD_tutor";
            this.Text = "Exibir Cadastro";
            this.Load += new System.EventHandler(this.CRUD_tutor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewTutor;
        private System.Windows.Forms.ColumnHeader Coluna1_Codigo_Cli;
        private System.Windows.Forms.ColumnHeader Coluna2_CPF_cli;
        private System.Windows.Forms.ColumnHeader Coluna_Data_nasc_cli;
        private System.Windows.Forms.ColumnHeader Coluna4_Nome_cli;
        private System.Windows.Forms.ColumnHeader Coluna5_Endereco_cli;
        private System.Windows.Forms.ColumnHeader Coluna6_Numero_cli;
        private System.Windows.Forms.ColumnHeader Coluna7_Bairro_cli;
        private System.Windows.Forms.ColumnHeader Coluna8_CEP_cli;
        private System.Windows.Forms.ColumnHeader Coluna9_Celular_cli;
        private System.Windows.Forms.ColumnHeader Coluna10_Telefone_cli;
        private System.Windows.Forms.ColumnHeader Coluna11_Email_cli;
        private System.Windows.Forms.Button EXCLUIR_cli;
    }
}