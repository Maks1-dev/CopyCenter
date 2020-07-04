using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyCenter
{
    public struct Uzer
    {
        public string login;
        public string password;
    }
    public partial class FormAuthorization : Form
    {
        public static Uzer users = new Uzer();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Form menu = new Menu();
                menu.Show();
            }
            else if (textBoxLogin.Text == "user" && textBoxPassword.Text == "users")
            {
                Form menu = new Menu();
                menu.Show();
            }
            else
            {
                this.Hide();
                Form formAuthorization = new FormAuthorization();
                formAuthorization.Show();
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
