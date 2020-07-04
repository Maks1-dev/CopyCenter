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
<<<<<<< HEAD
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formservice = new FormService();
=======
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formservice = new FormMain();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
            formservice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form formfeedback = new labelFormFeedback();
            formfeedback.Show();
=======
            Form formservices = new FormService();
            formservices.Show();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form FormProject = new FormProject();
            FormProject.Show();
        }
    }
=======
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
    
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
}
