namespace CaixaSucata.UserControlls
{
    partial class StockSaleUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            CompanyNameComboBox = new ComboBox();
            CancelButton = new Button();
            FinalizeSaleButton = new Button();
            MaterialNameTextBox = new TextBox();
            TruckPlateTextBox = new TextBox();
            CompanyPhoneTextBox = new TextBox();
            CompanyEmailTextBox = new TextBox();
            TotalValueTextBox = new TextBox();
            PricePerKgTextBox = new TextBox();
            TotalWeightTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MaterialStockListBox = new ListBox();
            FiscalNumberTextBox = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 670);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FiscalNumberTextBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(CompanyNameComboBox);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(FinalizeSaleButton);
            groupBox1.Controls.Add(MaterialNameTextBox);
            groupBox1.Controls.Add(TruckPlateTextBox);
            groupBox1.Controls.Add(CompanyPhoneTextBox);
            groupBox1.Controls.Add(CompanyEmailTextBox);
            groupBox1.Controls.Add(TotalValueTextBox);
            groupBox1.Controls.Add(PricePerKgTextBox);
            groupBox1.Controls.Add(TotalWeightTextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MaterialStockListBox);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 670);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurar Venda";
            // 
            // CompanyNameComboBox
            // 
            CompanyNameComboBox.FormattingEnabled = true;
            CompanyNameComboBox.Location = new Point(783, 217);
            CompanyNameComboBox.Name = "CompanyNameComboBox";
            CompanyNameComboBox.Size = new Size(338, 27);
            CompanyNameComboBox.TabIndex = 20;
            CompanyNameComboBox.SelectedIndexChanged += CompanyNameComboBox_SelectedIndexChanged;
            CompanyNameComboBox.MouseDoubleClick += CompanyNameComboBox_MouseDoubleClick;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlLight;
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.Location = new Point(6, 629);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(105, 35);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancelar";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // FinalizeSaleButton
            // 
            FinalizeSaleButton.BackColor = SystemColors.ControlLight;
            FinalizeSaleButton.FlatAppearance.BorderColor = Color.Black;
            FinalizeSaleButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizeSaleButton.Location = new Point(958, 629);
            FinalizeSaleButton.Name = "FinalizeSaleButton";
            FinalizeSaleButton.Size = new Size(163, 35);
            FinalizeSaleButton.TabIndex = 18;
            FinalizeSaleButton.Text = "Confirmar Venda";
            FinalizeSaleButton.UseVisualStyleBackColor = false;
            FinalizeSaleButton.Click += FinalizeSaleButton_Click;
            // 
            // MaterialNameTextBox
            // 
            MaterialNameTextBox.Location = new Point(783, 25);
            MaterialNameTextBox.Name = "MaterialNameTextBox";
            MaterialNameTextBox.Size = new Size(338, 26);
            MaterialNameTextBox.TabIndex = 16;
            // 
            // TruckPlateTextBox
            // 
            TruckPlateTextBox.Location = new Point(783, 185);
            TruckPlateTextBox.Name = "TruckPlateTextBox";
            TruckPlateTextBox.Size = new Size(338, 26);
            TruckPlateTextBox.TabIndex = 15;
            // 
            // CompanyPhoneTextBox
            // 
            CompanyPhoneTextBox.Location = new Point(783, 282);
            CompanyPhoneTextBox.Name = "CompanyPhoneTextBox";
            CompanyPhoneTextBox.Size = new Size(338, 26);
            CompanyPhoneTextBox.TabIndex = 14;
            CompanyPhoneTextBox.MouseDoubleClick += CompanyPhoneTextBox_MouseDoubleClick;
            // 
            // CompanyEmailTextBox
            // 
            CompanyEmailTextBox.Location = new Point(783, 250);
            CompanyEmailTextBox.Name = "CompanyEmailTextBox";
            CompanyEmailTextBox.Size = new Size(338, 26);
            CompanyEmailTextBox.TabIndex = 13;
            CompanyEmailTextBox.MouseDoubleClick += CompanyEmailTextBox_MouseDoubleClick;
            // 
            // TotalValueTextBox
            // 
            TotalValueTextBox.Location = new Point(783, 121);
            TotalValueTextBox.Name = "TotalValueTextBox";
            TotalValueTextBox.Size = new Size(338, 26);
            TotalValueTextBox.TabIndex = 11;
            // 
            // PricePerKgTextBox
            // 
            PricePerKgTextBox.Location = new Point(783, 89);
            PricePerKgTextBox.Name = "PricePerKgTextBox";
            PricePerKgTextBox.Size = new Size(338, 26);
            PricePerKgTextBox.TabIndex = 10;
            PricePerKgTextBox.TextChanged += PricePerKgTextBox_TextChanged;
            // 
            // TotalWeightTextBox
            // 
            TotalWeightTextBox.Location = new Point(783, 57);
            TotalWeightTextBox.Name = "TotalWeightTextBox";
            TotalWeightTextBox.Size = new Size(338, 26);
            TotalWeightTextBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(620, 188);
            label8.Name = "label8";
            label8.Size = new Size(163, 19);
            label8.TabIndex = 8;
            label8.Text = "Placa do Caminhão:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(697, 285);
            label7.Name = "label7";
            label7.Size = new Size(80, 19);
            label7.TabIndex = 7;
            label7.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(720, 253);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(694, 221);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 5;
            label5.Text = "Empresa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(682, 124);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 4;
            label4.Text = "Valor Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 92);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 3;
            label3.Text = "Preço por Kilo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 60);
            label2.Name = "label2";
            label2.Size = new Size(150, 19);
            label2.TabIndex = 2;
            label2.Text = "Peso para Vender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(703, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 1;
            label1.Text = "Material:";
            // 
            // MaterialStockListBox
            // 
            MaterialStockListBox.BackColor = SystemColors.Control;
            MaterialStockListBox.FormattingEnabled = true;
            MaterialStockListBox.ItemHeight = 19;
            MaterialStockListBox.Location = new Point(6, 25);
            MaterialStockListBox.Name = "MaterialStockListBox";
            MaterialStockListBox.Size = new Size(598, 593);
            MaterialStockListBox.TabIndex = 0;
            MaterialStockListBox.SelectedIndexChanged += MaterialStockListBox_SelectedIndexChanged;
            // 
            // FiscalNumberTextBox
            // 
            FiscalNumberTextBox.Location = new Point(783, 153);
            FiscalNumberTextBox.Name = "FiscalNumberTextBox";
            FiscalNumberTextBox.Size = new Size(338, 26);
            FiscalNumberTextBox.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(677, 160);
            label9.Name = "label9";
            label9.Size = new Size(100, 19);
            label9.TabIndex = 21;
            label9.Text = "Nota Fiscal:";
            // 
            // StockSaleUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StockSaleUC";
            Size = new Size(1130, 670);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox MaterialStockListBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox MaterialNameTextBox;
        private TextBox TruckPlateTextBox;
        private TextBox CompanyPhoneTextBox;
        private TextBox CompanyEmailTextBox;
        private TextBox textBox4;
        private TextBox TotalValueTextBox;
        private TextBox PricePerKgTextBox;
        private TextBox TotalWeightTextBox;
        private Button CancelButton;
        private Button FinalizeSaleButton;
        private ComboBox CompanyNameComboBox;
        private TextBox FiscalNumberTextBox;
        private Label label9;
    }
}
