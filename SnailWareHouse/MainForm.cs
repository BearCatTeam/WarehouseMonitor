using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SnailWareHouse
{
    public partial class MainForm : Form
    {
        private AddEntryForm addEntry_form;
        private EditEntryForm editEntry_form;
        private SQLiteConnection dbConnection_ob;
        public MainForm()
        {
            this.dbConnection_ob = new SQLiteConnection("Data Source=snailWHdb.db3;Version=3;");
            this.dbConnection_ob.Open();
            InitializeComponent();
            this.refresh_tableList();
            this.addEntry_form = new AddEntryForm();
            this.editEntry_form = new EditEntryForm();
            this.addEntry_form.ok_bt.Click += new System.EventHandler(this.addEntry_form_okBt_Clicked);
            this.addEntry_form.cancel_bt.Click += new System.EventHandler(this.addEntry_form_cancelBt_Clicked);
            this.editEntry_form.update_bt.Click += new System.EventHandler(this.editEntry_form_updateBt_Clicked);
            this.editEntry_form.cancel_bt.Click += new System.EventHandler(this.editEntry_form_cancelBt_Clicked);
        }

        private void editEntry_form_updateBt_Clicked(object sender, EventArgs e)
        {   
            string tableName = this.tableList.SelectedItem.ToString();
            string ID = this.editEntry_form.idNum.Text;
            string articleName = this.editEntry_form.articleName_tb.Text;
            string articleNumber = this.editEntry_form.articleNumber_tb.Text;
            string articleStorage = this.editEntry_form.articleStorage_tb.Text;
            string shelfNumber = this.editEntry_form.shelfNumber_tb.Text;
            string manuBrand = this.editEntry_form.manuBrand_tb.Text;

            string sql_cmd = "UPDATE " + tableName +
                             " SET " + "ArticleName = '" + articleName + "', ArticleNumber = " + articleNumber +
                             ", ArticleStorage = '" + articleStorage + "', ShelfNumber = " + shelfNumber + ", ManufacturedBrand = '" + manuBrand + "'" +
                             " WHERE ID = " + ID;
            
            using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
            {
                command.ExecuteNonQuery();
            }
            this.editEntry_form.Hide();
            this.refreshDataViewer();
        }

        private void editEntry_form_cancelBt_Clicked(object sender, EventArgs e)
        {
            this.editEntry_form.Hide();
        }

        private void enterEntry()
        {
            string articleName = this.addEntry_form.articleName_tb.Text;
            string articleNumber = this.addEntry_form.articleNumber_tb.Text;
            string articleStorage = this.addEntry_form.articleStorage_tb.Text;
            string shelfNumber = this.addEntry_form.shelfNumber_tb.Text;
            string manuBrand = this.addEntry_form.manuBrand_tb.Text;
            string tableName = this.tableList.SelectedItem.ToString();
            string sql_cmd = "INSERT INTO " + tableName + " (ArticleName, ArticleNumber, ArticleStorage, ShelfNumber, ManufacturedBrand) values ";
            sql_cmd += "('" + articleName + "', " + articleNumber + ", " + "'" + articleStorage + "', " + shelfNumber + ", " + "'" + manuBrand + "')";
            using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
            {
                command.ExecuteNonQuery();
            }
            this.clearAddEntryForm();
            this.refreshDataViewer();
        }

        private void addEntry_form_okBt_Clicked(object sender, EventArgs e)
        {
            this.enterEntry();
        }

        private void clearAddEntryForm()
        {
            this.addEntry_form.articleName_tb.Text = "";
            this.addEntry_form.articleNumber_tb.Text = "";
            this.addEntry_form.articleStorage_tb.Text = "";
            this.addEntry_form.shelfNumber_tb.Text = "";
            this.addEntry_form.manuBrand_tb.Text = "";
            this.addEntry_form.Hide();
        }

        private void addEntry_form_cancelBt_Clicked(object sender, EventArgs e)
        {
            this.clearAddEntryForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbConnection_ob.Close();
        }

        public void refresh_tableList()
        {
            string sql_cmd = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name";
            using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    this.tableList.Items.Clear();
                    while (reader.Read())
                    {
                        if (reader.GetString(0) != "sqlite_sequence")
                        {
                            this.tableList.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void tableCreate_bt_Click(object sender, EventArgs e)
        {
            string sql_cmd = Microsoft.VisualBasic.Interaction.InputBox("Input New Table's Name", "Create New Table", "", -1, -1);
            if (sql_cmd == "" )
            {
                MessageBox.Show("No table name entered");
                return;
            }
            sql_cmd ="CREATE TABLE " + sql_cmd + " (ID INTEGER PRIMARY KEY, ArticleName varchar(100), ArticleNumber int, ArticleStorage varchar(20), ShelfNumber int, ManufacturedBrand varchar(100))";
            using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
            {
                command.ExecuteNonQuery();
            };
            this.refresh_tableList();
        }

        private void tableDelete_bt_Click(object sender, EventArgs e)
        {
            if (this.tableList.SelectedItem != null)
            {
                string sql_cmd = this.tableList.SelectedItem.ToString();
                sql_cmd = "DROP TABLE " + sql_cmd;
                using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
                {
                    command.ExecuteNonQuery();
                }
                this.refresh_tableList();
                this.refreshDataViewer();
            }
            else 
            {
                MessageBox.Show("Please select a table to delete !");
            }
        }

        private void tableList_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tableList.SelectedItem != null)
            {
                this.refreshDataViewer();
            }
        }

        private void refreshDataViewer()
        {
            if (this.tableList.SelectedItem != null)
            {
                string sql_cmd = this.tableList.SelectedItem.ToString();
                DataTable dt = new DataTable();
                sql_cmd = "SELECT ID, ArticleName, ArticleNumber, ArticleStorage, ShelfNumber, ManufacturedBrand FROM " + sql_cmd;
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd, this.dbConnection_ob);
                da.Fill(dt);
                this.dataViewer.DataSource = dt;
                this.dataViewer.Refresh();
            }
            else
            {
                this.dataViewer.DataSource = null;
                this.dataViewer.Refresh();
            }
        }

        private void entryCreate_bt_Click(object sender, EventArgs e)
        {
            this.addEntry_form.Show();
        }

        private void entryUpdate_bt_Click(object sender, EventArgs e)
        {
            int selectedRowCount = this.dataViewer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string ID = this.dataViewer.SelectedRows[0].Cells[0].Value.ToString();
                string articleName = this.dataViewer.SelectedRows[0].Cells[1].Value.ToString();
                string articleNumber = this.dataViewer.SelectedRows[0].Cells[2].Value.ToString();
                string articleStorage = this.dataViewer.SelectedRows[0].Cells[3].Value.ToString();
                string shelfNumber = this.dataViewer.SelectedRows[0].Cells[4].Value.ToString();
                string manuBrand = this.dataViewer.SelectedRows[0].Cells[5].Value.ToString();
                this.editEntry_form.articleName_tb.Text = articleName;
                this.editEntry_form.articleNumber_tb.Text = articleNumber;
                this.editEntry_form.articleStorage_tb.Text = articleStorage;
                this.editEntry_form.shelfNumber_tb.Text = shelfNumber;
                this.editEntry_form.manuBrand_tb.Text = manuBrand;
                this.editEntry_form.idNum.Text = ID;
                this.editEntry_form.Show();
            } else if (selectedRowCount < 1)
            {
                MessageBox.Show("Please select a row to edit !");
            } else if (selectedRowCount > 1)
            {
                MessageBox.Show("Please select only one row to edit !");
            }
        }

        private void dataViewer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void entryDelete_bt_Click(object sender, EventArgs e)
        {
            int selectedRowCount = this.dataViewer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string ID = this.dataViewer.SelectedRows[0].Cells[0].Value.ToString();
                string tableName = this.tableList.SelectedItem.ToString();
                string sql_cmd = "DELETE FROM " + tableName + " WHERE ID = " + ID;
                using (SQLiteCommand command = new SQLiteCommand(sql_cmd, this.dbConnection_ob))
                {
                    command.ExecuteNonQuery();
                }
                this.refreshDataViewer();
            }
            else if (selectedRowCount < 1)
            {
                MessageBox.Show("Please select a row to delete !");
            }
            else if (selectedRowCount > 1)
            {
                MessageBox.Show("Please select only one row to delete !");
            }
        }

        private void entrySearch_bt_Click(object sender, EventArgs e)
        {
            if (this.searchTextInput.Text != "")
            {
                string tableName = this.tableList.SelectedItem.ToString();
                string pattern = this.searchTextInput.Text;
                string sql_cmd = "SELECT * FROM " + tableName + " WHERE ArticleName LIKE '%" + pattern +"%'";
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd, this.dbConnection_ob);
                da.Fill(dt);
                this.dataViewer.DataSource = dt;
                this.dataViewer.Refresh();
            } else
            {
                this.refreshDataViewer();
            }
        }
    }
}
