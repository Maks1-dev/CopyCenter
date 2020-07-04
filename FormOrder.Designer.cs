namespace CopyCenter
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewFeedback = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProduct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewFeedback
            // 
            this.listViewFeedback.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFeedback.FullRowSelect = true;
            this.listViewFeedback.GridLines = true;
            this.listViewFeedback.HideSelection = false;
            this.listViewFeedback.Location = new System.Drawing.Point(224, 12);
            this.listViewFeedback.MultiSelect = false;
            this.listViewFeedback.Name = "listViewFeedback";
            this.listViewFeedback.Size = new System.Drawing.Size(445, 219);
            this.listViewFeedback.TabIndex = 9;
            this.listViewFeedback.UseCompatibleStateImageBehavior = false;
            this.listViewFeedback.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование услуги";
            this.columnHeader3.Width = 139;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(12, 40);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(119, 13);
            this.labelProduct.TabIndex = 10;
            this.labelProduct.Text = "Наименование услуги";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Заказ услуги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "Разработка.NET приложений",
            "Аутсорсинг и футстаффинг",
            "Команда на проект",
            "Разработка сайтов",
            "Хостинг",
            "Разработка хранилищ данных ",
            "Регистрация доменов",
            "Сервис тестирования",
            "Администратирование баз данных",
            "UMS",
            "Разработка мобильных приложений",
            "Обучение",
            "Разработка SharePoint приложений"});
            this.comboBoxService.Location = new System.Drawing.Point(15, 56);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(176, 21);
            this.comboBoxService.TabIndex = 16;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(345, 248);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(159, 35);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Отменить заказ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.listViewFeedback);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFeedback;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonDel;
    }
}