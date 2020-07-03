using DAL.Repository;
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
    public partial class Category_Management : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public Category_Management()
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

        private void Category_Management_Load(object sender, EventArgs e)
        {
            
            LoadCategory();
        }

        private void LoadCategory()
        {
            // TODO: This line of code loads data into the 'SMSDataset.GetCategoryList' table. You can move, or remove it, as needed.
            this.getCategoryListTableAdapter.Fill(this.SMSDataset.GetCategoryList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var cname = tbxCategoryName.Text;
                var active = cbxActive.Checked;
                if (!string.IsNullOrEmpty(cname))
                {
                    var id = 0;
                    if (!string.IsNullOrEmpty(lblId.Text))
                    {
                        id = Int32.Parse(lblId.Text);
                        var cat = _unitOfWork.CategoryRepository.GetByID(id);
                        cat.CategoryName = cname;
                        cat.Status = active == true ? 1 : 0;
                        cat.EditedBy = 1;
                        cat.EditedDate = DateTime.Now;
                        _unitOfWork.CategoryRepository.Update(cat);
                    }
                    else
                    {
                        var category = new Category()
                        {
                            CategoryName = cname,
                            Status = active == true ? 1 : 0,
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now
                        };
                        _unitOfWork.CategoryRepository.Insert(category);
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

        private void ResetForm()
        {
            tbxCategoryName.Text = "";
            cbxActive.Checked = true;
            lblId.Text = "";
            btnAdd.Text = "Add";
        }

        private void categoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                var id = Int32.Parse(categoryGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadForEdit(id);

            }
        }

        private void LoadForEdit(int categoryId)
        {
            var category = _unitOfWork.CategoryRepository.GetByID(categoryId);
            tbxCategoryName.Text = category.CategoryName;
            cbxActive.Checked = category.Status == 1 ? true : false;
            btnAdd.Text = "Update";
            lblId.Text = categoryId+"";
        }
    }
}
