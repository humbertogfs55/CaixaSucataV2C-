using CaixaSucata.UserControlls;
using System.Globalization;

namespace CaixaSucata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainFunctionsUC mainFunctionsUC = new MainFunctionsUC(this);
            AddUserControl(mainFunctionsUC);
        }

        #region Methods
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainContentPanel.Controls.Clear();
            MainContentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        #endregion

    }
}