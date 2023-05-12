using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.Btnregister1 = new System.Windows.Forms.LinkLabel();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.BtnLogin1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textusername);
            this.panel2.Controls.Add(this.Btnregister1);
            this.panel2.Controls.Add(this.textpassword);
            this.panel2.Controls.Add(this.BtnLogin1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(323, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 469);
            this.panel2.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(3, 432);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(159, 24);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Забыли пароль?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(38, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 23);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Запомнить пароль?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 18.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(33, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Логин";
            // 
            // textusername
            // 
            this.textusername.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textusername.Location = new System.Drawing.Point(38, 86);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(264, 32);
            this.textusername.TabIndex = 9;
            // 
            // Btnregister1
            // 
            this.Btnregister1.AutoSize = true;
            this.Btnregister1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btnregister1.LinkColor = System.Drawing.Color.Black;
            this.Btnregister1.Location = new System.Drawing.Point(206, 432);
            this.Btnregister1.Name = "Btnregister1";
            this.Btnregister1.Size = new System.Drawing.Size(124, 24);
            this.Btnregister1.TabIndex = 7;
            this.Btnregister1.TabStop = true;
            this.Btnregister1.Text = "Регистрация";
            this.Btnregister1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Btnregister1_LinkClicked);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpassword.Location = new System.Drawing.Point(38, 213);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(264, 32);
            this.textpassword.TabIndex = 10;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // BtnLogin1
            // 
            this.BtnLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnLogin1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin1.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin1.Location = new System.Drawing.Point(38, 315);
            this.BtnLogin1.Name = "BtnLogin1";
            this.BtnLogin1.Size = new System.Drawing.Size(264, 59);
            this.BtnLogin1.TabIndex = 4;
            this.BtnLogin1.Text = "Войти";
            this.BtnLogin1.UseVisualStyleBackColor = false;
            this.BtnLogin1.Click += new System.EventHandler(this.BtnLogin1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 18.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(33, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(323, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 100);
            this.panel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(34, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 44);
            this.label8.TabIndex = 1;
            this.label8.Text = "Авторизация";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1212, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.LinkLabel Btnregister1;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button BtnLogin1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox pictureBox1;
        private EventHandler textusername_TextChanged;
        private EventHandler label8_Click;
        private EventHandler login_Load;
        private PaintEventHandler panel1_Paint;

    }
}

