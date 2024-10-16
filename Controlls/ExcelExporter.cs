using CaixaSucata.Models.ObjectModels;
using OfficeOpenXml;
using System.ComponentModel;
using System.Diagnostics;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace CaixaSucata.Controlls
{
    public class ExcelExporter
    {
        public ExcelExporter()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public static List<DateTime> GetDaysBetween(DateTime startDate, DateTime endDate)
        {
            List<DateTime> daysInRange = new List<DateTime>();

            // Iterate through the days between start and end dates
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                daysInRange.Add(date);
            }

            return daysInRange;
        }
        public static int GetMaterialColumnIndex(Material material, List<Purchase> purchases)
        {
            // Your implementation logic to get the column index based on the material
            // For simplicity, you can assume a fixed mapping between materials and column indices
            // For example, if material names are unique, you can use a dictionary to map material names to column indices
            // Replace the following line with your actual implementation

            // Example: Assuming material names are unique
            var materialColumnMapping = new Dictionary<string, int>();

            // Extract unique Material names from purchases and assign column indices
            int columnIndex = 2; // Starting from column index 2 (assuming the first column is for dates)
            foreach (var materialName in purchases.Select(purchase => purchase.Material.Name).Distinct())
            {
                materialColumnMapping.Add(materialName, columnIndex);
                columnIndex++;
            }

            if (materialColumnMapping.TryGetValue(material.Name, out columnIndex))
            {
                return columnIndex;
            }

            // Default to a specific column if not found
            return 2; // Modify this based on your actual requirements
        }
        public static void ExportSales(List<StockSale> sales, DateTime startDate, DateTime endDate)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var workSheetSales = package.Workbook.Worksheets.Add("Vendas");

                // Headers
                string[] headers = { "DATA", "Material", "Peso", "Preco por Kg", "Valor", "Nota Fiscal", "Placa", "Empresa", "Email", "Telefone" };
                for (int i = 1; i <= headers.Length; i++)
                {
                    workSheetSales.Cells[1, i].Value = headers[i - 1];
                    workSheetSales.Cells[1, i].Style.Font.Size = 11;
                    workSheetSales.Cells[1, i].Style.Font.Bold = true;
                }

                // Data
                int row = 2;
                foreach (var sale in sales)
                {
                    workSheetSales.Cells[row, 1].Value = sale.SaleDate.ToString("dd/MM/yyyy");
                    workSheetSales.Cells[row, 2].Value = sale.Material.Name;
                    workSheetSales.Cells[row, 3].Value = $"Kg {sale.TotalWeight.ToString("0.00")}";
                    workSheetSales.Cells[row, 4].Value = $"R$ {sale.KilogramSalePrice.ToString("0.00")}";
                    workSheetSales.Cells[row, 5].Value = $"R$ {sale.TotalValue.ToString("0.00")}";
                    workSheetSales.Cells[row, 6].Value = sale.FiscalNumber;
                    workSheetSales.Cells[row, 7].Value = sale.TruckPlate;
                    workSheetSales.Cells[row, 8].Value = sale.CompanyName;
                    workSheetSales.Cells[row, 9].Value = sale.CompanyEmail;
                    workSheetSales.Cells[row, 10].Value = sale.CompanyPhone;

                    // Apply formatting to data cells
                    workSheetSales.Cells[row, 1, row, 10].Style.Font.Size = 11;
                    workSheetSales.Cells[row, 1, row, 10].Style.Font.Color.SetColor(Color.Red);

                    row++;
                }

                // Add a new line after the last data row for material headers
                workSheetSales.Cells[row, 1].Value = "Materiais";
                workSheetSales.Cells[row, 1].Style.Font.Size = 11;
                workSheetSales.Cells[row, 1, row, 10].Style.Font.Bold = true;

                // Get distinct material names
                var materialNames = sales.Select(s => s.Material.Name).Distinct().OrderBy(m => m).ToList();

                // Display material names in the new line
                int materialHeadersRow = row + 1;
                int materialColumnIndex = 2; // Starting column index for Material headers
                foreach (var materialName in materialNames)
                {
                    workSheetSales.Cells[materialHeadersRow, materialColumnIndex].Value = materialName;
                    workSheetSales.Cells[materialHeadersRow, materialColumnIndex].Style.Font.Bold = true;
                    materialColumnIndex++;
                }

                int columnIndex = 2;
                // Calculate and display sums and averages for each material
                foreach (var materialName in materialNames)
                {
                    // Find sales for the current material
                    var materialSales = sales.Where(s => s.Material.Name == materialName).ToList();

                    // Calculate sums and averages
                    decimal totalWeight = materialSales.Sum(s => s.TotalWeight);
                    decimal totalValue = materialSales.Sum(s => s.TotalValue);
                    decimal averageWeight = materialSales.Any() ? materialSales.Average(s => s.TotalWeight) : 0;
                    decimal averageValue = materialSales.Any() ? materialSales.Average(s => s.TotalValue) : 0;


                    // Display calculated values under the respective material column
                    workSheetSales.Cells[row + 2, columnIndex].Value = $"Peso Total: Kg {totalWeight.ToString("0.00")}";
                    workSheetSales.Cells[row + 3, columnIndex].Value = $"Valor Total: R$ {totalValue.ToString("0.00")}";
                    workSheetSales.Cells[row + 4, columnIndex].Value = $"Peso Médio: Kg {averageWeight.ToString("0.00")}";
                    workSheetSales.Cells[row + 5, columnIndex].Value = $"Valor Médio: R$ {averageValue.ToString("0.00")}";

                    workSheetSales.Cells[row + 2, columnIndex, row + 5, columnIndex].Style.Font.Size = 11;
                    workSheetSales.Cells[row + 2, columnIndex, row + 5, columnIndex].Style.Font.Color.SetColor(Color.Red);
                    columnIndex++;
                }


                // Set the column width for all columns
                workSheetSales.Cells.AutoFitColumns();

                // Save the file
                var relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Planilhas");
                var fileName = $"Vendas-{startDate.ToString("dd_MM_yyyy")}-{endDate.ToString("dd_MM_yyyy")}.xlsx";
                var filePath = Path.Combine(relativePath, fileName);

                // Check if the directory exists; if not, create it
                if (!Directory.Exists(relativePath))
                {
                    Directory.CreateDirectory(relativePath);
                }

                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);

                // Open the Excel file using the default application
                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = fileInfo.FullName,
                        UseShellExecute = true
                    });
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    // Handle the exception or log it
                    Console.WriteLine($"Error opening Excel file: {ex.Message}");
                }
            }
        }
        public static void ExportPurchases(List<Purchase> purchases, DateTime startDate, DateTime endDate)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var package = new ExcelPackage();
            var workSheetPurchases = package.Workbook.Worksheets.Add("Compras");
            var workSheetWeight = package.Workbook.Worksheets.Add("Peso/Estoque");

            SetupHeader(workSheetPurchases, 1, "DATA");
            SetupHeader(workSheetWeight, 1, "DATA");

            var materialColumnIndex = SetupMaterialHeaders(workSheetPurchases, workSheetWeight, purchases);

            var days = GetDaysBetween(startDate, endDate);

            int row = 2;
            foreach (var currentDay in days)
            {
                var purchasesForDay = purchases.Where(purchase => purchase.PurchaseTime.Date == currentDay.Date).ToList();

                if (purchasesForDay.Count == 0)
                {
                    continue;
                }

                SetupDateCell(workSheetPurchases, row, 1, currentDay.ToString("dd/MM/yyyy"));
                SetupDateCell(workSheetWeight, row, 1, currentDay.ToString("dd/MM/yyyy"));

                SetupSums(workSheetPurchases, workSheetWeight, row, purchasesForDay, materialColumnIndex);

                row++;
            }

            AddRowWithLabel(workSheetPurchases, row, "Soma", true);
            AddRowWithLabel(workSheetWeight, row, "Soma", true);

            CalculateAndSetupTotals(workSheetPurchases, workSheetWeight, row, purchases, materialColumnIndex, Color.Red);

            row++;
            AddRowWithLabel(workSheetPurchases, row, "Media", true);
            AddRowWithLabel(workSheetWeight, row, "Media", true);

            CalculateAndSetupAverages(workSheetPurchases, workSheetWeight, row, purchases, days, materialColumnIndex, Color.Blue);

            AutoFitColumns(workSheetPurchases);
            AutoFitColumns(workSheetWeight);

            SaveAndOpenExcel(package, startDate, endDate);
        }

        private static void SetupHeader(ExcelWorksheet worksheet, int row, string label)
        {
            worksheet.Cells[row, 1].Value = label;
            worksheet.Cells[row, 1].Style.Font.Size = 11;
        }

        private static int SetupMaterialHeaders(ExcelWorksheet worksheetPurchases, ExcelWorksheet worksheetWeight, List<Purchase> purchases)
        {
            int materialColumnIndex = 2;
            foreach (var materialName in purchases.GroupBy(x => x.Material.Name).Select(x => x.Key))
            {
                SetupMaterialHeader(worksheetPurchases, materialColumnIndex, materialName);
                SetupMaterialHeader(worksheetWeight, materialColumnIndex, materialName);
                materialColumnIndex++;
            }
            return materialColumnIndex;
        }

        private static void SetupMaterialHeader(ExcelWorksheet worksheet, int columnIndex, string materialName)
        {
            worksheet.Cells[1, columnIndex].Value = materialName;
            worksheet.Cells[1, columnIndex].Style.Font.Size = 11;
            worksheet.Cells[1, columnIndex].Style.Font.Bold = true;
        }

        private static void SetupDateCell(ExcelWorksheet worksheet, int row, int column, string value)
        {
            worksheet.Cells[row, column].Value = value;
            worksheet.Cells[row, column].Style.Font.Size = 11;
        }

        private static void SetupSums(ExcelWorksheet worksheetPurchases, ExcelWorksheet worksheetWeight, int row, List<Purchase> purchasesForDay, int materialColumnIndex)
        {
            foreach (var material in purchasesForDay.Select(purchase => purchase.Material).Distinct())
            {
                decimal totalWeight = purchasesForDay.Where(purchase => purchase.Material.Equals(material)).Sum(purchase => purchase.Weight);
                decimal totalValue = purchasesForDay.Where(purchase => purchase.Material.Equals(material)).Sum(purchase => purchase.Value);

                int columnIndex = GetMaterialColumnIndex(material, purchasesForDay);

                SetupCellValueAndStyle(worksheetPurchases, row, columnIndex, $"R$ {totalValue.ToString("0.00")}", Color.Red);
                SetupCellValueAndStyle(worksheetWeight, row, columnIndex, $"KG {totalWeight.ToString("0.00")}", Color.Red);
            }
        }

        private static void AddRowWithLabel(ExcelWorksheet worksheet, int row, string label, bool isBold)
        {
            SetupCellValueAndStyle(worksheet, row, 1, label, isBold ? Color.Red : Color.Blue);
            worksheet.Cells[row, 1, row, worksheet.Dimension.End.Column].Style.Font.Bold = isBold;
        }

        private static void CalculateAndSetupTotals(ExcelWorksheet worksheetPurchases, ExcelWorksheet worksheetWeight, int row, List<Purchase> purchases, int materialColumnIndex, Color fontColor)
        {
            foreach (var material in purchases.Select(purchase => purchase.Material).Distinct())
            {
                decimal totalWeight = purchases.Where(purchase => purchase.Material.Equals(material)).Sum(purchase => purchase.Weight);
                decimal totalValue = purchases.Where(purchase => purchase.Material.Equals(material)).Sum(purchase => purchase.Value);

                int columnIndex = GetMaterialColumnIndex(material, purchases);

                SetupCellValueAndStyle(worksheetPurchases, row, columnIndex, $"R$ {totalValue.ToString("0.00")}", fontColor);
                SetupCellValueAndStyle(worksheetWeight, row, columnIndex, $"KG {totalWeight.ToString("0.00")}", fontColor);
            }
        }

        private static void CalculateAndSetupAverages(ExcelWorksheet worksheetPurchases, ExcelWorksheet worksheetWeight, int row, List<Purchase> purchases, List<DateTime> days, int materialColumnIndex, Color fontColor)
        {
            foreach (var material in purchases.Select(purchase => purchase.Material).Distinct())
            {
                var totalWeight = purchases.Where(purchase => purchase.Material.Equals(material)).Sum(x => x.Weight);
                var totalValue = purchases.Where(purchase => purchase.Material.Equals(material)).Sum(x => x.Value);

                decimal averageWeight = totalWeight / days.Count;
                decimal averageValue = totalValue / days.Count;

                int columnIndex = GetMaterialColumnIndex(material, purchases);

                SetupCellValueAndStyle(worksheetPurchases, row, columnIndex, $"R$ {averageValue.ToString("0.00")}", fontColor);
                SetupCellValueAndStyle(worksheetWeight, row, columnIndex, $"KG {averageWeight.ToString("0.00")}", fontColor);
            }
        }

        private static void SetupCellValueAndStyle(ExcelWorksheet worksheet, int row, int column, string value, Color fontColor)
        {
            worksheet.Cells[row, column].Value = value;
            worksheet.Cells[row, column].Style.Font.Size = 11;
            worksheet.Cells[row, column].Style.Font.Color.SetColor(fontColor);
        }

        private static void AutoFitColumns(ExcelWorksheet worksheet)
        {
            worksheet.Cells.AutoFitColumns();
        }

        private static void SaveAndOpenExcel(ExcelPackage package, DateTime startDate, DateTime endDate)
        {
            var relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Planilhas");
            var fileName = $"Compras-{startDate.ToString("dd_MM_yyyy")}-{endDate.ToString("dd_MM_yyyy")}.xlsx";
            var filePath = Path.Combine(relativePath, fileName);

            Directory.CreateDirectory(relativePath);

            var fileInfo = new FileInfo(filePath);
            package.SaveAs(fileInfo);

            TryOpenExcelFile(fileInfo);
        }

        private static void TryOpenExcelFile(FileInfo fileInfo)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = fileInfo.FullName,
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine($"Error opening Excel file: {ex.Message}");
            }
        }

    }
}
