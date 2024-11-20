namespace WindowsFormsApp1
{
    partial class Form3
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
            this.Avt = new System.Windows.Forms.Label();
            this.MainAvt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Avt
            // 
            this.Avt.AutoSize = true;
            this.Avt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Avt.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avt.ForeColor = System.Drawing.SystemColors.Control;
            this.Avt.Location = new System.Drawing.Point(178, 164);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(419, 35);
            this.Avt.TabIndex = 2;
            this.Avt.Text = "Аккаунт успешно зарегистрирован";
            this.Avt.Click += new System.EventHandler(this.Avt_Click);
            // 
            // MainAvt
            // 
            this.MainAvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.MainAvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainAvt.Location = new System.Drawing.Point(275, 276);
            this.MainAvt.Name = "MainAvt";
            this.MainAvt.Size = new System.Drawing.Size(214, 51);
            this.MainAvt.TabIndex = 15;
            this.MainAvt.Text = "Авторизоваться";
            this.MainAvt.UseVisualStyleBackColor = false;
            this.MainAvt.Click += new System.EventHandler(this.MainAvt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.d793a463771880bd2ddd27409d6bb8c8;
            this.ClientSize = new System.Drawing.Size(735, 680);
            this.Controls.Add(this.MainAvt);
            this.Controls.Add(this.Avt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Avt;
        private System.Windows.Forms.Button MainAvt;
    }
}