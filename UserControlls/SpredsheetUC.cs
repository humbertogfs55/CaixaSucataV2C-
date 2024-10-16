using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;

namespace CaixaSucata.UserControlls
{
    public partial class SpredsheetUC : UserControl
    {
        public List<Purchase> Purchases = new List<Purchase>();
        public List<StockSale> Sales = new List<StockSale>();
        private MainFunctionsUC MainFunctionsUC;

        public SpredsheetUC(MainFunctionsUC mainFunctionsUC)
        {
            MainFunctionsUC = mainFunctionsUC;
            InitializeComponent();
            InitializeDatePicker();
            PurchaseRadioButton.Checked = true;
            RefreshList();
        }

        private void InitializeDatePicker()
        {
            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.CustomFormat = "yyyy-MM-dd";
            EndDatePicker.Format = DateTimePickerFormat.Custom;
            EndDatePicker.CustomFormat = "yyyy-MM-dd";
            MaterialListComboBox.Items.Clear();
            MaterialListComboBox.Items.Add("");
            var list = SqliteDataAccess.ListMaterials();
            foreach (var material in list)
            {
                MaterialListComboBox.Items.Add(material.Name);
            }
        }

        private void SpredsheetUC_Load(object sender, EventArgs e)
        {

        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void MaterialListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (PurchaseRadioButton.Checked)
                ExcelExporter.ExportPurchases(Purchases, StartDatePicker.Value.Date, EndDatePicker.Value.Date.AddHours(23));
            else
                ExcelExporter.ExportSales(Sales, StartDatePicker.Value.Date, EndDatePicker.Value.Date.AddHours(23));
        }

        private void RefreshList()
        {
            if (PurchaseRadioButton.Checked)
            {
                ListPurchase();
            }
            if (SalesRadioButton.Checked)
            {
                ListSales();
            }
        }

        private void ListSales()
        {
            var startDate = StartDatePicker.Value.Date;
            var endDate = EndDatePicker.Value.Date.AddHours(23);

            Sales = SqliteDataAccess.ListStockSalesByDateRange(startDate, endDate);

            SpreadListView.Items.Clear();
            SpreadListView.Columns.Clear();
            SpreadListView.Columns.Add("Data", 100);
            SpreadListView.Columns.Add("Material", 100);
            SpreadListView.Columns.Add("Peso", 100);
            SpreadListView.Columns.Add("Preco por Kg", 120);
            SpreadListView.Columns.Add("Valor total", 100);
            SpreadListView.Columns.Add("Nota Fiscal", 130);
            SpreadListView.Columns.Add("Placa", 100);
            SpreadListView.Columns.Add("Empresa", 120);
            SpreadListView.Columns.Add("Email", 150);
            SpreadListView.Columns.Add("Telefone", 150);

            if (MaterialListComboBox.Text != "")
            {
                var filteredSales = new List<StockSale>();
                foreach (var sale in Sales)
                {
                    if (sale.Material.Name == MaterialListComboBox.Text)
                    {
                        ListViewItem listItem = new ListViewItem(sale.SaleDate.Date.ToString("dd/MM/yyyy"));
                        listItem.SubItems.Add(sale.Material.Name);
                        listItem.SubItems.Add("KG " + sale.TotalWeight.ToString("0.00"));
                        listItem.SubItems.Add("R$ " + sale.KilogramSalePrice.ToString("0.00"));
                        listItem.SubItems.Add("R$ " + sale.TotalValue.ToString("0.00"));
                        listItem.SubItems.Add(sale.FiscalNumber);
                        listItem.SubItems.Add(sale.TruckPlate);
                        listItem.SubItems.Add(sale.CompanyName);
                        listItem.SubItems.Add(sale.CompanyEmail);
                        listItem.SubItems.Add(sale.CompanyPhone);
                        SpreadListView.Items.Add(listItem);

                        filteredSales.Add(sale);
                    }
                }
                Sales = filteredSales;
            }
            else
            {
                foreach (var sale in Sales)
                {
                    ListViewItem listItem = new ListViewItem(sale.SaleDate.Date.ToString("dd/MM/yyyy"));
                    listItem.SubItems.Add(sale.Material.Name);
                    listItem.SubItems.Add("KG " + sale.TotalWeight.ToString("0.00"));
                    listItem.SubItems.Add("R$ " + sale.KilogramSalePrice.ToString("0.00"));
                    listItem.SubItems.Add("R$ " + sale.TotalValue.ToString("0.00"));
                    listItem.SubItems.Add(sale.FiscalNumber);
                    listItem.SubItems.Add(sale.TruckPlate);
                    listItem.SubItems.Add(sale.CompanyName);
                    listItem.SubItems.Add(sale.CompanyEmail);
                    listItem.SubItems.Add(sale.CompanyPhone);
                    SpreadListView.Items.Add(listItem);
                }
            }
        }

        private void ListPurchase()
        {
            var startDate = StartDatePicker.Value.Date;
            var endDate = EndDatePicker.Value.Date.AddHours(24);

            Purchases = SqliteDataAccess.ListPurchasesByDateRange(startDate, endDate);


            SpreadListView.Items.Clear();
            SpreadListView.Columns.Clear();
            SpreadListView.Columns.Add("Material", 200);
            SpreadListView.Columns.Add("Peso", 200);
            SpreadListView.Columns.Add("Valor", 200);

            var orderedPurchases = Purchases
                .GroupBy(x => x.Material.Name)
                .Select(group => new
                {
                    Name = group.Key,
                    TotalWeight = group.Sum(x => x.Weight),
                    TotalValue = group.Sum(x => x.Value)
                }).ToList();

            if (MaterialListComboBox.Text != "")
            {
                var filteredPurchases = Purchases.Where(x=>x.Material.Name == MaterialListComboBox.Text).ToList();
                Purchases = filteredPurchases;
                foreach (var group in orderedPurchases)
                {
                    if (group.Name == MaterialListComboBox.Text)
                    {
                        ListViewItem listItem = new ListViewItem(group.Name);
                        listItem.SubItems.Add("KG " + group.TotalWeight.ToString("0.00"));
                        listItem.SubItems.Add("R$ " + group.TotalValue.ToString("0.00"));
                        SpreadListView.Items.Add(listItem);
                    }
                }
            }
            else
            {
                foreach (var group in orderedPurchases)
                {
                    ListViewItem listItem = new ListViewItem(group.Name);
                    listItem.SubItems.Add("KG " + group.TotalWeight.ToString("0.00"));
                    listItem.SubItems.Add("R$ " + group.TotalValue.ToString("0.00"));
                    SpreadListView.Items.Add(listItem);
                }
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }

        private void PurchaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void SalesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
