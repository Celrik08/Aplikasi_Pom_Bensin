namespace Aplikasi_Pom_Bensin
{
    partial class MenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            ManagementAkun = new ToolStripMenuItem();
            ManagementPegawai = new ToolStripMenuItem();
            DataPegawai = new ToolStripMenuItem();
            DataJenis = new ToolStripMenuItem();
            DataPelanggan = new ToolStripMenuItem();
            DataRole = new ToolStripMenuItem();
            DataUser = new ToolStripMenuItem();
            DataBensin = new ToolStripMenuItem();
            ManagementTransaksi = new ToolStripMenuItem();
            DataTransaksi = new ToolStripMenuItem();
            DataStatus = new ToolStripMenuItem();
            ManagementMasuk = new ToolStripMenuItem();
            dataSuplaierToolStripMenuItem = new ToolStripMenuItem();
            dataBensinMasukToolStripMenuItem = new ToolStripMenuItem();
            Transaksi = new ToolStripMenuItem();
            ManagementPembayaran = new ToolStripMenuItem();
            ManagementPembayaranMasuk = new ToolStripMenuItem();
            label1 = new Label();
            User = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DataMaster, Transaksi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(487, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { ManagementAkun, DataBensin, ManagementTransaksi, ManagementMasuk });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(112, 24);
            DataMaster.Text = "Data Master";
            // 
            // ManagementAkun
            // 
            ManagementAkun.DropDownItems.AddRange(new ToolStripItem[] { ManagementPegawai, DataPelanggan, DataRole, DataUser });
            ManagementAkun.Name = "ManagementAkun";
            ManagementAkun.Size = new Size(293, 26);
            ManagementAkun.Text = "Management Akun";
            // 
            // ManagementPegawai
            // 
            ManagementPegawai.DropDownItems.AddRange(new ToolStripItem[] { DataPegawai, DataJenis });
            ManagementPegawai.Name = "ManagementPegawai";
            ManagementPegawai.Size = new Size(250, 26);
            ManagementPegawai.Text = "Management Pegawai";
            // 
            // DataPegawai
            // 
            DataPegawai.Name = "DataPegawai";
            DataPegawai.Size = new Size(231, 26);
            DataPegawai.Text = "Data Pegawai";
            // 
            // DataJenis
            // 
            DataJenis.Name = "DataJenis";
            DataJenis.Size = new Size(231, 26);
            DataJenis.Text = "Data Jenis Kelamin";
            // 
            // DataPelanggan
            // 
            DataPelanggan.Name = "DataPelanggan";
            DataPelanggan.Size = new Size(250, 26);
            DataPelanggan.Text = "Data Pelanggan";
            // 
            // DataRole
            // 
            DataRole.Name = "DataRole";
            DataRole.Size = new Size(250, 26);
            DataRole.Text = "Data Role";
            // 
            // DataUser
            // 
            DataUser.Name = "DataUser";
            DataUser.Size = new Size(250, 26);
            DataUser.Text = "Data User";
            // 
            // DataBensin
            // 
            DataBensin.Name = "DataBensin";
            DataBensin.Size = new Size(293, 26);
            DataBensin.Text = "Data Bensin";
            // 
            // ManagementTransaksi
            // 
            ManagementTransaksi.DropDownItems.AddRange(new ToolStripItem[] { DataTransaksi, DataStatus });
            ManagementTransaksi.Name = "ManagementTransaksi";
            ManagementTransaksi.Size = new Size(293, 26);
            ManagementTransaksi.Text = "Management Transaksi";
            // 
            // DataTransaksi
            // 
            DataTransaksi.Name = "DataTransaksi";
            DataTransaksi.Size = new Size(224, 26);
            DataTransaksi.Text = "Data Transaksi";
            // 
            // DataStatus
            // 
            DataStatus.Name = "DataStatus";
            DataStatus.Size = new Size(224, 26);
            DataStatus.Text = "Data Status";
            // 
            // ManagementMasuk
            // 
            ManagementMasuk.DropDownItems.AddRange(new ToolStripItem[] { dataSuplaierToolStripMenuItem, dataBensinMasukToolStripMenuItem });
            ManagementMasuk.Name = "ManagementMasuk";
            ManagementMasuk.Size = new Size(293, 26);
            ManagementMasuk.Text = "Management Bensin Masuk";
            // 
            // dataSuplaierToolStripMenuItem
            // 
            dataSuplaierToolStripMenuItem.Name = "dataSuplaierToolStripMenuItem";
            dataSuplaierToolStripMenuItem.Size = new Size(234, 26);
            dataSuplaierToolStripMenuItem.Text = "Data Suplaier";
            // 
            // dataBensinMasukToolStripMenuItem
            // 
            dataBensinMasukToolStripMenuItem.Name = "dataBensinMasukToolStripMenuItem";
            dataBensinMasukToolStripMenuItem.Size = new Size(234, 26);
            dataBensinMasukToolStripMenuItem.Text = "Data Bensin Masuk";
            // 
            // Transaksi
            // 
            Transaksi.DropDownItems.AddRange(new ToolStripItem[] { ManagementPembayaran, ManagementPembayaranMasuk });
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(92, 24);
            Transaksi.Text = "Transaksi";
            // 
            // ManagementPembayaran
            // 
            ManagementPembayaran.Name = "ManagementPembayaran";
            ManagementPembayaran.Size = new Size(388, 26);
            ManagementPembayaran.Text = "Management Pembayaran";
            // 
            // ManagementPembayaranMasuk
            // 
            ManagementPembayaranMasuk.Name = "ManagementPembayaranMasuk";
            ManagementPembayaranMasuk.Size = new Size(388, 26);
            ManagementPembayaranMasuk.Text = "Management Pembayaran Bensin Masuk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 108);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(207, 173);
            User.Name = "User";
            User.Size = new Size(43, 20);
            User.TabIndex = 2;
            User.Text = "User";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 312);
            Controls.Add(User);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem ManagementAkun;
        private ToolStripMenuItem DataBensin;
        private ToolStripMenuItem ManagementTransaksi;
        private ToolStripMenuItem DataTransaksi;
        private ToolStripMenuItem DataStatus;
        private ToolStripMenuItem ManagementPegawai;
        private ToolStripMenuItem DataPegawai;
        private ToolStripMenuItem DataJenis;
        private ToolStripMenuItem DataPelanggan;
        private ToolStripMenuItem DataRole;
        private ToolStripMenuItem DataUser;
        private ToolStripMenuItem Transaksi;
        private ToolStripMenuItem ManagementPembayaran;
        private Label label1;
        private Label User;
        private ToolStripMenuItem ManagementPembayaranMasuk;
        private ToolStripMenuItem ManagementMasuk;
        private ToolStripMenuItem dataSuplaierToolStripMenuItem;
        private ToolStripMenuItem dataBensinMasukToolStripMenuItem;
    }
}