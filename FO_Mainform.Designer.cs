
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
            this.LB_Notes = new System.Windows.Forms.Label();
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
            this.CB_Salutation = new System.Windows.Forms.ComboBox();
            this.LB_Salutation = new System.Windows.Forms.Label();
            this.LB_Surname = new System.Windows.Forms.Label();
            this.TB_Surname = new System.Windows.Forms.TextBox();
            this.LB_Forename = new System.Windows.Forms.Label();
            this.TB_Forename = new System.Windows.Forms.TextBox();
            this.DG_Grid = new System.Windows.Forms.DataGridView();
            this.BT_Create = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.GB_Address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Address
            // 
            this.GB_Address.Controls.Add(this.LB_Notes);
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
            this.GB_Address.Controls.Add(this.CB_Salutation);
            this.GB_Address.Controls.Add(this.LB_Salutation);
            this.GB_Address.Controls.Add(this.LB_Surname);
            this.GB_Address.Controls.Add(this.TB_Surname);
            this.GB_Address.Controls.Add(this.LB_Forename);
            this.GB_Address.Controls.Add(this.TB_Forename);
            this.GB_Address.Location = new System.Drawing.Point(12, 12);
            this.GB_Address.Name = "GB_Address";
            this.GB_Address.Size = new System.Drawing.Size(237, 397);
            this.GB_Address.TabIndex = 0;
            this.GB_Address.TabStop = false;
            this.GB_Address.Text = "Address";
            // 
            // LB_Notes
            // 
            this.LB_Notes.AutoSize = true;
            this.LB_Notes.Location = new System.Drawing.Point(6, 277);
            this.LB_Notes.Name = "LB_Notes";
            this.LB_Notes.Size = new System.Drawing.Size(38, 13);
            this.LB_Notes.TabIndex = 18;
            this.LB_Notes.Text = "Notes:";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(9, 293);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(222, 98);
            this.TB_Notes.TabIndex = 19;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(69, 233);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(162, 20);
            this.TB_Email.TabIndex = 17;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(6, 236);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(39, 13);
            this.LB_Email.TabIndex = 16;
            this.LB_Email.Text = "E-Mail:";
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(69, 207);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(162, 20);
            this.TB_Phone.TabIndex = 15;
            // 
            // LB_Phone
            // 
            this.LB_Phone.AutoSize = true;
            this.LB_Phone.Location = new System.Drawing.Point(6, 210);
            this.LB_Phone.Name = "LB_Phone";
            this.LB_Phone.Size = new System.Drawing.Size(41, 13);
            this.LB_Phone.TabIndex = 14;
            this.LB_Phone.Text = "Phone:";
            // 
            // TB_Country
            // 
            this.TB_Country.Location = new System.Drawing.Point(69, 181);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(162, 20);
            this.TB_Country.TabIndex = 13;
            // 
            // LB_Country
            // 
            this.LB_Country.AutoSize = true;
            this.LB_Country.Location = new System.Drawing.Point(6, 184);
            this.LB_Country.Name = "LB_Country";
            this.LB_Country.Size = new System.Drawing.Size(46, 13);
            this.LB_Country.TabIndex = 12;
            this.LB_Country.Text = "Country:";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(69, 155);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(162, 20);
            this.TB_City.TabIndex = 11;
            // 
            // LB_City
            // 
            this.LB_City.AutoSize = true;
            this.LB_City.Location = new System.Drawing.Point(6, 158);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(27, 13);
            this.LB_City.TabIndex = 10;
            this.LB_City.Text = "City:";
            // 
            // TB_Zip
            // 
            this.TB_Zip.Location = new System.Drawing.Point(69, 129);
            this.TB_Zip.Name = "TB_Zip";
            this.TB_Zip.Size = new System.Drawing.Size(162, 20);
            this.TB_Zip.TabIndex = 9;
            // 
            // LB_Zip
            // 
            this.LB_Zip.AutoSize = true;
            this.LB_Zip.Location = new System.Drawing.Point(6, 132);
            this.LB_Zip.Name = "LB_Zip";
            this.LB_Zip.Size = new System.Drawing.Size(25, 13);
            this.LB_Zip.TabIndex = 8;
            this.LB_Zip.Text = "Zip:";
            // 
            // TB_Street
            // 
            this.TB_Street.Location = new System.Drawing.Point(69, 103);
            this.TB_Street.Name = "TB_Street";
            this.TB_Street.Size = new System.Drawing.Size(162, 20);
            this.TB_Street.TabIndex = 7;
            // 
            // LB_Street
            // 
            this.LB_Street.AutoSize = true;
            this.LB_Street.Location = new System.Drawing.Point(6, 106);
            this.LB_Street.Name = "LB_Street";
            this.LB_Street.Size = new System.Drawing.Size(38, 13);
            this.LB_Street.TabIndex = 6;
            this.LB_Street.Text = "Street:";
            // 
            // CB_Salutation
            // 
            this.CB_Salutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Salutation.FormattingEnabled = true;
            this.CB_Salutation.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.CB_Salutation.Location = new System.Drawing.Point(69, 24);
            this.CB_Salutation.Name = "CB_Salutation";
            this.CB_Salutation.Size = new System.Drawing.Size(162, 21);
            this.CB_Salutation.TabIndex = 1;
            // 
            // LB_Salutation
            // 
            this.LB_Salutation.AutoSize = true;
            this.LB_Salutation.Location = new System.Drawing.Point(6, 27);
            this.LB_Salutation.Name = "LB_Salutation";
            this.LB_Salutation.Size = new System.Drawing.Size(57, 13);
            this.LB_Salutation.TabIndex = 0;
            this.LB_Salutation.Text = "Salutation:";
            // 
            // LB_Surname
            // 
            this.LB_Surname.AutoSize = true;
            this.LB_Surname.Location = new System.Drawing.Point(6, 80);
            this.LB_Surname.Name = "LB_Surname";
            this.LB_Surname.Size = new System.Drawing.Size(52, 13);
            this.LB_Surname.TabIndex = 4;
            this.LB_Surname.Text = "Surname:";
            // 
            // TB_Surname
            // 
            this.TB_Surname.Location = new System.Drawing.Point(69, 77);
            this.TB_Surname.Name = "TB_Surname";
            this.TB_Surname.Size = new System.Drawing.Size(162, 20);
            this.TB_Surname.TabIndex = 5;
            // 
            // LB_Forename
            // 
            this.LB_Forename.AutoSize = true;
            this.LB_Forename.Location = new System.Drawing.Point(6, 54);
            this.LB_Forename.Name = "LB_Forename";
            this.LB_Forename.Size = new System.Drawing.Size(57, 13);
            this.LB_Forename.TabIndex = 2;
            this.LB_Forename.Text = "Forename:";
            // 
            // TB_Forename
            // 
            this.TB_Forename.Location = new System.Drawing.Point(69, 51);
            this.TB_Forename.Name = "TB_Forename";
            this.TB_Forename.Size = new System.Drawing.Size(162, 20);
            this.TB_Forename.TabIndex = 3;
            // 
            // DG_Grid
            // 
            this.DG_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Grid.Dock = System.Windows.Forms.DockStyle.Right;
            this.DG_Grid.Location = new System.Drawing.Point(255, 0);
            this.DG_Grid.Name = "DG_Grid";
            this.DG_Grid.Size = new System.Drawing.Size(545, 450);
            this.DG_Grid.TabIndex = 4;
            // 
            // BT_Create
            // 
            this.BT_Create.Location = new System.Drawing.Point(12, 415);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(75, 23);
            this.BT_Create.TabIndex = 1;
            this.BT_Create.Text = "&Create";
            this.BT_Create.UseVisualStyleBackColor = true;
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(93, 415);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 2;
            this.BT_Update.Text = "&Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(174, 415);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(75, 23);
            this.BT_Delete.TabIndex = 3;
            this.BT_Delete.Text = "&Delete";
            this.BT_Delete.UseVisualStyleBackColor = true;
            // 
            // FO_Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.BT_Create);
            this.Controls.Add(this.DG_Grid);
            this.Controls.Add(this.GB_Address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FO_Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactbook";
            this.GB_Address.ResumeLayout(false);
            this.GB_Address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Address;
        private System.Windows.Forms.DataGridView DG_Grid;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.ComboBox CB_Salutation;
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
    }
}

