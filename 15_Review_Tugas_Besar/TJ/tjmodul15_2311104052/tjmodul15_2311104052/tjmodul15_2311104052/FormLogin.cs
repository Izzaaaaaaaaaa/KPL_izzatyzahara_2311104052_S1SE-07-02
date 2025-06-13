using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using tjmodul15_2311104052.Helpers;
using tjmodul15_2311104052.Models;

namespace tjmodul15_2311104052
{
    public partial class FormLogin: Form
    {
        private string userFile = "users.json";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string inputPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(inputPassword);

            if (!File.Exists(userFile))
            {
                MessageBox.Show("Belum ada user terdaftar.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<User> users;
            try
            {
                string json = File.ReadAllText(userFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca file user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == hashedPassword);

            if (user != null)
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login gagal! Username atau password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
