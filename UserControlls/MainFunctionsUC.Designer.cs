namespace CaixaSucata.UserControlls
{
    partial class MainFunctionsUC
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
            MainFunctionsHeaderPanel = new Panel();
            menuStrip1 = new MenuStrip();
            funçõesDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            caixaDeComprasToolStripMenuItem = new ToolStripMenuItem();
            aporteToolStripMenuItem = new ToolStripMenuItem();
            retiradaToolStripMenuItem = new ToolStripMenuItem();
            caixaDeVendasToolStripMenuItem = new ToolStripMenuItem();
            aporteToolStripMenuItem1 = new ToolStripMenuItem();
            retiradaToolStripMenuItem1 = new ToolStripMenuItem();
            planilhaToolStripMenuItem = new ToolStripMenuItem();
            configurToolStripMenuItem = new ToolStripMenuItem();
            precosToolStripMenuItem = new ToolStripMenuItem();
            ClicableButtonsPanel = new Panel();
            SalesRegisterLabel = new Label();
            SalesRegisterValueTextBox = new TextBox();
            PurchaseRegisterLabel = new Label();
            PurchaseRegisterValueTextBox = new TextBox();
            OpenRegisterButton = new Button();
            SellButton = new Button();
            BuyButton = new Button();
            RightMainPanel = new Panel();
            vendaDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            MainFunctionsHeaderPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            ClicableButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainFunctionsHeaderPanel
            // 
            MainFunctionsHeaderPanel.Controls.Add(menuStrip1);
            MainFunctionsHeaderPanel.Dock = DockStyle.Top;
            MainFunctionsHeaderPanel.Location = new Point(0, 0);
            MainFunctionsHeaderPanel.Name = "MainFunctionsHeaderPanel";
            MainFunctionsHeaderPanel.Size = new Size(1366, 24);
            MainFunctionsHeaderPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funçõesDeCaixaToolStripMenuItem, configurToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1366, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // funçõesDeCaixaToolStripMenuItem
            // 
            funçõesDeCaixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaDeComprasToolStripMenuItem, caixaDeVendasToolStripMenuItem, vendaDeEstoqueToolStripMenuItem, planilhaToolStripMenuItem });
            funçõesDeCaixaToolStripMenuItem.Name = "funçõesDeCaixaToolStripMenuItem";
            funçõesDeCaixaToolStripMenuItem.Size = new Size(124, 20);
            funçõesDeCaixaToolStripMenuItem.Text = "Funções de Caixa";
            // 
            // caixaDeComprasToolStripMenuItem
            // 
            caixaDeComprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aporteToolStripMenuItem, retiradaToolStripMenuItem });
            caixaDeComprasToolStripMenuItem.Name = "caixaDeComprasToolStripMenuItem";
            caixaDeComprasToolStripMenuItem.Size = new Size(182, 22);
            caixaDeComprasToolStripMenuItem.Text = "Caixa de compras";
            // 
            // aporteToolStripMenuItem
            // 
            aporteToolStripMenuItem.Name = "aporteToolStripMenuItem";
            aporteToolStripMenuItem.Size = new Size(122, 22);
            aporteToolStripMenuItem.Text = "Aporte";
            aporteToolStripMenuItem.Click += aporteToolStripMenuItem_Click;
            // 
            // retiradaToolStripMenuItem
            // 
            retiradaToolStripMenuItem.Name = "retiradaToolStripMenuItem";
            retiradaToolStripMenuItem.Size = new Size(122, 22);
            retiradaToolStripMenuItem.Text = "Retirada";
            retiradaToolStripMenuItem.Click += retiradaToolStripMenuItem_Click;
            // 
            // caixaDeVendasToolStripMenuItem
            // 
            caixaDeVendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aporteToolStripMenuItem1, retiradaToolStripMenuItem1 });
            caixaDeVendasToolStripMenuItem.Name = "caixaDeVendasToolStripMenuItem";
            caixaDeVendasToolStripMenuItem.Size = new Size(182, 22);
            caixaDeVendasToolStripMenuItem.Text = "Caixa de vendas";
            // 
            // aporteToolStripMenuItem1
            // 
            aporteToolStripMenuItem1.Name = "aporteToolStripMenuItem1";
            aporteToolStripMenuItem1.Size = new Size(122, 22);
            aporteToolStripMenuItem1.Text = "Aporte";
            aporteToolStripMenuItem1.Click += aporteToolStripMenuItem1_Click;
            // 
            // retiradaToolStripMenuItem1
            // 
            retiradaToolStripMenuItem1.Name = "retiradaToolStripMenuItem1";
            retiradaToolStripMenuItem1.Size = new Size(122, 22);
            retiradaToolStripMenuItem1.Text = "Retirada";
            retiradaToolStripMenuItem1.Click += retiradaToolStripMenuItem1_Click;
            // 
            // planilhaToolStripMenuItem
            // 
            planilhaToolStripMenuItem.Name = "planilhaToolStripMenuItem";
            planilhaToolStripMenuItem.Size = new Size(182, 22);
            planilhaToolStripMenuItem.Text = "Planilha";
            planilhaToolStripMenuItem.Click += PlanilhaToolStripMenuItem_Click;
            // 
            // configurToolStripMenuItem
            // 
            configurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { precosToolStripMenuItem });
            configurToolStripMenuItem.Name = "configurToolStripMenuItem";
            configurToolStripMenuItem.Size = new Size(94, 20);
            configurToolStripMenuItem.Text = "Configuração";
            // 
            // precosToolStripMenuItem
            // 
            precosToolStripMenuItem.Name = "precosToolStripMenuItem";
            precosToolStripMenuItem.Size = new Size(120, 22);
            precosToolStripMenuItem.Text = "Material";
            precosToolStripMenuItem.Click += precosToolStripMenuItem_Click;
            // 
            // ClicableButtonsPanel
            // 
            ClicableButtonsPanel.Controls.Add(SalesRegisterLabel);
            ClicableButtonsPanel.Controls.Add(SalesRegisterValueTextBox);
            ClicableButtonsPanel.Controls.Add(PurchaseRegisterLabel);
            ClicableButtonsPanel.Controls.Add(PurchaseRegisterValueTextBox);
            ClicableButtonsPanel.Controls.Add(OpenRegisterButton);
            ClicableButtonsPanel.Controls.Add(SellButton);
            ClicableButtonsPanel.Controls.Add(BuyButton);
            ClicableButtonsPanel.Dock = DockStyle.Left;
            ClicableButtonsPanel.Location = new Point(0, 24);
            ClicableButtonsPanel.Name = "ClicableButtonsPanel";
            ClicableButtonsPanel.Size = new Size(215, 716);
            ClicableButtonsPanel.TabIndex = 1;
            // 
            // SalesRegisterLabel
            // 
            SalesRegisterLabel.AutoSize = true;
            SalesRegisterLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SalesRegisterLabel.Location = new Point(12, 113);
            SalesRegisterLabel.Name = "SalesRegisterLabel";
            SalesRegisterLabel.Size = new Size(186, 24);
            SalesRegisterLabel.TabIndex = 9;
            SalesRegisterLabel.Text = "Caixa De Vendas:";
            SalesRegisterLabel.Visible = false;
            // 
            // SalesRegisterValueTextBox
            // 
            SalesRegisterValueTextBox.CausesValidation = false;
            SalesRegisterValueTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SalesRegisterValueTextBox.Location = new Point(3, 140);
            SalesRegisterValueTextBox.Name = "SalesRegisterValueTextBox";
            SalesRegisterValueTextBox.ReadOnly = true;
            SalesRegisterValueTextBox.RightToLeft = RightToLeft.Yes;
            SalesRegisterValueTextBox.ShortcutsEnabled = false;
            SalesRegisterValueTextBox.Size = new Size(209, 32);
            SalesRegisterValueTextBox.TabIndex = 8;
            SalesRegisterValueTextBox.TabStop = false;
            SalesRegisterValueTextBox.TextAlign = HorizontalAlignment.Center;
            SalesRegisterValueTextBox.Visible = false;
            // 
            // PurchaseRegisterLabel
            // 
            PurchaseRegisterLabel.AutoSize = true;
            PurchaseRegisterLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PurchaseRegisterLabel.Location = new Point(3, 10);
            PurchaseRegisterLabel.Name = "PurchaseRegisterLabel";
            PurchaseRegisterLabel.Size = new Size(204, 24);
            PurchaseRegisterLabel.TabIndex = 7;
            PurchaseRegisterLabel.Text = "Caixa De Compras:";
            PurchaseRegisterLabel.Visible = false;
            // 
            // PurchaseRegisterValueTextBox
            // 
            PurchaseRegisterValueTextBox.CausesValidation = false;
            PurchaseRegisterValueTextBox.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PurchaseRegisterValueTextBox.Location = new Point(3, 37);
            PurchaseRegisterValueTextBox.Name = "PurchaseRegisterValueTextBox";
            PurchaseRegisterValueTextBox.ReadOnly = true;
            PurchaseRegisterValueTextBox.RightToLeft = RightToLeft.Yes;
            PurchaseRegisterValueTextBox.ShortcutsEnabled = false;
            PurchaseRegisterValueTextBox.Size = new Size(209, 32);
            PurchaseRegisterValueTextBox.TabIndex = 6;
            PurchaseRegisterValueTextBox.TabStop = false;
            PurchaseRegisterValueTextBox.TextAlign = HorizontalAlignment.Center;
            PurchaseRegisterValueTextBox.Visible = false;
            // 
            // OpenRegisterButton
            // 
            OpenRegisterButton.BackColor = SystemColors.ControlLight;
            OpenRegisterButton.FlatAppearance.BorderColor = Color.Black;
            OpenRegisterButton.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OpenRegisterButton.Location = new Point(3, 6);
            OpenRegisterButton.Name = "OpenRegisterButton";
            OpenRegisterButton.Size = new Size(206, 35);
            OpenRegisterButton.TabIndex = 4;
            OpenRegisterButton.Text = "Abrir Caixa";
            OpenRegisterButton.UseVisualStyleBackColor = false;
            OpenRegisterButton.Click += OpenRegisterButton_Click;
            // 
            // SellButton
            // 
            SellButton.BackColor = SystemColors.ControlLight;
            SellButton.FlatAppearance.BorderColor = Color.Black;
            SellButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SellButton.Location = new Point(3, 178);
            SellButton.Name = "SellButton";
            SellButton.Size = new Size(206, 35);
            SellButton.TabIndex = 3;
            SellButton.Text = "Venda";
            SellButton.UseVisualStyleBackColor = false;
            SellButton.Visible = false;
            SellButton.Click += SellButton_Click;
            // 
            // BuyButton
            // 
            BuyButton.BackColor = SystemColors.ControlLight;
            BuyButton.FlatAppearance.BorderColor = Color.Black;
            BuyButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BuyButton.Location = new Point(3, 75);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(206, 35);
            BuyButton.TabIndex = 0;
            BuyButton.Text = "Compra";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Visible = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // RightMainPanel
            // 
            RightMainPanel.Dock = DockStyle.Fill;
            RightMainPanel.Location = new Point(215, 24);
            RightMainPanel.Name = "RightMainPanel";
            RightMainPanel.Size = new Size(1151, 716);
            RightMainPanel.TabIndex = 2;
            // 
            // vendaDeEstoqueToolStripMenuItem
            // 
            vendaDeEstoqueToolStripMenuItem.Name = "vendaDeEstoqueToolStripMenuItem";
            vendaDeEstoqueToolStripMenuItem.Size = new Size(182, 22);
            vendaDeEstoqueToolStripMenuItem.Text = "Venda De Estoque";
            vendaDeEstoqueToolStripMenuItem.Click += vendaDeEstoqueToolStripMenuItem_Click;
            // 
            // MainFunctionsUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(RightMainPanel);
            Controls.Add(ClicableButtonsPanel);
            Controls.Add(MainFunctionsHeaderPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainFunctionsUC";
            Size = new Size(1366, 740);
            MainFunctionsHeaderPanel.ResumeLayout(false);
            MainFunctionsHeaderPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ClicableButtonsPanel.ResumeLayout(false);
            ClicableButtonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainFunctionsHeaderPanel;
        private Panel ClicableButtonsPanel;
        private Button BuyButton;
        private Button SellButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configurToolStripMenuItem;
        private ToolStripMenuItem precosToolStripMenuItem;
        private Button OpenRegisterButton;
        private TextBox PurchaseRegisterValueTextBox;
        private Panel RightMainPanel;
        private ToolStripMenuItem funçõesDeCaixaToolStripMenuItem;
        private ToolStripMenuItem caixaDeComprasToolStripMenuItem;
        private ToolStripMenuItem aporteToolStripMenuItem;
        private ToolStripMenuItem retiradaToolStripMenuItem;
        private ToolStripMenuItem caixaDeVendasToolStripMenuItem;
        private ToolStripMenuItem aporteToolStripMenuItem1;
        private ToolStripMenuItem retiradaToolStripMenuItem1;
        private Label SalesRegisterLabel;
        private TextBox SalesRegisterValueTextBox;
        private Label PurchaseRegisterLabel;
        private ToolStripMenuItem planilhaToolStripMenuItem;
        private ToolStripMenuItem vendaDeEstoqueToolStripMenuItem;
    }
}
