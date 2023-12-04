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
            button_Produtos = new Button();
            button_Fornecedores = new Button();
            comboBox_Clientes = new ComboBox();
            label_Cliente = new Label();
            numericUpDown_Quantidade = new NumericUpDown();
            label_Produto = new Label();
            button_Adicionar = new Button();
            dataGridView_Itens = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Preco = new DataGridViewTextBoxColumn();
            Column_Quantidade = new DataGridViewTextBoxColumn();
            Column_ValorTotal = new DataGridViewTextBoxColumn();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Itens).BeginInit();
            SuspendLayout();
            // 
            // button_Notas
            // 
            button_Notas.Location = new Point(1137, 616);
            button_Notas.Name = "button_Notas";
            button_Notas.Size = new Size(95, 95);
            button_Notas.TabIndex = 35;
            button_Notas.Text = "Notas";
            button_Notas.UseVisualStyleBackColor = true;
            button_Notas.Click += button_Notas_Click;
            // 
            // button_EmitirNota
            // 
            button_EmitirNota.Location = new Point(993, 726);
            button_EmitirNota.Name = "button_EmitirNota";
            button_EmitirNota.Size = new Size(75, 23);
            button_EmitirNota.TabIndex = 33;
            button_EmitirNota.Text = "Emitir Nota";
            button_EmitirNota.UseVisualStyleBackColor = true;
            // 
            // comboBox_Produtos
            // 
            comboBox_Produtos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Produtos.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Produtos.FormattingEnabled = true;
            comboBox_Produtos.Location = new Point(397, 13);
            comboBox_Produtos.Name = "comboBox_Produtos";
            comboBox_Produtos.Size = new Size(299, 23);
            comboBox_Produtos.TabIndex = 32;
            // 
            // button_AtualizarClientes
            // 
            button_AtualizarClientes.Location = new Point(947, 10);
            button_AtualizarClientes.Name = "button_AtualizarClientes";
            button_AtualizarClientes.Size = new Size(121, 23);
            button_AtualizarClientes.TabIndex = 31;
            button_AtualizarClientes.Text = "Atualizar Listas";
            button_AtualizarClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(button_Clientes);
            groupBox_Cadastro.Controls.Add(button_Produtos);
            groupBox_Cadastro.Controls.Add(button_Fornecedores);
            groupBox_Cadastro.Location = new Point(1112, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(140, 160);
            groupBox_Cadastro.TabIndex = 30;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastros";
            // 
            // button_Clientes
            // 
            button_Clientes.Anchor = AnchorStyles.Top;
            button_Clientes.Location = new Point(25, 29);
            button_Clientes.Margin = new Padding(10);
            button_Clientes.Name = "button_Clientes";
            button_Clientes.Size = new Size(95, 25);
            button_Clientes.TabIndex = 12;
            button_Clientes.Text = "Clientes";
            button_Clientes.UseVisualStyleBackColor = true;
            button_Clientes.Click += button_Clientes_Click;
            // 
            // button_Produtos
            // 
            button_Produtos.Anchor = AnchorStyles.Bottom;
            button_Produtos.Location = new Point(25, 122);
            button_Produtos.Margin = new Padding(10);
            button_Produtos.Name = "button_Produtos";
            button_Produtos.Size = new Size(95, 25);
            button_Produtos.TabIndex = 13;
            button_Produtos.Text = "Produtos";
            button_Produtos.UseVisualStyleBackColor = true;
            button_Produtos.Click += button_Produtos_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Anchor = AnchorStyles.None;
            button_Fornecedores.Location = new Point(25, 76);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(95, 25);
            button_Fornecedores.TabIndex = 14;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button_Fornecedores_Click;
            // 
            // comboBox_Clientes
            // 
            comboBox_Clientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_Clientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Clientes.FormattingEnabled = true;
            comboBox_Clientes.Location = new Point(64, 12);
            comboBox_Clientes.Name = "comboBox_Clientes";
            comboBox_Clientes.Size = new Size(176, 23);
            comboBox_Clientes.TabIndex = 29;
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(11, 15);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(47, 15);
            label_Cliente.TabIndex = 28;
            label_Cliente.Text = "Cliente:";
            // 
            // numericUpDown_Quantidade
            // 
            numericUpDown_Quantidade.Location = new Point(702, 13);
            numericUpDown_Quantidade.Name = "numericUpDown_Quantidade";
            numericUpDown_Quantidade.Size = new Size(83, 23);
            numericUpDown_Quantidade.TabIndex = 34;
            numericUpDown_Quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_Produto
            // 
            label_Produto.AutoSize = true;
            label_Produto.Location = new Point(336, 16);
            label_Produto.Name = "label_Produto";
            label_Produto.Size = new Size(55, 15);
            label_Produto.TabIndex = 27;
            label_Produto.Text = "Produtos";
            // 
            // button_Adicionar
            // 
            button_Adicionar.FlatStyle = FlatStyle.System;
            button_Adicionar.Location = new Point(818, 10);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(75, 23);
            button_Adicionar.TabIndex = 26;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Itens
            // 
            dataGridView_Itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Itens.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Nome, Column_Preco, Column_Quantidade, Column_ValorTotal });
            dataGridView_Itens.Location = new Point(11, 41);
            dataGridView_Itens.Name = "dataGridView_Itens";
            dataGridView_Itens.RowTemplate.Height = 25;
            dataGridView_Itens.Size = new Size(1057, 679);
            dataGridView_Itens.TabIndex = 25;
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.Visible = false;
            // 
            // Column_Nome
            // 
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            // 
            // Column_Preco
            // 
            Column_Preco.HeaderText = "Preço";
            Column_Preco.Name = "Column_Preco";
            // 
            // Column_Quantidade
            // 
            Column_Quantidade.HeaderText = "Quantidade";
            Column_Quantidade.Name = "Column_Quantidade";
            // 
            // Column_ValorTotal
            // 
            Column_ValorTotal.HeaderText = "Valor Total";
            Column_ValorTotal.Name = "Column_ValorTotal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Button button_Adicionar;
        private DataGridView dataGridView_Itens;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Preco;
        private DataGridViewTextBoxColumn Column_Quantidade;
        private DataGridViewTextBoxColumn Column_ValorTotal;
    }
}
