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
            foreach (TableSupply supplySet in Program.wftDb.TableSupply)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        supplySet.id.ToString(), supplySet.Наименование_товара, supplySet.Отзыв
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
            TableSupply supplySet = new TableSupply();
            
            supplySet.Наименование_товара = textBoxProduct.Text;
            supplySet.Отзыв = textBoxFeedback.Text;            
            Program.wftDb.TableSupply.Add(supplySet);
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (listViewFeedback.SelectedItems.Count == 1)
            {
                TableSupply TableSupply = listViewFeedback.SelectedItems[0].Tag as TableSupply;
                Program.wftDb.TableSupply.Remove(TableSupply);
                Program.wftDb.SaveChanges();
                ShowClient();
            }
            textBoxProduct.Text = "";
            textBoxFeedback.Text = "";
        }
    }
}
