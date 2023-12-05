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
            textBox_Consultar = new TextBox();
            groupBox_Cadastro = new GroupBox();
            label_CNPJ = new Label();
            button_LimparCampos = new Button();
            maskedTextBox_CNPJ = new MaskedTextBox();
            button_Cadastrar = new Button();
            label_RazaoSocial = new Label();
            textBox_RazaoSocial = new TextBox();
            dataGridView_Fornecedores = new DataGridView();
            button_Consultar = new Button();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_CNPJ = new DataGridViewTextBoxColumn();
            Column_RazaoSocial = new DataGridViewTextBoxColumn();
            Column_Excluir = new DataGridViewButtonColumn();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            SuspendLayout();
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
            groupBox_Cadastro.Controls.Add(button_LimparCampos);
            groupBox_Cadastro.Controls.Add(maskedTextBox_CNPJ);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Controls.Add(label_RazaoSocial);
            groupBox_Cadastro.Controls.Add(textBox_RazaoSocial);
            groupBox_Cadastro.Location = new Point(1007, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(245, 207);
            groupBox_Cadastro.TabIndex = 6;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
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
            // button_LimparCampos
            // 
            button_LimparCampos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_LimparCampos.Image = Properties.Resources.broom_black;
            button_LimparCampos.Location = new Point(6, 161);
            button_LimparCampos.Name = "button_LimparCampos";
            button_LimparCampos.Size = new Size(100, 40);
            button_LimparCampos.TabIndex = 15;
            button_LimparCampos.Text = "Limpar Campos";
            button_LimparCampos.TextAlign = ContentAlignment.MiddleRight;
            button_LimparCampos.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_LimparCampos.UseVisualStyleBackColor = true;
            button_LimparCampos.Click += button_LimparCampos_Click_1;
            // 
            // maskedTextBox_CNPJ
            // 
            maskedTextBox_CNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_CNPJ.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBox_CNPJ.Location = new Point(6, 45);
            maskedTextBox_CNPJ.Mask = "00,000,000/0000-00";
            maskedTextBox_CNPJ.Name = "maskedTextBox_CNPJ";
            maskedTextBox_CNPJ.Size = new Size(233, 23);
            maskedTextBox_CNPJ.TabIndex = 13;
            maskedTextBox_CNPJ.Enter += maskedTextBox_CNPJ_Enter;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cadastrar.Image = Properties.Resources.add_user_male_black;
            button_Cadastrar.Location = new Point(123, 161);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(116, 40);
            button_Cadastrar.TabIndex = 14;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.TextAlign = ContentAlignment.MiddleRight;
            button_Cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
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
            // textBox_RazaoSocial
            // 
            textBox_RazaoSocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_RazaoSocial.Location = new Point(6, 105);
            textBox_RazaoSocial.Name = "textBox_RazaoSocial";
            textBox_RazaoSocial.Size = new Size(233, 23);
            textBox_RazaoSocial.TabIndex = 4;
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.BackgroundColor = SystemColors.ControlLight;
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_CNPJ, Column_RazaoSocial, Column_Excluir });
            dataGridView_Fornecedores.Location = new Point(12, 83);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.RowTemplate.Height = 25;
            dataGridView_Fornecedores.Size = new Size(917, 666);
            dataGridView_Fornecedores.TabIndex = 5;
            dataGridView_Fornecedores.CellClick += dataGridView_Fornecedores_CellClick;
            // 
            // button_Consultar
            // 
            button_Consultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Consultar.Image = Properties.Resources.search_black;
            button_Consultar.Location = new Point(821, 41);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(108, 40);
            button_Consultar.TabIndex = 16;
            button_Consultar.Text = "Consultar";
            button_Consultar.TextAlign = ContentAlignment.MiddleRight;
            button_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_CNPJ
            // 
            Column_CNPJ.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_CNPJ.DataPropertyName = "CNPJ";
            Column_CNPJ.HeaderText = "CNPJ";
            Column_CNPJ.Name = "Column_CNPJ";
            Column_CNPJ.Width = 59;
            // 
            // Column_RazaoSocial
            // 
            Column_RazaoSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_RazaoSocial.DataPropertyName = "RazaoSocial";
            Column_RazaoSocial.HeaderText = "Razão Social";
            Column_RazaoSocial.Name = "Column_RazaoSocial";
            Column_RazaoSocial.Width = 97;
            // 
            // Column_Excluir
            // 
            Column_Excluir.HeaderText = "Excluir";
            Column_Excluir.Text = "Excluir";
            Column_Excluir.Name = "Column_Excluir";
            Column_Excluir.UseColumnTextForButtonValue = true;
            Column_Excluir.Resizable = DataGridViewTriState.True;
            Column_Excluir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 761);
            Controls.Add(button_Consultar);
            Controls.Add(textBox_Consultar);
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
        private TextBox textBox_Consultar;
        private GroupBox groupBox_Cadastro;
        private TextBox textBox_RazaoSocial;
        private Label label_CNPJ;
        private Button button_Cadastrar;
        private DataGridView dataGridView_Fornecedores;
        private MaskedTextBox maskedTextBox_CNPJ;
        private Label label_RazaoSocial;
        private Button button_Consultar;
        private Button button_LimparCampos;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_CNPJ;
        private DataGridViewTextBoxColumn Column_RazaoSocial;
        private DataGridViewButtonColumn Column_Excluir;
    }
}