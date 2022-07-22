namespace Assigment_4__GUI_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Inventory_number = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Object_Name = new System.Windows.Forms.Label();
            this.txtDATE = new System.Windows.Forms.TextBox();
            this.txtINVENTORYNUM = new System.Windows.Forms.TextBox();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.txtCOUNT = new System.Windows.Forms.TextBox();
            this.txtPRICE = new System.Windows.Forms.TextBox();
            this.txtOBJNM = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Allprod = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Allprod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(845, 288);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(136, 39);
            this.bttn_Add.TabIndex = 0;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.Location = new System.Drawing.Point(1023, 288);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(126, 39);
            this.bttn_Cancel.TabIndex = 1;
            this.bttn_Cancel.Text = "Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(446, 150);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(41, 16);
            this.lbl_Count.TabIndex = 2;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(71, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(387, 50);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(39, 16);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date ";
            // 
            // lbl_Inventory_number
            // 
            this.lbl_Inventory_number.AutoSize = true;
            this.lbl_Inventory_number.Location = new System.Drawing.Point(726, 50);
            this.lbl_Inventory_number.Name = "lbl_Inventory_number";
            this.lbl_Inventory_number.Size = new System.Drawing.Size(112, 16);
            this.lbl_Inventory_number.TabIndex = 5;
            this.lbl_Inventory_number.Text = "Inventory Number";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(814, 150);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(41, 16);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "Price ";
            this.lbl_Price.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_Object_Name
            // 
            this.lbl_Object_Name.AutoSize = true;
            this.lbl_Object_Name.Location = new System.Drawing.Point(71, 150);
            this.lbl_Object_Name.Name = "lbl_Object_Name";
            this.lbl_Object_Name.Size = new System.Drawing.Size(89, 16);
            this.lbl_Object_Name.TabIndex = 7;
            this.lbl_Object_Name.Text = "Object Name ";
            // 
            // txtDATE
            // 
            this.txtDATE.Location = new System.Drawing.Point(390, 86);
            this.txtDATE.Name = "txtDATE";
            this.txtDATE.Size = new System.Drawing.Size(278, 22);
            this.txtDATE.TabIndex = 8;
            // 
            // txtINVENTORYNUM
            // 
            this.txtINVENTORYNUM.Location = new System.Drawing.Point(729, 86);
            this.txtINVENTORYNUM.Name = "txtINVENTORYNUM";
            this.txtINVENTORYNUM.Size = new System.Drawing.Size(320, 22);
            this.txtINVENTORYNUM.TabIndex = 9;
            this.txtINVENTORYNUM.TextChanged += new System.EventHandler(this.txtINVENTORYNUM_TextChanged);
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(74, 86);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(244, 22);
            this.txtNUM.TabIndex = 10;
            this.txtNUM.TextChanged += new System.EventHandler(this.txtNUM_TextChanged);
            // 
            // txtCOUNT
            // 
            this.txtCOUNT.Location = new System.Drawing.Point(437, 196);
            this.txtCOUNT.Name = "txtCOUNT";
            this.txtCOUNT.Size = new System.Drawing.Size(278, 22);
            this.txtCOUNT.TabIndex = 11;
            this.txtCOUNT.TextChanged += new System.EventHandler(this.txtCOUNT_TextChanged);
            // 
            // txtPRICE
            // 
            this.txtPRICE.Location = new System.Drawing.Point(801, 196);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(320, 22);
            this.txtPRICE.TabIndex = 12;
            this.txtPRICE.TextChanged += new System.EventHandler(this.txtPRICE_TextChanged);
            // 
            // txtOBJNM
            // 
            this.txtOBJNM.Location = new System.Drawing.Point(74, 196);
            this.txtOBJNM.Name = "txtOBJNM";
            this.txtOBJNM.Size = new System.Drawing.Size(327, 22);
            this.txtOBJNM.TabIndex = 13;
            this.txtOBJNM.TextChanged += new System.EventHandler(this.txtOBJNM_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Allprod
            // 
            this.Allprod.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Allprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allprod.GridColor = System.Drawing.SystemColors.Control;
            this.Allprod.Location = new System.Drawing.Point(74, 257);
            this.Allprod.Name = "Allprod";
            this.Allprod.RowHeadersWidth = 51;
            this.Allprod.RowTemplate.Height = 24;
            this.Allprod.Size = new System.Drawing.Size(742, 199);
            this.Allprod.TabIndex = 15;
            this.Allprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allprod_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1343, 530);
            this.Controls.Add(this.Allprod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtOBJNM);
            this.Controls.Add(this.txtPRICE);
            this.Controls.Add(this.txtCOUNT);
            this.Controls.Add(this.txtNUM);
            this.Controls.Add(this.txtINVENTORYNUM);
            this.Controls.Add(this.txtDATE);
            this.Controls.Add(this.lbl_Object_Name);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Inventory_number);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.bttn_Cancel);
            this.Controls.Add(this.bttn_Add);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Allprod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Inventory_number;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Object_Name;
        private System.Windows.Forms.TextBox txtDATE;
        private System.Windows.Forms.TextBox txtINVENTORYNUM;
        private System.Windows.Forms.TextBox txtNUM;
        private System.Windows.Forms.TextBox txtCOUNT;
        private System.Windows.Forms.TextBox txtPRICE;
        private System.Windows.Forms.TextBox txtOBJNM;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView Allprod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

