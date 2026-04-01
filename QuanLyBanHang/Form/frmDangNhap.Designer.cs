namespace QuanLyBanHang.Forms;

partial class frmDangNhap
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTieuDe = new System.Windows.Forms.Label();
        this.lblTenDangNhap = new System.Windows.Forms.Label();
        this.txtTenDangNhap = new System.Windows.Forms.TextBox();
        this.lblMatKhau = new System.Windows.Forms.Label();
        this.txtMatKhau = new System.Windows.Forms.TextBox();
        this.btnDangNhap = new System.Windows.Forms.Button();
        this.btnHuyBo = new System.Windows.Forms.Button();
        this.picLock = new System.Windows.Forms.PictureBox();
        this.panelMain = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
        this.panelMain.SuspendLayout();
        this.SuspendLayout();
        // 
        // picLock
        // 
        this.picLock.Location = new System.Drawing.Point(20, 80);
        this.picLock.Name = "picLock";
        this.picLock.Size = new System.Drawing.Size(80, 80);
        this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picLock.TabStop = false;
        // 
        // lblTieuDe
        // 
        this.lblTieuDe.AutoSize = false;
        this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTieuDe.Location = new System.Drawing.Point(0, 20);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(400, 40);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "ĐĂNG NHẬP";
        this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTenDangNhap
        // 
        this.lblTenDangNhap.AutoSize = true;
        this.lblTenDangNhap.Location = new System.Drawing.Point(115, 75);
        this.lblTenDangNhap.Name = "lblTenDangNhap";
        this.lblTenDangNhap.Size = new System.Drawing.Size(100, 20);
        this.lblTenDangNhap.TabIndex = 1;
        this.lblTenDangNhap.Text = "Tên đăng nhập:";
        // 
        // txtTenDangNhap
        // 
        this.txtTenDangNhap.Location = new System.Drawing.Point(115, 98);
        this.txtTenDangNhap.Name = "txtTenDangNhap";
        this.txtTenDangNhap.Size = new System.Drawing.Size(260, 27);
        this.txtTenDangNhap.TabIndex = 2;
        // 
        // lblMatKhau
        // 
        this.lblMatKhau.AutoSize = true;
        this.lblMatKhau.Location = new System.Drawing.Point(115, 135);
        this.lblMatKhau.Name = "lblMatKhau";
        this.lblMatKhau.Size = new System.Drawing.Size(60, 20);
        this.lblMatKhau.TabIndex = 3;
        this.lblMatKhau.Text = "Mật khẩu:";
        // 
        // txtMatKhau
        // 
        this.txtMatKhau.Location = new System.Drawing.Point(115, 158);
        this.txtMatKhau.Name = "txtMatKhau";
        this.txtMatKhau.PasswordChar = '●';
        this.txtMatKhau.Size = new System.Drawing.Size(260, 27);
        this.txtMatKhau.TabIndex = 4;
        this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
        // 
        // btnDangNhap
        // 
        this.btnDangNhap.Location = new System.Drawing.Point(155, 205);
        this.btnDangNhap.Name = "btnDangNhap";
        this.btnDangNhap.Size = new System.Drawing.Size(90, 32);
        this.btnDangNhap.TabIndex = 5;
        this.btnDangNhap.Text = "Đăng nhập";
        this.btnDangNhap.UseVisualStyleBackColor = true;
        this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
        // 
        // btnHuyBo
        // 
        this.btnHuyBo.Location = new System.Drawing.Point(255, 205);
        this.btnHuyBo.Name = "btnHuyBo";
        this.btnHuyBo.Size = new System.Drawing.Size(80, 32);
        this.btnHuyBo.TabIndex = 6;
        this.btnHuyBo.Text = "Hủy bỏ";
        this.btnHuyBo.UseVisualStyleBackColor = true;
        this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
        // 
        // panelMain
        // 
        this.panelMain.Controls.Add(this.lblTieuDe);
        this.panelMain.Controls.Add(this.picLock);
        this.panelMain.Controls.Add(this.lblTenDangNhap);
        this.panelMain.Controls.Add(this.txtTenDangNhap);
        this.panelMain.Controls.Add(this.lblMatKhau);
        this.panelMain.Controls.Add(this.txtMatKhau);
        this.panelMain.Controls.Add(this.btnDangNhap);
        this.panelMain.Controls.Add(this.btnHuyBo);
        this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelMain.Location = new System.Drawing.Point(0, 0);
        this.panelMain.Name = "panelMain";
        this.panelMain.Size = new System.Drawing.Size(400, 260);
        this.panelMain.TabIndex = 0;
        //
        // frmDangNhap
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 260);
        this.Controls.Add(this.panelMain);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmDangNhap";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Đăng nhập";
        ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
        this.panelMain.ResumeLayout(false);
        this.panelMain.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Label lblTenDangNhap;
    public System.Windows.Forms.TextBox txtTenDangNhap;
    private System.Windows.Forms.Label lblMatKhau;
    public System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.Button btnDangNhap;
    private System.Windows.Forms.Button btnHuyBo;
    private System.Windows.Forms.PictureBox picLock;
    private System.Windows.Forms.Panel panelMain;
}
