using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvstudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtlastname.Text);
            it.SubItems.Add(txtfirstname.Text);
            it.SubItems.Add(txtphone.Text);
            lvstudent.Items.Add(it);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvstudent.SelectedItems.Count > 0)
            {
                ListViewItem item = lvstudent.SelectedItems[0];
                item.SubItems[0].Text = txtlastname.Text;
                item.SubItems[1].Text = txtfirstname.Text;
                item.SubItems[2].Text = txtphone.Text;

            }
            else
            {
                MessageBox.Show("Chon dong de sua!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvstudent.SelectedItems.Count > 0)
            {
                lvstudent.Items.RemoveAt(lvstudent.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chon dong de xoa!");
            }
        }
    }
}
