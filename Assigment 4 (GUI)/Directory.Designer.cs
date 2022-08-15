namespace Assigment_4__GUI_
{
    partial class Directory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Indicator_panl = new System.Windows.Forms.Panel();
            this.Exit_bttn = new System.Windows.Forms.Button();
            this.Delete_bttn = new System.Windows.Forms.Button();
            this.Update_bttn = new System.Windows.Forms.Button();
            this.Add_bttn = new System.Windows.Forms.Button();
            this.PNL_m = new System.Windows.Forms.Panel();
            this.flwLytPnl_productlist = new System.Windows.Forms.FlowLayoutPanel();
            this.bttn_productlist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PNL_m.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.bttn_productlist);
            this.panel1.Controls.Add(this.Indicator_panl);
            this.panel1.Controls.Add(this.Exit_bttn);
            this.panel1.Controls.Add(this.Delete_bttn);
            this.panel1.Controls.Add(this.Update_bttn);
            this.panel1.Controls.Add(this.Add_bttn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 450);
            this.panel1.TabIndex = 0;
            // 
            // Indicator_panl
            // 
            this.Indicator_panl.BackColor = System.Drawing.Color.Black;
            this.Indicator_panl.Location = new System.Drawing.Point(3, 52);
            this.Indicator_panl.Name = "Indicator_panl";
            this.Indicator_panl.Size = new System.Drawing.Size(14, 39);
            this.Indicator_panl.TabIndex = 4;
            // 
            // Exit_bttn
            // 
            this.Exit_bttn.Location = new System.Drawing.Point(89, 221);
            this.Exit_bttn.Name = "Exit_bttn";
            this.Exit_bttn.Size = new System.Drawing.Size(104, 44);
            this.Exit_bttn.TabIndex = 3;
            this.Exit_bttn.Text = "Exit";
            this.Exit_bttn.UseVisualStyleBackColor = true;
            this.Exit_bttn.Click += new System.EventHandler(this.Exit_bttn_Click);
            // 
            // Delete_bttn
            // 
            this.Delete_bttn.Location = new System.Drawing.Point(62, 164);
            this.Delete_bttn.Name = "Delete_bttn";
            this.Delete_bttn.Size = new System.Drawing.Size(163, 51);
            this.Delete_bttn.TabIndex = 2;
            this.Delete_bttn.Text = "Delete";
            this.Delete_bttn.UseVisualStyleBackColor = true;
            this.Delete_bttn.Click += new System.EventHandler(this.Delete_bttn_Click);
            // 
            // Update_bttn
            // 
            this.Update_bttn.Location = new System.Drawing.Point(43, 106);
            this.Update_bttn.Name = "Update_bttn";
            this.Update_bttn.Size = new System.Drawing.Size(201, 52);
            this.Update_bttn.TabIndex = 1;
            this.Update_bttn.Text = "Update";
            this.Update_bttn.UseVisualStyleBackColor = true;
            this.Update_bttn.Click += new System.EventHandler(this.Update_bttn_Click);
            // 
            // Add_bttn
            // 
            this.Add_bttn.Location = new System.Drawing.Point(20, 52);
            this.Add_bttn.Name = "Add_bttn";
            this.Add_bttn.Size = new System.Drawing.Size(244, 48);
            this.Add_bttn.TabIndex = 0;
            this.Add_bttn.Text = "Add product";
            this.Add_bttn.UseVisualStyleBackColor = true;
            this.Add_bttn.Click += new System.EventHandler(this.Add_bttn_Click);
            // 
            // PNL_m
            // 
            this.PNL_m.BackColor = System.Drawing.Color.Silver;
            this.PNL_m.Controls.Add(this.flwLytPnl_productlist);
            this.PNL_m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_m.Location = new System.Drawing.Point(270, 0);
            this.PNL_m.Name = "PNL_m";
            this.PNL_m.Size = new System.Drawing.Size(805, 450);
            this.PNL_m.TabIndex = 1;
            // 
            // flwLytPnl_productlist
            // 
            this.flwLytPnl_productlist.AutoScroll = true;
            this.flwLytPnl_productlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwLytPnl_productlist.Location = new System.Drawing.Point(0, 0);
            this.flwLytPnl_productlist.Name = "flwLytPnl_productlist";
            this.flwLytPnl_productlist.Size = new System.Drawing.Size(805, 450);
            this.flwLytPnl_productlist.TabIndex = 1;
            this.flwLytPnl_productlist.Paint += new System.Windows.Forms.PaintEventHandler(this.flwLytPnl_productlist_Paint);
            // 
            // bttn_productlist
            // 
            this.bttn_productlist.Location = new System.Drawing.Point(109, 271);
            this.bttn_productlist.Name = "bttn_productlist";
            this.bttn_productlist.Size = new System.Drawing.Size(71, 44);
            this.bttn_productlist.TabIndex = 5;
            this.bttn_productlist.Text = "Product List";
            this.bttn_productlist.UseVisualStyleBackColor = true;
            this.bttn_productlist.Click += new System.EventHandler(this.bttn_productlist_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.PNL_m);
            this.Controls.Add(this.panel1);
            this.Name = "Directory";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.panel1.ResumeLayout(false);
            this.PNL_m.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Indicator_panl;
        private System.Windows.Forms.Button Exit_bttn;
        private System.Windows.Forms.Button Delete_bttn;
        private System.Windows.Forms.Button Update_bttn;
        private System.Windows.Forms.Button Add_bttn;
        private System.Windows.Forms.Panel PNL_m;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnl_productlist;
        private System.Windows.Forms.Button bttn_productlist;
    }
}