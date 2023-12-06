namespace AcademiaDotNet_WFMiniERP
{
    partial class FormProduto
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
            components = new System.ComponentModel.Container();
            textBox_Consultar = new TextBox();
            groupBox_Cadastro = new GroupBox();
            numericUpDown_QuantidadeEstoque = new NumericUpDown();
            textBox_Preco = new TextBox();
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            label_Preco = new Label();
            label_QuantidadeEstoque = new Label();
            label_Fornecedor = new Label();
            comboBox_Fornecedor = new ComboBox();
            button_LimparCampos = new Button();
            button_Cadastrar = new Button();
            button_Consultar = new Button();
            dataGridView_Produtos = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Preco = new DataGridViewTextBoxColumn();
            Column_FornecedorID = new DataGridViewTextBoxColumn();
            Column_Excluir = new DataGridViewButtonColumn();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QuantidadeEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            SuspendLayout();
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(12, 12);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(917, 23);
            textBox_Consultar.TabIndex = 15;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(numericUpDown_QuantidadeEstoque);
            groupBox_Cadastro.Controls.Add(textBox_Preco);
            groupBox_Cadastro.Controls.Add(label_Nome);
            groupBox_Cadastro.Controls.Add(textBox_Nome);
            groupBox_Cadastro.Controls.Add(label_Preco);
            groupBox_Cadastro.Controls.Add(label_QuantidadeEstoque);
            groupBox_Cadastro.Controls.Add(label_Fornecedor);
            groupBox_Cadastro.Controls.Add(comboBox_Fornecedor);
            groupBox_Cadastro.Controls.Add(button_LimparCampos);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Location = new Point(1007, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(245, 312);
            groupBox_Cadastro.TabIndex = 14;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // numericUpDown_QuantidadeEstoque
            // 
            numericUpDown_QuantidadeEstoque.Location = new Point(6, 166);
            numericUpDown_QuantidadeEstoque.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown_QuantidadeEstoque.Name = "numericUpDown_QuantidadeEstoque";
            numericUpDown_QuantidadeEstoque.Size = new Size(120, 23);
            numericUpDown_QuantidadeEstoque.TabIndex = 20;
            // 
            // textBox_Preco
            // 
            textBox_Preco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Preco.Location = new Point(6, 103);
            textBox_Preco.Name = "textBox_Preco";
            textBox_Preco.Size = new Size(233, 23);
            textBox_Preco.TabIndex = 19;
            textBox_Preco.Leave += textBox_Preco_Leave;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(14, 25);
            label_Nome.Margin = new Padding(14, 25, 14, 20);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(40, 15);
            label_Nome.TabIndex = 5;
            label_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Nome.Location = new Point(6, 45);
            textBox_Nome.Margin = new Padding(3, 20, 3, 20);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(233, 23);
            textBox_Nome.TabIndex = 4;
            // 
            // label_Preco
            // 
            label_Preco.AutoSize = true;
            label_Preco.Location = new Point(14, 85);
            label_Preco.Name = "label_Preco";
            label_Preco.Size = new Size(37, 15);
            label_Preco.TabIndex = 3;
            label_Preco.Text = "Preço";
            // 
            // label_QuantidadeEstoque
            // 
            label_QuantidadeEstoque.AutoSize = true;
            label_QuantidadeEstoque.Location = new Point(14, 145);
            label_QuantidadeEstoque.Name = "label_QuantidadeEstoque";
            label_QuantidadeEstoque.Size = new Size(114, 15);
            label_QuantidadeEstoque.TabIndex = 16;
            label_QuantidadeEstoque.Text = "Quantidade Estoque";
            // 
            // label_Fornecedor
            // 
            label_Fornecedor.AutoSize = true;
            label_Fornecedor.Location = new Point(14, 205);
            label_Fornecedor.Name = "label_Fornecedor";
            label_Fornecedor.Size = new Size(67, 15);
            label_Fornecedor.TabIndex = 14;
            label_Fornecedor.Text = "Fornecedor";
            // 
            // comboBox_Fornecedor
            // 
            comboBox_Fornecedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Fornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Fornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Fornecedor.FormattingEnabled = true;
            comboBox_Fornecedor.Location = new Point(6, 225);
            comboBox_Fornecedor.Name = "comboBox_Fornecedor";
            comboBox_Fornecedor.Size = new Size(233, 23);
            comboBox_Fornecedor.TabIndex = 13;
            // 
            // button_LimparCampos
            // 
            button_LimparCampos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_LimparCampos.Image = Properties.Resources.broom_black;
            button_LimparCampos.Location = new Point(6, 266);
            button_LimparCampos.Name = "button_LimparCampos";
            button_LimparCampos.Size = new Size(100, 40);
            button_LimparCampos.TabIndex = 18;
            button_LimparCampos.Text = "Limpar Campos";
            button_LimparCampos.TextAlign = ContentAlignment.MiddleRight;
            button_LimparCampos.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_LimparCampos.UseVisualStyleBackColor = true;
            button_LimparCampos.Click += button_LimparCampos_Click;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cadastrar.Image = Properties.Resources.add_user_male_black;
            button_Cadastrar.Location = new Point(123, 266);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(116, 40);
            button_Cadastrar.TabIndex = 17;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.TextAlign = ContentAlignment.MiddleRight;
            button_Cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // button_Consultar
            // 
            button_Consultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Consultar.Image = Properties.Resources.search_black;
            button_Consultar.Location = new Point(821, 41);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(108, 40);
            button_Consultar.TabIndex = 19;
            button_Consultar.Text = "Consultar";
            button_Consultar.TextAlign = ContentAlignment.MiddleRight;
            button_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.BackgroundColor = SystemColors.ControlLight;
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Nome, Column_Preco, Column_FornecedorID, Column_Excluir });
            dataGridView_Produtos.Location = new Point(12, 87);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.Size = new Size(917, 666);
            dataGridView_Produtos.TabIndex = 20;
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_Nome
            // 
            Column_Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_Nome.DataPropertyName = "Nome";
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            Column_Nome.Width = 65;
            // 
            // Column_Preco
            // 
            Column_Preco.DataPropertyName = "Preco";
            Column_Preco.HeaderText = "Preço";
            Column_Preco.Name = "Column_Preco";
            // 
            // Column_FornecedorID
            // 
            Column_FornecedorID.DataPropertyName = "FornecedorID";
            Column_FornecedorID.HeaderText = "Fornecedor";
            Column_FornecedorID.Name = "Column_FornecedorID";
            // 
            // Column_Excluir
            // 
            Column_Excluir.HeaderText = "Excluir";
            Column_Excluir.Name = "Column_Excluir";
            Column_Excluir.Resizable = DataGridViewTriState.True;
            Column_Excluir.SortMode = DataGridViewColumnSortMode.Automatic;
            Column_Excluir.Text = "Excluir";
            Column_Excluir.UseColumnTextForButtonValue = true;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 761);
            Controls.Add(dataGridView_Produtos);
            Controls.Add(textBox_Consultar);
            Controls.Add(button_Consultar);
            Controls.Add(groupBox_Cadastro);
            Name = "FormProduto";
            Text = "FormProduto";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_QuantidadeEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Consultar;
        private GroupBox groupBox_Cadastro;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Label label_Preco;
        private Label label_QuantidadeEstoque;
        private Label label_Fornecedor;
        private ComboBox comboBox_Fornecedor;
        private Button button_Consultar;
        private Button button_LimparCampos;
        private Button button_Cadastrar;
        private TextBox textBox_Preco;
        private NumericUpDown numericUpDown_QuantidadeEstoque;
        private DataGridView dataGridView_Produtos;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Preco;
        private DataGridViewTextBoxColumn Column_FornecedorID;
        private DataGridViewButtonColumn Column_Excluir;
    }
}