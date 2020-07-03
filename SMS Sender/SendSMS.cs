using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Sender
{
    public partial class SendSMS : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public SendSMS()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.WindowState = FormWindowState.Maximized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }

        private void CategoryChanged(object sender, EventArgs e)
        {
            var category = Int32.Parse(cmbCategory.SelectedValue.ToString());
            LoadCustomerByCategory(category);
        }

        private void LoadCustomerByCategory(int categoryId)
        {
            var dt = _unitOfWork.GetDataTable($"EXEC GetCustomerByCategroy {categoryId}");
            customerGrid.DataSource = dt;
        }

        private void SendSMS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SMSDataset.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.SMSDataset.Category);
            // TODO: This line of code loads data into the 'SMSDataset.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.SMSDataset.Customer);

        }

        private void smsSend_Click(object sender, EventArgs e)
        {
            //Send SMS logic here
            MessageBox.Show("SMS sent successfully");
        }
    }
}
