namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Avt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.AcceptA = new System.Windows.Forms.Button();
            this.AccNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Avt
            // 
            this.Avt.AutoSize = true;
            this.Avt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Avt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Avt.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avt.ForeColor = System.Drawing.SystemColors.Control;
            this.Avt.Location = new System.Drawing.Point(216, 106);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(329, 67);
            this.Avt.TabIndex = 1;
            this.Avt.Text = "Авторизация";
            this.Avt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._403019_avatar_male_man_person_user_icon;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources._403019_avatar_male_man_person_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(129, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._299105_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(129, 299);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(212, 211);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(333, 59);
            this.Login.TabIndex = 4;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(212, 299);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(333, 58);
            this.Password.TabIndex = 5;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // AcceptA
            // 
            this.AcceptA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.AcceptA.FlatAppearance.BorderSize = 0;
            this.AcceptA.Image = global::WindowsFormsApp1.Properties.Resources._3545094_approved_aproved_business_confirm_outline_icon__1_;
            this.AcceptA.Location = new System.Drawing.Point(551, 299);
            this.AcceptA.Name = "AcceptA";
            this.AcceptA.Size = new System.Drawing.Size(61, 58);
            this.AcceptA.TabIndex = 6;
            this.AcceptA.UseVisualStyleBackColor = false;
            this.AcceptA.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.AccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccNo.Location = new System.Drawing.Point(302, 370);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(154, 20);
            this.AccNo.TabIndex = 7;
            this.AccNo.Text = "Еще нет аккаунта?";
            this.AccNo.Click += new System.EventHandler(this.AccNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.d793a463771880bd2ddd27409d6bb8c8;
            this.ClientSize = new System.Drawing.Size(728, 686);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.AcceptA);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Avt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Avt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button AcceptA;
        private System.Windows.Forms.Label AccNo;
    }
}

