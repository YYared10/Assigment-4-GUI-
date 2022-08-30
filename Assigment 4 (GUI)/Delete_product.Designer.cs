namespace Assigment_4__GUI_
{
    partial class Delete_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Invnum = new System.Windows.Forms.Label();
            this.lb_Count = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.Bttn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(75, 41);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 16);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Name";
            // 
            // lb_Invnum
            // 
            this.lb_Invnum.AutoSize = true;
            this.lb_Invnum.Location = new System.Drawing.Point(75, 73);
            this.lb_Invnum.Name = "lb_Invnum";
            this.lb_Invnum.Size = new System.Drawing.Size(112, 16);
            this.lb_Invnum.TabIndex = 1;
            this.lb_Invnum.Text = "Inventory Number";
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(75, 108);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(41, 16);
            this.lb_Count.TabIndex = 2;
            this.lb_Count.Text = "Count";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(75, 142);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(38, 16);
            this.lb_price.TabIndex = 3;
            this.lb_price.Text = "Price";
            // 
            // Bttn_Delete
            // 
            this.Bttn_Delete.Location = new System.Drawing.Point(203, 164);
            this.Bttn_Delete.Name = "Bttn_Delete";
            this.Bttn_Delete.Size = new System.Drawing.Size(102, 37);
            this.Bttn_Delete.TabIndex = 4;
            this.Bttn_Delete.Text = "Delete";
            this.Bttn_Delete.UseVisualStyleBackColor = true;
            // 
            // Delete_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Bttn_Delete);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.lb_Invnum);
            this.Controls.Add(this.lb_Name);
            this.Name = "Delete_product";
            this.Size = new System.Drawing.Size(339, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Invnum;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Button Bttn_Delete;
    }
}
