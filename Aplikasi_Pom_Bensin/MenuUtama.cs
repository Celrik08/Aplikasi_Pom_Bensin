using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pom_Bensin
{
    public partial class MenuUtama : Form
    {
        private int roleId; // Tambahkan variabel roleId
        public MenuUtama(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;

            // Ganti pengecekan level dengan pengecekan roleId
            if (roleId == 1)
            {
                DataMaster.Visible = true;
                Transaksi.Visible = true;
            }

            else if (roleId == 2)
            {
                DataMaster.Visible = false;
                ManagementPembayaranMasuk.Visible = false;
            }

            else if (roleId == 3)
            {
                DataMaster.Visible = false;
                ManagementPembayaran.Visible = true;
                ManagementPembayaranMasuk.Visible = false;
            }

            else if (roleId == 4)
            {
                ManagementAkun.Visible = false;
                DataBensin.Visible = true;
                ManagementTransaksi.Visible = false;
                ManagementMasuk.Visible = false;
                Transaksi.Visible = false;
            }

            User.Text = GetRoleName(roleId);
        }

        private string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin";
                case 2:
                    return "Manager";
                case 3:
                    return "Operator";
                case 4:
                    return "Pelanggan";
                default:
                    return "Unknown";
            }
        }
    }
}
