using System;
using System.Windows.Forms;

namespace Contactbook
{
    public partial class FO_Mainform : Form
    {
        Person selectedPerson = new Person();
        public FO_Mainform()
        {
            InitializeComponent();
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            Contact.CreateContact(CreatePerson());
            GetDataSource();
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

        private void GetDataSource()
        {
            DG_Grid.DataSource = Contact.ReadContacts();
        }

        private void FO_Mainform_Load(object sender, EventArgs e)
        {
            CO_Salutation.SelectedIndex = 0;
            GetDataSource();
        }

        private void DG_Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_Grid.Rows[index];
            selectedPerson.ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            selectedPerson.Salutation = selectedRow.Cells[1].Value.ToString();
            selectedPerson.Forename = selectedRow.Cells[2].Value.ToString();
            selectedPerson.Surname = selectedRow.Cells[3].Value.ToString();
            selectedPerson.Street = selectedRow.Cells[4].Value.ToString();
            selectedPerson.ZIP = selectedRow.Cells[5].Value.ToString();
            selectedPerson.City = selectedRow.Cells[6].Value.ToString();
            selectedPerson.Country = selectedRow.Cells[7].Value.ToString();
            selectedPerson.Phone = selectedRow.Cells[8].Value.ToString();
            selectedPerson.EMail = selectedRow.Cells[9].Value.ToString();
            selectedPerson.Notes = selectedRow.Cells[10].Value.ToString();
            WritePersonIntoTextBoxes(selectedPerson);
        }

        private void WritePersonIntoTextBoxes(Person person)
        {
            CO_Salutation.Text = person.Salutation;
            TB_Forename.Text = person.Forename;
            TB_Surname.Text = person.Surname;
            TB_Street.Text = person.Street;
            TB_Zip.Text = person.ZIP;
            TB_City.Text = person.City;
            TB_Country.Text = person.Country;
            TB_Phone.Text = person.Phone;
            TB_Email.Text = person.EMail;
            TB_Notes.Text = person.Notes;
        }

        private void ClearAllTextBoxes()
        {
            CO_Salutation.Text = "";
            TB_Forename.Text = "";
            TB_Surname.Text = "";
            TB_Street.Text = "";
            TB_Zip.Text = "";
            TB_City.Text = "";
            TB_Country.Text = "";
            TB_Phone.Text = "";
            TB_Email.Text = "";
            TB_Notes.Text = "";
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            DialogResult mResult = MessageBox.Show("Do you really want to delete the selected data record?",
                                                    "Contactbook", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mResult == DialogResult.Yes)
            {
                Contact.DeleteContact(selectedPerson);
                ClearAllTextBoxes();
                GetDataSource();
            }
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            Person tempPerson = CreatePerson();
            tempPerson.ID = selectedPerson.ID;
            Contact.UpdateContact(tempPerson);
        }
    }
}
