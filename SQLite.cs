using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Contactbook
{
    class SQLite
    {
        public string Folder { get; private set; }
        public string Database { get; private set; }

        private SQLiteConnection Con;
        public SQLite()
        {
            Folder = "./database/";
            Database = Folder + "contactbook.db3";
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            if (!Directory.Exists(Folder))
            {
                Directory.CreateDirectory(Folder);
                CreateDatabaseFile();
                
            }
            else if (Directory.Exists(Folder) && !File.Exists(Database))
            {
                CreateDatabaseFile();
            }
        }

        private void CreateDatabaseFile()
        {
            File.Create(Database).Close();
            CreateTableAddresses();
        }

        private void CreateDatabaseConnection()
        {
            SQLiteConnectionStringBuilder mBuilder = new SQLiteConnectionStringBuilder()
            {
                DataSource = Database,
                Version = 3
            };
            Con = new SQLiteConnection(mBuilder.ToString());
        }

        private void OpenDatabaseConnection()
        {
            try
            {
                CreateDatabaseConnection();
                Con.Open();
            }
            catch (Exception e)
            {
                ErrorHandler(e);
            }
        }

        private void CloseDatabaseConnection()
        {
            try
            {
                Con.Close();
                Con.Dispose();
            }
            catch (Exception e)
            {
                ErrorHandler(e);
            }
        }

        private void ErrorHandler(Exception exception)
        {
            MessageBox.Show(exception.Message, "SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateTableAddresses()
        {
            SQLiteCommand cmd;
            string statement = "CREATE TABLE \"addresses\" (\"id\" INTEGER NOT NULL UNIQUE, " +
                                "\"salutation\" TEXT, \"forename\" TEXT, \"surname\" TEXT, \"street\"" +
                                " TEXT, \"zip\" TEXT, \"city\" TEXT, \"country\" TEXT, \"phone\" TEXT, \"email\" TEXT, " +
                                "\"notes\" TEXT, \"create_date\" TEXT, \"change_date\" TEXT, PRIMARY KEY(\"id\" AUTOINCREMENT));";

            try
            {
                OpenDatabaseConnection();
                cmd = Con.CreateCommand();
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                CloseDatabaseConnection();
            }
        }

        public DataTable ReadAddresses()
        {
            DataTable table = new DataTable();
            SQLiteCommand cmd;
            SQLiteDataAdapter adapter;

            try
            {
                OpenDatabaseConnection();
                cmd = Con.CreateCommand();
                cmd.CommandText = "select * from addresses;";
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(table);
                cmd.Dispose();
                adapter.Dispose();
            }
            catch (Exception e)
            {
                ErrorHandler(e);
            }
            finally
            {
                CloseDatabaseConnection();
            }

            return table;
        }
        public void InsertAddress(Person person)
        {
            SQLiteCommand cmd;

            try
            {
                OpenDatabaseConnection();
                cmd = Con.CreateCommand();
                cmd.CommandText = "INSERT INTO addresses (salutation, forename, surname, street, zip, " +
                                    "city, country, phone, email, notes, create_date, change_date) VALUES " +
                                    "(@Salutation, @Forename, @Surname, @Street, @ZIP, @City, @Country, " +
                                    "@Phone, @EMail, @Notes, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";
                cmd.Parameters.AddWithValue("@Salutation", person.Salutation);
                cmd.Parameters.AddWithValue("@Forename", person.Forename);
                cmd.Parameters.AddWithValue("@Surname", person.Surname);
                cmd.Parameters.AddWithValue("@Street", person.Street);
                cmd.Parameters.AddWithValue("@ZIP", person.ZIP);
                cmd.Parameters.AddWithValue("@City", person.City);
                cmd.Parameters.AddWithValue("@Country", person.Country);
                cmd.Parameters.AddWithValue("@Phone", person.Phone);
                cmd.Parameters.AddWithValue("@EMail", person.EMail);
                cmd.Parameters.AddWithValue("@Notes", person.Notes);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ErrorHandler(e);
            }
            finally
            {
                CloseDatabaseConnection();
            }
        }

        public void UpdateAddress()
        {

        }

        public void DeleteAddress(int id)
        {

        }
    }
}
