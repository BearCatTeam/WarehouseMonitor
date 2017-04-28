using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnailWareHouse
{
    public partial class AddEntryForm : Form
    {
        public AddEntryForm()
        {
            InitializeComponent();
        }

        private void AddEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {

        }

        private void AddEntryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
