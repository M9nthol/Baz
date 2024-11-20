namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Reg = new System.Windows.Forms.Label();
            this.RegFio = new System.Windows.Forms.TextBox();
            this.RegNumber = new System.Windows.Forms.TextBox();
            this.RegPas1 = new System.Windows.Forms.TextBox();
            this.picfioreg = new System.Windows.Forms.PictureBox();
            this.picpas1 = new System.Windows.Forms.PictureBox();
            this.picnumreg = new System.Windows.Forms.PictureBox();
            this.ButtonReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfioreg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnumreg)).BeginInit();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.AutoSize = true;
            this.Reg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Reg.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg.ForeColor = System.Drawing.SystemColors.Control;
            this.Reg.Location = new System.Drawing.Point(184, 146);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(322, 67);
            this.Reg.TabIndex = 2;
            this.Reg.Text = "Регистрация";
            this.Reg.Click += new System.EventHandler(this.Avt_Click);
            // 
            // RegFio
            // 
            this.RegFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegFio.Location = new System.Drawing.Point(251, 242);
            this.RegFio.Multiline = true;
            this.RegFio.Name = "RegFio";
            this.RegFio.Size = new System.Drawing.Size(239, 36);
            this.RegFio.TabIndex = 5;
            this.RegFio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegNumber
            // 
            this.RegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegNumber.Location = new System.Drawing.Point(251, 296);
            this.RegNumber.Multiline = true;
            this.RegNumber.Name = "RegNumber";
            this.RegNumber.Size = new System.Drawing.Size(239, 36);
            this.RegNumber.TabIndex = 6;
            this.RegNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegPas1
            // 
            this.RegPas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPas1.Location = new System.Drawing.Point(251, 349);
            this.RegPas1.Multiline = true;
            this.RegPas1.Name = "RegPas1";
            this.RegPas1.Size = new System.Drawing.Size(239, 36);
            this.RegPas1.TabIndex = 7;
            this.RegPas1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picfioreg
            // 
            this.picfioreg.Image = global::WindowsFormsApp1.Properties.Resources._403019_avatar_male_man_person_user_icon;
            this.picfioreg.InitialImage = global::WindowsFormsApp1.Properties.Resources._403019_avatar_male_man_person_user_icon;
            this.picfioreg.Location = new System.Drawing.Point(196, 242);
            this.picfioreg.Name = "picfioreg";
            this.picfioreg.Size = new System.Drawing.Size(37, 36);
            this.picfioreg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfioreg.TabIndex = 9;
            this.picfioreg.TabStop = false;
            // 
            // picpas1
            // 
            this.picpas1.Image = global::WindowsFormsApp1.Properties.Resources._299105_lock_icon;
            this.picpas1.Location = new System.Drawing.Point(196, 349);
            this.picpas1.Name = "picpas1";
            this.picpas1.Size = new System.Drawing.Size(37, 36);
            this.picpas1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpas1.TabIndex = 10;
            this.picpas1.TabStop = false;
            // 
            // picnumreg
            // 
            this.picnumreg.Image = global::WindowsFormsApp1.Properties.Resources._176640_phone_metroui_icon1;
            this.picnumreg.InitialImage = global::WindowsFormsApp1.Properties.Resources._176640_phone_metroui_icon;
            this.picnumreg.Location = new System.Drawing.Point(196, 296);
            this.picnumreg.Name = "picnumreg";
            this.picnumreg.Size = new System.Drawing.Size(37, 36);
            this.picnumreg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnumreg.TabIndex = 12;
            this.picnumreg.TabStop = false;
            this.picnumreg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ButtonReg
            // 
            this.ButtonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ButtonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReg.Location = new System.Drawing.Point(251, 416);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(214, 51);
            this.ButtonReg.TabIndex = 13;
            this.ButtonReg.Text = "Зарегистрироваться";
            this.ButtonReg.UseVisualStyleBackColor = false;
            this.ButtonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.d793a463771880bd2ddd27409d6bb8c8;
            this.ClientSize = new System.Drawing.Size(666, 676);
            this.Controls.Add(this.ButtonReg);
            this.Controls.Add(this.picnumreg);
            this.Controls.Add(this.picpas1);
            this.Controls.Add(this.picfioreg);
            this.Controls.Add(this.RegPas1);
            this.Controls.Add(this.RegNumber);
            this.Controls.Add(this.RegFio);
            this.Controls.Add(this.Reg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfioreg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnumreg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg;
        private System.Windows.Forms.TextBox RegFio;
        private System.Windows.Forms.TextBox RegNumber;
        private System.Windows.Forms.TextBox RegPas1;
        private System.Windows.Forms.PictureBox picfioreg;
        private System.Windows.Forms.PictureBox picpas1;
        private System.Windows.Forms.PictureBox picnumreg;
        private System.Windows.Forms.Button ButtonReg;
    }
}