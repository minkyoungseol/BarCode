namespace Barcode
{
    partial class BarCode
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_PrintStatus = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.part_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.revision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sILotNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemCount = new System.Windows.Forms.TextBox();
            this.btn_SubjectList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_SILotNo = new System.Windows.Forms.TextBox();
            this.txt_BoxQuantity = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.txt_Revision = new System.Windows.Forms.TextBox();
            this.txt_PartNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_Printer = new System.Windows.Forms.ComboBox();
            this.dateTime_ProdDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(12, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "품목 등록";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_PrintStatus
            // 
            this.btn_PrintStatus.Location = new System.Drawing.Point(460, 12);
            this.btn_PrintStatus.Name = "btn_PrintStatus";
            this.btn_PrintStatus.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintStatus.TabIndex = 2;
            this.btn_PrintStatus.Text = "출력 현황";
            this.btn_PrintStatus.UseVisualStyleBackColor = true;
            this.btn_PrintStatus.Click += new System.EventHandler(this.btn_PrintStatus_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(293, 342);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(242, 70);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "라벨 출력";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.part_Number,
            this.revision,
            this.unit,
            this.b_Quantity,
            this.sILotNO});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(523, 166);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "*";
            this.columnHeader1.Width = 20;
            // 
            // part_Number
            // 
            this.part_Number.Text = "PART NUMBER";
            this.part_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.part_Number.Width = 125;
            // 
            // revision
            // 
            this.revision.Text = "REVISION";
            this.revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.revision.Width = 75;
            // 
            // unit
            // 
            this.unit.Text = "UNIT";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unit.Width = 50;
            // 
            // b_Quantity
            // 
            this.b_Quantity.Text = "BOX QUANTITY";
            this.b_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_Quantity.Width = 105;
            // 
            // sILotNO
            // 
            this.sILotNO.Text = "S I Lot NO";
            this.sILotNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sILotNO.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "물품 수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "기준일자";
            // 
            // txt_ItemCount
            // 
            this.txt_ItemCount.Location = new System.Drawing.Point(363, 272);
            this.txt_ItemCount.Name = "txt_ItemCount";
            this.txt_ItemCount.Size = new System.Drawing.Size(172, 21);
            this.txt_ItemCount.TabIndex = 4;
            this.txt_ItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_SubjectList
            // 
            this.btn_SubjectList.Location = new System.Drawing.Point(93, 12);
            this.btn_SubjectList.Name = "btn_SubjectList";
            this.btn_SubjectList.Size = new System.Drawing.Size(75, 23);
            this.btn_SubjectList.TabIndex = 1;
            this.btn_SubjectList.Text = "품목 조회";
            this.btn_SubjectList.UseVisualStyleBackColor = true;
            this.btn_SubjectList.Click += new System.EventHandler(this.btn_SubjectList_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Part Number : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Revision : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Box Quantity :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Supplier Interal Lot No : ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(167, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 12);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(167, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 12);
            this.label9.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(167, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 12);
            this.label10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(167, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 12);
            this.label11.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(167, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 12);
            this.label12.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.txt_SILotNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_BoxQuantity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Unit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Revision, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_PartNumber, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.93478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.19565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 184);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // txt_SILotNo
            // 
            this.txt_SILotNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SILotNo.Location = new System.Drawing.Point(167, 153);
            this.txt_SILotNo.Name = "txt_SILotNo";
            this.txt_SILotNo.ReadOnly = true;
            this.txt_SILotNo.Size = new System.Drawing.Size(102, 21);
            this.txt_SILotNo.TabIndex = 16;
            // 
            // txt_BoxQuantity
            // 
            this.txt_BoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BoxQuantity.Location = new System.Drawing.Point(167, 114);
            this.txt_BoxQuantity.Name = "txt_BoxQuantity";
            this.txt_BoxQuantity.ReadOnly = true;
            this.txt_BoxQuantity.Size = new System.Drawing.Size(102, 21);
            this.txt_BoxQuantity.TabIndex = 15;
            // 
            // txt_Unit
            // 
            this.txt_Unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Unit.Location = new System.Drawing.Point(169, 78);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.ReadOnly = true;
            this.txt_Unit.Size = new System.Drawing.Size(98, 21);
            this.txt_Unit.TabIndex = 14;
            // 
            // txt_Revision
            // 
            this.txt_Revision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Revision.Location = new System.Drawing.Point(167, 44);
            this.txt_Revision.Name = "txt_Revision";
            this.txt_Revision.ReadOnly = true;
            this.txt_Revision.Size = new System.Drawing.Size(102, 21);
            this.txt_Revision.TabIndex = 13;
            // 
            // txt_PartNumber
            // 
            this.txt_PartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PartNumber.Location = new System.Drawing.Point(167, 8);
            this.txt_PartNumber.Name = "txt_PartNumber";
            this.txt_PartNumber.ReadOnly = true;
            this.txt_PartNumber.Size = new System.Drawing.Size(102, 21);
            this.txt_PartNumber.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "프린터";
            // 
            // combo_Printer
            // 
            this.combo_Printer.FormattingEnabled = true;
            this.combo_Printer.Location = new System.Drawing.Point(363, 236);
            this.combo_Printer.Name = "combo_Printer";
            this.combo_Printer.Size = new System.Drawing.Size(172, 20);
            this.combo_Printer.TabIndex = 20;
            // 
            // dateTime_ProdDate
            // 
            this.dateTime_ProdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_ProdDate.Location = new System.Drawing.Point(363, 305);
            this.dateTime_ProdDate.Name = "dateTime_ProdDate";
            this.dateTime_ProdDate.Size = new System.Drawing.Size(172, 21);
            this.dateTime_ProdDate.TabIndex = 21;
            // 
            // BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 437);
            this.Controls.Add(this.dateTime_ProdDate);
            this.Controls.Add(this.combo_Printer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_ItemCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_SubjectList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_PrintStatus);
            this.Controls.Add(this.btn_New);
            this.Name = "BarCode";
            this.Text = "바코드";
            this.Load += new System.EventHandler(this.BarCode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_PrintStatus;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ItemCount;
        private System.Windows.Forms.Button btn_SubjectList;
        private System.Windows.Forms.ColumnHeader part_Number;
        private System.Windows.Forms.ColumnHeader revision;
        private System.Windows.Forms.ColumnHeader unit;
        private System.Windows.Forms.ColumnHeader b_Quantity;
        private System.Windows.Forms.ColumnHeader sILotNO;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_SILotNo;
        private System.Windows.Forms.TextBox txt_BoxQuantity;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.TextBox txt_Revision;
        private System.Windows.Forms.TextBox txt_PartNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_Printer;
        private System.Windows.Forms.DateTimePicker dateTime_ProdDate;
    }
}

