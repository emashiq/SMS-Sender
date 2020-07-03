using DAL.Repository;
using DAL.Utility;
using SMS_Sender.Models;
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
    public partial class Manage_User : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public Manage_User()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Manage_User_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var cname = tbxUserName.Text;
                var active = cbxActive.Checked;
                var pass = tbxPassword.Text;
                if (!string.IsNullOrEmpty(cname) && !string.IsNullOrEmpty(pass))
                {
                    var id = 0;
                    if (!string.IsNullOrEmpty(lblId.Text))
                    {
                        id = Int32.Parse(lblId.Text);
                        var user = _unitOfWork.UserRepository.GetByID(id);
                        user.UserName = cname;
                        user.Password = Crypto.EncryptPassword(pass);
                        user.Status = active == true ? 1 : 0;
                        user.EditedBy = 1;
                        user.EditedDate = DateTime.Now;
                        _unitOfWork.UserRepository.Update(user);
                    }
                    else
                    {
                        var user = new User()
                        {
                            UserName = cname,
                            Password = Crypto.EncryptPassword(pass),
                            Status = active == true ? 1 : 0,
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now
                        };
                        _unitOfWork.UserRepository.Insert(user);
                    }

                    _unitOfWork.Save();
                    MessageBox.Show("Saved successfully");
                    ResetForm();
                    LoadCategory();
                }
                else
                {
                    MessageBox.Show("Some field is required!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCategory()
        {
            // TODO: This line of code loads data into the 'sMSDataset.GetUserList' table. You can move, or remove it, as needed.
            this.getUserListTableAdapter.Fill(this.sMSDataset.GetUserList);
        }

        private void ResetForm()
        {
            tbxUserName.Text = "";
            tbxPassword.Text = "";
            cbxActive.Checked = true;
            lblId.Text = "";
            btnAdd.Text = "Add";
        }

        private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var id = Int32.Parse(userGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadForEdit(id);

            }
        }

        private void LoadForEdit(int Id)
        {
            var user = _unitOfWork.UserRepository.GetByID(Id);
            tbxUserName.Text = user.UserName;
            //tbxPassword.Text = user.UserName;
            cbxActive.Checked = user.Status == 1 ? true : false;
            btnAdd.Text = "Update";
            lblId.Text = Id + "";
        }
    }
}
