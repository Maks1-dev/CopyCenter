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
    public partial class FormOrder : Form
    {
        void ShowClient()
        {
            listViewFeedback.Items.Clear();
            foreach (Заказ_услуги Заказ_услуги in Program.wftDb.Заказ_услуги)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        Заказ_услуги.id.ToString(), Заказ_услуги.Наименование_услуги
                });
                item.Tag = Заказ_услуги;
                listViewFeedback.Items.Add(item);
            }
            listViewFeedback.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormOrder()
        {
            InitializeComponent();
            ShowClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказ_услуги Заказ_услуги = new Заказ_услуги();

            Заказ_услуги.Наименование_услуги = comboBoxService.Text;
            Program.wftDb.Заказ_услуги.Add(Заказ_услуги);
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewFeedback.SelectedItems.Count == 1)
            {
                Заказ_услуги Заказ_услуги = listViewFeedback.SelectedItems[0].Tag as Заказ_услуги;
                Program.wftDb.Заказ_услуги.Remove(Заказ_услуги);
                Program.wftDb.SaveChanges();
                ShowClient();
            }
            comboBoxService.Text = "";
        }
    }
}
