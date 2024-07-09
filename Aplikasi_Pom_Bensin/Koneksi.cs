using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Pom_Bensin
{
    class Koneksi
    {
        public static MySqlConnection Connection = null; // Mengubah nama variabel statis
        public static MySqlConnection GetConnection()
        {
            // Pastikan koneksi belum dibuat sebelumnya
            if (Connection == null)
            {
                string constring = "Server=localhost; Database=db_pom_bensin; Uid=root; Pwd=;";
                Connection = new MySqlConnection(constring);
            }
            return Connection;
        }

        public static void Connect()
        {
            try
            {
                // Pastikan koneksi tidak sedang terbuka
                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                    // MessageBox.Show("Koneksi Berhasil dilakukan");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                Console.WriteLine("Koneksi Ditutup");
            }
        }
    }
}
