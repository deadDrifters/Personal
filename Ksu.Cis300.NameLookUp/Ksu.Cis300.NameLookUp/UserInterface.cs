using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ksu.Cis300.NameLookup;


namespace Ksu.Cis300.NameLookUp
{
    public partial class UserInterface : Form
    {
        private LinkedListArray _listArray = new LinkedListArray();

        public UserInterface()
        {
            InitializeComponent();
        }

        public void displayMatches(LinkedListCell<NameInformation> firstName, string prefix)
        {
            statList.Items.Clear();
            UxSaveResults.Enabled = false;
            if (firstName == null)
            {
                MessageBox.Show("No names found.");
                return;
            }
            while ((firstName.Data.Name).StartsWith(prefix.ToString()))
            {
                ListViewItem item = new ListViewItem(firstName.Data.Name);
                item.SubItems.Add(firstName.Data.Frequency.ToString());
                item.SubItems.Add(firstName.Data.CumulativeFrequency.ToString());
                item.SubItems.Add(firstName.Data.Rank.ToString());
                statList.Items.Add(item);

                firstName = firstName.Next;
                if (firstName == null)
                {
                    return;
                }



            }
            UxSaveResults.Enabled = true;
            return;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namePrefix = UxTextBox.Text.Trim().ToUpper();
            if (namePrefix[0] >= 'A' && namePrefix[0] <= 'Z')
            {
                LinkedListCell<NameInformation> firstName = _listArray.FindFirstCell(namePrefix);
                displayMatches(firstName, namePrefix);
            }
            else
            {
                MessageBox.Show("Invalid text input.");
                return;
            }
        }

        private void UxLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LinkedListArray listArray = new LinkedListArray();
                    listArray.LoadFile(openFileDialog1.FileName);


                }
                catch (Exception ex)
                {
                    throw new System.Exception("User did not select a proper file: " + ex);
                }
            }
        }

        private void saveResults(string filename)
        {
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                foreach (ListViewItem item in statList.Items)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        sb.Append(statList.Text).Append(',');
                    }
                    sw.WriteLine(sb.ToString());
                }
            }
        }

        private void UxSaveResults_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    saveResults(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    throw new System.Exception(ex.ToString());
                }
            }
        }

        private void UxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UxFindNames.Text.Trim().Length > 0)
            {
                UxFindNames.Enabled = true;
            }
            else UxFindNames.Enabled = false;
        }
    }
    
}
