namespace CopyCenter
{
<<<<<<< HEAD
    partial class FormMenu
=======
    partial class Menu
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
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
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
=======
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonVacancy = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбор услуги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Оставить отзыв";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "О проекте";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CopyCenter.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(221, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMenu";
            this.Text = "Копицентр";
=======
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
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
=======
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonVacancy;
        private System.Windows.Forms.Button buttonCompany;
>>>>>>> ff3a75d6a09a3da444939f0e92883cf1f8fa5609
    }
}

