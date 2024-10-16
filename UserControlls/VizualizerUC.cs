using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;
using System.Data;

namespace CaixaSucata.UserControlls
{
    public partial class VisualizerUC : UserControl
    {
        private MainFunctionsUC MainFunctionsUC;
        public VisualizerUC(MainFunctionsUC mainFunctionsUC)
        {
            InitializeComponent();
            MainFunctionsUC = mainFunctionsUC;
            SetVisualizerPurchase();
        }

        private void BuyList_Click(object sender, EventArgs e)
        {
            SetVisualizerPurchase();
        }
        private void SalesList_Click(object sender, EventArgs e)
        {
            SetVisualizerSales();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            SetVisualizerStock();
        }
        private void ClosingButton_Click(object sender, EventArgs e)
        {
            SetVisualizerClosing();
        }

        private void SetVisualizerClosing()
        {
            VisualizerListView.Items.Clear();
            VisualizerListView.Columns.Clear();
            VisualizerListView.Columns.Add("Caixa", 150);
            VisualizerListView.Columns.Add("Total", 150);
            VisualizerListView.Columns.Add("Aportes", 150);
            VisualizerListView.Columns.Add("Retiradas", 150);
            VisualizerListView.Columns.Add("Valor Final", 200);
            var allOperations = SqliteDataAccess.GetAllRegisterOperations();

            List<RegisterOperation> PurchasesAports;
            List<RegisterOperation> PurchasesRemovals;
            List<RegisterOperation> SalesAports;
            List<RegisterOperation> SalesRemovals;
            SeparateOperations(allOperations, out PurchasesAports, out PurchasesRemovals, out SalesAports, out SalesRemovals);

            var purchases = SqliteDataAccess.GetPurchasesByDay(DateTime.Now, false);
            var purchaseTotal = purchases.Sum(x => x.Value);
            var purchaseAportTotal = PurchasesAports.Sum(x => x.Amount);
            var purchaseRemovalTotal = PurchasesRemovals.Sum(x => x.Amount);
            var finalPurchaseValue = purchaseAportTotal - purchaseTotal - purchaseRemovalTotal; 

            var sales = SqliteDataAccess.GetPurchasesByDay(DateTime.Now, true);
            var saleTotal = sales.Sum(x => x.Value);
            var saleAportTotal = SalesAports.Sum(x => x.Amount);
            var saleRemovalTotal = SalesRemovals.Sum(x => x.Amount);
            var finalSaleValue = saleAportTotal + saleTotal - saleRemovalTotal;

            //construct purchase register
            ListViewItem purchaseItem = new ListViewItem("Compras");
            purchaseItem.SubItems.Add("R$ " + purchaseTotal.ToString());
            purchaseItem.SubItems.Add("R$ " + purchaseAportTotal.ToString());
            purchaseItem.SubItems.Add("R$ " + purchaseRemovalTotal.ToString());
            purchaseItem.SubItems.Add("R$ " + finalPurchaseValue.ToString());
            VisualizerListView.Items.Add(purchaseItem);

            //construct sales register
            ListViewItem saleItem = new ListViewItem("Vendas");
            saleItem.SubItems.Add("R$ " + saleTotal.ToString());
            saleItem.SubItems.Add("R$ " + saleAportTotal.ToString());
            saleItem.SubItems.Add("R$ " + saleRemovalTotal.ToString());
            saleItem.SubItems.Add("R$ " + finalSaleValue.ToString());
            VisualizerListView.Items.Add(saleItem);

        }

        private void SetVisualizerStock()
        {
            VisualizerListView.Items.Clear();
            VisualizerListView.Columns.Clear();
            VisualizerListView.Columns.Add("Material", 200);
            VisualizerListView.Columns.Add("Peso", 200);

            var materials = SqliteDataAccess.ListMaterials();

            foreach (var material in materials)
            {
                ListViewItem listItem = new ListViewItem(material.Name);
                listItem.SubItems.Add("KG " + material.Stock.ToString("0.00"));
                VisualizerListView.Items.Add(listItem);
            }
        }

        private void SetVisualizerPurchase()
        {
            VisualizerListView.Items.Clear();
            VisualizerListView.Columns.Clear();
            VisualizerListView.Columns.Add("Hora", 100);
            VisualizerListView.Columns.Add("Material", 150);
            VisualizerListView.Columns.Add("Valor", 150);
            VisualizerListView.Columns.Add("Peso", 150);
            VisualizerListView.Columns.Add("Nome", 230);

            var purchases = SqliteDataAccess.GetPurchasesByDay(DateTime.Now, false);

            var orderedPurchases = purchases.OrderByDescending(x => x.PurchaseTime).ToList();
            foreach (var purchase in orderedPurchases)
            {
                ListViewItem listItem = new ListViewItem(purchase.PurchaseTime.ToString("HH:mm"));
                listItem.SubItems.Add(purchase.Material.Name);
                listItem.SubItems.Add("R$ " + purchase.Value.ToString());
                listItem.SubItems.Add("KG " + purchase.Weight.ToString("0.00"));
                listItem.SubItems.Add(purchase.SellerName);
                VisualizerListView.Items.Add(listItem);
            }
        }

        private void SetVisualizerSales()
        {
            VisualizerListView.Items.Clear();
            VisualizerListView.Columns.Clear();
            VisualizerListView.Columns.Add("Hora", 100);
            VisualizerListView.Columns.Add("Material", 150);
            VisualizerListView.Columns.Add("Valor", 150);
            VisualizerListView.Columns.Add("Peso", 150);

            var sales = SqliteDataAccess.GetPurchasesByDay(DateTime.Now, true);

            var orderedSales = sales.OrderByDescending(x => x.PurchaseTime).ToList();
            foreach (var sale in orderedSales)
            {
                ListViewItem listItem = new ListViewItem(sale.PurchaseTime.ToString("HH:mm"));
                listItem.SubItems.Add(sale.Material.Name);
                listItem.SubItems.Add("R$ " + sale.Value.ToString());
                listItem.SubItems.Add("KG " + sale.Weight.ToString("0.00"));
                VisualizerListView.Items.Add(listItem);
            }
        }

        public static void SeparateOperations(List<RegisterOperation> allOperations, out List<RegisterOperation> PurchasesAports, out List<RegisterOperation> PurchasesRemovals, out List<RegisterOperation> SalesAports, out List<RegisterOperation> SalesRemovals)
        {
            PurchasesAports = allOperations.Where(op => op.IsPurchase && !op.IsRemoval).ToList();
            PurchasesRemovals = allOperations.Where(op => op.IsPurchase && op.IsRemoval).ToList();
            SalesAports = allOperations.Where(op => !op.IsPurchase && !op.IsRemoval).ToList();
            SalesRemovals = allOperations.Where(op => !op.IsPurchase && op.IsRemoval).ToList();
        }
    }
}
