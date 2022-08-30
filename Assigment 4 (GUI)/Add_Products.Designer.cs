namespace Assigment_4__GUI_
{
    partial class Add_Products
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
            this.AllprodDGV = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CurrentUser = new System.Windows.Forms.Label();
            this.cbIsAvailable = new System.Windows.Forms.CheckBox();
            this.rbvariable = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.gbProductType = new System.Windows.Forms.GroupBox();
            this.gbAvilability = new System.Windows.Forms.GroupBox();
            this.clbCatagory = new System.Windows.Forms.CheckedListBox();
            this.lblProductCatagory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllprodDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbProductType.SuspendLayout();
            this.gbAvilability.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_Add
            // 
            this.bttn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Add.Location = new System.Drawing.Point(838, 417);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(136, 39);
            this.bttn_Add.TabIndex = 0;
            this.bttn_Add.Text = "Add";
            this.bttn_Add.UseVisualStyleBackColor = false;
            this.bttn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_Cancel.Location = new System.Drawing.Point(1006, 417);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(126, 39);
            this.bttn_Cancel.TabIndex = 1;
            this.bttn_Cancel.Text = "Cancel";
            this.bttn_Cancel.UseVisualStyleBackColor = false;
            this.bttn_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(434, 150);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(41, 16);
            this.lbl_Count.TabIndex = 2;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_name.Location = new System.Drawing.Point(71, 63);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Date.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Date.Location = new System.Drawing.Point(434, 63);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(39, 16);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date ";
            // 
            // lbl_Inventory_number
            // 
            this.lbl_Inventory_number.AutoSize = true;
            this.lbl_Inventory_number.Location = new System.Drawing.Point(814, 63);
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
            this.txtDATE.Location = new System.Drawing.Point(437, 98);
            this.txtDATE.Name = "txtDATE";
            this.txtDATE.Size = new System.Drawing.Size(278, 22);
            this.txtDATE.TabIndex = 8;
            // 
            // txtINVENTORYNUM
            // 
            this.txtINVENTORYNUM.Location = new System.Drawing.Point(817, 100);
            this.txtINVENTORYNUM.Name = "txtINVENTORYNUM";
            this.txtINVENTORYNUM.Size = new System.Drawing.Size(320, 22);
            this.txtINVENTORYNUM.TabIndex = 9;
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(74, 98);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(244, 22);
            this.txtNUM.TabIndex = 10;
            // 
            // txtCOUNT
            // 
            this.txtCOUNT.Location = new System.Drawing.Point(437, 196);
            this.txtCOUNT.Name = "txtCOUNT";
            this.txtCOUNT.Size = new System.Drawing.Size(278, 22);
            this.txtCOUNT.TabIndex = 11;
            // 
            // txtPRICE
            // 
            this.txtPRICE.Location = new System.Drawing.Point(817, 196);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(320, 22);
            this.txtPRICE.TabIndex = 12;
            // 
            // txtOBJNM
            // 
            this.txtOBJNM.Location = new System.Drawing.Point(74, 196);
            this.txtOBJNM.Name = "txtOBJNM";
            this.txtOBJNM.Size = new System.Drawing.Size(327, 22);
            this.txtOBJNM.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AllprodDGV
            // 
            this.AllprodDGV.AllowUserToDeleteRows = false;
            this.AllprodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllprodDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllprodDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllprodDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllprodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllprodDGV.GridColor = System.Drawing.SystemColors.Control;
            this.AllprodDGV.Location = new System.Drawing.Point(74, 257);
            this.AllprodDGV.Name = "AllprodDGV";
            this.AllprodDGV.RowHeadersWidth = 51;
            this.AllprodDGV.RowTemplate.Height = 24;
            this.AllprodDGV.Size = new System.Drawing.Size(742, 199);
            this.AllprodDGV.TabIndex = 15;
            this.AllprodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allprod_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CurrentUser
            // 
            this.CurrentUser.AutoSize = true;
            this.CurrentUser.Location = new System.Drawing.Point(71, 23);
            this.CurrentUser.Name = "CurrentUser";
            this.CurrentUser.Size = new System.Drawing.Size(84, 16);
            this.CurrentUser.TabIndex = 16;
            this.CurrentUser.Text = "Current User:";
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.AutoSize = true;
            this.cbIsAvailable.Location = new System.Drawing.Point(15, 38);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(99, 20);
            this.cbIsAvailable.TabIndex = 18;
            this.cbIsAvailable.Text = "Is Available";
            this.cbIsAvailable.UseVisualStyleBackColor = true;
            this.cbIsAvailable.CheckedChanged += new System.EventHandler(this.cbIsAvailable_CheckedChanged);
            // 
            // rbvariable
            // 
            this.rbvariable.AutoSize = true;
            this.rbvariable.Location = new System.Drawing.Point(6, 38);
            this.rbvariable.Name = "rbvariable";
            this.rbvariable.Size = new System.Drawing.Size(79, 20);
            this.rbvariable.TabIndex = 19;
            this.rbvariable.TabStop = true;
            this.rbvariable.Text = "Variable";
            this.rbvariable.UseVisualStyleBackColor = true;
            this.rbvariable.CheckedChanged += new System.EventHandler(this.rbvariable_CheckedChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(123, 38);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(70, 20);
            this.rbSimple.TabIndex = 20;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbProductType
            // 
            this.gbProductType.Controls.Add(this.rbSimple);
            this.gbProductType.Controls.Add(this.rbvariable);
            this.gbProductType.Location = new System.Drawing.Point(848, 257);
            this.gbProductType.Name = "gbProductType";
            this.gbProductType.Size = new System.Drawing.Size(200, 100);
            this.gbProductType.TabIndex = 21;
            this.gbProductType.TabStop = false;
            this.gbProductType.Text = "ProductType";
            // 
            // gbAvilability
            // 
            this.gbAvilability.Controls.Add(this.cbIsAvailable);
            this.gbAvilability.Location = new System.Drawing.Point(1103, 257);
            this.gbAvilability.Name = "gbAvilability";
            this.gbAvilability.Size = new System.Drawing.Size(200, 100);
            this.gbAvilability.TabIndex = 22;
            this.gbAvilability.TabStop = false;
            this.gbAvilability.Text = "Avilability";
            // 
            // clbCatagory
            // 
            this.clbCatagory.BackColor = System.Drawing.SystemColors.ControlText;
            this.clbCatagory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.clbCatagory.FormattingEnabled = true;
            this.clbCatagory.Items.AddRange(new object[] {
            "Food",
            "Electronics",
            "Toys",
            "Guns",
            "Swords"});
            this.clbCatagory.Location = new System.Drawing.Point(1176, 180);
            this.clbCatagory.Name = "clbCatagory";
            this.clbCatagory.Size = new System.Drawing.Size(138, 72);
            this.clbCatagory.TabIndex = 23;
            // 
            // lblProductCatagory
            // 
            this.lblProductCatagory.AutoSize = true;
            this.lblProductCatagory.Location = new System.Drawing.Point(1175, 149);
            this.lblProductCatagory.Name = "lblProductCatagory";
            this.lblProductCatagory.Size = new System.Drawing.Size(111, 16);
            this.lblProductCatagory.TabIndex = 24;
            this.lblProductCatagory.Text = "Product Catagory";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1343, 530);
            this.Controls.Add(this.lblProductCatagory);
            this.Controls.Add(this.clbCatagory);
            this.Controls.Add(this.gbAvilability);
            this.Controls.Add(this.gbProductType);
            this.Controls.Add(this.CurrentUser);
            this.Controls.Add(this.AllprodDGV);
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
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Products";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllprodDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbProductType.ResumeLayout(false);
            this.gbProductType.PerformLayout();
            this.gbAvilability.ResumeLayout(false);
            this.gbAvilability.PerformLayout();
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
        private System.Windows.Forms.DataGridView AllprodDGV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label CurrentUser;
        private System.Windows.Forms.CheckBox cbIsAvailable;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbvariable;
        private System.Windows.Forms.GroupBox gbAvilability;
        private System.Windows.Forms.GroupBox gbProductType;
        private System.Windows.Forms.Label lblProductCatagory;
        private System.Windows.Forms.CheckedListBox clbCatagory;
    }
}

