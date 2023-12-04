﻿namespace AcademiaDotNet_WFMiniERP
{
    partial class FormCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox_Cadastro = new GroupBox();
            label_CPF = new Label();
            maskedTextBox_CPF = new MaskedTextBox();
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            label_Email = new Label();
            textBox_Email = new TextBox();
            button_LimparCampos = new Button();
            button_Cadastrar = new Button();
            button_Consultar = new Button();
            textBox_Consultar = new TextBox();
            dataGridView_Clientes = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_CPF = new DataGridViewTextBoxColumn();
            Column_Nome = new DataGridViewTextBoxColumn();
            Column_Email = new DataGridViewTextBoxColumn();
            Column_Excluir = new DataGridViewButtonColumn();
            groupBox_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Cadastro
            // 
            groupBox_Cadastro.Controls.Add(label_CPF);
            groupBox_Cadastro.Controls.Add(maskedTextBox_CPF);
            groupBox_Cadastro.Controls.Add(label_Nome);
            groupBox_Cadastro.Controls.Add(textBox_Nome);
            groupBox_Cadastro.Controls.Add(label_Email);
            groupBox_Cadastro.Controls.Add(textBox_Email);
            groupBox_Cadastro.Controls.Add(button_LimparCampos);
            groupBox_Cadastro.Controls.Add(button_Cadastrar);
            groupBox_Cadastro.Location = new Point(1052, 12);
            groupBox_Cadastro.Name = "groupBox_Cadastro";
            groupBox_Cadastro.Size = new Size(200, 238);
            groupBox_Cadastro.TabIndex = 7;
            groupBox_Cadastro.TabStop = false;
            groupBox_Cadastro.Text = "Cadastro";
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Location = new Point(14, 25);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(28, 15);
            label_CPF.TabIndex = 3;
            label_CPF.Text = "CPF";
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_CPF.Location = new Point(6, 45);
            maskedTextBox_CPF.Mask = "000,000,000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(188, 23);
            maskedTextBox_CPF.TabIndex = 12;
            maskedTextBox_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(14, 85);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(40, 15);
            label_Nome.TabIndex = 5;
            label_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Nome.Location = new Point(6, 105);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(188, 23);
            textBox_Nome.TabIndex = 4;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(14, 145);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(36, 15);
            label_Email.TabIndex = 7;
            label_Email.Text = "Email";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Email.Location = new Point(6, 165);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(188, 23);
            textBox_Email.TabIndex = 6;
            // 
            // button_LimparCampos
            // 
            button_LimparCampos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_LimparCampos.Location = new Point(6, 209);
            button_LimparCampos.Name = "button_LimparCampos";
            button_LimparCampos.Size = new Size(101, 23);
            button_LimparCampos.TabIndex = 10;
            button_LimparCampos.Text = "Limpar Campos";
            button_LimparCampos.UseVisualStyleBackColor = true;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Cadastrar.Location = new Point(119, 207);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 25);
            button_Cadastrar.TabIndex = 1;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // button_Consultar
            // 
            button_Consultar.FlatStyle = FlatStyle.System;
            button_Consultar.Location = new Point(854, 41);
            button_Consultar.Name = "button_Consultar";
            button_Consultar.Size = new Size(75, 23);
            button_Consultar.TabIndex = 11;
            button_Consultar.Text = "Consultar";
            button_Consultar.UseVisualStyleBackColor = true;
            // 
            // textBox_Consultar
            // 
            textBox_Consultar.Location = new Point(12, 12);
            textBox_Consultar.Name = "textBox_Consultar";
            textBox_Consultar.Size = new Size(917, 23);
            textBox_Consultar.TabIndex = 10;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_CPF, Column_Nome, Column_Email, Column_Excluir });
            dataGridView_Clientes.Location = new Point(12, 83);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(917, 666);
            dataGridView_Clientes.TabIndex = 9;
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.ReadOnly = true;
            Column_ID.Visible = false;
            // 
            // Column_CPF
            // 
            Column_CPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_CPF.HeaderText = "CPF";
            Column_CPF.Name = "Column_CPF";
            Column_CPF.Width = 53;
            // 
            // Column_Nome
            // 
            Column_Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_Nome.HeaderText = "Nome";
            Column_Nome.Name = "Column_Nome";
            Column_Nome.Width = 65;
            // 
            // Column_Email
            // 
            Column_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column_Email.HeaderText = "Email";
            Column_Email.Name = "Column_Email";
            Column_Email.Width = 61;
            // 
            // Column_Excluir
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "000,000,000-00";
            dataGridViewCellStyle1.NullValue = null;
            Column_Excluir.DefaultCellStyle = dataGridViewCellStyle1;
            Column_Excluir.HeaderText = "Excluir";
            Column_Excluir.Name = "Column_Excluir";
            Column_Excluir.Text = "Excluir";
            Column_Excluir.UseColumnTextForButtonValue = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(textBox_Consultar);
            Controls.Add(button_Consultar);
            Controls.Add(dataGridView_Clientes);
            Controls.Add(groupBox_Cadastro);
            Name = "FormCliente";
            Text = "FormCliente";
            groupBox_Cadastro.ResumeLayout(false);
            groupBox_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_Cadastro;
        private Label label_CPF;
        private MaskedTextBox maskedTextBox_CPF;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Label label_Email;
        private TextBox textBox_Email;
        private Button button_LimparCampos;
        private Button button_Cadastrar;
        private Button button_Consultar;
        private TextBox textBox_Consultar;
        private DataGridView dataGridView_Clientes;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_CPF;
        private DataGridViewTextBoxColumn Column_Nome;
        private DataGridViewTextBoxColumn Column_Email;
        private DataGridViewButtonColumn Column_Excluir;
    }
}