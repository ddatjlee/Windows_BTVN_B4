using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNBuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(frm.MSNV);
                item.SubItems.Add(frm.TenNV);
                item.SubItems.Add(frm.Luong);
                lv1.Items.Add(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lv1.SelectedItems[0];
                Form2 frm = new Form2(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    item.SubItems[0].Text = frm.MSNV;
                    item.SubItems[1].Text = frm.TenNV;
                    item.SubItems[2].Text = frm.Luong;
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {           
                    lv1.Items.Remove(lv1.SelectedItems[0]);
                
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
