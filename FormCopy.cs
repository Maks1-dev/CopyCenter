﻿using System;
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
    public partial class FormCopy : Form
    {
        public FormCopy()
        {
            InitializeComponent();           
        }
        
        private void FormCopy_Load(object sender, EventArgs e)
        {
           
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
