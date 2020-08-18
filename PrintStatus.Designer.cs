namespace Barcode
{
    partial class PrintStatus
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CREATE_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PART_NUMBER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.REVISION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QUANTITY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UNIT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROD_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LOT_NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.S_I_LOTNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BOX_NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BoxNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LookUp = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.dateTime_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTime_EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.CREATE_DATE,
            this.PART_NUMBER,
            this.REVISION,
            this.QUANTITY,
            this.UNIT,
            this.PROD_DATE,
            this.LOT_NO,
            this.S_I_LOTNO,
            this.BOX_NO});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(16, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(828, 375);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "*";
            this.columnHeader1.Width = 30;
            // 
            // CREATE_DATE
            // 
            this.CREATE_DATE.Text = "Create Date";
            this.CREATE_DATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CREATE_DATE.Width = 80;
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.Text = "Part Number";
            this.PART_NUMBER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PART_NUMBER.Width = 90;
            // 
            // REVISION
            // 
            this.REVISION.Text = "Revision";
            this.REVISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QUANTITY
            // 
            this.QUANTITY.Text = "Quantity";
            this.QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UNIT
            // 
            this.UNIT.Text = "Unit";
            this.UNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UNIT.Width = 40;
            // 
            // PROD_DATE
            // 
            this.PROD_DATE.Text = "Prod Date";
            this.PROD_DATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PROD_DATE.Width = 80;
            // 
            // LOT_NO
            // 
            this.LOT_NO.Text = "Lot No";
            this.LOT_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LOT_NO.Width = 120;
            // 
            // S_I_LOTNO
            // 
            this.S_I_LOTNO.Text = "Supplier Interal Lot No";
            this.S_I_LOTNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.S_I_LOTNO.Width = 140;
            // 
            // BOX_NO
            // 
            this.BOX_NO.Text = "Box No";
            this.BOX_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BOX_NO.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Box No";
            // 
            // txt_BoxNo
            // 
            this.txt_BoxNo.Location = new System.Drawing.Point(424, 12);
            this.txt_BoxNo.Name = "txt_BoxNo";
            this.txt_BoxNo.Size = new System.Drawing.Size(221, 21);
            this.txt_BoxNo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "발행일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "~";
            // 
            // btn_LookUp
            // 
            this.btn_LookUp.Location = new System.Drawing.Point(688, 9);
            this.btn_LookUp.Name = "btn_LookUp";
            this.btn_LookUp.Size = new System.Drawing.Size(75, 23);
            this.btn_LookUp.TabIndex = 13;
            this.btn_LookUp.Text = "조회";
            this.btn_LookUp.UseVisualStyleBackColor = true;
            this.btn_LookUp.Click += new System.EventHandler(this.btn_LookUp_Click);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(769, 8);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(75, 23);
            this.btn_All.TabIndex = 12;
            this.btn_All.Text = "전체보기";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // dateTime_StartDate
            // 
            this.dateTime_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_StartDate.Location = new System.Drawing.Point(61, 11);
            this.dateTime_StartDate.Name = "dateTime_StartDate";
            this.dateTime_StartDate.Size = new System.Drawing.Size(111, 21);
            this.dateTime_StartDate.TabIndex = 19;
            // 
            // dateTime_EndDate
            // 
            this.dateTime_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_EndDate.Location = new System.Drawing.Point(198, 11);
            this.dateTime_EndDate.Name = "dateTime_EndDate";
            this.dateTime_EndDate.Size = new System.Drawing.Size(109, 21);
            this.dateTime_EndDate.TabIndex = 20;
            // 
            // PrintStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 441);
            this.Controls.Add(this.dateTime_EndDate);
            this.Controls.Add(this.dateTime_StartDate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_BoxNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LookUp);
            this.Controls.Add(this.btn_All);
            this.Name = "PrintStatus";
            this.Text = "발행 이력 조회";
            this.Load += new System.EventHandler(this.PrintStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader CREATE_DATE;
        private System.Windows.Forms.ColumnHeader PART_NUMBER;
        private System.Windows.Forms.ColumnHeader REVISION;
        private System.Windows.Forms.ColumnHeader QUANTITY;
        private System.Windows.Forms.ColumnHeader UNIT;
        private System.Windows.Forms.ColumnHeader PROD_DATE;
        private System.Windows.Forms.ColumnHeader LOT_NO;
        private System.Windows.Forms.ColumnHeader S_I_LOTNO;
        private System.Windows.Forms.ColumnHeader BOX_NO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BoxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LookUp;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.DateTimePicker dateTime_StartDate;
        private System.Windows.Forms.DateTimePicker dateTime_EndDate;
    }
}