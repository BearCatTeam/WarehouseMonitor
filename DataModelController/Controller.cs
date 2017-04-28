using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DataModelController
{
    class Controller
    {
        public Controller()
        {
            System.Data.SQLite.SQLiteConnection.CreateFile("warehouse.db3");
        }

        public void createTable(string tableName)
        {
        }

        public void dropTable(string tableName)
        {
        }

        public void createEntry(string articleName, int articleNumber, string storage, int shelfNumber, string brand)
        {
        }

        public void deleteEntry(string tableName)
        {
        }

        public void updateEntry(string tableName)
        {
        }

        public void searchEntry(string tableName)
        {
        }
    }
}
