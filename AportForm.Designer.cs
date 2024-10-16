namespace CaixaSucata
{
    partial class AportForm
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
            OpeningValueLabel = new Label();
            ValueTextBox = new TextBox();
            CancelButton = new Button();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // OpeningValueLabel
            // 
            OpeningValueLabel.AutoSize = true;
            OpeningValueLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OpeningValueLabel.Location = new Point(13, 15);
            OpeningValueLabel.Name = "OpeningValueLabel";
            OpeningValueLabel.Size = new Size(67, 24);
            OpeningValueLabel.TabIndex = 0;
            OpeningValueLabel.Text = "Valor:";
            // 
            // ValueTextBox
            // 
            ValueTextBox.BackColor = SystemColors.Control;
            ValueTextBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ValueTextBox.Location = new Point(86, 12);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(315, 32);
            ValueTextBox.TabIndex = 1;
            ValueTextBox.MouseDown += ValueTextBox_MouseDown;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.ControlLight;
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.Location = new Point(182, 50);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(105, 35);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancelar";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = SystemColors.ControlLight;
            ConfirmButton.FlatAppearance.BorderColor = Color.Black;
            ConfirmButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmButton.Location = new Point(296, 50);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(105, 35);
            ConfirmButton.TabIndex = 3;
            ConfirmButton.Text = "Confirmar";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // AportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(413, 92);
            Controls.Add(ConfirmButton);
            Controls.Add(CancelButton);
            Controls.Add(ValueTextBox);
            Controls.Add(OpeningValueLabel);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OpeningValueLabel;
        private TextBox ValueTextBox;
        private new Button CancelButton;
        private Button ConfirmButton;
    }
}