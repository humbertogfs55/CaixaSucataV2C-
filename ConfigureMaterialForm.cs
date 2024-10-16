using CaixaSucata.Controlls;
using CaixaSucata.Models.ObjectModels;
using CaixaSucata.UserControlls;
using System.ComponentModel;

namespace CaixaSucata
{
    public partial class ConfigureMaterialForm : Form
    {
        private MainFunctionsUC MainFunctionsUC;
        private BindingList<Material> DisplayMaterials = new BindingList<Material>();
        private List<Material> Materials = new List<Material>();
        private Material SelectedMaterial = new Material();
        public ConfigureMaterialForm(MainFunctionsUC mainFunctionsUC)
        {
            InitializeComponent();
            MainFunctionsUC = mainFunctionsUC;
            LoadMaterialList();
        }

        private void LoadMaterialList()
        {
            var materialsToDisplay = SqliteDataAccess.ListMaterials();

            DisplayMaterials.Clear();
            materialsToDisplay.Sort((x1, x2) => x1.Ind.CompareTo(x2.Ind));
            materialsToDisplay.ForEach(material => DisplayMaterials.Add(material));

            MaterialListBox.DataSource = null;
            MaterialListBox.Items.Clear();
            MaterialListBox.DisplayMember = "DisplayConfiguration";
            MaterialListBox.DataSource = DisplayMaterials;
            NameTextBox.Text = string.Empty;
            Price1TextBox.Text = string.Empty;
            Price2TextBox.Text = string.Empty;
            Price3TextBox.Text = string.Empty;
            IndexTextBox.Text = string.Empty;
        }

        private void AddMaterialButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && Price1TextBox.Text.Length > 0 && IndexTextBox.Text.Length > 0)
            {
                var materialToAdd = new Material
                {
                    Name = NameTextBox.Text,
                    Stock = 0,
                    StandartPrice = decimal.TryParse(Price1TextBox.Text.Replace(",", "."), out var value1) ? value1 : 0,
                    ModifiedPrice1 = decimal.TryParse(Price2TextBox.Text.Replace(",", "."), out var value2) ? value2 : 0,
                    ModifiedPrice2 = decimal.TryParse(Price3TextBox.Text.Replace(",", "."), out var value3) ? value3 : 0,
                    Ind = int.TryParse(IndexTextBox.Text, out var value4) ? value4 : 0,
                };

                if (!SqliteDataAccess.ListMaterials().Contains(materialToAdd))
                {
                    SqliteDataAccess.SaveMaterial(materialToAdd);
                    LoadMaterialList();
                }
                else
                {
                    NameTextBox.Text = "Material já na lista";
                    Price1TextBox.Text = string.Empty;
                    Price2TextBox.Text = string.Empty;
                    Price3TextBox.Text = string.Empty;
                    IndexTextBox.Text = string.Empty;
                }
            }
        }

        private void UpdateMaterialButton_Click(object sender, EventArgs e)
        {
            if (DisplayMaterials.Contains(SelectedMaterial))
            {
                var materialToUpdate = new Material
                {
                    Name = NameTextBox.Text,
                    StandartPrice = decimal.TryParse(Price1TextBox.Text.Replace(",", "."), out var value1) ? value1 : 0,
                    ModifiedPrice1 = decimal.TryParse(Price2TextBox.Text.Replace(",", "."), out var value2) ? value2 : 0,
                    ModifiedPrice2 = decimal.TryParse(Price3TextBox.Text.Replace(",", "."), out var value3) ? value3 : 0,
                    Ind = int.TryParse(IndexTextBox.Text, out var value4) ? value4 : 0,
                };
                SqliteDataAccess.UpdateMaterial(materialToUpdate, SelectedMaterial);
                LoadMaterialList();
            }
        }

        private void ExcludeMaterialButton_Click(object sender, EventArgs e)
        {
            if (DisplayMaterials.Contains(SelectedMaterial))
            {
                SqliteDataAccess.DeleteMaterial(SelectedMaterial.Name);
                LoadMaterialList();
            }
            else
            {
                NameTextBox.Text = "Material Não encontrado";
                Price1TextBox.Text = string.Empty;
                Price2TextBox.Text = string.Empty;
                Price3TextBox.Text = string.Empty;
                IndexTextBox.Text = string.Empty;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainFunctionsUC.RefreshVisualizer();
            this.Dispose();
        }

        private void FinalizeButton_Click(object sender, EventArgs e)
        {

        }

        private void MaterialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialListBox.SelectedIndex != -1)
            {
                SelectedMaterial = (Material)MaterialListBox.SelectedItem;
                UpdateTextBoxes(SelectedMaterial);
            }
        }

        private void UpdateTextBoxes(Material selectedMaterial)
        {
            NameTextBox.Text = selectedMaterial.Name;
            Price1TextBox.Text = selectedMaterial.StandartPrice.ToString();
            Price2TextBox.Text = selectedMaterial.ModifiedPrice1.ToString();
            Price3TextBox.Text = selectedMaterial.ModifiedPrice2.ToString();
            IndexTextBox.Text = selectedMaterial.Ind.ToString();
        }
    }
}
