namespace Assigment_4__GUI_
{
    partial class Search
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
            this.Searchbttn1 = new System.Windows.Forms.Button();
            this.SearchdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchlbl1 = new System.Windows.Forms.Label();
            this.OBJNAMEtextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbttn1
            // 
            this.Searchbttn1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Searchbttn1.Location = new System.Drawing.Point(583, 43);
            this.Searchbttn1.Name = "Searchbttn1";
            this.Searchbttn1.Size = new System.Drawing.Size(118, 29);
            this.Searchbttn1.TabIndex = 0;
            this.Searchbttn1.Text = "Search";
            this.Searchbttn1.UseVisualStyleBackColor = false;
            this.Searchbttn1.Click += new System.EventHandler(this.Searchbttn1_Click);
            // 
            // SearchdataGridView1
            // 
            this.SearchdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchdataGridView1.Location = new System.Drawing.Point(121, 117);
            this.SearchdataGridView1.Name = "SearchdataGridView1";
            this.SearchdataGridView1.RowHeadersWidth = 51;
            this.SearchdataGridView1.RowTemplate.Height = 24;
            this.SearchdataGridView1.Size = new System.Drawing.Size(546, 249);
            this.SearchdataGridView1.TabIndex = 1;
            // 
            // Searchlbl1
            // 
            this.Searchlbl1.AutoSize = true;
            this.Searchlbl1.Location = new System.Drawing.Point(49, 49);
            this.Searchlbl1.Name = "Searchlbl1";
            this.Searchlbl1.Size = new System.Drawing.Size(89, 16);
            this.Searchlbl1.TabIndex = 2;
            this.Searchlbl1.Text = "Object Name ";
            // 
            // OBJNAMEtextBox1
            // 
            this.OBJNAMEtextBox1.Location = new System.Drawing.Point(187, 43);
            this.OBJNAMEtextBox1.Multiline = true;
            this.OBJNAMEtextBox1.Name = "OBJNAMEtextBox1";
            this.OBJNAMEtextBox1.Size = new System.Drawing.Size(372, 29);
            this.OBJNAMEtextBox1.TabIndex = 3;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OBJNAMEtextBox1);
            this.Controls.Add(this.Searchlbl1);
            this.Controls.Add(this.SearchdataGridView1);
            this.Controls.Add(this.Searchbttn1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbttn1;
        private System.Windows.Forms.DataGridView SearchdataGridView1;
        private System.Windows.Forms.Label Searchlbl1;
        private System.Windows.Forms.TextBox OBJNAMEtextBox1;
    }
}