using CaixaSucata.Models.ObjectModels;
using Dapper;
using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace CaixaSucata.Controlls
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #region Material
        public static List<Material> ListMaterials()
        {
            using (IDbConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = connection.Query<Material>("SELECT * FROM Material", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveMaterial(Material material)
        {
            using (IDbConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                DynamicParameters parameters = new DynamicParameters();
                string insertCommand = @"
                    INSERT INTO Material (Ind, Name, Stock, StandartPrice, ModifiedPrice1, ModifiedPrice2)
                    VALUES (@Ind, @Name, @Stock, @StandartPrice, @ModifiedPrice1, @ModifiedPrice2)";

                connection.Execute(insertCommand, new
                {
                    material.Ind,
                    material.Name,
                    material.Stock,
                    material.StandartPrice,
                    material.ModifiedPrice1,
                    material.ModifiedPrice2,
                });

            }
        }

        public static void DeleteMaterial(string materialName)
        {
            var mat = SqliteDataAccess.GetMaterialByName(materialName);
            using (IDbConnection con = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string deleteCommand = "DELETE FROM Material WHERE Id = @Id";

                // Provide the parameter values using an anonymous object
                con.Execute(deleteCommand, new { Id = mat.Id });
            }
        }

        public static Material GetMaterialByName(string name)
        {
            using (IDbConnection con = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                // Query the database to get the material based on its name
                string query = "SELECT * FROM Material WHERE Name = @Name";
                return con.QueryFirstOrDefault<Material>(query, new { Name = name });
            }
        }
        public static void UpdateMaterialStock(Material material)
        {
            using (IDbConnection con = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string updateCommand = "UPDATE Material SET Stock = @Stock WHERE Id = @Id";

                con.Execute(updateCommand, new { material.Stock, material.Id });
            }
        }

        public static void UpdateMaterial(Material materialToUpdate, Material currentMaterial)
        {
            var mat = SqliteDataAccess.GetMaterialByName(currentMaterial.Name);
            using (IDbConnection con = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                PropertyInfo[] properties = typeof(Material).GetProperties();

                string setClause = string.Join(", ", properties
                    .Where(prop => prop.Name != "Id" && prop.Name != "DisplayStandart" && prop.Name != "DisplayMod1" && prop.Name != "DisplayMod2" && prop.Name != "DisplayConfiguration" && prop.Name != "DisplayStock") // Exclude the Id property from update
                    .Select(prop => $"{prop.Name} = @{prop.Name}"));

                string updateCommand = $"UPDATE Material SET {setClause} WHERE Id = @Id";

                var parameters = new
                {
                    Id = mat.Id,
                    materialToUpdate.Ind,
                    materialToUpdate.Name,
                    materialToUpdate.Stock,
                    materialToUpdate.StandartPrice,
                    materialToUpdate.ModifiedPrice1,
                    materialToUpdate.ModifiedPrice2,
                };

                con.Execute(updateCommand, parameters);
            }
        }
        #endregion
        #region Purchase
        public static void SavePurchase(Purchase purchase)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                // Insert a Purchase object into the Purchase table
                string insertCommand = @"
                    INSERT INTO Purchase (IsSale, MaterialId, Weight, Value, PurchaseTime, SellerName)
                    VALUES (@IsSale, @MaterialId, @Weight, @Value, @PurchaseTime, @SellerName)";

                connection.Execute(insertCommand, new
                {
                    purchase.IsSale,
                    MaterialId = purchase.Material.Id, // Assuming Material has an Id property
                    purchase.Weight,
                    purchase.Value,
                    purchase.PurchaseTime,
                    purchase.SellerName
                });
            }
        }
        public static List<Purchase> GetPurchasesByDay(DateTime targetDate, bool isSale)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                // Query the database to get purchases for a specific day
                string query = @"
            SELECT
                p.Id,
                p.MaterialId,
                p.Weight,
                p.Value,
                p.PurchaseTime,
                p.SellerName,
                m.Id,
                m.Ind,
                m.Name,
                m.Stock,
                m.StandartPrice,
                m.ModifiedPrice1,
                m.ModifiedPrice2
            FROM
                Purchase p
            INNER JOIN
                Material m ON p.MaterialId = m.Id
            WHERE
                DATE(p.PurchaseTime) = DATE(@TargetDate) 
                AND
                p.IsSale = @IsSale";

                // Use Dapper's Query method to execute the query and map the result to a list of Purchase objects
                var purchases = connection.Query<Purchase, Material, Purchase>(
                query,
                (purchase, material) =>
                    {
                        // Attach the Material object to the Purchase
                        purchase.Material = material;

                        return purchase;
                    },
                new { TargetDate = targetDate.ToString("yyyy-MM-dd"), IsSale = isSale },
                splitOn: "Id");

                return purchases.ToList();
            }
        }
        public static List<Purchase> ListPurchasesByDateRange(DateTime startDate, DateTime endDate)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = @"
            SELECT
                p.Id,
                p.MaterialId,
                p.Weight,
                p.Value,
                p.PurchaseTime,
                m.Id,
                m.Ind,
                m.Name,
                m.stock,
                m.StandartPrice,
                m.ModifiedPrice1,
                m.ModifiedPrice2
            FROM
                Purchase p
            INNER JOIN
                Material m ON p.MaterialId = m.Id
            WHERE
                p.PurchaseTime BETWEEN @StartDate AND @EndDate
                AND
                p.IsSale = 0";

                var purchases = connection.Query<Purchase, Material, Purchase>(
                    query,
                    (purchase, material) =>
                    {
                        // Attach the Material object to the Purchase
                        purchase.Material = material;
                        return purchase;
                    },
                    new { StartDate = startDate.ToString("yyyy-MM-dd"), EndDate = endDate.ToString("yyyy-MM-dd") },
                    splitOn: "Id");

                return purchases.ToList();
            }
        }

        #endregion
        #region Register
        public static void SaveRegister(Register register)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string insertCommand = @"
                    INSERT INTO Register (RegisterDate, PurchaseRegisterAmount, SalesRegisterAmount)
                    VALUES (@RegisterDate, @PurchaseRegisterAmount, @SalesRegisterAmount)";

                connection.Execute(insertCommand, new
                {
                    register.RegisterDate,
                    register.PurchaseRegisterAmount,
                    register.SalesRegisterAmount
                });
            }
        }
        public static Register GetTodayRegister()
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();
                var today = DateTime.Now.ToString("yyyy-MM-dd") + "%";
                string query = @"SELECT * FROM Register WHERE RegisterDate LIKE @Today";

                var register = connection.QueryFirstOrDefault<Register>(query, new {Today = today});

                return register;
            }
        }
        public static void UpdatePurchaseRegister(Register register)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = "UPDATE Register SET PurchaseRegisterAmount = @PurchaseRegisterAmount WHERE Id = @Id";

                connection.Execute(query, new
                {
                    register.PurchaseRegisterAmount,
                    register.Id
                });
            }
        }
        public static void UpdateSalesRegister(Register register)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = "UPDATE Register SET SalesRegisterAmount = @SalesRegisterAmount WHERE Id = @Id";

                connection.Execute(query, new
                {
                    register.SalesRegisterAmount,
                    register.Id
                });
            }
        }

        public static List<RegisterOperation> GetAllRegisterOperations()
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = "SELECT * FROM Register_Operation";

                List<RegisterOperation> operations = connection.Query<RegisterOperation>(query).ToList();

                return operations;
            }
        }

        public static void SaveRegisterOperation(RegisterOperation operation)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = "INSERT INTO Register_Operation (Amount, IsPurchase, IsRemoval) VALUES (@Amount, @IsPurchase, @IsRemoval)";

                connection.Execute(query, new
                {
                    operation.Amount,
                    operation.IsPurchase,
                    operation.IsRemoval
                });
            }
        }

        public static void ClearAllRegisterOperations()
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                connection.Open();

                string query = "DELETE FROM Register_Operation";

                connection.Execute(query);
            }
        }
        #endregion
        #region StockSale
        public static List<StockSale> ListStockSales()
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string selectCommand = @"
            SELECT
                ss.Id,
                ss.KilogramSalePrice,
                ss.TotalWeight,
                ss.TotalValue,
                ss.FiscalNumber,
                ss.CompanyName,
                ss.CompanyEmail,
                ss.CompanyPhone,
                ss.TruckPlate,
                ss.SaleDate,
                m.Id AS Material_Id,
                m.Ind,
                m.Name,
                m.Stock,
                m.StandartPrice,
                m.ModifiedPrice1,
                m.ModifiedPrice2
            FROM StockSale ss
            JOIN Material m ON ss.MaterialId = m.Id";

                var stockSales = connection.Query<StockSale, Material, StockSale>(
                    selectCommand,
                    (stockSale, material) =>
                    {
                        stockSale.Material = material;
                        return stockSale;
                    },
                    splitOn: "Material_Id"
                ).ToList();

                return stockSales;
            }
        }
        public static void SaveStockSale(StockSale stockSale)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string insertCommand = @"
            INSERT INTO StockSale (
                KilogramSalePrice,
                TotalWeight,
                TotalValue,
                FiscalNumber,
                CompanyName,
                CompanyEmail,
                CompanyPhone,
                TruckPlate,
                MaterialId,
                SaleDate
            )
            VALUES (
                @KilogramSalePrice,
                @TotalWeight,
                @TotalValue,
                @FiscalNumber,
                @CompanyName,
                @CompanyEmail,
                @CompanyPhone,
                @TruckPlate,
                @MaterialId,
                @SaleDate
            )";

                connection.Execute(insertCommand, new
                {
                    stockSale.KilogramSalePrice,
                    stockSale.TotalWeight,
                    stockSale.TotalValue,
                    stockSale.FiscalNumber,
                    stockSale.CompanyName,
                    stockSale.CompanyEmail,
                    stockSale.CompanyPhone,
                    stockSale.TruckPlate,
                    stockSale.SaleDate,
                    MaterialId = stockSale.Material.Id  // Extracting MaterialId from the Material object
                });
            }
        }

        public static List<StockSale> ListStockSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                string selectCommand = @"
            SELECT
                ss.Id,
                ss.KilogramSalePrice,
                ss.TotalWeight,
                ss.TotalValue,
                ss.FiscalNumber,
                ss.CompanyName,
                ss.CompanyEmail,
                ss.CompanyPhone,
                ss.TruckPlate,
                ss.SaleDate,
                m.Id AS Material_Id,
                m.Ind,
                m.Name,
                m.Stock,
                m.StandartPrice,
                m.ModifiedPrice1,
                m.ModifiedPrice2
            FROM StockSale ss
            JOIN Material m ON ss.MaterialId = m.Id
            WHERE ss.SaleDate BETWEEN @StartDate AND @EndDate";

                var stockSales = connection.Query<StockSale, Material, StockSale>(
                    selectCommand,
                    (stockSale, material) =>
                    {
                        stockSale.Material = material;
                        return stockSale;
                    },
                    new { StartDate = startDate, EndDate = endDate },
                    splitOn: "Material_Id"
                ).ToList();

                return stockSales;
            }
        }

        #endregion
    }
}
