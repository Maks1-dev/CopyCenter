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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formservice = new FormMain();
            formservice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formservices = new FormService();
            formservices.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formjobopenings = new FormJobopenings();
            formjobopenings.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formprint = new FormPrint();
            formprint.Show();
        }

        public static implicit operator System.Windows.Forms.Menu(Menu v)
        {
            throw new NotImplementedException();
        }
    }
    
}
