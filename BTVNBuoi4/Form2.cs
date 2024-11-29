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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string Luong { get; set; }

        public Form2(string msnv, string tennv, string luong) : this()
        {
            txtMSNV.Text = msnv;
            txtTen.Text = tennv;
            txtLuong.Text = luong;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSNV.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MSNV = txtMSNV.Text;
            TenNV = txtTen.Text;
            Luong = txtLuong.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
