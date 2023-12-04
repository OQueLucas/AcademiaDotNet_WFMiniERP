namespace AcademiaDotNet_WFMiniERP
{
    partial class FormFornecedor
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
            button_Consultar = new Button();
            textBox_Consultar = new TextBox();
            groupBox_Cadastro = new GroupBox();
            textBox_RazaoSocial = new TextBox();
            label_CNPJ = new Label();
            button_Cadastrar = new Button();
            dataGridView_Fornecedores = new DataGridView();
            maskedTextBox_CPF = new MaskedTextBox();
            label_RazaoSocial = new Label();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_CNPJ = new DataGridViewTextBoxColumn();
            Column_RazaoSocial = new DataGridViewTextBoxColumn();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            SuspendLayout();
            // 
            // button_Consultar
            // 
            button_Consultar.FlatStyle = FlatStyle.System;
            button_Consultar.Location = new Point(854, 41);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(75, 23);
            button_Consultar.TabIndex = 8;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(12, 12);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(917, 23);
            textBox_Consultar.TabIndex = 7;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(label_CNPJ);
            groupBox_Cadastro.Controls.Add(maskedTextBox_CPF);
            groupBox_Cadastro.Controls.Add(label_RazaoSocial);
            groupBox_Cadastro.Controls.Add(textBox_RazaoSocial);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Location = new Point(1052, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(200, 173);
            groupBox_Cadastro.TabIndex = 6;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // textBox_RazaoSocial
            // 
            textBox_RazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_RazaoSocial.Location = new Point(6, 105);
            textBox_RazaoSocial.Name = "textBox_RazaoSocial";
            textBox_RazaoSocial.Size = new Size(188, 23);
            textBox_RazaoSocial.TabIndex = 4;
            // 
            // label_CNPJ
            // 
            label_CNPJ.AutoSize = true;
            label_CNPJ.Location = new Point(14, 25);
            label_CNPJ.Name = "label_CNPJ";
            label_CNPJ.Size = new Size(34, 15);
            label_CNPJ.TabIndex = 3;
            label_CNPJ.Text = "CNPJ";
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cadastrar.Location = new Point(119, 144);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 1;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_CNPJ, Column_RazaoSocial });
            dataGridView_Fornecedores.Location = new Point(12, 83);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.RowTemplate.Height = 25;
            dataGridView_Fornecedores.Size = new Size(917, 666);
            dataGridView_Fornecedores.TabIndex = 5;
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_CPF.Location = new Point(6, 45);
            maskedTextBox_CPF.Mask = "00,000,000/0000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(188, 23);
            maskedTextBox_CPF.TabIndex = 13;
            // 
            // label_RazaoSocial
            // 
            label_RazaoSocial.AutoSize = true;
            label_RazaoSocial.Location = new Point(14, 85);
            label_RazaoSocial.Name = "label_RazaoSocial";
            label_RazaoSocial.Size = new Size(72, 15);
            label_RazaoSocial.TabIndex = 5;
            label_RazaoSocial.Text = "Razão Social";
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_CNPJ
            // 
            Column_CNPJ.HeaderText = "CNPJ";
            Column_CNPJ.Name = "Column_CNPJ";
            // 
            // Column_RazaoSocial
            // 
            Column_RazaoSocial.HeaderText = "Razão Social";
            Column_RazaoSocial.Name = "Column_RazaoSocial";
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(textBox_Consultar);
            Controls.Add(button_Consultar);
            Controls.Add(dataGridView_Fornecedores);
            Controls.Add(groupBox_Cadastro);
            Name = "FormFornecedor";
            Text = "FormFornecedor";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Consultar;
        private TextBox textBox_Consultar;
        private GroupBox groupBox_Cadastro;
        private TextBox textBox_RazaoSocial;
        private Label label_CNPJ;
        private Button button_Cadastrar;
        private DataGridView dataGridView_Fornecedores;
        private MaskedTextBox maskedTextBox_CPF;
        private Label label_RazaoSocial;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_CNPJ;
        private DataGridViewTextBoxColumn Column_RazaoSocial;
    }
}