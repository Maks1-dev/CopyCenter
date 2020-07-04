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
    public partial class labelFormFeedback : Form
    {
        void ShowClient()
        {
            listViewFeedback.Items.Clear();
            foreach (Отзыв supplySet in Program.wftDb.Отзыв)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        supplySet.id.ToString(), supplySet.Наименование_услуги, supplySet.Отзыв1
                });
                item.Tag = supplySet;
                listViewFeedback.Items.Add(item);
            }
            listViewFeedback.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public labelFormFeedback()
        {
            InitializeComponent();
            ShowClient();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Отзыв supplySet = new Отзыв();

            supplySet.Наименование_услуги = textBoxProduct.Text;
            supplySet.Отзыв1 = textBoxFeedback.Text;
            Program.wftDb.Отзыв.Add(supplySet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewFeedback.SelectedItems.Count == 1)
            {
                Отзыв Отзыв = listViewFeedback.SelectedItems[0].Tag as Отзыв;
                Program.wftDb.Отзыв.Remove(Отзыв);
                Program.wftDb.SaveChanges();
                ShowClient();
            }
            textBoxProduct.Text = "";
            textBoxFeedback.Text = "";
        }
    }
}
