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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form formcopy = new FormCopy();
            formcopy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formlamination = new FormLamination();
            formlamination.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formprint = new FormPrint();
            formprint.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
=======
            Form FormOrder = new FormOrder();
            FormOrder.Show();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
        }
    }
}
