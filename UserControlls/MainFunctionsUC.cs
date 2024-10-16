using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;

namespace CaixaSucata.UserControlls
{
    public partial class MainFunctionsUC : UserControl
    {
        private Form1 MainForm;
        public Register Register;

        public MainFunctionsUC(Form1 mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            RefreshVisualizer();
            CheckIfRegisterIsOpen();
        }

        private void CheckIfRegisterIsOpen()
        {
            var register = SqliteDataAccess.GetTodayRegister();
            if (register != null)
            {
                Register = register;
                PurchaseRegisterValueTextBox.Text = "R$ " + Register.PurchaseRegisterAmount.ToString();
                SalesRegisterValueTextBox.Text = "R$ " + Register.SalesRegisterAmount.ToString();

                OpenRegisterButton.Visible = false;
                BuyButton.Visible = true;
                SellButton.Visible = true;
                PurchaseRegisterValueTextBox.Visible = true;
                PurchaseRegisterLabel.Visible = true;
                SalesRegisterLabel.Visible = true;
                SalesRegisterValueTextBox.Visible = true;
            }
            else
            {
                Register = new Register();
            }
        }

        #region Buttons

        private void OpenRegisterButton_Click(object sender, EventArgs e)
        {
            OpenRegistry();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            SellFunctionUC sellFunctionUC = new SellFunctionUC(this);
            AddUserControl(sellFunctionUC);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            BuyFunctionUC buyFunctionUC = new BuyFunctionUC(this);
            AddUserControl(buyFunctionUC);
        }


        #endregion
        #region Methods
        public void RefreshVisualizer()
        {
            VisualizerUC vizualizerUC = new VisualizerUC(this);
            AddUserControl(vizualizerUC);
        }
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            RightMainPanel.Controls.Clear();
            RightMainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void OpenRegistry()
        {
            AportForm form = new AportForm();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                string val = form.ReturnValue;
                if (val.Length > 0)
                {
                    var amount = Decimal.Parse(val.Replace(",", "."));
                    PurchaseRegisterAmountAdd(amount);
                    Register.RegisterDate = DateTime.Now;
                    SqliteDataAccess.ClearAllRegisterOperations();
                    SqliteDataAccess.SaveRegister(Register);

                    var operation = new RegisterOperation
                    {
                        Amount = amount,
                        IsPurchase = true,
                        IsRemoval = false
                    };

                    UpdatePurchaseRegister(operation);
                    Register = SqliteDataAccess.GetTodayRegister();

                    OpenRegisterButton.Visible = false;
                    BuyButton.Visible = true;
                    SellButton.Visible = true;
                    PurchaseRegisterValueTextBox.Visible = true;
                    PurchaseRegisterLabel.Visible = true;
                    SalesRegisterLabel.Visible = true;
                    SalesRegisterValueTextBox.Visible = true;
                }
            }
        }

        #endregion
        #region RegisterMethods
        public void UpdatePurchaseRegister(RegisterOperation operation = null)
        {
            PurchaseRegisterValueTextBox.Text = "R$ " + Register.PurchaseRegisterAmount.ToString("0.00");
            SqliteDataAccess.UpdatePurchaseRegister(Register);
            if (operation != null)
            {
                SqliteDataAccess.SaveRegisterOperation(operation);
            }
        }
        public void UpdateSalesRegister(RegisterOperation operation = null)
        {
            SalesRegisterValueTextBox.Text = "R$ " + Register.SalesRegisterAmount.ToString("0.00");
            SqliteDataAccess.UpdateSalesRegister(Register);
            if (operation != null)
            {
                SqliteDataAccess.SaveRegisterOperation(operation);
            }
        }
        #endregion
        #region toolstripmenu

        private void aporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AportForm form = new AportForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string val = form.ReturnValue;
                var amount = Decimal.Parse(val.Replace(",", "."));
                PurchaseRegisterAmountAdd(amount);
                var operation = new RegisterOperation
                {
                    Amount = amount,
                    IsPurchase = true,
                    IsRemoval = false
                };
                UpdatePurchaseRegister(operation);
            }
        }
        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AportForm form = new AportForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string val = form.ReturnValue;
                var amount = Decimal.Parse(val.Replace(",", "."));
                PurchaseRegisterAmountRemove(amount);
                var operation = new RegisterOperation
                {
                    Amount = amount,
                    IsPurchase = true,
                    IsRemoval = true
                };
                UpdatePurchaseRegister(operation);
            }
        }
        private void aporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AportForm form = new AportForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string val = form.ReturnValue;
                var amount = Decimal.Parse(val.Replace(",", "."));
                SalesRegisterAmountAdd(amount);
                var operation = new RegisterOperation
                {
                    Amount = amount,
                    IsPurchase = false,
                    IsRemoval = false
                };
                UpdateSalesRegister(operation);
            }
        }

        private void retiradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AportForm form = new AportForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string val = form.ReturnValue;
                var amount = Decimal.Parse(val.Replace(",", "."));
                SalesRegisterAmountRemove(amount);
                var operation = new RegisterOperation
                {
                    Amount = amount,
                    IsPurchase = false,
                    IsRemoval = true
                };
                UpdateSalesRegister(operation);
            }
        }
        private void PlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpredsheetUC spredsheetUC = new SpredsheetUC(this);
            AddUserControl(spredsheetUC);
        }
        private void precosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigureMaterialForm configureMaterialForm = new ConfigureMaterialForm(this);
            configureMaterialForm.Show();
        }
        private void vendaDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockSaleUC stockSaleUC = new StockSaleUC(this);
            AddUserControl(stockSaleUC);
        }
        #endregion
        #region purchase register
        public void PurchaseRegisterAmountAdd(decimal amount)
        {
            Register.PurchaseRegisterAmount = Register.PurchaseRegisterAmount + Math.Round(amount / 5, 2) * 5;
        }
        public void PurchaseRegisterAmountRemove(decimal amount)
        {
            Register.PurchaseRegisterAmount = Register.PurchaseRegisterAmount - Math.Round(amount / 5, 2) * 5;
        }
        #endregion

        #region Sales Register
        public void SalesRegisterAmountAdd(decimal amount)
        {
            Register.SalesRegisterAmount = Register.SalesRegisterAmount + Math.Round(amount / 5, 2) * 5;
        }
        public void SalesRegisterAmountRemove(decimal amount)
        {
            Register.SalesRegisterAmount = Register.SalesRegisterAmount - Math.Round(amount / 5, 2) * 5;
        }
        #endregion
    }
}
