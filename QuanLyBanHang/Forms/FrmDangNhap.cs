using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
        protected override void OnHelpRequested(HelpEventArgs hevent)
        {
            string helpFile = Path.Combine(Application.StartupPath, @"Help\HuongDanSuDung.html#dangnhap");
            if (!File.Exists(helpFile))
                helpFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Help\HuongDanSuDung.html#dangnhap");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = helpFile,
                UseShellExecute = true
            });
            hevent.Handled = true;
        }

    }
}
