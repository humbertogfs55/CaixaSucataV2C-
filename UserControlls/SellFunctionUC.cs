using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;
using System.ComponentModel;

namespace CaixaSucata.UserControlls
{
    public partial class SellFunctionUC : UserControl
    {
        private MainFunctionsUC MainFunctionsUC;
        private Material SelectedMaterial;
        private BindingList<Material> DisplayMaterials = new BindingList<Material>();
        private BindingList<Purchase> Sales = new BindingList<Purchase>();
        private decimal FinalValue = 0;

        public SellFunctionUC(MainFunctionsUC mainFunctionsUC)
        {
            InitializeComponent();
            MainFunctionsUC = mainFunctionsUC;
            Sales.ListChanged += Sales_ListChanged;

            LoadMaterialList();
        }

        private void LoadMaterialList()
        {
            var materialsToDisplay = SqliteDataAccess.ListMaterials();
            if (materialsToDisplay.Count > 0)
            {
                DisplayMaterials.Clear();
                materialsToDisplay.Sort((x1, x2) => x1.Ind.CompareTo(x2.Ind));
                materialsToDisplay.ForEach(material => DisplayMaterials.Add(material));

                SellItemsListBox.DataSource = null;
                SellItemsListBox.Items.Clear();
                SellItemsListBox.DisplayMember = "DisplayStandart";
                SellItemsListBox.DataSource = DisplayMaterials;
            }
        }

        private void CancelSailButton_Click(object sender, EventArgs e)
        {
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }

        private void SellItemButton_Click(object sender, EventArgs e)
        {
            if (ItemWeightTextBox.Text.Length > 0 && ItemTotalTextBox.Text.Length > 0)
            {
                var purchase = new Purchase
                {
                    IsSale = true,
                    Material = SelectedMaterial,
                    Weight = decimal.Parse(ItemWeightTextBox.Text),
                    Value = decimal.Parse(ItemTotalTextBox.Text)
                };
                Sales.Add(purchase);
                SoldItemsListBox.DataSource = null;
                SoldItemsListBox.DisplayMember = "DisplayBuyScreen";
                SoldItemsListBox.DataSource = Sales;
            }
        }

        private void SellItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SellItemsListBox.SelectedIndex != -1)
            {
                SelectedMaterial = (Material)SellItemsListBox.SelectedItem;
                ItemPriceTextBox.Text = SelectedMaterial.StandartPrice.ToString();

                ItemWeightTextBox.Text = "";
                ItemTotalTextBox.Text = "";
            }
        }

        private void ItemWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemWeightTextBox.Text.Length > 0 && decimal.TryParse(ItemWeightTextBox.Text, out decimal i))
            {
                var weight = decimal.Parse(ItemWeightTextBox.Text.Replace(",", "."));
                var price = decimal.Parse(ItemPriceTextBox.Text.Replace(",", "."));

                var ammountValue = price * weight;
                ammountValue = Math.Round(ammountValue / 5, 2) * 5;
                ItemTotalTextBox.Text = +ammountValue + "";
            }
        }

        private void ExcludeItemButton_Click(object sender, EventArgs e)
        {
            if (SoldItemsListBox.SelectedIndex != -1)
            {
                var selectedSale = (Purchase)SoldItemsListBox.SelectedItem;
                Sales.Remove(selectedSale);

                SoldItemsListBox.DataSource = null;
                SoldItemsListBox.DisplayMember = "DisplayBuyScreen";
                SoldItemsListBox.DataSource = Sales;
            }
        }

        private void Sales_ListChanged(object sender, EventArgs e)
        {
            FinalValue = Sales.Sum(x => x.Value);
            FinalValueTextBox.Text = FinalValue.ToString();
        }

        private void FinalizeSalesButton_Click(object sender, EventArgs e)
        {
            foreach (Purchase sale in Sales)
            {
                sale.PurchaseTime = DateTime.Now;
                SqliteDataAccess.SavePurchase(sale);
            }
            MainFunctionsUC.SalesRegisterAmountAdd(FinalValue);
            MainFunctionsUC.UpdateSalesRegister();
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }
    }
}
