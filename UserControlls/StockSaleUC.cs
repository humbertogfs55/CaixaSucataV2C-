using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace CaixaSucata.UserControlls
{
    public partial class StockSaleUC : UserControl
    {
        private MainFunctionsUC MainFunctionsUC;
        private Material SelectedMaterial;
        private BindingList<Material> DisplayMaterials = new BindingList<Material>();
        private List<StockSale> StockSales = new List<StockSale>();
        public StockSaleUC(MainFunctionsUC mainFunctionsUC)
        {
            MainFunctionsUC = mainFunctionsUC;
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            var materialsToDisplay = SqliteDataAccess.ListMaterials();
            if (materialsToDisplay.Count > 0)
            {
                DisplayMaterials.Clear();
                materialsToDisplay.Sort((x1, x2) => x1.Ind.CompareTo(x2.Ind));
                materialsToDisplay.ForEach(material => DisplayMaterials.Add(material));

                MaterialStockListBox.DataSource = null;
                MaterialStockListBox.Items.Clear();
                MaterialStockListBox.DisplayMember = "DisplayStock";
                MaterialStockListBox.DataSource = DisplayMaterials;
            }
            StockSales = SqliteDataAccess.ListStockSales();
            if (StockSales.Count > 0)
            {
                var companyNames = StockSales.Select(x => x.CompanyName).Distinct();
                CompanyNameComboBox.DataSource = companyNames.ToList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }

        private void MaterialStockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMaterial = (Material)MaterialStockListBox.SelectedItem;

            MaterialNameTextBox.Text = SelectedMaterial.Name;
            TotalWeightTextBox.Text = SelectedMaterial.Stock.ToString("0.00");
        }

        private void PricePerKgTextBox_TextChanged(object sender, EventArgs e)
        {

            if (PricePerKgTextBox.Text.Length > 0 && TotalWeightTextBox.Text.Length > 0 && decimal.TryParse(TotalWeightTextBox.Text, out decimal i))
            {
                var weight = decimal.Parse(TotalWeightTextBox.Text.Replace(",", "."));
                var price = decimal.Parse(PricePerKgTextBox.Text.Replace(",", "."));

                var ammountValue = price * weight;
                ammountValue = Math.Round(ammountValue / 5, 2) * 5;
                TotalValueTextBox.Text = +ammountValue + "";
            }
            else
                TotalValueTextBox.Text = string.Empty;
        }

        private void FinalizeSaleButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TotalWeightTextBox.Text, out decimal i) && decimal.TryParse(TotalValueTextBox.Text, out decimal j) && decimal.TryParse(PricePerKgTextBox.Text, out decimal k))
            {
                var stockSale = new StockSale
                {
                    Material = SelectedMaterial,
                    TotalWeight = decimal.Parse(TotalWeightTextBox.Text),
                    TotalValue = decimal.Parse(TotalValueTextBox.Text),
                    FiscalNumber = FiscalNumberTextBox.Text,
                    KilogramSalePrice = decimal.Parse(PricePerKgTextBox.Text),
                    TruckPlate = TruckPlateTextBox.Text,
                    CompanyName = CompanyNameComboBox.Text,
                    CompanyEmail = CompanyEmailTextBox.Text,
                    CompanyPhone = CompanyPhoneTextBox.Text,
                    SaleDate = DateTime.Now.Date,
                };

                SqliteDataAccess.SaveStockSale(stockSale);
                var materialToUpdate = SqliteDataAccess.GetMaterialByName(SelectedMaterial.Name);
                var alteredMaterial = materialToUpdate;
                alteredMaterial.Stock = alteredMaterial.Stock - stockSale.TotalWeight;
                SqliteDataAccess.UpdateMaterial(alteredMaterial, materialToUpdate);

                GeneratePdf(stockSale);

                MainFunctionsUC.RefreshVisualizer();
                this.Dispose();
            }
        }

        private void GeneratePdf(StockSale stockSale)
        {
            // Ensure the "Vendas" directory exists
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Vendas");
            Directory.CreateDirectory(directoryPath);

            // Generate PDF file path
            string pdfFilePath = Path.Combine(directoryPath, $"Venda_{stockSale.CompanyName}_{DateTime.Now:ddMMyyyy}.pdf");

            // Check if the directory exists; if not, create it
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Create a PdfWriter object
            using (var writer = new PdfWriter(pdfFilePath))
            {
                // Create a PdfDocument object
                using (var pdf = new PdfDocument(writer))
                {
                    // Create a Document object with some margin
                    var document = new Document(pdf);
                    document.SetBottomMargin(40);
                    document.SetTopMargin(40);
                    document.SetRightMargin(40);
                    document.SetLeftMargin(40);

                    // Add a title
                    var title = new Paragraph("Detalhes da Venda")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(18)
                        .SetBold();
                    document.Add(title);

                    // Add content to the document
                    document.Add(new Paragraph($"Data: {stockSale.SaleDate.ToString("dd/MM/yyyy")}").SetFontSize(12));
                    document.Add(new Paragraph($"Material: {stockSale.Material.Name}").SetFontSize(12));
                    document.Add(new Paragraph($"Peso Total: {stockSale.TotalWeight.ToString("0.00")} kg").SetFontSize(12));
                    document.Add(new Paragraph($"Valor Total: R$ {stockSale.TotalValue.ToString("0.00")}").SetFontSize(12));
                    document.Add(new Paragraph($"Preço por kg: R$ {stockSale.KilogramSalePrice.ToString("0.00")}").SetFontSize(12));
                    document.Add(new Paragraph($"Nota Fiscal: {stockSale.FiscalNumber}")).SetFontSize(12);
                    document.Add(new Paragraph($"Placa do Caminhão: {stockSale.TruckPlate}").SetFontSize(12));
                    document.Add(new Paragraph($"Nome da Empresa: {stockSale.CompanyName}").SetFontSize(12));
                    document.Add(new Paragraph($"Email: {stockSale.CompanyEmail}").SetFontSize(12));
                    document.Add(new Paragraph($"Telefone: {stockSale.CompanyPhone}").SetFontSize(12));
                }
            }

            Console.WriteLine($"PDF generated and saved to: {pdfFilePath}");

            // Try to open the PDF with the default application
            try
            {
                // Use ProcessStartInfo to specify the default PDF viewer
                var startInfo = new ProcessStartInfo
                {
                    FileName = pdfFilePath,
                    UseShellExecute = true
                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening PDF: {ex.Message}");
            }
        }


        private void CompanyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockSales = SqliteDataAccess.ListStockSales();
            var stocksale = StockSales.FirstOrDefault(x => x.CompanyName == CompanyNameComboBox.Text);

            if (stocksale != null)
            {
                CompanyEmailTextBox.Text = stocksale.CompanyEmail;
                CompanyPhoneTextBox.Text = stocksale.CompanyPhone;
            }
        }

        private void CompanyNameComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CompanyNameComboBox.Text = string.Empty;
        }

        private void CompanyEmailTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CompanyEmailTextBox.Text = string.Empty;
        }

        private void CompanyPhoneTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CompanyPhoneTextBox.Text = string.Empty;
        }
    }
}
