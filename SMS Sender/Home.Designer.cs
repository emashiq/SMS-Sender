namespace SMS_Sender
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sms = new MetroFramework.Controls.MetroTile();
            this.customer = new MetroFramework.Controls.MetroTile();
            this.user = new MetroFramework.Controls.MetroTile();
            this.category = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // sms
            // 
            this.sms.ActiveControl = null;
            this.sms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sms.Location = new System.Drawing.Point(464, 350);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(296, 139);
            this.sms.TabIndex = 10;
            this.sms.Text = "Send SMS";
            this.sms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sms.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sms.TileImage = global::SMS_Sender.Properties.Resources.send_80px;
            this.sms.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sms.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.sms.UseSelectable = true;
            this.sms.UseTileImage = true;
            this.sms.Click += new System.EventHandler(this.sms_Click);
            // 
            // customer
            // 
            this.customer.ActiveControl = null;
            this.customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer.Location = new System.Drawing.Point(619, 205);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(296, 139);
            this.customer.TabIndex = 9;
            this.customer.Text = "Customer Management";
            this.customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.customer.TileImage = global::SMS_Sender.Properties.Resources.conference_100px;
            this.customer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.customer.UseSelectable = true;
            this.customer.UseTileImage = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // user
            // 
            this.user.ActiveControl = null;
            this.user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user.Location = new System.Drawing.Point(766, 350);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(149, 139);
            this.user.TabIndex = 8;
            this.user.Text = "Manage User";
            this.user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.user.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.user.TileImage = global::SMS_Sender.Properties.Resources.user_80px;
            this.user.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.user.UseSelectable = true;
            this.user.UseTileImage = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // category
            // 
            this.category.ActiveControl = null;
            this.category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category.Location = new System.Drawing.Point(464, 205);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(149, 139);
            this.category.TabIndex = 7;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.category.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.category.TileImage = global::SMS_Sender.Properties.Resources.administrative_tools_64px;
            this.category.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.category.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.category.UseSelectable = true;
            this.category.UseTileImage = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 635);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.user);
            this.Controls.Add(this.category);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile category;
        private MetroFramework.Controls.MetroTile user;
        private MetroFramework.Controls.MetroTile customer;
        private MetroFramework.Controls.MetroTile sms;
    }
}

