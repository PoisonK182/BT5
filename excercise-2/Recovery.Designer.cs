namespace excercise_2
{
    partial class Recovery
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
            this.Noti_Lb = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Noti2_lb = new System.Windows.Forms.Label();
            this.Comfirm_btn = new System.Windows.Forms.Button();
            this.Comfirm_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Noti_Lb
            // 
            this.Noti_Lb.AutoSize = true;
            this.Noti_Lb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti_Lb.Location = new System.Drawing.Point(1, 143);
            this.Noti_Lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Noti_Lb.Name = "Noti_Lb";
            this.Noti_Lb.Size = new System.Drawing.Size(479, 39);
            this.Noti_Lb.TabIndex = 1;
            this.Noti_Lb.Text = "Nhập Email khi đăng ký tài khoản";
            this.Noti_Lb.Click += new System.EventHandler(this.Noti_Lb_Click);
            // 
            // Email_txt
            // 
            this.Email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_txt.Location = new System.Drawing.Point(517, 143);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(451, 34);
            this.Email_txt.TabIndex = 4;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // Send_btn
            // 
            this.Send_btn.BackColor = System.Drawing.Color.White;
            this.Send_btn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_btn.Location = new System.Drawing.Point(202, 400);
            this.Send_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(278, 48);
            this.Send_btn.TabIndex = 24;
            this.Send_btn.Text = "Gửi mã xác nhận";
            this.Send_btn.UseVisualStyleBackColor = false;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Noti2_lb
            // 
            this.Noti2_lb.AutoSize = true;
            this.Noti2_lb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti2_lb.Location = new System.Drawing.Point(43, 305);
            this.Noti2_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Noti2_lb.Name = "Noti2_lb";
            this.Noti2_lb.Size = new System.Drawing.Size(297, 39);
            this.Noti2_lb.TabIndex = 25;
            this.Noti2_lb.Text = "Nhập  Mã Xác Nhận";
            // 
            // Comfirm_btn
            // 
            this.Comfirm_btn.BackColor = System.Drawing.Color.White;
            this.Comfirm_btn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_btn.Location = new System.Drawing.Point(548, 400);
            this.Comfirm_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Comfirm_btn.Name = "Comfirm_btn";
            this.Comfirm_btn.Size = new System.Drawing.Size(215, 48);
            this.Comfirm_btn.TabIndex = 27;
            this.Comfirm_btn.Text = "Xác Nhận";
            this.Comfirm_btn.UseVisualStyleBackColor = false;
            this.Comfirm_btn.Click += new System.EventHandler(this.Comfirm_btn_Click);
            // 
            // Comfirm_txt
            // 
            this.Comfirm_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_txt.Location = new System.Drawing.Point(366, 305);
            this.Comfirm_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Comfirm_txt.Name = "Comfirm_txt";
            this.Comfirm_txt.Size = new System.Drawing.Size(539, 34);
            this.Comfirm_txt.TabIndex = 26;
            this.Comfirm_txt.TextChanged += new System.EventHandler(this.Comfirm_txt_TextChanged);
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Comfirm_btn);
            this.Controls.Add(this.Comfirm_txt);
            this.Controls.Add(this.Noti2_lb);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Noti_Lb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Recovery";
            this.Text = "Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Noti_Lb;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Button Send_btn;
        private System.Windows.Forms.Label Noti2_lb;
        private System.Windows.Forms.Button Comfirm_btn;
        private System.Windows.Forms.TextBox Comfirm_txt;
    }
}