using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;
using System.ComponentModel;

namespace CaixaSucata.UserControlls
{
    public partial class BuyFunctionUC : UserControl
    {
        private MainFunctionsUC MainFunctionsUC;
        private BindingList<Material> DisplayMaterials = new BindingList<Material>();
        private BindingList<Purchase> Purchases = new BindingList<Purchase>();
        private int CurrentList = 0;
        private decimal FinalValue = 0;
        private Material SelectedMaterial;
        public BuyFunctionUC(MainFunctionsUC mainFunctionsUC)
        {
            InitializeComponent();
            Purchases.ListChanged += Purchases_ListChanged;
            MainFunctionsUC = mainFunctionsUC;

            LoadMaterialList();
        }

        #region Methods
        private void LoadMaterialList()
        {
            var materialsToDisplay = SqliteDataAccess.ListMaterials();
            if (materialsToDisplay.Count > 0)
            {
                DisplayMaterials.Clear();
                materialsToDisplay.Sort((x1, x2) => x1.Ind.CompareTo(x2.Ind));
                materialsToDisplay.ForEach(material => DisplayMaterials.Add(material));

                MaterialListBox.DataSource = null;
                MaterialListBox.Items.Clear();
                MaterialListBox.DisplayMember = "DisplayStandart";
                MaterialListBox.DataSource = DisplayMaterials;
            }
        }
        private void StartListStandart()
        {
            MaterialListBox.DisplayMember = "DisplayStandart";
            CurrentList = 0;
        }
        private void StartListPrice1()
        {
            MaterialListBox.DisplayMember = "DisplayMod1";
            CurrentList = 1;
        }
        private void StartListPrice2()
        {
            MaterialListBox.DisplayMember = "DisplayMod2";
            CurrentList = 2;
        }
        #endregion

        private void MaterialsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialListBox.SelectedIndex != -1)
            {
                SelectedMaterial = (Material)MaterialListBox.SelectedItem;
                UpdatePriceTextBox(SelectedMaterial);

                WeightTextBox.Text = "";
                AmountValueTextBox.Text = "";
            }
        }

        private void CancelPurchaseButton_Click(object sender, EventArgs e)
        {
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }

        private void RegularCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartListStandart();
            UpdatePriceTextBox(SelectedMaterial);
        }

        private void PartnerCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartListPrice1();
            UpdatePriceTextBox(SelectedMaterial);
        }

        private void SpecialCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            StartListPrice2();
            UpdatePriceTextBox(SelectedMaterial);
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WeightTextBox.Text.Length > 0 && decimal.TryParse(WeightTextBox.Text, out decimal i))
            {
                var weight = decimal.Parse(WeightTextBox.Text.Replace(",", "."));
                var price = decimal.Parse(PriceTextBox.Text.Replace(",", "."));

                var ammountValue = price * weight;
                ammountValue = Math.Round(ammountValue / 5, 2) * 5;
                AmountValueTextBox.Text = +ammountValue + "";
            }
            else
                AmountValueTextBox.Text = string.Empty;
        }

        private void AddPurchaseButton_Click(object sender, EventArgs e)
        {
            if (MaterialListBox.SelectedIndex != -1 && WeightTextBox.Text.Length > 0 && AmountValueTextBox.Text.Length > 0)
            {
                Material selectedMaterial = (Material)MaterialListBox.SelectedItem;
                var purchase = new Purchase
                {
                    IsSale = false,
                    Material = selectedMaterial,
                    Weight = decimal.Parse(WeightTextBox.Text),
                    Value = decimal.Parse(AmountValueTextBox.Text),
                    SellerName = SellerNameTextBox.Text
                };
                purchase.Material.Stock += purchase.Weight;
                Purchases.Add(purchase);
                PurchasesListBox.DataSource = null;
                PurchasesListBox.DisplayMember = "DisplayBuyScreen";
                PurchasesListBox.DataSource = Purchases;
            }
        }
        private void UpdatePriceTextBox(Material selectedMaterial)
        {
            if (CurrentList == 0)
            {
                PriceTextBox.Text = selectedMaterial.StandartPrice.ToString();
            }
            if (CurrentList == 1)
            {
                PriceTextBox.Text = selectedMaterial.ModifiedPrice1.ToString();
            }
            if (CurrentList == 2)
            {
                PriceTextBox.Text = selectedMaterial.ModifiedPrice2.ToString();
            }
        }

        private void ExcludeItemButton_Click(object sender, EventArgs e)
        {
            if (PurchasesListBox.SelectedIndex != -1)
            {
                var selectedPurchase = (Purchase)PurchasesListBox.SelectedItem;
                Purchases.Remove(selectedPurchase);

                PurchasesListBox.DataSource = null;
                PurchasesListBox.DisplayMember = "DisplayBuyScreen";
                PurchasesListBox.DataSource = Purchases;
            }
        }

        private void Purchases_ListChanged(object sender, ListChangedEventArgs e)
        {
            FinalValue = Purchases.Sum(x => x.Value);
            FinalValueTextBox.Text = FinalValue.ToString();
        }

        private void FinalizePurchaseButton_Click(object sender, EventArgs e)
        {
            foreach (Purchase purchase in Purchases)
            {
                purchase.PurchaseTime = DateTime.Now;
                SqliteDataAccess.SavePurchase(purchase);
                SqliteDataAccess.UpdateMaterialStock(purchase.Material);
            }
            MainFunctionsUC.PurchaseRegisterAmountRemove(FinalValue);
            MainFunctionsUC.UpdatePurchaseRegister();
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }
    }
}
