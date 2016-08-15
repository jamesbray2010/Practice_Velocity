using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coding_Challange_Practice_Velocity
{
    public partial class AddEventType : Form
    {
        public AddEventType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEventType_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.AddEventTypeItem(txtEventType.Text.ToString());
            Close();
            main.Show();
        }
    }
}
