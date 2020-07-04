namespace CopyCenter
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonVacancy = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(12, 199);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(296, 47);
            this.buttonMain.TabIndex = 1;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Location = new System.Drawing.Point(12, 266);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(296, 47);
            this.buttonServices.TabIndex = 2;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVacancy
            // 
            this.buttonVacancy.Location = new System.Drawing.Point(12, 335);
            this.buttonVacancy.Name = "buttonVacancy";
            this.buttonVacancy.Size = new System.Drawing.Size(296, 47);
            this.buttonVacancy.TabIndex = 3;
            this.buttonVacancy.Text = "Вакансии";
            this.buttonVacancy.UseVisualStyleBackColor = true;
            this.buttonVacancy.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCompany
            // 
            this.buttonCompany.Location = new System.Drawing.Point(12, 407);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(296, 47);
            this.buttonCompany.TabIndex = 4;
            this.buttonCompany.Text = "О компании";
            this.buttonCompany.UseVisualStyleBackColor = true;
            this.buttonCompany.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CopyCenter.Properties.Resources.Lodoo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(323, 470);
            this.Controls.Add(this.buttonCompany);
            this.Controls.Add(this.buttonVacancy);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonVacancy;
        private System.Windows.Forms.Button buttonCompany;
    }
}

