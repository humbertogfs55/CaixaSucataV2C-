namespace CaixaSucata.UserControlls
{
    partial class SellFunctionUC
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
            SellGroupBox = new GroupBox();
            CancelSailButton = new Button();
            ItemTotalTextBox = new TextBox();
            ItemWeightTextBox = new TextBox();
            SellItemButton = new Button();
            ItemPriceTextBox = new TextBox();
            ValueLabel = new Label();
            WeighLabel = new Label();
            ItemPriceLabel = new Label();
            SellItemsListBox = new ListBox();
            groupBox1 = new GroupBox();
            ExcludeItemButton = new Button();
            FinalValueTextBox = new TextBox();
            FinalizeSalesButton = new Button();
            SoldItemsListBox = new ListBox();
            label1 = new Label();
            SellGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SellGroupBox
            // 
            SellGroupBox.Controls.Add(CancelSailButton);
            SellGroupBox.Controls.Add(ItemTotalTextBox);
            SellGroupBox.Controls.Add(ItemWeightTextBox);
            SellGroupBox.Controls.Add(SellItemButton);
            SellGroupBox.Controls.Add(ItemPriceTextBox);
            SellGroupBox.Controls.Add(ValueLabel);
            SellGroupBox.Controls.Add(WeighLabel);
            SellGroupBox.Controls.Add(ItemPriceLabel);
            SellGroupBox.Controls.Add(SellItemsListBox);
            SellGroupBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SellGroupBox.Location = new Point(3, 0);
            SellGroupBox.Name = "SellGroupBox";
            SellGroupBox.Size = new Size(586, 667);
            SellGroupBox.TabIndex = 0;
            SellGroupBox.TabStop = false;
            SellGroupBox.Text = "Vender";
            // 
            // CancelSailButton
            // 
            CancelSailButton.BackColor = SystemColors.ControlLight;
            CancelSailButton.FlatAppearance.BorderColor = Color.Black;
            CancelSailButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelSailButton.Location = new Point(6, 626);
            CancelSailButton.Name = "CancelSailButton";
            CancelSailButton.Size = new Size(105, 35);
            CancelSailButton.TabIndex = 19;
            CancelSailButton.Text = "Cancelar";
            CancelSailButton.UseVisualStyleBackColor = false;
            CancelSailButton.Click += CancelSailButton_Click;
            // 
            // ItemTotalTextBox
            // 
            ItemTotalTextBox.BackColor = SystemColors.Control;
            ItemTotalTextBox.Location = new Point(222, 627);
            ItemTotalTextBox.Name = "ItemTotalTextBox";
            ItemTotalTextBox.ReadOnly = true;
            ItemTotalTextBox.Size = new Size(179, 32);
            ItemTotalTextBox.TabIndex = 18;
            // 
            // ItemWeightTextBox
            // 
            ItemWeightTextBox.BackColor = SystemColors.Control;
            ItemWeightTextBox.Location = new Point(222, 589);
            ItemWeightTextBox.Name = "ItemWeightTextBox";
            ItemWeightTextBox.Size = new Size(179, 32);
            ItemWeightTextBox.TabIndex = 17;
            ItemWeightTextBox.TextChanged += ItemWeightTextBox_TextChanged;
            // 
            // SellItemButton
            // 
            SellItemButton.BackColor = SystemColors.ControlLight;
            SellItemButton.FlatAppearance.BorderColor = Color.Black;
            SellItemButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SellItemButton.Location = new Point(475, 626);
            SellItemButton.Name = "SellItemButton";
            SellItemButton.Size = new Size(105, 35);
            SellItemButton.TabIndex = 12;
            SellItemButton.Text = "Adicionar";
            SellItemButton.UseVisualStyleBackColor = false;
            SellItemButton.Click += SellItemButton_Click;
            // 
            // ItemPriceTextBox
            // 
            ItemPriceTextBox.BackColor = SystemColors.Control;
            ItemPriceTextBox.Location = new Point(222, 551);
            ItemPriceTextBox.Name = "ItemPriceTextBox";
            ItemPriceTextBox.Size = new Size(179, 32);
            ItemPriceTextBox.TabIndex = 16;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ValueLabel.Location = new Point(151, 630);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(65, 24);
            ValueLabel.TabIndex = 15;
            ValueLabel.Text = "Total:";
            // 
            // WeighLabel
            // 
            WeighLabel.AutoSize = true;
            WeighLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            WeighLabel.Location = new Point(148, 592);
            WeighLabel.Name = "WeighLabel";
            WeighLabel.Size = new Size(68, 24);
            WeighLabel.TabIndex = 14;
            WeighLabel.Text = "Peso:";
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPriceLabel.Location = new Point(140, 554);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(76, 24);
            ItemPriceLabel.TabIndex = 13;
            ItemPriceLabel.Text = "Preço:";
            // 
            // SellItemsListBox
            // 
            SellItemsListBox.BackColor = SystemColors.Control;
            SellItemsListBox.FormattingEnabled = true;
            SellItemsListBox.ItemHeight = 24;
            SellItemsListBox.Location = new Point(6, 31);
            SellItemsListBox.Name = "SellItemsListBox";
            SellItemsListBox.Size = new Size(574, 508);
            SellItemsListBox.TabIndex = 0;
            SellItemsListBox.SelectedIndexChanged += SellItemsListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExcludeItemButton);
            groupBox1.Controls.Add(FinalValueTextBox);
            groupBox1.Controls.Add(FinalizeSalesButton);
            groupBox1.Controls.Add(SoldItemsListBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(595, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 664);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista De Vendas";
            // 
            // ExcludeItemButton
            // 
            ExcludeItemButton.BackColor = SystemColors.ControlLight;
            ExcludeItemButton.FlatAppearance.BorderColor = Color.Black;
            ExcludeItemButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExcludeItemButton.Location = new Point(6, 623);
            ExcludeItemButton.Name = "ExcludeItemButton";
            ExcludeItemButton.Size = new Size(105, 35);
            ExcludeItemButton.TabIndex = 23;
            ExcludeItemButton.Text = "Excluir";
            ExcludeItemButton.UseVisualStyleBackColor = false;
            ExcludeItemButton.Click += ExcludeItemButton_Click;
            // 
            // FinalValueTextBox
            // 
            FinalValueTextBox.BackColor = SystemColors.Control;
            FinalValueTextBox.Location = new Point(206, 624);
            FinalValueTextBox.Name = "FinalValueTextBox";
            FinalValueTextBox.ReadOnly = true;
            FinalValueTextBox.Size = new Size(209, 32);
            FinalValueTextBox.TabIndex = 25;
            // 
            // FinalizeSalesButton
            // 
            FinalizeSalesButton.BackColor = SystemColors.ControlLight;
            FinalizeSalesButton.FlatAppearance.BorderColor = Color.Black;
            FinalizeSalesButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizeSalesButton.Location = new Point(421, 623);
            FinalizeSalesButton.Name = "FinalizeSalesButton";
            FinalizeSalesButton.Size = new Size(105, 35);
            FinalizeSalesButton.TabIndex = 22;
            FinalizeSalesButton.Text = "Finalizar";
            FinalizeSalesButton.UseVisualStyleBackColor = false;
            FinalizeSalesButton.Click += FinalizeSalesButton_Click;
            // 
            // SoldItemsListBox
            // 
            SoldItemsListBox.BackColor = SystemColors.Control;
            SoldItemsListBox.FormattingEnabled = true;
            SoldItemsListBox.ItemHeight = 24;
            SoldItemsListBox.Location = new Point(6, 28);
            SoldItemsListBox.Name = "SoldItemsListBox";
            SoldItemsListBox.Size = new Size(520, 580);
            SoldItemsListBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 627);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 24;
            label1.Text = "Total:";
            // 
            // SellFunctionUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(groupBox1);
            Controls.Add(SellGroupBox);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SellFunctionUC";
            Size = new Size(1130, 670);
            SellGroupBox.ResumeLayout(false);
            SellGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SellGroupBox;
        private ListBox SellItemsListBox;
        private TextBox ItemTotalTextBox;
        private TextBox ItemWeightTextBox;
        private Button SellItemButton;
        private TextBox ItemPriceTextBox;
        private Label ValueLabel;
        private Label WeighLabel;
        private Label ItemPriceLabel;
        private Button CancelSailButton;
        private GroupBox groupBox1;
        private ListBox SoldItemsListBox;
        private Button ExcludeItemButton;
        private Button FinalizeSalesButton;
        private TextBox FinalValueTextBox;
        private Label label1;
    }
}
