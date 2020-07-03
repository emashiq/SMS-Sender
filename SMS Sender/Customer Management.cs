using DAL.Repository;
using SMS_Sender.Models;
using System;
using System.Windows.Forms;

namespace SMS_Sender
{
    public partial class Customer_Management : MaterialSkin.Controls.MaterialForm
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        public Customer_Management()
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

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            // TODO: This line of code loads data into the 'SMSDataset.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.SMSDataset.Category);
            // TODO: This line of code loads data into the 'SMSDataset.GetCustomerList' table. You can move, or remove it, as needed.
            this.getCustomerListTableAdapter.Fill(this.SMSDataset.GetCustomerList);
            //// TODO: This line of code loads data into the 'SMSDataset.GetCustomerList' table. You can move, or remove it, as needed.
            //this.getCustomerListTableAdapter.Fill(this.SMSDataset.GetCustomerList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var cname = tbxCustomerName.Text;
                var pn = tbxPhoneNumber.Text;
                var add = tbxAddress.Text;
                var cat = cmbCategory.SelectedValue.ToString();
                var active = cbxActive.Checked;
                if (!string.IsNullOrEmpty(cname) && !string.IsNullOrEmpty(pn) && !string.IsNullOrEmpty(cat))
                {
                    var id = 0;
                    if (!string.IsNullOrEmpty(lblId.Text))
                    {
                        id = Int32.Parse(lblId.Text);
                        var customer = _unitOfWork.CustomerRepository.GetByID(id);
                        customer.Name = cname;
                        customer.PhoneNumber = pn;
                        customer.Address = add;
                        customer.CategoryId = Int32.Parse(cat);
                        customer.Status = active == true ? 1 : 0;
                        customer.EditedBy = 1;
                        customer.EditedDate = DateTime.Now;
                        _unitOfWork.CustomerRepository.Update(customer);
                    }
                    else
                    {
                        var customer = new Customer()
                        {
                            Name = cname,
                            PhoneNumber = pn,
                            Address = add,
                            CategoryId = Int32.Parse(cat),
                            Status = active == true ? 1 : 0,
                            CreatedBy = 1,
                            CreatedDate = DateTime.Now
                        };
                        _unitOfWork.CustomerRepository.Insert(customer);
                    }

                    _unitOfWork.Save();
                    MessageBox.Show("Saved successfully");
                    ResetForm();
                    LoadCustomer();
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
            tbxCustomerName.Text = "";
            tbxPhoneNumber.Text = "";
            tbxAddress.Text = "";
            cmbCategory.Refresh();
            cbxActive.Checked = true;
            btnAdd.Text = "Add";
            lblId.Text = "";
        }


        private void customerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var id = Int32.Parse(customerGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadForEdit(id);
            }
        }

        private void LoadForEdit(int id)
        {
            var customer = _unitOfWork.CustomerRepository.GetByID(id);
            tbxCustomerName.Text = customer.Name;
            tbxPhoneNumber.Text = customer.PhoneNumber;
            tbxAddress.Text = customer.Address;
            cbxActive.Checked = customer.Status == 1 ? true : false;
            cmbCategory.SelectedValue = customer.CategoryId;
            btnAdd.Text = "Update";
            lblId.Text = id + "";
        }
    }
}
