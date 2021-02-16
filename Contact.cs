using System.Data;

namespace Contactbook
{
    struct Person
    {
        public int ID;
        public string Salutation;
        public string Forename;
        public string Surname;
        public string Street;
        public string ZIP;
        public string City;
        public string Country;
        public string Phone;
        public string EMail;
        public string Notes;
    }
    static class Contact
    {
        private static SQLite SQL = new SQLite();

        public static DataTable ReadContacts()
        {
            return SQL.ReadAddresses();
        }
        public static void CreateContact(Person person)
        {
            SQL.InsertAddress(person);
        }

        public static void UpdateContact(Person person)
        {
            SQL.UpdateAddress(person);
        }

        public static void DeleteContact(Person person)
        {
            SQL.DeleteAddress(person);
        }
    }
}
