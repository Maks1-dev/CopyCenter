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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formservice = new FormService();
            formservice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formfeedback = new labelFormFeedback();
            formfeedback.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FormProject = new FormProject();
            FormProject.Show();
        }
    }
}
