namespace CaixaSucata
{
    partial class ConfigureMaterialForm
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
            panel1 = new Panel();
            CancelButton = new Button();
            ExcludeMaterialButton = new Button();
            UpdateMaterialButton = new Button();
            AddMaterialButton = new Button();
            IndexLabel = new Label();
            IndexTextBox = new TextBox();
            Price3Label = new Label();
            Price3TextBox = new TextBox();
            Price2Label = new Label();
            Price2TextBox = new TextBox();
            StandartPriceLabel = new Label();
            Price1TextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            MaterialListBox = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(ExcludeMaterialButton);
            panel1.Controls.Add(UpdateMaterialButton);
            panel1.Controls.Add(AddMaterialButton);
            panel1.Controls.Add(IndexLabel);
            panel1.Controls.Add(IndexTextBox);
            panel1.Controls.Add(Price3Label);
            panel1.Controls.Add(Price3TextBox);
            panel1.Controls.Add(Price2Label);
            panel1.Controls.Add(Price2TextBox);
            panel1.Controls.Add(StandartPriceLabel);
            panel1.Controls.Add(Price1TextBox);
            panel1.Controls.Add(NameLabel);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(MaterialListBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 635);
            panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlLight;
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.Location = new Point(553, 597);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(132, 35);
            CancelButton.TabIndex = 14;
            CancelButton.Text = "Finalizar";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ExcludeMaterialButton
            // 
            ExcludeMaterialButton.BackColor = SystemColors.ControlLight;
            ExcludeMaterialButton.FlatAppearance.BorderColor = Color.Black;
            ExcludeMaterialButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExcludeMaterialButton.Location = new Point(127, 280);
            ExcludeMaterialButton.Name = "ExcludeMaterialButton";
            ExcludeMaterialButton.Size = new Size(132, 35);
            ExcludeMaterialButton.TabIndex = 13;
            ExcludeMaterialButton.Text = "Excluir";
            ExcludeMaterialButton.UseVisualStyleBackColor = false;
            ExcludeMaterialButton.Click += ExcludeMaterialButton_Click;
            // 
            // UpdateMaterialButton
            // 
            UpdateMaterialButton.BackColor = SystemColors.ControlLight;
            UpdateMaterialButton.FlatAppearance.BorderColor = Color.Black;
            UpdateMaterialButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateMaterialButton.Location = new Point(127, 239);
            UpdateMaterialButton.Name = "UpdateMaterialButton";
            UpdateMaterialButton.Size = new Size(132, 35);
            UpdateMaterialButton.TabIndex = 12;
            UpdateMaterialButton.Text = "Atualizar";
            UpdateMaterialButton.UseVisualStyleBackColor = false;
            UpdateMaterialButton.Click += UpdateMaterialButton_Click;
            // 
            // AddMaterialButton
            // 
            AddMaterialButton.BackColor = SystemColors.ControlLight;
            AddMaterialButton.FlatAppearance.BorderColor = Color.Black;
            AddMaterialButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddMaterialButton.Location = new Point(127, 198);
            AddMaterialButton.Name = "AddMaterialButton";
            AddMaterialButton.Size = new Size(132, 35);
            AddMaterialButton.TabIndex = 11;
            AddMaterialButton.Text = "Adicionar";
            AddMaterialButton.UseVisualStyleBackColor = false;
            AddMaterialButton.Click += AddMaterialButton_Click;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IndexLabel.Location = new Point(12, 143);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(98, 19);
            IndexLabel.TabIndex = 10;
            IndexLabel.Text = "Index Lista:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.BackColor = SystemColors.Control;
            IndexTextBox.Location = new Point(127, 143);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(212, 26);
            IndexTextBox.TabIndex = 9;
            // 
            // Price3Label
            // 
            Price3Label.AutoSize = true;
            Price3Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Price3Label.Location = new Point(31, 111);
            Price3Label.Name = "Price3Label";
            Price3Label.Size = new Size(73, 19);
            Price3Label.TabIndex = 8;
            Price3Label.Text = "Preço 3:";
            // 
            // Price3TextBox
            // 
            Price3TextBox.BackColor = SystemColors.Control;
            Price3TextBox.Location = new Point(127, 111);
            Price3TextBox.Name = "Price3TextBox";
            Price3TextBox.Size = new Size(212, 26);
            Price3TextBox.TabIndex = 7;
            // 
            // Price2Label
            // 
            Price2Label.AutoSize = true;
            Price2Label.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Price2Label.Location = new Point(31, 79);
            Price2Label.Name = "Price2Label";
            Price2Label.Size = new Size(73, 19);
            Price2Label.TabIndex = 6;
            Price2Label.Text = "Preço 2:";
            // 
            // Price2TextBox
            // 
            Price2TextBox.BackColor = SystemColors.Control;
            Price2TextBox.Location = new Point(127, 79);
            Price2TextBox.Name = "Price2TextBox";
            Price2TextBox.Size = new Size(212, 26);
            Price2TextBox.TabIndex = 5;
            // 
            // StandartPriceLabel
            // 
            StandartPriceLabel.AutoSize = true;
            StandartPriceLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StandartPriceLabel.Location = new Point(31, 47);
            StandartPriceLabel.Name = "StandartPriceLabel";
            StandartPriceLabel.Size = new Size(73, 19);
            StandartPriceLabel.TabIndex = 4;
            StandartPriceLabel.Text = "Preço 1:";
            // 
            // Price1TextBox
            // 
            Price1TextBox.BackColor = SystemColors.Control;
            Price1TextBox.Location = new Point(127, 47);
            Price1TextBox.Name = "Price1TextBox";
            Price1TextBox.Size = new Size(212, 26);
            Price1TextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(44, 15);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(60, 19);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Nome:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.Control;
            NameTextBox.Location = new Point(127, 15);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(212, 26);
            NameTextBox.TabIndex = 1;
            // 
            // MaterialListBox
            // 
            MaterialListBox.BackColor = SystemColors.Control;
            MaterialListBox.FormattingEnabled = true;
            MaterialListBox.ItemHeight = 18;
            MaterialListBox.Location = new Point(345, 12);
            MaterialListBox.Name = "MaterialListBox";
            MaterialListBox.Size = new Size(340, 580);
            MaterialListBox.TabIndex = 0;
            MaterialListBox.SelectedIndexChanged += MaterialListBox_SelectedIndexChanged;
            // 
            // ConfigureMaterialForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(697, 635);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ConfigureMaterialForm";
            Text = "Configurar Materiais";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox MaterialListBox;
        private TextBox NameTextBox;
        private Label IndexLabel;
        private TextBox IndexTextBox;
        private Label Price3Label;
        private TextBox Price3TextBox;
        private Label Price2Label;
        private TextBox Price2TextBox;
        private Label StandartPriceLabel;
        private TextBox Price1TextBox;
        private Label NameLabel;
        private Button ExcludeMaterialButton;
        private Button UpdateMaterialButton;
        private Button AddMaterialButton;
        private Button CancelButton;
    }
}