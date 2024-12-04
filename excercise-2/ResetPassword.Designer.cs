namespace excercise_2
{
    partial class ResetPassword
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
            this.Comfirm_btn = new System.Windows.Forms.Button();
            this.Comfirm_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Noti_Lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Comfirm_btn
            // 
            this.Comfirm_btn.BackColor = System.Drawing.Color.White;
            this.Comfirm_btn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_btn.Location = new System.Drawing.Point(365, 429);
            this.Comfirm_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comfirm_btn.Name = "Comfirm_btn";
            this.Comfirm_btn.Size = new System.Drawing.Size(215, 48);
            this.Comfirm_btn.TabIndex = 33;
            this.Comfirm_btn.Text = "Thay Đổi";
            this.Comfirm_btn.UseVisualStyleBackColor = false;
            this.Comfirm_btn.Click += new System.EventHandler(this.Comfirm_btn_Click);
            // 
            // Comfirm_txt
            // 
            this.Comfirm_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comfirm_txt.Location = new System.Drawing.Point(201, 354);
            this.Comfirm_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comfirm_txt.Name = "Comfirm_txt";
            this.Comfirm_txt.Size = new System.Drawing.Size(539, 34);
            this.Comfirm_txt.TabIndex = 32;
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(201, 210);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(539, 34);
            this.Password_txt.TabIndex = 29;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // Noti_Lb
            // 
            this.Noti_Lb.AutoSize = true;
            this.Noti_Lb.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti_Lb.Location = new System.Drawing.Point(329, 72);
            this.Noti_Lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Noti_Lb.Name = "Noti_Lb";
            this.Noti_Lb.Size = new System.Drawing.Size(301, 39);
            this.Noti_Lb.TabIndex = 28;
            this.Noti_Lb.Text = "Nhập Mật Khẩu Mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 39);
            this.label2.TabIndex = 35;
            this.label2.Text = "Xác Nhận";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comfirm_btn);
            this.Controls.Add(this.Comfirm_txt);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Noti_Lb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPassword";
            this.Text = "Quên mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comfirm_btn;
        private System.Windows.Forms.TextBox Comfirm_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Noti_Lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}