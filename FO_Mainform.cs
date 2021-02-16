using System;
using System.Windows.Forms;

namespace Contactbook
{
    public partial class FO_Mainform : Form
    {
        public FO_Mainform()
        {
            InitializeComponent();
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            Contact.CreateContact(CreatePerson());
        }

        private Person CreatePerson()
        {
            Person newPerson = new Person();
            newPerson.Salutation = CO_Salutation.Text;
            newPerson.Forename = GetTextBoxValue(TB_Forename);
            newPerson.Surname = GetTextBoxValue(TB_Surname);
            newPerson.Street = GetTextBoxValue(TB_Street);
            newPerson.ZIP = GetTextBoxValue(TB_Zip);
            newPerson.City = GetTextBoxValue(TB_City);
            newPerson.Country = GetTextBoxValue(TB_Country);
            newPerson.Phone = GetTextBoxValue(TB_Phone);
            newPerson.EMail = GetTextBoxValue(TB_Email);
            newPerson.Notes = GetTextBoxValue(TB_Notes);
            return newPerson;
        }

        private string GetTextBoxValue(TextBox textBox)
        {
            return textBox.Text;
        }

        private void FO_Mainform_Load(object sender, EventArgs e)
        {
            CO_Salutation.SelectedIndex = 0;
            DG_Grid.DataSource = Contact.ReadContacts();
        }
    }
}
