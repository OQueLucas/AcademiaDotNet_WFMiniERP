namespace AcademiaDotNet_WFMiniERP
{
    partial class FormNotaFiscal
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
            button_RemoverFiltros = new Button();
            button_Filtrar = new Button();
            label_FiltroDataEmissao = new Label();
            label_FiltroStatus = new Label();
            comboBox_FiltroStatus = new ComboBox();
            dateTimePicker_FiltroDataEmissao = new DateTimePicker();
            label_FiltroCliente = new Label();
            comboBox_FiltroCliente = new ComboBox();
            dataGridView_Notas = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Data_Emissao = new DataGridViewTextBoxColumn();
            Column_Status = new DataGridViewTextBoxColumn();
            Column_Cliente = new DataGridViewTextBoxColumn();
            groupBox_VisualizarNota = new GroupBox();
            label_Status = new Label();
            comboBox_Status = new ComboBox();
            maskedTextBox_DataEmissao = new MaskedTextBox();
            label_DataEmissao = new Label();
            label_Cliente = new Label();
            textBox_Cliente = new TextBox();
            label_CPF = new Label();
            maskedTextBox_CPF = new MaskedTextBox();
            dataGridView_ItensNota = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Notas).BeginInit();
            groupBox_VisualizarNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItensNota).BeginInit();
            SuspendLayout();
            // 
            // button_RemoverFiltros
            // 
            button_RemoverFiltros.Image = Properties.Resources.clear_filters_black;
            button_RemoverFiltros.Location = new Point(579, 24);
            button_RemoverFiltros.Name = "button_RemoverFiltros";
            button_RemoverFiltros.Size = new Size(107, 40);
            button_RemoverFiltros.TabIndex = 16;
            button_RemoverFiltros.Text = "Remover Filtros";
            button_RemoverFiltros.TextAlign = ContentAlignment.MiddleRight;
            button_RemoverFiltros.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_RemoverFiltros.UseVisualStyleBackColor = true;
            // 
            // button_Filtrar
            // 
            button_Filtrar.Image = Properties.Resources.filter_black;
            button_Filtrar.Location = new Point(468, 24);
            button_Filtrar.Name = "button_Filtrar";
            button_Filtrar.Size = new Size(87, 40);
            button_Filtrar.TabIndex = 15;
            button_Filtrar.Text = "Filtrar";
            button_Filtrar.TextAlign = ContentAlignment.MiddleRight;
            button_Filtrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Filtrar.UseVisualStyleBackColor = true;
            // 
            // label_FiltroDataEmissao
            // 
            label_FiltroDataEmissao.AutoSize = true;
            label_FiltroDataEmissao.Location = new Point(12, 50);
            label_FiltroDataEmissao.Name = "label_FiltroDataEmissao";
            label_FiltroDataEmissao.Size = new Size(77, 15);
            label_FiltroDataEmissao.TabIndex = 14;
            label_FiltroDataEmissao.Text = "Data Emissão";
            // 
            // label_FiltroStatus
            // 
            label_FiltroStatus.AutoSize = true;
            label_FiltroStatus.Location = new Point(187, 9);
            label_FiltroStatus.Name = "label_FiltroStatus";
            label_FiltroStatus.Size = new Size(39, 15);
            label_FiltroStatus.TabIndex = 13;
            label_FiltroStatus.Text = "Status";
            // 
            // comboBox_FiltroStatus
            // 
            comboBox_FiltroStatus.FormattingEnabled = true;
            comboBox_FiltroStatus.Location = new Point(237, 6);
            comboBox_FiltroStatus.Name = "comboBox_FiltroStatus";
            comboBox_FiltroStatus.Size = new Size(102, 23);
            comboBox_FiltroStatus.TabIndex = 12;
            // 
            // dateTimePicker_FiltroDataEmissao
            // 
            dateTimePicker_FiltroDataEmissao.Location = new Point(95, 47);
            dateTimePicker_FiltroDataEmissao.Name = "dateTimePicker_FiltroDataEmissao";
            dateTimePicker_FiltroDataEmissao.Size = new Size(154, 23);
            dateTimePicker_FiltroDataEmissao.TabIndex = 11;
            // 
            // label_FiltroCliente
            // 
            label_FiltroCliente.AutoSize = true;
            label_FiltroCliente.Location = new Point(15, 9);
            label_FiltroCliente.Name = "label_FiltroCliente";
            label_FiltroCliente.Size = new Size(44, 15);
            label_FiltroCliente.TabIndex = 10;
            label_FiltroCliente.Text = "Cliente";
            // 
            // comboBox_FiltroCliente
            // 
            comboBox_FiltroCliente.FormattingEnabled = true;
            comboBox_FiltroCliente.Location = new Point(65, 6);
            comboBox_FiltroCliente.Name = "comboBox_FiltroCliente";
            comboBox_FiltroCliente.Size = new Size(102, 23);
            comboBox_FiltroCliente.TabIndex = 9;
            // 
            // dataGridView_Notas
            // 
            dataGridView_Notas.AllowUserToAddRows = false;
            dataGridView_Notas.AllowUserToDeleteRows = false;
            dataGridView_Notas.AllowUserToOrderColumns = true;
            dataGridView_Notas.BackgroundColor = SystemColors.ControlLight;
            dataGridView_Notas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Notas.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Data_Emissao, Column_Status, Column_Cliente });
            dataGridView_Notas.Location = new Point(12, 83);
            dataGridView_Notas.Name = "dataGridView_Notas";
            dataGridView_Notas.ReadOnly = true;
            dataGridView_Notas.RowTemplate.Height = 25;
            dataGridView_Notas.Size = new Size(674, 666);
            dataGridView_Notas.TabIndex = 17;
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            Column_ID.ReadOnly = true;
            Column_ID.Visible = false;
            // 
            // Column_Data_Emissao
            // 
            Column_Data_Emissao.HeaderText = "Data de Emissão";
            Column_Data_Emissao.Name = "Column_Data_Emissao";
            Column_Data_Emissao.ReadOnly = true;
            // 
            // Column_Status
            // 
            Column_Status.HeaderText = "Status";
            Column_Status.Name = "Column_Status";
            Column_Status.ReadOnly = true;
            // 
            // Column_Cliente
            // 
            Column_Cliente.HeaderText = "Cliente";
            Column_Cliente.Name = "Column_Cliente";
            Column_Cliente.ReadOnly = true;
            // 
            // groupBox_VisualizarNota
            // 
            groupBox_VisualizarNota.Controls.Add(label_Cliente);
            groupBox_VisualizarNota.Controls.Add(textBox_Cliente);
            groupBox_VisualizarNota.Controls.Add(label_CPF);
            groupBox_VisualizarNota.Controls.Add(maskedTextBox_CPF);
            groupBox_VisualizarNota.Controls.Add(dataGridView_ItensNota);
            groupBox_VisualizarNota.Controls.Add(label_DataEmissao);
            groupBox_VisualizarNota.Controls.Add(maskedTextBox_DataEmissao);
            groupBox_VisualizarNota.Controls.Add(label_Status);
            groupBox_VisualizarNota.Controls.Add(comboBox_Status);
            groupBox_VisualizarNota.Location = new Point(722, 12);
            groupBox_VisualizarNota.Name = "groupBox_VisualizarNota";
            groupBox_VisualizarNota.Size = new Size(530, 737);
            groupBox_VisualizarNota.TabIndex = 18;
            groupBox_VisualizarNota.TabStop = false;
            groupBox_VisualizarNota.Text = "Visualizar";
            // 
            // label_Status
            // 
            label_Status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_Status.AutoSize = true;
            label_Status.Location = new Point(10, 711);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(42, 15);
            label_Status.TabIndex = 22;
            label_Status.Text = "Status:";
            // 
            // comboBox_Status
            // 
            comboBox_Status.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Location = new Point(58, 708);
            comboBox_Status.Name = "comboBox_Status";
            comboBox_Status.Size = new Size(121, 23);
            comboBox_Status.TabIndex = 21;
            // 
            // maskedTextBox_DataEmissao
            // 
            maskedTextBox_DataEmissao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            maskedTextBox_DataEmissao.Enabled = false;
            maskedTextBox_DataEmissao.Location = new Point(112, 679);
            maskedTextBox_DataEmissao.Mask = "00/00/0000 90:00";
            maskedTextBox_DataEmissao.Name = "maskedTextBox_DataEmissao";
            maskedTextBox_DataEmissao.Size = new Size(87, 23);
            maskedTextBox_DataEmissao.TabIndex = 20;
            maskedTextBox_DataEmissao.ValidatingType = typeof(DateTime);
            // 
            // label_DataEmissao
            // 
            label_DataEmissao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_DataEmissao.AutoSize = true;
            label_DataEmissao.Location = new Point(10, 682);
            label_DataEmissao.Name = "label_DataEmissao";
            label_DataEmissao.Size = new Size(96, 15);
            label_DataEmissao.TabIndex = 19;
            label_DataEmissao.Text = "Data de Emissão:";
            // 
            // label_Cliente
            // 
            label_Cliente.AutoSize = true;
            label_Cliente.Location = new Point(6, 25);
            label_Cliente.Name = "label_Cliente";
            label_Cliente.Size = new Size(47, 15);
            label_Cliente.TabIndex = 10;
            label_Cliente.Text = "Cliente:";
            // 
            // textBox_Cliente
            // 
            textBox_Cliente.Enabled = false;
            textBox_Cliente.Location = new Point(58, 22);
            textBox_Cliente.Name = "textBox_Cliente";
            textBox_Cliente.Size = new Size(177, 23);
            textBox_Cliente.TabIndex = 13;
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Location = new Point(6, 54);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(31, 15);
            label_CPF.TabIndex = 12;
            label_CPF.Text = "CPF:";
            // 
            // maskedTextBox_CPF
            // 
            maskedTextBox_CPF.Enabled = false;
            maskedTextBox_CPF.Location = new Point(58, 51);
            maskedTextBox_CPF.Mask = "000,000,000-00";
            maskedTextBox_CPF.Name = "maskedTextBox_CPF";
            maskedTextBox_CPF.Size = new Size(88, 23);
            maskedTextBox_CPF.TabIndex = 14;
            // 
            // dataGridView_ItensNota
            // 
            dataGridView_ItensNota.AllowUserToAddRows = false;
            dataGridView_ItensNota.AllowUserToDeleteRows = false;
            dataGridView_ItensNota.AllowUserToOrderColumns = true;
            dataGridView_ItensNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_ItensNota.BackgroundColor = SystemColors.ControlLight;
            dataGridView_ItensNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ItensNota.Enabled = false;
            dataGridView_ItensNota.Location = new Point(6, 80);
            dataGridView_ItensNota.MultiSelect = false;
            dataGridView_ItensNota.Name = "dataGridView_ItensNota";
            dataGridView_ItensNota.ReadOnly = true;
            dataGridView_ItensNota.RowTemplate.Height = 25;
            dataGridView_ItensNota.Size = new Size(518, 593);
            dataGridView_ItensNota.TabIndex = 10;
            // 
            // FormNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1264, 761);
            Controls.Add(label_FiltroCliente);
            Controls.Add(comboBox_FiltroCliente);
            Controls.Add(label_FiltroStatus);
            Controls.Add(comboBox_FiltroStatus);
            Controls.Add(label_FiltroDataEmissao);
            Controls.Add(dateTimePicker_FiltroDataEmissao);
            Controls.Add(button_Filtrar);
            Controls.Add(button_RemoverFiltros);
            Controls.Add(dataGridView_Notas);
            Controls.Add(groupBox_VisualizarNota);
            Name = "FormNotaFiscal";
            Text = "FormNotaFiscal";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Notas).EndInit();
            groupBox_VisualizarNota.ResumeLayout(false);
            groupBox_VisualizarNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItensNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_RemoverFiltros;
        private Button button_Filtrar;
        private Label label_FiltroDataEmissao;
        private Label label_FiltroStatus;
        private ComboBox comboBox_FiltroStatus;
        private DateTimePicker dateTimePicker_FiltroDataEmissao;
        private Label label_FiltroCliente;
        private ComboBox comboBox_FiltroCliente;
        private DataGridView dataGridView_Notas;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Data_Emissao;
        private DataGridViewTextBoxColumn Column_Status;
        private DataGridViewTextBoxColumn Column_Cliente;
        private GroupBox groupBox_VisualizarNota;
        private Label label_Status;
        private ComboBox comboBox_Status;
        private MaskedTextBox maskedTextBox_DataEmissao;
        private Label label_DataEmissao;
        private Label label_Cliente;
        private TextBox textBox_Cliente;
        private Label label_CPF;
        private MaskedTextBox maskedTextBox_CPF;
        private DataGridView dataGridView_ItensNota;
    }
}