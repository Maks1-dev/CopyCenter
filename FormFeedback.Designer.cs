namespace CopyCenter
{
    partial class labelFormFeedback
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
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.listViewFeedback = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFixation = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(12, 39);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(100, 20);
            this.textBoxProduct.TabIndex = 0;
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(12, 97);
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(100, 20);
            this.textBoxFeedback.TabIndex = 3;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(9, 23);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(121, 13);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Наименование товара";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(9, 81);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(40, 13);
            this.labelFeedback.TabIndex = 7;
            this.labelFeedback.Text = "Отзыв";
            // 
            // listViewFeedback
            // 
            this.listViewFeedback.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader10});
            this.listViewFeedback.FullRowSelect = true;
            this.listViewFeedback.GridLines = true;
            this.listViewFeedback.HideSelection = false;
            this.listViewFeedback.Location = new System.Drawing.Point(164, 23);
            this.listViewFeedback.MultiSelect = false;
            this.listViewFeedback.Name = "listViewFeedback";
            this.listViewFeedback.Size = new System.Drawing.Size(445, 219);
            this.listViewFeedback.TabIndex = 8;
            this.listViewFeedback.UseCompatibleStateImageBehavior = false;
            this.listViewFeedback.View = System.Windows.Forms.View.Details;
            this.listViewFeedback.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование товара";
            this.columnHeader3.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Отзыв";
            this.columnHeader10.Width = 168;
            // 
            // buttonFixation
            // 
            this.buttonFixation.Location = new System.Drawing.Point(468, 261);
            this.buttonFixation.Name = "buttonFixation";
            this.buttonFixation.Size = new System.Drawing.Size(141, 23);
            this.buttonFixation.TabIndex = 9;
            this.buttonFixation.Text = "Зафиксировать отзыв";
            this.buttonFixation.UseVisualStyleBackColor = true;
            this.buttonFixation.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(321, 261);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(141, 23);
<<<<<<< HEAD
            this.buttonSend.TabIndex = 19;
            this.buttonSend.Text = "Отправить отзыв";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
=======
            this.buttonSend.TabIndex = 18;
            this.buttonSend.Text = "Отправить отзыв";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonDel_Click);
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
            // 
            // labelFormFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 296);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonFixation);
            this.Controls.Add(this.listViewFeedback);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.textBoxProduct);
            this.Name = "labelFormFeedback";
            this.Text = "FormFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.ListView listViewFeedback;
        private System.Windows.Forms.Button buttonFixation;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonSend;
    }
}