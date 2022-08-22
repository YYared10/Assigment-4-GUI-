namespace Assigment_4__GUI_
{
    partial class Poduct_Card
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
            this.Description_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.NM_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Description_lbl.Location = new System.Drawing.Point(85, 124);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(95, 20);
            this.Description_lbl.TabIndex = 5;
            this.Description_lbl.Text = "Description";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Price_lbl.Location = new System.Drawing.Point(85, 177);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(48, 20);
            this.Price_lbl.TabIndex = 4;
            this.Price_lbl.Text = "Price";
            // 
            // NM_label1
            // 
            this.NM_label1.AutoSize = true;
            this.NM_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.NM_label1.Location = new System.Drawing.Point(84, 66);
            this.NM_label1.Name = "NM_label1";
            this.NM_label1.Size = new System.Drawing.Size(64, 25);
            this.NM_label1.TabIndex = 3;
            this.NM_label1.Text = "Name";
            // 
            // Poduct_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.NM_label1);
            this.Name = "Poduct_Card";
            this.Size = new System.Drawing.Size(437, 274);
            this.DoubleClick += new System.EventHandler(this.Poduct_Card_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label NM_label1;
    }
}
