namespace AcademiaDotNet_WFMiniERP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Notas = new Button();
            button_EmitirNota = new Button();
            comboBox_Produtos = new ComboBox();
            button_AtualizarClientes = new Button();
            groupBox_Cadastro = new GroupBox();
            button_Clientes = new Button();
            button_Fornecedores = new Button();
            button_Produtos = new Button();
            comboBox_Clientes = new ComboBox();
            label_Cliente = new Label();
            numericUpDown_Quantidade = new NumericUpDown();
            label_Produto = new Label();
            dataGridView_Itens = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_ProdutoID = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Preco = new DataGridViewTextBoxColumn();
            Column_Quantidade = new DataGridViewTextBoxColumn();
            Column_ValorTotal = new DataGridViewTextBoxColumn();
            button_Adicionar = new Button();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Itens).BeginInit();
            SuspendLayout();
            // 
            // button_Notas
            // 
            button_Notas.Image = Properties.Resources.invoice_black;
            button_Notas.Location = new Point(1128, 617);
            button_Notas.Name = "button_Notas";
            button_Notas.Size = new Size(81, 83);
            button_Notas.TabIndex = 11;
            button_Notas.Text = "Visualizar Notas";
            button_Notas.TextAlign = ContentAlignment.BottomCenter;
            button_Notas.TextImageRelation = TextImageRelation.ImageAboveText;
            button_Notas.UseVisualStyleBackColor = true;
            button_Notas.Click += button_Notas_Click;
            // 
            // button_EmitirNota
            // 
            button_EmitirNota.Image = Properties.Resources.billing_machine_black;
            button_EmitirNota.Location = new Point(915, 709);
            button_EmitirNota.Name = "button_EmitirNota";
            button_EmitirNota.Size = new Size(121, 40);
            button_EmitirNota.TabIndex = 7;
            button_EmitirNota.Text = "Emitir Nota";
            button_EmitirNota.TextAlign = ContentAlignment.MiddleRight;
            button_EmitirNota.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_EmitirNota.UseVisualStyleBackColor = true;
            button_EmitirNota.Click += button_EmitirNota_Click;
            // 
            // comboBox_Produtos
            // 
            comboBox_Produtos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Produtos.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Produtos.FormattingEnabled = true;
            comboBox_Produtos.Location = new Point(333, 24);
            comboBox_Produtos.Name = "comboBox_Produtos";
            comboBox_Produtos.Size = new Size(299, 23);
            comboBox_Produtos.TabIndex = 2;
            // 
            // button_AtualizarClientes
            // 
            button_AtualizarClientes.Image = Properties.Resources.sync_black;
            button_AtualizarClientes.Location = new Point(894, 14);
            button_AtualizarClientes.Name = "button_AtualizarClientes";
            button_AtualizarClientes.Size = new Size(142, 40);
            button_AtualizarClientes.TabIndex = 5;
            button_AtualizarClientes.Text = "Atualizar Listas";
            button_AtualizarClientes.TextAlign = ContentAlignment.MiddleRight;
            button_AtualizarClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_AtualizarClientes.UseVisualStyleBackColor = true;
            button_AtualizarClientes.Click += button_AtualizarClientes_Click;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(button_Clientes);
            groupBox_Cadastro.Controls.Add(button_Fornecedores);
            groupBox_Cadastro.Controls.Add(button_Produtos);
            groupBox_Cadastro.Location = new Point(1082, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(170, 219);
            groupBox_Cadastro.TabIndex = 30;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastros";
            // 
            // button_Clientes
            // 
            button_Clientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Clientes.BackgroundImageLayout = ImageLayout.None;
            button_Clientes.ForeColor = SystemColors.ControlText;
            button_Clientes.Image = Properties.Resources.user_male_black;
            button_Clientes.Location = new Point(25, 29);
            button_Clientes.Margin = new Padding(10);
            button_Clientes.Name = "button_Clientes";
            button_Clientes.Size = new Size(125, 45);
            button_Clientes.TabIndex = 8;
            button_Clientes.Text = "Clientes";
            button_Clientes.TextAlign = ContentAlignment.MiddleRight;
            button_Clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Clientes.UseVisualStyleBackColor = true;
            button_Clientes.Click += button_Clientes_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button_Fornecedores.Image = Properties.Resources.company_black;
            button_Fornecedores.Location = new Point(25, 95);
            button_Fornecedores.Margin = new Padding(10);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(125, 45);
            button_Fornecedores.TabIndex = 9;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.TextAlign = ContentAlignment.MiddleRight;
            button_Fornecedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // button_Produtos
            // 
            button_Produtos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Produtos.Image = Properties.Resources.product_black;
            button_Produtos.Location = new Point(25, 161);
            button_Produtos.Margin = new Padding(10);
            button_Produtos.Name = "button_Produtos";
            button_Produtos.Size = new Size(125, 45);
            button_Produtos.TabIndex = 10;
            button_Produtos.Text = "Produtos";
            button_Produtos.TextAlign = ContentAlignment.MiddleRight;
            button_Produtos.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Produtos.UseVisualStyleBackColor = true;
            button_Produtos.Click += button_Produtos_Click;
            // 
            // comboBox_Clientes
            // 
            comboBox_Clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Clientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Clientes.FormattingEnabled = true;
            comboBox_Clientes.Location = new Point(81, 24);
            comboBox_Clientes.Name = "comboBox_Clientes";
            comboBox_Clientes.Size = new Size(176, 23);
            comboBox_Clientes.TabIndex = 1;
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(28, 27);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(47, 15);
            label_Cliente.TabIndex = 28;
            label_Cliente.Text = "Cliente:";
            // 
            // numericUpDown_Quantidade
            // 
            numericUpDown_Quantidade.Location = new Point(638, 24);
            numericUpDown_Quantidade.Name = "numericUpDown_Quantidade";
            numericUpDown_Quantidade.Size = new Size(83, 23);
            numericUpDown_Quantidade.TabIndex = 3;
            numericUpDown_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Location = new Point(272, 27);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(55, 15);
            label_Produto.TabIndex = 27;
            label_Produto.Text = "Produtos";
            // 
            // dataGridView_Itens
            // 
            dataGridView_Itens.AllowUserToAddRows = false;
            dataGridView_Itens.BackgroundColor = SystemColors.ControlLight;
            dataGridView_Itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Itens.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_ProdutoID, Column_Nome, Column_Preco, Column_Quantidade, Column_ValorTotal });
            dataGridView_Itens.Location = new Point(11, 64);
            dataGridView_Itens.Name = "dataGridView_Itens";
            dataGridView_Itens.RowTemplate.Height = 25;
            dataGridView_Itens.Size = new Size(1025, 636);
            dataGridView_Itens.TabIndex = 6;
            // 
            // Column_ID
            // 
            Column_ID.DataPropertyName = "ID";
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_ProdutoID
            // 
            Column_ProdutoID.HeaderText = "ProdutoID";
            Column_ProdutoID.Name = "Column_ProdutoID";
            // 
            // Column_Nome
            // 
            Column_Nome.DataPropertyName = "Nome";
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            // 
            // Column_Preco
            // 
            Column_Preco.DataPropertyName = "Preco";
            Column_Preco.HeaderText = "Preço";
            Column_Preco.Name = "Column_Preco";
            // 
            // Column_Quantidade
            // 
            Column_Quantidade.DataPropertyName = "Quantidade";
            Column_Quantidade.HeaderText = "Quantidade";
            Column_Quantidade.Name = "Column_Quantidade";
            // 
            // Column_ValorTotal
            // 
            Column_ValorTotal.HeaderText = "Valor Total";
            Column_ValorTotal.Name = "Column_ValorTotal";
            // 
            // button_Adicionar
            // 
            button_Adicionar.Image = Properties.Resources.add_shopping_cart_black;
            button_Adicionar.Location = new Point(761, 14);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(115, 40);
            button_Adicionar.TabIndex = 4;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.TextAlign = ContentAlignment.MiddleRight;
            button_Adicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Adicionar.UseVisualStyleBackColor = true;
            button_Adicionar.Click += button_Adicionar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 761);
            Controls.Add(label_Cliente);
            Controls.Add(comboBox_Clientes);
            Controls.Add(label_Produto);
            Controls.Add(comboBox_Produtos);
            Controls.Add(numericUpDown_Quantidade);
            Controls.Add(button_Adicionar);
            Controls.Add(button_AtualizarClientes);
            Controls.Add(dataGridView_Itens);
            Controls.Add(button_EmitirNota);
            Controls.Add(groupBox_Cadastro);
            Controls.Add(button_Notas);
            Name = "Form1";
            Text = "Form1";
            groupBox_Cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Itens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Notas;
        private Button button_EmitirNota;
        private ComboBox comboBox_Produtos;
        private Button button_AtualizarClientes;
        private GroupBox groupBox_Cadastro;
        private Button button_Clientes;
        private Button button_Produtos;
        private Button button_Fornecedores;
        private ComboBox comboBox_Clientes;
        private Label label_Cliente;
        private NumericUpDown numericUpDown_Quantidade;
        private Label label_Produto;
        private DataGridView dataGridView_Itens;
        private Button button_Adicionar;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_ProdutoID;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Preco;
        private DataGridViewTextBoxColumn Column_Quantidade;
        private DataGridViewTextBoxColumn Column_ValorTotal;
    }
}
