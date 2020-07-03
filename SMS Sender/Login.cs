using DAL.Repository;
using DAL.Utility;
using System;
using System.Linq;
using System.Windows;

namespace SMS_Sender
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void loginBtn_Click(object sender, EventArgs e)
        {

            //var password = Crypto.EncryptPassword("Admin@123");
            try
            {
                var userName = Username.Text;
                var passsword = Password.Text;
                if (!string.IsNullOrEmpty(userName))
                {
                    if (!string.IsNullOrEmpty(passsword))
                    {
                        var passhass = Crypto.EncryptPassword(passsword);
                        var user = _unitOfWork.UserRepository.Get(x => x.UserName == userName && x.Password == passhass && x.Status == 1).FirstOrDefault();
                        if (user != null)
                        {

                            var home = new Home();
                            home.Show();
                            this.Hide();
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login attempt!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter password");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter username");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

