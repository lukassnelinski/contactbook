
namespace Contactbook
{
    partial class FO_Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_Mainform));
            this.GB_Address = new System.Windows.Forms.GroupBox();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.LB_Notes = new System.Windows.Forms.Label();
            this.BT_Create = new System.Windows.Forms.Button();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.LB_Phone = new System.Windows.Forms.Label();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.LB_Country = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.LB_City = new System.Windows.Forms.Label();
            this.TB_Zip = new System.Windows.Forms.TextBox();
            this.LB_Zip = new System.Windows.Forms.Label();
            this.TB_Street = new System.Windows.Forms.TextBox();
            this.LB_Street = new System.Windows.Forms.Label();
            this.CO_Salutation = new System.Windows.Forms.ComboBox();
            this.LB_Salutation = new System.Windows.Forms.Label();
            this.LB_Surname = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.LB_Forename = new System.Windows.Forms.Label();
            this.TB_Forename = new System.Windows.Forms.TextBox();
            this.DG_Grid = new System.Windows.Forms.DataGridView();
            this.CL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Salutation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_ZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL_Changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Grid)).BeginInit();
            this.PN_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Address
            // 
            this.GB_Address.Controls.Add(this.BT_Delete);
            this.GB_Address.Controls.Add(this.BT_Update);
            this.GB_Address.Controls.Add(this.LB_Notes);
            this.GB_Address.Controls.Add(this.BT_Create);
            this.GB_Address.Controls.Add(this.TB_Notes);
            this.GB_Address.Controls.Add(this.TB_Email);
            this.GB_Address.Controls.Add(this.LB_Email);
            this.GB_Address.Controls.Add(this.TB_Phone);
            this.GB_Address.Controls.Add(this.LB_Phone);
            this.GB_Address.Controls.Add(this.TB_Country);
            this.GB_Address.Controls.Add(this.LB_Country);
            this.GB_Address.Controls.Add(this.TB_City);
            this.GB_Address.Controls.Add(this.LB_City);
            this.GB_Address.Controls.Add(this.TB_Zip);
            this.GB_Address.Controls.Add(this.LB_Zip);
            this.GB_Address.Controls.Add(this.TB_Street);
            this.GB_Address.Controls.Add(this.LB_Street);
            this.GB_Address.Controls.Add(this.CO_Salutation);
            this.GB_Address.Controls.Add(this.LB_Salutation);
            this.GB_Address.Controls.Add(this.LB_Surname);
            this.GB_Address.Controls.Add(this.TB_Surname);
            this.GB_Address.Controls.Add(this.LB_Forename);
            this.GB_Address.Controls.Add(this.TB_Forename);
            this.GB_Address.Location = new System.Drawing.Point(3, 3);
            this.GB_Address.Name = "GB_Address";
            this.GB_Address.Size = new System.Drawing.Size(249, 438);
            this.GB_Address.TabIndex = 0;
            this.GB_Address.TabStop = false;
            this.GB_Address.Text = "Address";
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(168, 409);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 3;
            this.BT_Delete.Text = "&Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(87, 409);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 2;
            this.BT_Update.Text = "&Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // LB_Notes
            // 
            this.LB_Notes.AutoSize = true;
            this.LB_Notes.Location = new System.Drawing.Point(3, 265);
            this.LB_Notes.Name = "LB_Notes";
            this.LB_Notes.Size = new System.Drawing.Size(38, 13);
            this.LB_Notes.TabIndex = 18;
            this.LB_Notes.Text = "Notes:";
            // 
            // BT_Create
            // 
            this.BT_Create.Location = new System.Drawing.Point(6, 409);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(75, 23);
            this.BT_Create.TabIndex = 1;
            this.BT_Create.Text = "&Create";
            this.BT_Create.UseVisualStyleBackColor = true;
            this.BT_Create.Click += new System.EventHandler(this.BT_Create_Click);
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(6, 281);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(237, 122);
            this.TB_Notes.TabIndex = 19;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(66, 229);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(177, 20);
            this.TB_Email.TabIndex = 17;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(3, 232);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(39, 13);
            this.LB_Email.TabIndex = 16;
            this.LB_Email.Text = "E-Mail:";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(66, 203);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(177, 20);
            this.TB_Phone.TabIndex = 15;
            // 
            // LB_Phone
            // 
            this.LB_Phone.AutoSize = true;
            this.LB_Phone.Location = new System.Drawing.Point(3, 206);
            this.LB_Phone.Name = "LB_Phone";
            this.LB_Phone.Size = new System.Drawing.Size(41, 13);
            this.LB_Phone.TabIndex = 14;
            this.LB_Phone.Text = "Phone:";
            // 
            // TB_Country
            // 
            this.TB_Country.Location = new System.Drawing.Point(66, 177);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(177, 20);
            this.TB_Country.TabIndex = 13;
            // 
            // LB_Country
            // 
            this.LB_Country.AutoSize = true;
            this.LB_Country.Location = new System.Drawing.Point(3, 180);
            this.LB_Country.Name = "LB_Country";
            this.LB_Country.Size = new System.Drawing.Size(46, 13);
            this.LB_Country.TabIndex = 12;
            this.LB_Country.Text = "Country:";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(66, 151);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(177, 20);
            this.TB_City.TabIndex = 11;
            // 
            // LB_City
            // 
            this.LB_City.AutoSize = true;
            this.LB_City.Location = new System.Drawing.Point(3, 154);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(27, 13);
            this.LB_City.TabIndex = 10;
            this.LB_City.Text = "City:";
            // 
            // TB_Zip
            // 
            this.TB_Zip.Location = new System.Drawing.Point(66, 125);
            this.TB_Zip.Name = "TB_Zip";
            this.TB_Zip.Size = new System.Drawing.Size(177, 20);
            this.TB_Zip.TabIndex = 9;
            // 
            // LB_Zip
            // 
            this.LB_Zip.AutoSize = true;
            this.LB_Zip.Location = new System.Drawing.Point(3, 128);
            this.LB_Zip.Name = "LB_Zip";
            this.LB_Zip.Size = new System.Drawing.Size(25, 13);
            this.LB_Zip.TabIndex = 8;
            this.LB_Zip.Text = "Zip:";
            // 
            // TB_Street
            // 
            this.TB_Street.Location = new System.Drawing.Point(66, 99);
            this.TB_Street.Name = "TB_Street";
            this.TB_Street.Size = new System.Drawing.Size(177, 20);
            this.TB_Street.TabIndex = 7;
            // 
            // LB_Street
            // 
            this.LB_Street.AutoSize = true;
            this.LB_Street.Location = new System.Drawing.Point(3, 102);
            this.LB_Street.Name = "LB_Street";
            this.LB_Street.Size = new System.Drawing.Size(38, 13);
            this.LB_Street.TabIndex = 6;
            this.LB_Street.Text = "Street:";
            // 
            // CO_Salutation
            // 
            this.CO_Salutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CO_Salutation.FormattingEnabled = true;
            this.CO_Salutation.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.CO_Salutation.Location = new System.Drawing.Point(66, 19);
            this.CO_Salutation.Name = "CO_Salutation";
            this.CO_Salutation.Size = new System.Drawing.Size(177, 21);
            this.CO_Salutation.TabIndex = 1;
            // 
            // LB_Salutation
            // 
            this.LB_Salutation.AutoSize = true;
            this.LB_Salutation.Location = new System.Drawing.Point(3, 22);
            this.LB_Salutation.Name = "LB_Salutation";
            this.LB_Salutation.Size = new System.Drawing.Size(57, 13);
            this.LB_Salutation.TabIndex = 0;
            this.LB_Salutation.Text = "Salutation:";
            // 
            // LB_Surname
            // 
            this.LB_Surname.AutoSize = true;
            this.LB_Surname.Location = new System.Drawing.Point(3, 76);
            this.LB_Surname.Name = "LB_Surname";
            this.LB_Surname.Size = new System.Drawing.Size(52, 13);
            this.LB_Surname.TabIndex = 4;
            this.LB_Surname.Text = "Surname:";
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(66, 73);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(177, 20);
            this.TB_Surname.TabIndex = 5;
            // 
            // LB_Forename
            // 
            this.LB_Forename.AutoSize = true;
            this.LB_Forename.Location = new System.Drawing.Point(3, 49);
            this.LB_Forename.Name = "LB_Forename";
            this.LB_Forename.Size = new System.Drawing.Size(57, 13);
            this.LB_Forename.TabIndex = 2;
            this.LB_Forename.Text = "Forename:";
            // 
            // TB_Forename
            // 
            this.TB_Forename.Location = new System.Drawing.Point(66, 46);
            this.TB_Forename.Name = "TB_Forename";
            this.TB_Forename.Size = new System.Drawing.Size(177, 20);
            this.TB_Forename.TabIndex = 3;
            // 
            // DG_Grid
            // 
            this.DG_Grid.AllowUserToAddRows = false;
            this.DG_Grid.AllowUserToDeleteRows = false;
            this.DG_Grid.AllowUserToResizeRows = false;
            this.DG_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL_ID,
            this.CL_Salutation,
            this.CL_Forename,
            this.CL_Surname,
            this.CL_Street,
            this.CL_ZIP,
            this.CL_City,
            this.CL_Country,
            this.CL_Phone,
            this.CL_Email,
            this.CL_Notes,
            this.CL_Created,
            this.CL_Changed});
            this.DG_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Grid.Location = new System.Drawing.Point(257, 0);
            this.DG_Grid.Margin = new System.Windows.Forms.Padding(0);
            this.DG_Grid.MultiSelect = false;
            this.DG_Grid.Name = "DG_Grid";
            this.DG_Grid.ReadOnly = true;
            this.DG_Grid.RowHeadersVisible = false;
            this.DG_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Grid.Size = new System.Drawing.Size(504, 446);
            this.DG_Grid.TabIndex = 4;
            this.DG_Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Grid_RowEnter);
            // 
            // CL_ID
            // 
            this.CL_ID.DataPropertyName = "id";
            this.CL_ID.HeaderText = "ID";
            this.CL_ID.Name = "CL_ID";
            this.CL_ID.ReadOnly = true;
            this.CL_ID.Width = 43;
            // 
            // CL_Salutation
            // 
            this.CL_Salutation.DataPropertyName = "salutation";
            this.CL_Salutation.HeaderText = "Salutation";
            this.CL_Salutation.Name = "CL_Salutation";
            this.CL_Salutation.ReadOnly = true;
            this.CL_Salutation.Width = 79;
            // 
            // CL_Forename
            // 
            this.CL_Forename.DataPropertyName = "forename";
            this.CL_Forename.HeaderText = "Forename";
            this.CL_Forename.Name = "CL_Forename";
            this.CL_Forename.ReadOnly = true;
            this.CL_Forename.Width = 79;
            // 
            // CL_Surname
            // 
            this.CL_Surname.DataPropertyName = "surname";
            this.CL_Surname.HeaderText = "Surname";
            this.CL_Surname.Name = "CL_Surname";
            this.CL_Surname.ReadOnly = true;
            this.CL_Surname.Width = 74;
            // 
            // CL_Street
            // 
            this.CL_Street.DataPropertyName = "street";
            this.CL_Street.HeaderText = "Street";
            this.CL_Street.Name = "CL_Street";
            this.CL_Street.ReadOnly = true;
            this.CL_Street.Width = 60;
            // 
            // CL_ZIP
            // 
            this.CL_ZIP.DataPropertyName = "zip";
            this.CL_ZIP.HeaderText = "Zip";
            this.CL_ZIP.Name = "CL_ZIP";
            this.CL_ZIP.ReadOnly = true;
            this.CL_ZIP.Width = 47;
            // 
            // CL_City
            // 
            this.CL_City.DataPropertyName = "city";
            this.CL_City.HeaderText = "City";
            this.CL_City.Name = "CL_City";
            this.CL_City.ReadOnly = true;
            this.CL_City.Width = 49;
            // 
            // CL_Country
            // 
            this.CL_Country.DataPropertyName = "country";
            this.CL_Country.HeaderText = "Country";
            this.CL_Country.Name = "CL_Country";
            this.CL_Country.ReadOnly = true;
            this.CL_Country.Width = 68;
            // 
            // CL_Phone
            // 
            this.CL_Phone.DataPropertyName = "phone";
            this.CL_Phone.HeaderText = "Phone";
            this.CL_Phone.Name = "CL_Phone";
            this.CL_Phone.ReadOnly = true;
            this.CL_Phone.Width = 63;
            // 
            // CL_Email
            // 
            this.CL_Email.DataPropertyName = "email";
            this.CL_Email.HeaderText = "Email";
            this.CL_Email.Name = "CL_Email";
            this.CL_Email.ReadOnly = true;
            this.CL_Email.Width = 57;
            // 
            // CL_Notes
            // 
            this.CL_Notes.DataPropertyName = "notes";
            this.CL_Notes.HeaderText = "Notes";
            this.CL_Notes.Name = "CL_Notes";
            this.CL_Notes.ReadOnly = true;
            this.CL_Notes.Width = 60;
            // 
            // CL_Created
            // 
            this.CL_Created.DataPropertyName = "create_date";
            this.CL_Created.HeaderText = "Created";
            this.CL_Created.Name = "CL_Created";
            this.CL_Created.ReadOnly = true;
            this.CL_Created.Width = 69;
            // 
            // CL_Changed
            // 
            this.CL_Changed.DataPropertyName = "change_date";
            this.CL_Changed.HeaderText = "Changed";
            this.CL_Changed.Name = "CL_Changed";
            this.CL_Changed.ReadOnly = true;
            this.CL_Changed.Width = 75;
            // 
            // PN_Layout
            // 
            this.PN_Layout.ColumnCount = 2;
            this.PN_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.PN_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PN_Layout.Controls.Add(this.DG_Grid, 1, 0);
            this.PN_Layout.Controls.Add(this.GB_Address, 0, 0);
            this.PN_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Layout.Location = new System.Drawing.Point(3, 0);
            this.PN_Layout.Name = "PN_Layout";
            this.PN_Layout.RowCount = 1;
            this.PN_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PN_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PN_Layout.Size = new System.Drawing.Size(761, 446);
            this.PN_Layout.TabIndex = 5;
            // 
            // FO_Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 446);
            this.Controls.Add(this.PN_Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 485);
            this.Name = "FO_Mainform";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactbook";
            this.Load += new System.EventHandler(this.FO_Mainform_Load);
            this.GB_Address.ResumeLayout(false);
            this.GB_Address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Grid)).EndInit();
            this.PN_Layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Address;
        private System.Windows.Forms.DataGridView DG_Grid;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.ComboBox CO_Salutation;
        private System.Windows.Forms.Label LB_Salutation;
        private System.Windows.Forms.Label LB_Surname;
        private System.Windows.Forms.TextBox TB_Surname;
        private System.Windows.Forms.Label LB_Forename;
        private System.Windows.Forms.TextBox TB_Forename;
        private System.Windows.Forms.Label LB_Notes;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.Label LB_Phone;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.Label LB_Country;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.TextBox TB_Zip;
        private System.Windows.Forms.Label LB_Zip;
        private System.Windows.Forms.TextBox TB_Street;
        private System.Windows.Forms.Label LB_Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Salutation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_ZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL_Changed;
        private System.Windows.Forms.TableLayoutPanel PN_Layout;
    }
}

