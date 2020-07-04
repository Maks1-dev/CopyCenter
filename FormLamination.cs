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
    public partial class FormLamination : Form
    {
        public FormLamination()
        {
            InitializeComponent();            
        }

        private void FormLamination_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Yes)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.pictureBox1.Size = this.pictureBox1.Image.Size;
            }
        }
    }
}
