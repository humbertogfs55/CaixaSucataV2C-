namespace CaixaSucata.UserControlls
{
    partial class BuyFunctionUC
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
            MaterialListBox = new ListBox();
            PurchasesListBox = new ListBox();
            PurchaseGroupBox = new GroupBox();
            SellerNameTextBox = new TextBox();
            SellerNameLabel = new Label();
            CancelPurchaseButton = new Button();
            AmountValueTextBox = new TextBox();
            WeightTextBox = new TextBox();
            AddPurchaseButton = new Button();
            PriceTextBox = new TextBox();
            ValueLabel = new Label();
            WeighLabel = new Label();
            ItemPriceLabel = new Label();
            ProviderTypesLabel = new Label();
            SpecialCustomerRadioButton = new RadioButton();
            PartnerCustomerRadioButton = new RadioButton();
            RegularCustomerRadioButton = new RadioButton();
            FinalizePurchaseGroupBox = new GroupBox();
            ExcludeItemButton = new Button();
            FinalValueTextBox = new TextBox();
            label1 = new Label();
            FinalizePurchaseButton = new Button();
            PurchaseGroupBox.SuspendLayout();
            FinalizePurchaseGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MaterialListBox
            // 
            MaterialListBox.BackColor = SystemColors.Control;
            MaterialListBox.FormattingEnabled = true;
            MaterialListBox.ItemHeight = 24;
            MaterialListBox.Location = new Point(6, 31);
            MaterialListBox.Name = "MaterialListBox";
            MaterialListBox.Size = new Size(345, 580);
            MaterialListBox.TabIndex = 0;
            MaterialListBox.SelectedIndexChanged += MaterialsListBox_SelectedIndexChanged;
            // 
            // PurchasesListBox
            // 
            PurchasesListBox.BackColor = SystemColors.Control;
            PurchasesListBox.FormattingEnabled = true;
            PurchasesListBox.ItemHeight = 24;
            PurchasesListBox.Location = new Point(6, 31);
            PurchasesListBox.Name = "PurchasesListBox";
            PurchasesListBox.Size = new Size(532, 580);
            PurchasesListBox.TabIndex = 1;
            // 
            // PurchaseGroupBox
            // 
            PurchaseGroupBox.Controls.Add(SellerNameTextBox);
            PurchaseGroupBox.Controls.Add(SellerNameLabel);
            PurchaseGroupBox.Controls.Add(CancelPurchaseButton);
            PurchaseGroupBox.Controls.Add(AmountValueTextBox);
            PurchaseGroupBox.Controls.Add(WeightTextBox);
            PurchaseGroupBox.Controls.Add(AddPurchaseButton);
            PurchaseGroupBox.Controls.Add(PriceTextBox);
            PurchaseGroupBox.Controls.Add(ValueLabel);
            PurchaseGroupBox.Controls.Add(WeighLabel);
            PurchaseGroupBox.Controls.Add(ItemPriceLabel);
            PurchaseGroupBox.Controls.Add(ProviderTypesLabel);
            PurchaseGroupBox.Controls.Add(SpecialCustomerRadioButton);
            PurchaseGroupBox.Controls.Add(PartnerCustomerRadioButton);
            PurchaseGroupBox.Controls.Add(RegularCustomerRadioButton);
            PurchaseGroupBox.Controls.Add(MaterialListBox);
            PurchaseGroupBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PurchaseGroupBox.Location = new Point(3, 3);
            PurchaseGroupBox.Name = "PurchaseGroupBox";
            PurchaseGroupBox.Size = new Size(563, 662);
            PurchaseGroupBox.TabIndex = 2;
            PurchaseGroupBox.TabStop = false;
            PurchaseGroupBox.Text = "Comprar";
            // 
            // SellerNameTextBox
            // 
            SellerNameTextBox.BackColor = SystemColors.Control;
            SellerNameTextBox.Location = new Point(293, 618);
            SellerNameTextBox.Name = "SellerNameTextBox";
            SellerNameTextBox.Size = new Size(153, 32);
            SellerNameTextBox.TabIndex = 17;
            // 
            // SellerNameLabel
            // 
            SellerNameLabel.AutoSize = true;
            SellerNameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SellerNameLabel.Location = new Point(212, 621);
            SellerNameLabel.Name = "SellerNameLabel";
            SellerNameLabel.Size = new Size(75, 24);
            SellerNameLabel.TabIndex = 16;
            SellerNameLabel.Text = "Nome:";
            // 
            // CancelPurchaseButton
            // 
            CancelPurchaseButton.BackColor = SystemColors.ControlLight;
            CancelPurchaseButton.FlatAppearance.BorderColor = Color.Black;
            CancelPurchaseButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelPurchaseButton.Location = new Point(6, 617);
            CancelPurchaseButton.Name = "CancelPurchaseButton";
            CancelPurchaseButton.Size = new Size(105, 35);
            CancelPurchaseButton.TabIndex = 15;
            CancelPurchaseButton.Text = "Cancelar";
            CancelPurchaseButton.UseVisualStyleBackColor = false;
            CancelPurchaseButton.Click += CancelPurchaseButton_Click;
            // 
            // AmountValueTextBox
            // 
            AmountValueTextBox.BackColor = SystemColors.Control;
            AmountValueTextBox.Location = new Point(439, 564);
            AmountValueTextBox.Name = "AmountValueTextBox";
            AmountValueTextBox.ReadOnly = true;
            AmountValueTextBox.Size = new Size(118, 32);
            AmountValueTextBox.TabIndex = 11;
            // 
            // WeightTextBox
            // 
            WeightTextBox.BackColor = SystemColors.Control;
            WeightTextBox.Location = new Point(439, 526);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(118, 32);
            WeightTextBox.TabIndex = 10;
            WeightTextBox.TextChanged += WeightTextBox_TextChanged;
            // 
            // AddPurchaseButton
            // 
            AddPurchaseButton.BackColor = SystemColors.ControlLight;
            AddPurchaseButton.FlatAppearance.BorderColor = Color.Black;
            AddPurchaseButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddPurchaseButton.Location = new Point(452, 617);
            AddPurchaseButton.Name = "AddPurchaseButton";
            AddPurchaseButton.Size = new Size(105, 35);
            AddPurchaseButton.TabIndex = 1;
            AddPurchaseButton.Text = "Adicionar";
            AddPurchaseButton.UseVisualStyleBackColor = false;
            AddPurchaseButton.Click += AddPurchaseButton_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.BackColor = SystemColors.Control;
            PriceTextBox.Location = new Point(439, 488);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(118, 32);
            PriceTextBox.TabIndex = 9;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ValueLabel.Location = new Point(368, 567);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(65, 24);
            ValueLabel.TabIndex = 8;
            ValueLabel.Text = "Total:";
            // 
            // WeighLabel
            // 
            WeighLabel.AutoSize = true;
            WeighLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            WeighLabel.Location = new Point(365, 529);
            WeighLabel.Name = "WeighLabel";
            WeighLabel.Size = new Size(68, 24);
            WeighLabel.TabIndex = 7;
            WeighLabel.Text = "Peso:";
            // 
            // ItemPriceLabel
            // 
            ItemPriceLabel.AutoSize = true;
            ItemPriceLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPriceLabel.Location = new Point(357, 491);
            ItemPriceLabel.Name = "ItemPriceLabel";
            ItemPriceLabel.Size = new Size(76, 24);
            ItemPriceLabel.TabIndex = 6;
            ItemPriceLabel.Text = "Preço:";
            // 
            // ProviderTypesLabel
            // 
            ProviderTypesLabel.AutoSize = true;
            ProviderTypesLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProviderTypesLabel.Location = new Point(439, 42);
            ProviderTypesLabel.Name = "ProviderTypesLabel";
            ProviderTypesLabel.Size = new Size(104, 19);
            ProviderTypesLabel.TabIndex = 5;
            ProviderTypesLabel.Text = "Fornecedor:";
            // 
            // SpecialCustomerRadioButton
            // 
            SpecialCustomerRadioButton.AutoSize = true;
            SpecialCustomerRadioButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SpecialCustomerRadioButton.Location = new Point(443, 122);
            SpecialCustomerRadioButton.Name = "SpecialCustomerRadioButton";
            SpecialCustomerRadioButton.Size = new Size(92, 23);
            SpecialCustomerRadioButton.TabIndex = 4;
            SpecialCustomerRadioButton.TabStop = true;
            SpecialCustomerRadioButton.Text = "Especial";
            SpecialCustomerRadioButton.UseVisualStyleBackColor = true;
            SpecialCustomerRadioButton.CheckedChanged += SpecialCustomerRadioButton_CheckedChanged;
            // 
            // PartnerCustomerRadioButton
            // 
            PartnerCustomerRadioButton.AutoSize = true;
            PartnerCustomerRadioButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PartnerCustomerRadioButton.Location = new Point(444, 93);
            PartnerCustomerRadioButton.Name = "PartnerCustomerRadioButton";
            PartnerCustomerRadioButton.Size = new Size(91, 23);
            PartnerCustomerRadioButton.TabIndex = 3;
            PartnerCustomerRadioButton.TabStop = true;
            PartnerCustomerRadioButton.Text = "Parceiro";
            PartnerCustomerRadioButton.UseVisualStyleBackColor = true;
            PartnerCustomerRadioButton.CheckedChanged += PartnerCustomerRadioButton_CheckedChanged;
            // 
            // RegularCustomerRadioButton
            // 
            RegularCustomerRadioButton.AutoSize = true;
            RegularCustomerRadioButton.Checked = true;
            RegularCustomerRadioButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegularCustomerRadioButton.Location = new Point(444, 64);
            RegularCustomerRadioButton.Name = "RegularCustomerRadioButton";
            RegularCustomerRadioButton.Size = new Size(87, 23);
            RegularCustomerRadioButton.TabIndex = 2;
            RegularCustomerRadioButton.TabStop = true;
            RegularCustomerRadioButton.Text = "Comum";
            RegularCustomerRadioButton.UseVisualStyleBackColor = true;
            RegularCustomerRadioButton.CheckedChanged += RegularCustomerRadioButton_CheckedChanged;
            // 
            // FinalizePurchaseGroupBox
            // 
            FinalizePurchaseGroupBox.Controls.Add(ExcludeItemButton);
            FinalizePurchaseGroupBox.Controls.Add(FinalValueTextBox);
            FinalizePurchaseGroupBox.Controls.Add(label1);
            FinalizePurchaseGroupBox.Controls.Add(FinalizePurchaseButton);
            FinalizePurchaseGroupBox.Controls.Add(PurchasesListBox);
            FinalizePurchaseGroupBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizePurchaseGroupBox.Location = new Point(572, 3);
            FinalizePurchaseGroupBox.Name = "FinalizePurchaseGroupBox";
            FinalizePurchaseGroupBox.Size = new Size(547, 662);
            FinalizePurchaseGroupBox.TabIndex = 3;
            FinalizePurchaseGroupBox.TabStop = false;
            FinalizePurchaseGroupBox.Text = "Lista de Compras";
            // 
            // ExcludeItemButton
            // 
            ExcludeItemButton.BackColor = SystemColors.ControlLight;
            ExcludeItemButton.FlatAppearance.BorderColor = Color.Black;
            ExcludeItemButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExcludeItemButton.Location = new Point(6, 617);
            ExcludeItemButton.Name = "ExcludeItemButton";
            ExcludeItemButton.Size = new Size(105, 35);
            ExcludeItemButton.TabIndex = 14;
            ExcludeItemButton.Text = "Excluir";
            ExcludeItemButton.UseVisualStyleBackColor = false;
            ExcludeItemButton.Click += ExcludeItemButton_Click;
            // 
            // FinalValueTextBox
            // 
            FinalValueTextBox.BackColor = SystemColors.Control;
            FinalValueTextBox.Location = new Point(228, 618);
            FinalValueTextBox.Name = "FinalValueTextBox";
            FinalValueTextBox.ReadOnly = true;
            FinalValueTextBox.Size = new Size(199, 32);
            FinalValueTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 621);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 12;
            label1.Text = "Total:";
            // 
            // FinalizePurchaseButton
            // 
            FinalizePurchaseButton.BackColor = SystemColors.ControlLight;
            FinalizePurchaseButton.FlatAppearance.BorderColor = Color.Black;
            FinalizePurchaseButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizePurchaseButton.Location = new Point(433, 617);
            FinalizePurchaseButton.Name = "FinalizePurchaseButton";
            FinalizePurchaseButton.Size = new Size(105, 35);
            FinalizePurchaseButton.TabIndex = 2;
            FinalizePurchaseButton.Text = "Finalizar";
            FinalizePurchaseButton.UseVisualStyleBackColor = false;
            FinalizePurchaseButton.Click += FinalizePurchaseButton_Click;
            // 
            // BuyFunctionUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(FinalizePurchaseGroupBox);
            Controls.Add(PurchaseGroupBox);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "BuyFunctionUC";
            Size = new Size(1130, 670);
            PurchaseGroupBox.ResumeLayout(false);
            PurchaseGroupBox.PerformLayout();
            FinalizePurchaseGroupBox.ResumeLayout(false);
            FinalizePurchaseGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox MaterialListBox;
        private ListBox PurchasesListBox;
        private GroupBox PurchaseGroupBox;
        private GroupBox FinalizePurchaseGroupBox;
        private Button AddPurchaseButton;
        private Button FinalizePurchaseButton;
        private Label ProviderTypesLabel;
        private RadioButton SpecialCustomerRadioButton;
        private RadioButton PartnerCustomerRadioButton;
        private RadioButton RegularCustomerRadioButton;
        private Label ValueLabel;
        private Label WeighLabel;
        private Label ItemPriceLabel;
        private TextBox AmountValueTextBox;
        private TextBox WeightTextBox;
        private TextBox PriceTextBox;
        private TextBox FinalValueTextBox;
        private Label label1;
        private Button CancelPurchaseButton;
        private Button ExcludeItemButton;
        private TextBox SellerNameTextBox;
        private Label SellerNameLabel;
    }
}
