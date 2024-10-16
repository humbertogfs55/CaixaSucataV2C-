namespace CaixaSucata.UserControlls
{
    partial class SpredsheetUC
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
            groupBox2 = new GroupBox();
            SpreadListView = new ListView();
            groupBox1 = new GroupBox();
            SalesRadioButton = new RadioButton();
            PurchaseRadioButton = new RadioButton();
            label3 = new Label();
            MaterialListComboBox = new ComboBox();
            ExportButton = new Button();
            MainMenuButton = new Button();
            label2 = new Label();
            EndDatePicker = new DateTimePicker();
            label1 = new Label();
            StartDatePicker = new DateTimePicker();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 670);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SpreadListView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(235, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 670);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planilha";
            // 
            // SpreadListView
            // 
            SpreadListView.BackColor = SystemColors.ControlDark;
            SpreadListView.Dock = DockStyle.Fill;
            SpreadListView.GridLines = true;
            SpreadListView.Location = new Point(3, 22);
            SpreadListView.Name = "SpreadListView";
            SpreadListView.Size = new Size(889, 645);
            SpreadListView.TabIndex = 0;
            SpreadListView.UseCompatibleStateImageBehavior = false;
            SpreadListView.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SalesRadioButton);
            groupBox1.Controls.Add(PurchaseRadioButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(MaterialListComboBox);
            groupBox1.Controls.Add(ExportButton);
            groupBox1.Controls.Add(MainMenuButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(EndDatePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(StartDatePicker);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 670);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurar";
            // 
            // SalesRadioButton
            // 
            SalesRadioButton.AutoSize = true;
            SalesRadioButton.Location = new Point(6, 189);
            SalesRadioButton.Name = "SalesRadioButton";
            SalesRadioButton.Size = new Size(152, 23);
            SalesRadioButton.TabIndex = 21;
            SalesRadioButton.TabStop = true;
            SalesRadioButton.Text = "Vendas/Estoque";
            SalesRadioButton.UseVisualStyleBackColor = true;
            SalesRadioButton.CheckedChanged += SalesRadioButton_CheckedChanged;
            // 
            // PurchaseRadioButton
            // 
            PurchaseRadioButton.AutoSize = true;
            PurchaseRadioButton.Location = new Point(6, 160);
            PurchaseRadioButton.Name = "PurchaseRadioButton";
            PurchaseRadioButton.Size = new Size(97, 23);
            PurchaseRadioButton.TabIndex = 20;
            PurchaseRadioButton.TabStop = true;
            PurchaseRadioButton.Text = "Compras";
            PurchaseRadioButton.UseVisualStyleBackColor = true;
            PurchaseRadioButton.CheckedChanged += PurchaseRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 19;
            label3.Text = "Filtrar:";
            // 
            // MaterialListComboBox
            // 
            MaterialListComboBox.FormattingEnabled = true;
            MaterialListComboBox.Location = new Point(71, 118);
            MaterialListComboBox.Name = "MaterialListComboBox";
            MaterialListComboBox.Size = new Size(151, 27);
            MaterialListComboBox.TabIndex = 18;
            MaterialListComboBox.SelectedIndexChanged += MaterialListComboBox_SelectedIndexChanged;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = SystemColors.ControlLight;
            ExportButton.FlatAppearance.BorderColor = Color.Black;
            ExportButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExportButton.Location = new Point(117, 629);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(105, 35);
            ExportButton.TabIndex = 17;
            ExportButton.Text = "Exportar";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // MainMenuButton
            // 
            MainMenuButton.BackColor = SystemColors.ControlLight;
            MainMenuButton.FlatAppearance.BorderColor = Color.Black;
            MainMenuButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuButton.Location = new Point(6, 629);
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Size = new Size(105, 35);
            MainMenuButton.TabIndex = 16;
            MainMenuButton.Text = "Voltar";
            MainMenuButton.UseVisualStyleBackColor = false;
            MainMenuButton.Click += MainMenuButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 3;
            label2.Text = "Até:";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(48, 57);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(174, 26);
            EndDatePicker.TabIndex = 2;
            EndDatePicker.ValueChanged += EndDatePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 1;
            label1.Text = "De:";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(48, 25);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(174, 26);
            StartDatePicker.TabIndex = 0;
            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            // 
            // SpredsheetUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SpredsheetUC";
            Size = new Size(1130, 670);
            Load += SpredsheetUC_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker StartDatePicker;
        private Label label2;
        private DateTimePicker EndDatePicker;
        private ListView SpreadListView;
        private Button ExportButton;
        private Button MainMenuButton;
        private Label label3;
        private ComboBox MaterialListComboBox;
        private RadioButton SalesRadioButton;
        private RadioButton PurchaseRadioButton;
    }
}
