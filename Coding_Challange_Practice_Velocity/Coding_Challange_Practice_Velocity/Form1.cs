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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            if (CboEventType.SelectedItem == null)  // Check To See If The User Selected An Event Type
            {
                MessageBox.Show("Please Select An Event Type", "Event Type Required");
                return;
            }


            txtResults.Clear();
            
            if (CboEventType.SelectedIndex == 0)   // Register Event Type
            {
                RegisterEventType();
            }
            else if (CboEventType.SelectedIndex == 1) // Diagnose Event Type
            {
                DiagnoseEventType();
            }
            else                                     // NoBusinessRulesEventType
            {
                NoBusinessRulesEventType();
            }
        }

        public void RegisterEventType()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)           // this is a multiple of 3 and 5 
                        txtResults.AppendText(CboEventType.SelectedItem.ToString() + " Patient" + Environment.NewLine);
                    else                      // this is a multiple of 3
                        txtResults.AppendText(CboEventType.SelectedItem.ToString() + Environment.NewLine);
                }
                else if (i % 5 == 0)          // this is a multiple of 5
                    txtResults.AppendText("Patient" + Environment.NewLine);
                else                          // this is NOT a mutiple of 3 or 5
                    txtResults.AppendText(i + Environment.NewLine);
            }
        }

        public void DiagnoseEventType()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 7 == 0)           // this is a multiple of 2 and 7
                        txtResults.AppendText(CboEventType.SelectedItem.ToString() + " Patient" + Environment.NewLine);
                    else                      // this is a multiple of 2
                        txtResults.AppendText(CboEventType.SelectedItem.ToString() + Environment.NewLine);
                }
                else if (i % 7 == 0)          // this is a multiple of 7
                    txtResults.AppendText("Patient" + Environment.NewLine);
                else                          // this is NOT a mutiple of 2 or 7
                    txtResults.AppendText(i + Environment.NewLine);
            }
        }

        public void NoBusinessRulesEventType()
        {
            for (int i = 1; i <= 100; i++)
            {
              txtResults.AppendText(i + Environment.NewLine);
            }
        }

        private void btnAddEventType_Click(object sender, EventArgs e)
        {
            Form frm = new AddEventType();
            frm.Show();
            this.Hide();
        }

        public void AddEventTypeItem(object NewEventType)
        {
            CboEventType.Items.Add(NewEventType);
        }

   
    }
}
