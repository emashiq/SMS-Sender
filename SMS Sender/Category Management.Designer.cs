namespace SMS_Sender
{
    partial class Category_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SMSDataset = new SMS_Sender.SMSDataset();
            this.getCustomerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerListTableAdapter = new SMS_Sender.SMSDatasetTableAdapters.GetCustomerListTableAdapter();
            this.categoryGrid = new MetroFramework.Controls.MetroGrid();
            this.getCategoryListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getCategoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxActive = new MetroFramework.Controls.MetroCheckBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.tbxCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new SMS_Sender.SMSDatasetTableAdapters.CategoryTableAdapter();
            this.getCategoryListTableAdapter = new SMS_Sender.SMSDatasetTableAdapters.GetCategoryListTableAdapter();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SMSDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryListBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SMSDataset
            // 
            this.SMSDataset.DataSetName = "SMSDataset";
            this.SMSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerListBindingSource
            // 
            this.getCustomerListBindingSource.DataMember = "GetCustomerList";
            this.getCustomerListBindingSource.DataSource = this.SMSDataset;
            // 
            // getCustomerListTableAdapter
            // 
            this.getCustomerListTableAdapter.ClearBeforeFill = true;
            // 
            // categoryGrid
            // 
            this.categoryGrid.AllowUserToAddRows = false;
            this.categoryGrid.AllowUserToDeleteRows = false;
            this.categoryGrid.AllowUserToOrderColumns = true;
            this.categoryGrid.AllowUserToResizeRows = false;
            this.categoryGrid.AutoGenerateColumns = false;
            this.categoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.categoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.categoryNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Edit,
            this.createdDateDataGridViewTextBoxColumn});
            this.categoryGrid.DataSource = this.getCategoryListBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryGrid.EnableHeadersVisualStyles = false;
            this.categoryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryGrid.Location = new System.Drawing.Point(15, 101);
            this.categoryGrid.Name = "categoryGrid";
            this.categoryGrid.ReadOnly = true;
            this.categoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGrid.Size = new System.Drawing.Size(495, 376);
            this.categoryGrid.TabIndex = 4;
            this.categoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGrid_CellContentClick);
            // 
            // getCategoryListBindingSource1
            // 
            this.getCategoryListBindingSource1.DataMember = "GetCategoryList";
            this.getCategoryListBindingSource1.DataSource = this.SMSDataset;
            // 
            // getCategoryListBindingSource
            // 
            this.getCategoryListBindingSource.DataMember = "GetCategoryList";
            this.getCategoryListBindingSource.DataSource = this.SMSDataset;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblId);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Controls.Add(this.cbxActive);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.tbxCategoryName);
            this.metroPanel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(529, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(355, 178);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(19, 120);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(319, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(19, 73);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(56, 15);
            this.cbxActive.TabIndex = 11;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseSelectable = true;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(87, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(19, 3);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(319, 23);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "Category Name";
            // 
            // tbxCategoryName
            // 
            // 
            // 
            // 
            this.tbxCategoryName.CustomButton.Image = null;
            this.tbxCategoryName.CustomButton.Location = new System.Drawing.Point(297, 1);
            this.tbxCategoryName.CustomButton.Name = "";
            this.tbxCategoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCategoryName.CustomButton.TabIndex = 1;
            this.tbxCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCategoryName.CustomButton.UseSelectable = true;
            this.tbxCategoryName.CustomButton.Visible = false;
            this.tbxCategoryName.Lines = new string[0];
            this.tbxCategoryName.Location = new System.Drawing.Point(19, 29);
            this.tbxCategoryName.MaxLength = 32767;
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.PasswordChar = '\0';
            this.tbxCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCategoryName.SelectedText = "";
            this.tbxCategoryName.SelectionLength = 0;
            this.tbxCategoryName.SelectionStart = 0;
            this.tbxCategoryName.ShortcutsEnabled = true;
            this.tbxCategoryName.Size = new System.Drawing.Size(319, 23);
            this.tbxCategoryName.TabIndex = 2;
            this.tbxCategoryName.UseSelectable = true;
            this.tbxCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(13, 98);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(498, 388);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(844, 30);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.SMSDataset;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // getCategoryListTableAdapter
            // 
            this.getCategoryListTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 100;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Depth = 0;
            this.lblId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblId.Location = new System.Drawing.Point(15, 157);
            this.lblId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 19);
            this.lblId.TabIndex = 13;
            this.lblId.Visible = false;
            // 
            // Category_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 507);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.categoryGrid);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Category_Management";
            this.Text = "Category Management";
            this.Load += new System.EventHandler(this.Category_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SMSDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCategoryListBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SMSDataset SMSDataset;
        private System.Windows.Forms.BindingSource getCustomerListBindingSource;
        private SMSDatasetTableAdapters.GetCustomerListTableAdapter getCustomerListTableAdapter;
        private MetroFramework.Controls.MetroGrid categoryGrid;
        private System.Windows.Forms.BindingSource getCategoryListBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MetroFramework.Controls.MetroCheckBox cbxActive;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox tbxCategoryName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SMSDatasetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource getCategoryListBindingSource1;
        private SMSDatasetTableAdapters.GetCategoryListTableAdapter getCategoryListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel lblId;
    }
}