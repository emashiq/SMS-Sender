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
    public partial class Home : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public Home()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.WindowState = FormWindowState.Maximized;
        }

        private void category_Click(object sender, EventArgs e)
        {
            var cm = new Category_Management();
            cm.Show();
            this.Hide();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            var cm = new Customer_Management();
            cm.Show();
            this.Hide();
        }

        private void sms_Click(object sender, EventArgs e)
        {
            var sm = new SendSMS();
            sm.Show();
            this.Hide();
        }

        private void user_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Coming soon");
            var sm = new Manage_User();
            sm.Show();
            this.Hide();
        }

    }
}
