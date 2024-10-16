namespace CaixaSucata.UserControlls
{
    partial class VisualizerUC
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
            rightMainPanel = new Panel();
            VisualizerPanel = new Panel();
            VisualizerListView = new ListView();
            TabControllPanel = new Panel();
            ClosingButton = new Button();
            StockButton = new Button();
            SalesList = new Button();
            BuyList = new Button();
            rightMainPanel.SuspendLayout();
            VisualizerPanel.SuspendLayout();
            TabControllPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rightMainPanel
            // 
            rightMainPanel.Controls.Add(VisualizerPanel);
            rightMainPanel.Controls.Add(TabControllPanel);
            rightMainPanel.Dock = DockStyle.Fill;
            rightMainPanel.Location = new Point(0, 0);
            rightMainPanel.Name = "rightMainPanel";
            rightMainPanel.Size = new Size(1130, 670);
            rightMainPanel.TabIndex = 3;
            // 
            // VisualizerPanel
            // 
            VisualizerPanel.Controls.Add(VisualizerListView);
            VisualizerPanel.Dock = DockStyle.Fill;
            VisualizerPanel.Location = new Point(0, 35);
            VisualizerPanel.Name = "VisualizerPanel";
            VisualizerPanel.Size = new Size(1130, 635);
            VisualizerPanel.TabIndex = 4;
            // 
            // VisualizerListView
            // 
            VisualizerListView.BackColor = SystemColors.ControlDark;
            VisualizerListView.Dock = DockStyle.Fill;
            VisualizerListView.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            VisualizerListView.GridLines = true;
            VisualizerListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            VisualizerListView.Location = new Point(0, 0);
            VisualizerListView.MultiSelect = false;
            VisualizerListView.Name = "VisualizerListView";
            VisualizerListView.Size = new Size(1130, 635);
            VisualizerListView.TabIndex = 0;
            VisualizerListView.UseCompatibleStateImageBehavior = false;
            VisualizerListView.View = View.Details;
            // 
            // TabControllPanel
            // 
            TabControllPanel.BackColor = SystemColors.ControlDark;
            TabControllPanel.Controls.Add(ClosingButton);
            TabControllPanel.Controls.Add(StockButton);
            TabControllPanel.Controls.Add(SalesList);
            TabControllPanel.Controls.Add(BuyList);
            TabControllPanel.Dock = DockStyle.Top;
            TabControllPanel.Location = new Point(0, 0);
            TabControllPanel.Name = "TabControllPanel";
            TabControllPanel.Size = new Size(1130, 35);
            TabControllPanel.TabIndex = 3;
            // 
            // ClosingButton
            // 
            ClosingButton.BackColor = SystemColors.ControlLight;
            ClosingButton.FlatAppearance.BorderColor = Color.Black;
            ClosingButton.FlatStyle = FlatStyle.Popup;
            ClosingButton.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ClosingButton.Location = new Point(360, 0);
            ClosingButton.Name = "ClosingButton";
            ClosingButton.Size = new Size(120, 35);
            ClosingButton.TabIndex = 4;
            ClosingButton.Text = "Fechamento";
            ClosingButton.UseVisualStyleBackColor = false;
            ClosingButton.Click += ClosingButton_Click;
            // 
            // StockButton
            // 
            StockButton.BackColor = SystemColors.ControlLight;
            StockButton.FlatAppearance.BorderColor = Color.Black;
            StockButton.FlatStyle = FlatStyle.Popup;
            StockButton.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            StockButton.Location = new Point(240, 0);
            StockButton.Name = "StockButton";
            StockButton.Size = new Size(120, 35);
            StockButton.TabIndex = 3;
            StockButton.Text = "Estoque";
            StockButton.UseVisualStyleBackColor = false;
            StockButton.Click += StockButton_Click;
            // 
            // SalesList
            // 
            SalesList.BackColor = SystemColors.ControlLight;
            SalesList.FlatAppearance.BorderColor = Color.Black;
            SalesList.FlatStyle = FlatStyle.Popup;
            SalesList.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalesList.Location = new Point(120, 0);
            SalesList.Name = "SalesList";
            SalesList.Size = new Size(120, 35);
            SalesList.TabIndex = 2;
            SalesList.Text = "Vendas";
            SalesList.UseVisualStyleBackColor = false;
            SalesList.Click += SalesList_Click;
            // 
            // BuyList
            // 
            BuyList.BackColor = SystemColors.ControlLight;
            BuyList.FlatAppearance.BorderColor = Color.Black;
            BuyList.FlatStyle = FlatStyle.Popup;
            BuyList.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BuyList.Location = new Point(0, 0);
            BuyList.Name = "BuyList";
            BuyList.Size = new Size(120, 35);
            BuyList.TabIndex = 1;
            BuyList.Text = "Compras ";
            BuyList.UseVisualStyleBackColor = false;
            BuyList.Click += BuyList_Click;
            // 
            // VisualizerUC
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rightMainPanel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "VisualizerUC";
            Size = new Size(1130, 670);
            rightMainPanel.ResumeLayout(false);
            VisualizerPanel.ResumeLayout(false);
            TabControllPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel rightMainPanel;
        private Panel VisualizerPanel;
        private Panel TabControllPanel;
        private Button SalesList;
        private Button BuyList;
        private Button StockButton;
        private ListView VisualizerListView;
        private Button ClosingButton;
    }
}
