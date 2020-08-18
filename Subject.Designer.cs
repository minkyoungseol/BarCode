namespace Barcode
{
    partial class Subject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SILotNO = new System.Windows.Forms.Label();
            this.lbl_BoxQuantity = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Revision = new System.Windows.Forms.Label();
            this.txt_Revision = new System.Windows.Forms.TextBox();
            this.txt_BoxQuantity = new System.Windows.Forms.TextBox();
            this.txt_SILotNo = new System.Windows.Forms.TextBox();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.txt_PartNumber = new System.Windows.Forms.TextBox();
            this.comboBox_Unit = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_SILotNO, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_BoxQuantity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Unit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Revision, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Revision, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_BoxQuantity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_SILotNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PartNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_PartNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Unit, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_SILotNO
            // 
            this.lbl_SILotNO.AutoSize = true;
            this.lbl_SILotNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SILotNO.Location = new System.Drawing.Point(4, 221);
            this.lbl_SILotNO.Name = "lbl_SILotNO";
            this.lbl_SILotNO.Size = new System.Drawing.Size(209, 56);
            this.lbl_SILotNO.TabIndex = 9;
            this.lbl_SILotNO.Text = "Supplier Interal Lot NO";
            this.lbl_SILotNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BoxQuantity
            // 
            this.lbl_BoxQuantity.AutoSize = true;
            this.lbl_BoxQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_BoxQuantity.Location = new System.Drawing.Point(4, 166);
            this.lbl_BoxQuantity.Name = "lbl_BoxQuantity";
            this.lbl_BoxQuantity.Size = new System.Drawing.Size(209, 54);
            this.lbl_BoxQuantity.TabIndex = 8;
            this.lbl_BoxQuantity.Text = "Box Quantity";
            this.lbl_BoxQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Unit.Location = new System.Drawing.Point(4, 111);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(209, 54);
            this.lbl_Unit.TabIndex = 7;
            this.lbl_Unit.Text = "UNIT";
            this.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Revision
            // 
            this.lbl_Revision.AutoSize = true;
            this.lbl_Revision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Revision.Location = new System.Drawing.Point(4, 56);
            this.lbl_Revision.Name = "lbl_Revision";
            this.lbl_Revision.Size = new System.Drawing.Size(209, 54);
            this.lbl_Revision.TabIndex = 6;
            this.lbl_Revision.Text = "Revision";
            this.lbl_Revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Revision
            // 
            this.txt_Revision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Revision.Location = new System.Drawing.Point(220, 72);
            this.txt_Revision.Name = "txt_Revision";
            this.txt_Revision.Size = new System.Drawing.Size(138, 21);
            this.txt_Revision.TabIndex = 1;
            this.txt_Revision.Leave += new System.EventHandler(this.txt_Revision_Leave);
            // 
            // txt_BoxQuantity
            // 
            this.txt_BoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BoxQuantity.Location = new System.Drawing.Point(220, 182);
            this.txt_BoxQuantity.Name = "txt_BoxQuantity";
            this.txt_BoxQuantity.Size = new System.Drawing.Size(138, 21);
            this.txt_BoxQuantity.TabIndex = 3;
            this.txt_BoxQuantity.Leave += new System.EventHandler(this.txt_BoxQuantity_Leave);
            // 
            // txt_SILotNo
            // 
            this.txt_SILotNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SILotNo.Location = new System.Drawing.Point(220, 238);
            this.txt_SILotNo.Name = "txt_SILotNo";
            this.txt_SILotNo.Size = new System.Drawing.Size(138, 21);
            this.txt_SILotNo.TabIndex = 4;
            this.txt_SILotNo.Leave += new System.EventHandler(this.txt_SILotNo_Leave);
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_PartNumber.Location = new System.Drawing.Point(4, 1);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(209, 54);
            this.lbl_PartNumber.TabIndex = 5;
            this.lbl_PartNumber.Text = "Part Number";
            this.lbl_PartNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PartNumber
            // 
            this.txt_PartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PartNumber.Location = new System.Drawing.Point(220, 17);
            this.txt_PartNumber.Name = "txt_PartNumber";
            this.txt_PartNumber.Size = new System.Drawing.Size(138, 21);
            this.txt_PartNumber.TabIndex = 0;
            this.txt_PartNumber.Leave += new System.EventHandler(this.txt_PartNumber_Leave);
            // 
            // comboBox_Unit
            // 
            this.comboBox_Unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_Unit.FormattingEnabled = true;
            this.comboBox_Unit.Items.AddRange(new object[] {
            "EA",
            "KG"});
            this.comboBox_Unit.Location = new System.Drawing.Point(220, 128);
            this.comboBox_Unit.Name = "comboBox_Unit";
            this.comboBox_Unit.Size = new System.Drawing.Size(138, 20);
            this.comboBox_Unit.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(106, 321);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(206, 321);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "등록";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 371);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Subject";
            this.Text = "품목 등록";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_SILotNO;
        private System.Windows.Forms.Label lbl_BoxQuantity;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_Revision;
        private System.Windows.Forms.TextBox txt_Revision;
        private System.Windows.Forms.TextBox txt_BoxQuantity;
        private System.Windows.Forms.TextBox txt_SILotNo;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.TextBox txt_PartNumber;
        private System.Windows.Forms.ComboBox comboBox_Unit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}