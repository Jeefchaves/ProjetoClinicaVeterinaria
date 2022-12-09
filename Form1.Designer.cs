namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_animal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_nasc_animal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Raça = new System.Windows.Forms.Label();
            this.raca_animal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pelagem_animal = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cadastrar_animal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.especie_animal = new System.Windows.Forms.ComboBox();
            this.sexo_animal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLINICA_VETERINARIADataSet = new WindowsFormsApp1.CLINICA_VETERINARIADataSet();
            this.cLIENTETableAdapter = new WindowsFormsApp1.CLINICA_VETERINARIADataSetTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICA_VETERINARIADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Cliente";
            // 
            // nome_animal
            // 
            this.nome_animal.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_animal.Location = new System.Drawing.Point(287, 69);
            this.nome_animal.Name = "nome_animal";
            this.nome_animal.Size = new System.Drawing.Size(65, 20);
            this.nome_animal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // data_nasc_animal
            // 
            this.data_nasc_animal.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nasc_animal.Location = new System.Drawing.Point(361, 71);
            this.data_nasc_animal.Name = "data_nasc_animal";
            this.data_nasc_animal.Size = new System.Drawing.Size(85, 20);
            this.data_nasc_animal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Espécie";
            // 
            // Raça
            // 
            this.Raça.AutoSize = true;
            this.Raça.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raça.Location = new System.Drawing.Point(322, 105);
            this.Raça.Name = "Raça";
            this.Raça.Size = new System.Drawing.Size(31, 13);
            this.Raça.TabIndex = 13;
            this.Raça.Text = "Raça";
            // 
            // raca_animal
            // 
            this.raca_animal.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_animal.Location = new System.Drawing.Point(325, 121);
            this.raca_animal.Name = "raca_animal";
            this.raca_animal.Size = new System.Drawing.Size(121, 20);
            this.raca_animal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pelagem";
            // 
            // pelagem_animal
            // 
            this.pelagem_animal.FormattingEnabled = true;
            this.pelagem_animal.Items.AddRange(new object[] {
            "Nenhuma",
            "Curta",
            "Média",
            "Longa"});
            this.pelagem_animal.Location = new System.Drawing.Point(191, 173);
            this.pelagem_animal.Name = "pelagem_animal";
            this.pelagem_animal.Size = new System.Drawing.Size(121, 21);
            this.pelagem_animal.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "VOLTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cadastrar_animal
            // 
            this.cadastrar_animal.FlatAppearance.BorderSize = 0;
            this.cadastrar_animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar_animal.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar_animal.Image = ((System.Drawing.Image)(resources.GetObject("cadastrar_animal.Image")));
            this.cadastrar_animal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar_animal.Location = new System.Drawing.Point(12, 158);
            this.cadastrar_animal.Name = "cadastrar_animal";
            this.cadastrar_animal.Size = new System.Drawing.Size(140, 37);
            this.cadastrar_animal.TabIndex = 8;
            this.cadastrar_animal.Text = "CADASTRAR";
            this.cadastrar_animal.UseVisualStyleBackColor = true;
            this.cadastrar_animal.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // especie_animal
            // 
            this.especie_animal.FormattingEnabled = true;
            this.especie_animal.Items.AddRange(new object[] {
            "Canina ",
            "Felina"});
            this.especie_animal.Location = new System.Drawing.Point(191, 122);
            this.especie_animal.Name = "especie_animal";
            this.especie_animal.Size = new System.Drawing.Size(121, 21);
            this.especie_animal.TabIndex = 4;
            // 
            // sexo_animal
            // 
            this.sexo_animal.FormattingEnabled = true;
            this.sexo_animal.Items.AddRange(new object[] {
            "Fêmea",
            "Macho"});
            this.sexo_animal.Location = new System.Drawing.Point(325, 172);
            this.sexo_animal.Name = "sexo_animal";
            this.sexo_animal.Size = new System.Drawing.Size(121, 21);
            this.sexo_animal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sexo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.pet_folder_file_document_page_icon_124627;
            this.pictureBox2.Location = new System.Drawing.Point(233, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 116);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cLIENTEBindingSource;
            this.comboBox1.DisplayMember = "Nome_cli";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "Codigo_cli";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.cLINICA_VETERINARIADataSet;
            // 
            // cLINICA_VETERINARIADataSet
            // 
            this.cLINICA_VETERINARIADataSet.DataSetName = "CLINICA_VETERINARIADataSet";
            this.cLINICA_VETERINARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 362);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sexo_animal);
            this.Controls.Add(this.especie_animal);
            this.Controls.Add(this.pelagem_animal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.raca_animal);
            this.Controls.Add(this.Raça);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_nasc_animal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_animal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrar_animal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro Animal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLINICA_VETERINARIADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadastrar_animal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_animal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_nasc_animal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Raça;
        private System.Windows.Forms.TextBox raca_animal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pelagem_animal;
        private System.Windows.Forms.ComboBox especie_animal;
        private System.Windows.Forms.ComboBox sexo_animal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private CLINICA_VETERINARIADataSet cLINICA_VETERINARIADataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private CLINICA_VETERINARIADataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
    }
}