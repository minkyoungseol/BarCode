using DBLIB;
using PrintBarcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class BarCode : Form
    {
        clsDBLib db = new clsDBLib();
        string partNumber;
        int boxQuantity;
        string lotNo;
        string sILotNo;
        string boxNo;
        int itemCount;
        string prodDate;
        string defaultPrinter;
        DataSet ds = new DataSet();
        DataTable dt;

        public BarCode()
        {
            InitializeComponent();            
            defaultPrinter = ConfigurationManager.AppSettings["DEFAULTPRINTER"];
            PrinterSettings ps = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                ps.PrinterName = printer;
                combo_Printer.Items.Add(printer);
                if (string.IsNullOrEmpty(defaultPrinter))
                {
                    defaultPrinter = printer;
                }
                    combo_Printer.SelectedItem = defaultPrinter;                
            }
        }

        private void BarCode_Load(object sender, EventArgs e)
        {
            getSubject();
        }

        /// <summary>
        /// 품목 등록 버튼 클릭 시 등록 창 새 창으로 팝업 팝업창 닫히면 ListView 갱신
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_New_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            sub.ShowDialog();
            getSubject();
        }

        /// <summary>
        /// ListView 인덱스 변경 될 때마다 하단 테이블에 선택한 품목 정보 보여주기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (listView1.SelectedIndices.Count > 0)
            {
                int index;
                index = Convert.ToInt32(listView1.SelectedIndices[0].ToString());

                txt_PartNumber.Text = listView1.Items[index].SubItems[1].Text;
                txt_Revision.Text = listView1.Items[index].SubItems[2].Text;
                txt_Unit.Text = listView1.Items[index].SubItems[3].Text;
                txt_BoxQuantity.Text = listView1.Items[index].SubItems[4].Text;
                txt_SILotNo.Text = listView1.Items[index].SubItems[5].Text;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("품목 리스트에서 품목을 선택해 주세요.");
                return;
            }
            else if(string.IsNullOrEmpty(txt_ItemCount.Text))
            {
                MessageBox.Show("물품 수량을 입력하세요.");
                return;
            }
            else if (combo_Printer.SelectedIndex < 0)
            {
                MessageBox.Show("프린터를 선택해 주세요.");
                return;
            }

            prodDate = dateTime_ProdDate.Value.ToString("yyyy-MM-dd");

            defaultPrinter = combo_Printer.SelectedItem.ToString();
            // 선택한 프린터 App.config에 저장
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DEFAULTPRINTER"].Value = defaultPrinter;
            config.Save(ConfigurationSaveMode.Modified);

            partNumber = txt_PartNumber.Text;
            string revision = txt_Revision.Text;
            string unit = txt_Unit.Text;
            sILotNo = txt_SILotNo.Text;
            itemCount = Convert.ToInt32(txt_ItemCount.Text);
            boxQuantity = Convert.ToInt32(txt_BoxQuantity.Text);

            int numOfPrint = (itemCount / boxQuantity);
            int remainder = itemCount % boxQuantity;
            if(remainder != 0)
            {
                numOfPrint = numOfPrint + 1;
                for(int i = 0; i < numOfPrint; i++)
                {                    
                    lotNo = GetNo("L", 3, prodDate);
                    boxNo = GetNo("B", 5, prodDate);

                    if(i != (numOfPrint - 1))
                    {
                        barCodePrint(defaultPrinter, partNumber, revision, Convert.ToString(boxQuantity), prodDate, unit, lotNo, sILotNo, boxNo);
                        barCodeInfo_Save(partNumber, Convert.ToString(boxQuantity), prodDate, lotNo, boxNo);
                    }
                    else
                    {
                        barCodePrint(defaultPrinter, partNumber, revision, Convert.ToString(remainder), prodDate, unit, lotNo, sILotNo, boxNo);
                        barCodeInfo_Save(partNumber, Convert.ToString(remainder), prodDate, lotNo, boxNo);
                    }                    
                }
            }
            else
            {
                for(int i = 0; i < numOfPrint; i++)
                {
                    lotNo = GetNo("L", 3, prodDate);
                    boxNo = GetNo("B", 5, prodDate);

                    barCodePrint(defaultPrinter, partNumber, revision, Convert.ToString(boxQuantity), prodDate, unit, lotNo, sILotNo, boxNo);
                }
            }
            MessageBox.Show("numOfPrint : " + numOfPrint + "\r\nremainde : " + remainder);
        }

        /// <summary>
        /// 프린트 실행(디자인, 데이터 넣어서 프린터 전달)
        /// </summary>
        /// <param name="defaultPrinter"> 선택한 프린터 이름 </param>
        /// <param name="partNumber"></param>
        /// <param name="revision"></param>
        /// <param name="quantity"></param>
        /// <param name="prodDate"></param>
        /// <param name="unit"></param>
        /// <param name="lotNo"></param>
        /// <param name="sILotNo"></param>
        /// <param name="boxNo"></param>
        public void barCodePrint(string defaultPrinter, string partNumber, string revision, string quantity, string prodDate
                                 ,string unit, string lotNo, string sILotNo, string boxNo)
        {
            PrintDialog pd = new PrintDialog();

            string s = "";

            s += "^XA";

            // 가로줄
            s += "^FO10,40^GB620,0,2^FS";
            s += "^FO400,360^GB230,0,2^FS";
            s += "^FO400,490^GB130,0,2^FS";
            s += "^FO530,565^GB100,0,2^FS";
            s += "^FO140,590^GB260,0,2^FS";
            s += "^FO530,710^GB100,0,2^FS";
            s += "^FO140,870^GB490,0,2^FS";
            s += "^FO10,1090^GB720,0,2^FS";

            // 세로줄
            s += "^FO10,40^GB0,1050,2^FS";
            s += "^FO140,40^GB0,1050,2^FS";
            s += "^FO270,40^GB0,550,2^FS";
            s += "^FO335,40^GB0,550,2^FS";
            s += "^FO400,40^GB0,830,2^FS";
            s += "^FO465,40^GB0,320,2^FS";
            s += "^FO530,40^GB0,830,2^FS";
            s += "^FO730,870^GB0,220,2^FS";

            // 색상 반전(배경 : 검정, 글씨: 흰색)
            s += "^LRY^FO630,40";
            s += "^GB101,832,101^FS";
            s += "^FWR";
            s += "^FO695,43^A0,20,20^FD Supplier Name^FS";
            s += "^FO695,365^A0,15,15^FD ZFPlant ^FS";
            s += "^FO670,365^A0,15,15^FD TRW Automotive technologies ^FS";
            s += "^FO655,43^A0,20,20^FD Halla StackPole Corporation ^FS";
            s += "^FO645,365^A0,15,15^FD(Shanhai),Co.Ltd.)^FS";
            s += "^FO660,750^A0,35,35^FD 208 ^FS";

            // 데이터명
            s += "^FO600,43^A0,20,20^FD Part Number:^FS";
            s += "^FO600,363^A0,20,20^FD Revision: ^FS";
            s += "^FO600,713^A0,20,20^FD Bonded ^FS";
            s += "^FO485,43^A0,20,20^FD Quantity: ^FS";
            s += "^FO485,363^A0,20,20^FD UNIT: ^FS";
            s += "^FO430,363^A0,20,20^FD " + unit + "^FS";
            s += "^FO420,43^A0,20,20^FD Prod Date:^FS";
            s += "^FO355,43^A0,20,20^FD Lot No.:^FS";
            s += "^FO290,43^A0,20,20^FD Supplier Interal Lot No:^FS";
            //s += "^ FO240,43^A0,20,20^FD Serial No.:^FS";

            //데이터 값
            s += "^FO590,200^A0,30,30^FD" + partNumber + "^FS";
            s += "^FO550,100^BY2^BC,35,N,N,N^FD" + partNumber + "^FS";
            s += "^FO590,500^A0,30,30^FD" + revision + "^FS";
            s += "^FO550,430^BY2^BC,35,N,N,N^FD" + revision + "^FS";
            s += "^FO480,130^A0,30,30^FD" + quantity + "^FS";
            s += "^FO480,200^BY2^BA,30,N,N,N^FD" + quantity + "^FS";
            s += "^FO415,150^A0,30,30^FD" + prodDate + "^FS";
            s += "^FO355,350^A0,20,20^FD" + lotNo + "^FS";
            s += "^FO290,500^A0,20,20^FD" + sILotNo + "^FS";
            //s += "^FO240,320^A0,20,20^FDUSN63238201807130101^FS";
            //s += "^FO160,60^BY2^BC,55,N,N,N^FDUSN63238201807130101^FS";
            s += "^FO195,655^BQ,2,4^FD" + boxNo + " | " + partNumber + " | " + quantity +  " | " + lotNo + " | " + sILotNo + " | 208 | " + revision + "^FS";
            s += "^FO60,400^BY2^BC,40,N,N,N^FD" + boxNo + "^FS";
            s += "^FO30,500^A0,20,20^FD" + boxNo + "^FS";

            //기본 데이터 값

            s += "^FO150,890^A0N,20,20^FDPart No.: " + partNumber + "^FS";
            s += "^FO150,930^A0N,20,20^FDQuantity: " + quantity + "^FS";
            s += "^FO345,930^A0N,20,20^FDRevision: " + revision + "^FS";
            s += "^FO150,970^A0N,20,20^FDLot No.: " + lotNo + "^FS";
            s += "^FO150,1010^A0N20,20^FDBox No.:^FS";
            s += "^FO150,1050^A0N,20,20^FD" + boxNo + "^FS";
            s += "^FO510,900^BQ,2,4^FD" + boxNo + " | " + partNumber + " | " + quantity + " | " + lotNo + " | " + sILotNo + " | 208 | " + revision + "^FS";
            s += "^XZ";

             CM_Function.RawPrinterHelper.SendStringToPrinter(defaultPrinter, s);
        }

        /// <summary>
        /// DB BAR_SUBJECT에 등록된 품목정보 전체 가져와서 ListView에 넣기
        /// </summary>
        private void getSubject()
        {
            string sQuery = "EXEC SP_BAR_SUBJECT_R";
            ds = db.SelectQueryDataset(sQuery);
            dt = ds.Tables["DATA"];

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (listView1.Items.Count + 1).ToString();

                item.SubItems.Add(dt.Rows[i]["PART_NUMBER"].ToString());
                item.SubItems.Add(dt.Rows[i]["REVISION"].ToString());
                item.SubItems.Add(dt.Rows[i]["UNIT"].ToString());
                item.SubItems.Add(dt.Rows[i]["B_QUANTITY"].ToString());
                item.SubItems.Add(dt.Rows[i]["S_I_LOTNO"].ToString());

                listView1.Items.Add(item);
            }
        }

        /// <summary>
        ///  채번하기 
        /// </summary>
        /// <param name="header"> 바코드 구분(L = Lot, B = Box)</param>
        /// <param name="seqLength"> Seq 길이 </param>
        /// <param name="prodDate"> 기준일자 </param>
        /// <returns></returns>
        private string GetNo(string header, int seqLength, string prodDate)
        {
            string barCodeNumber = "";
            try
            {
                string sQuery = "";

                sQuery = "EXEC SP_MD_GETNO_R @HEADER, @SEQLENGTH, @CONDATE";

                SqlParameter[] sPrm = new SqlParameter[3]
                {
                      new SqlParameter("@HEADER", header)
                    , new SqlParameter("@SEQLENGTH", seqLength)
                    , new SqlParameter("@CONDATE", prodDate)
                };

                barCodeNumber = db.selectParmQuery(sQuery, sPrm);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return barCodeNumber;
        }

        /// <summary>
        /// 출력하면서 출력한 바코드 정보 BARCODEINFO TABLE에 저장
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="quantity"></param>
        /// <param name="prodDate"></param>
        /// <param name="lotNo"></param>
        /// <param name="boxNo"></param>
        private void barCodeInfo_Save(string partNumber, string quantity, string prodDate, string lotNo, string boxNo)
        {
            int resultCode = 0;

            string sQuery = "";
            sQuery = "EXEC SP_BAR_BARCODEINFO_C @PARTNUMBER, @QUANTITY, @PRODDATE, @LOTNO, @BOXNO";

            SqlParameter[] sPrm = new SqlParameter[5]
            {
                    new SqlParameter("@PARTNUMBER", partNumber)
                , new SqlParameter("@QUANTITY", quantity)
                , new SqlParameter("@PRODDATE", prodDate)
                , new SqlParameter("@LOTNO", lotNo)
                , new SqlParameter("@BOXNO", boxNo)
            };
            resultCode = db.NonQueryParams(sQuery, sPrm);

            if(resultCode != 0)
            {
                MessageBox.Show("출력정보 저장 실패!! 관리자에게 문의하세요!");
            }
        }

        private void btn_SubjectList_Click(object sender, EventArgs e)
        {
            getSubject();
        }

        private void btn_PrintStatus_Click(object sender, EventArgs e)
        {
            PrintStatus printStatus = new PrintStatus();
            printStatus.ShowDialog();
        }
    }
}
