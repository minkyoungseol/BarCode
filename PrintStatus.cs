using DBLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class PrintStatus : Form
    {
        clsDBLib db = new clsDBLib();
        DataSet ds = new DataSet();
        DataTable dt;

        public PrintStatus()
        {
            InitializeComponent();
        }

        private void PrintStatus_Load(object sender, EventArgs e)
        {
            getBarCodeInfo("ALL", "", "", "");
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            getBarCodeInfo("ALL", "", "", "");
        }

        private void btn_LookUp_Click(object sender, EventArgs e)
        {
            string startDate = dateTime_StartDate.Value.ToString("yyyy-MM-dd");
            string endDate = dateTime_EndDate.Value.ToString("yyyy-MM-dd");
            string boxNo = txt_BoxNo.Text;

            getBarCodeInfo("SEARCH", startDate, endDate, boxNo);

            MessageBox.Show("startDate : " + startDate + "\r\nendDate : " + endDate + "BoxNo : " + boxNo);
        }

        private void getBarCodeInfo(string gubun, string startDate, string endDate, string boxNo)
        {
            string sQuery = "";
            sQuery = "EXEC SP_BAR_BARCODEINFO_R @GUBUN, @STARTDATE, @ENDDATE, @BOXNO";

            SqlParameter[] sPrm = new SqlParameter[4]
            {
                  new SqlParameter("@GUBUN", gubun)
                , new SqlParameter("@STARTDATE", startDate)
                , new SqlParameter("@ENDDATE", endDate)
                , new SqlParameter("@BOXNO", boxNo)
            };

            ds = db.SelectQueryDataset(sQuery, sPrm);
            dt = ds.Tables["DATA"];

            listView1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (listView1.Items.Count + 1).ToString();

                item.SubItems.Add(dt.Rows[i]["CREATE_DATE"].ToString());
                item.SubItems.Add(dt.Rows[i]["PART_NUMBER"].ToString());
                item.SubItems.Add(dt.Rows[i]["REVISION"].ToString());
                item.SubItems.Add(dt.Rows[i]["QUANTITY"].ToString());
                item.SubItems.Add(dt.Rows[i]["UNIT"].ToString());
                item.SubItems.Add(dt.Rows[i]["PROD_DATE"].ToString());
                item.SubItems.Add(dt.Rows[i]["LOT_NO"].ToString());
                item.SubItems.Add(dt.Rows[i]["S_I_LOTNO"].ToString());
                item.SubItems.Add(dt.Rows[i]["BOX_NO"].ToString());

                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            BarCode barCode = new BarCode();
            string defaultPrinter = ConfigurationManager.AppSettings["DEFAULTPRINTER"];

            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                string partNumber = listView1.Items[index].SubItems[2].Text;
                string revision = listView1.Items[index].SubItems[3].Text;
                string quantity = listView1.Items[index].SubItems[4].Text;
                string unit = listView1.Items[index].SubItems[5].Text;
                string prodDate = listView1.Items[index].SubItems[6].Text;
                string lotNo = listView1.Items[index].SubItems[7].Text;
                string sILotNo = listView1.Items[index].SubItems[8].Text;
                string boxNo = listView1.Items[index].SubItems[9].Text;

                if(MessageBox.Show("BOX NO : " + boxNo + "\r\n\r\n재발행 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    barCode.barCodePrint(defaultPrinter, partNumber, revision, quantity, prodDate, unit, lotNo, sILotNo, boxNo);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
