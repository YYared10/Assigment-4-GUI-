namespace Assigment_4__GUI_
{
    partial class login
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
            this.bttn_Add = new System.Windows.Forms.Button();
            this.textBox1Email = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_Add
            // 
            this.bttn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Add.Location = new System.Drawing.Point(249, 246);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(133, 23);
            this.bttn_Add.TabIndex = 0;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = false;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // textBox1Email
            // 
            this.textBox1Email.Location = new System.Drawing.Point(238, 95);
            this.textBox1Email.Name = "textBox1Email";
            this.textBox1Email.Size = new System.Drawing.Size(338, 22);
            this.textBox1Email.TabIndex = 1;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(238, 168);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(338, 22);
            this.textBoxpass.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(126, 95);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(126, 174);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(67, 16);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_cancel.Location = new System.Drawing.Point(432, 246);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(144, 23);
            this.bttn_cancel.TabIndex = 5;
            this.bttn_cancel.Text = "Cancel";
            this.bttn_cancel.UseVisualStyleBackColor = false;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBox1Email);
            this.Controls.Add(this.bttn_Add);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.TextBox textBox1Email;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button bttn_cancel;
    }
}