namespace CaixaSucata.UserControlls
{
    partial class CloseRegisterUC
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
            groupBox1 = new GroupBox();
            GenDocumentButton = new Button();
            label1 = new Label();
            TotalValueTextBox = new TextBox();
            TotalWeightTextBox = new TextBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            CloseProgramButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GenDocumentButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TotalValueTextBox);
            groupBox1.Controls.Add(TotalWeightTextBox);
            groupBox1.Controls.Add(listView1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 716);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fechar Compras";
            // 
            // GenDocumentButton
            // 
            GenDocumentButton.BackColor = SystemColors.ControlLight;
            GenDocumentButton.FlatAppearance.BorderColor = Color.Black;
            GenDocumentButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenDocumentButton.Location = new Point(6, 348);
            GenDocumentButton.Name = "GenDocumentButton";
            GenDocumentButton.Size = new Size(105, 35);
            GenDocumentButton.TabIndex = 5;
            GenDocumentButton.Text = "Planilha";
            GenDocumentButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 265);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 4;
            label1.Text = "Totais:";
            // 
            // TotalValueTextBox
            // 
            TotalValueTextBox.Location = new Point(264, 262);
            TotalValueTextBox.Name = "TotalValueTextBox";
            TotalValueTextBox.Size = new Size(123, 32);
            TotalValueTextBox.TabIndex = 3;
            // 
            // TotalWeightTextBox
            // 
            TotalWeightTextBox.Location = new Point(135, 262);
            TotalWeightTextBox.Name = "TotalWeightTextBox";
            TotalWeightTextBox.Size = new Size(123, 32);
            TotalWeightTextBox.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.ForeColor = SystemColors.Control;
            listView1.Location = new Point(6, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(382, 225);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CloseProgramButton);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(758, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 716);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fechar Vendas";
            // 
            // CloseProgramButton
            // 
            CloseProgramButton.BackColor = SystemColors.ControlLight;
            CloseProgramButton.FlatAppearance.BorderColor = Color.Black;
            CloseProgramButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgramButton.Location = new Point(282, 664);
            CloseProgramButton.Name = "CloseProgramButton";
            CloseProgramButton.Size = new Size(105, 35);
            CloseProgramButton.TabIndex = 6;
            CloseProgramButton.Text = "Fechar dia";
            CloseProgramButton.UseVisualStyleBackColor = false;
            // 
            // CloseRegisterUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CloseRegisterUC";
            Size = new Size(1151, 716);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TotalValueTextBox;
        private TextBox textBox2;
        private TextBox TotalWeightTextBox;
        private ListView listView1;
        private GroupBox groupBox2;
        private Label label1;
        private Button GenDocumentButton;
        private Button CloseProgramButton;
    }
}
