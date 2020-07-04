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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Yes)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.pictureBox1.Size = this.pictureBox1.Image.Size;
            }
=======

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Отзыв_Click(object sender, EventArgs e)
        {
            Form labelFormFeedback = new labelFormFeedback();
            labelFormFeedback.Show();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
        }
    }
}
