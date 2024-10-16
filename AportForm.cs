namespace CaixaSucata
{
    public partial class AportForm : Form
    {
        public string ReturnValue { get; set; }

        public AportForm()
        {
            InitializeComponent();
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(ValueTextBox.Text.Replace(",", "."), out var x) && x >= 0)
            {
                this.ReturnValue = ValueTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ValueTextBox.Text = "Valor Fornecido Incorretamente";
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ValueTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ValueTextBox.Text = string.Empty;
        }
    }
}
