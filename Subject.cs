using DBLIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Subject : Form
    {
        clsDBLib db = new clsDBLib();

        public Subject()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {            
            // ComboBox 선택 검증
            if(comboBox_Unit.Text == string.Empty)
            {
                MessageBox.Show("UNIT을 선택해주세요.");
                comboBox_Unit.Focus();
                return;
            }
            // TextBox  빈 값 검증
            else if(CheckTextBox(txt_PartNumber, txt_PartNumber.Text, lbl_PartNumber.Text) == false)
            {
                return;
            }
            else if(CheckTextBox(txt_Revision, txt_Revision.Text, lbl_Revision.Text) == false)
            {
                return;
            }
            else if(CheckTextBox(txt_BoxQuantity, txt_BoxQuantity.Text, lbl_BoxQuantity.Text) == false){
                return;
            }
            else if(CheckTextBox(txt_SILotNo, txt_SILotNo.Text, lbl_SILotNO.Text) == false)
            {
                return;
            }

            string partNumber = txt_PartNumber.Text;                // 파트 번호
            string revision = txt_Revision.Text;                    // 
            string unit = comboBox_Unit.SelectedItem.ToString();    // 단위
            string boxQuantity = txt_BoxQuantity.Text;              // 박스당 수량
            string sILotNo = txt_SILotNo.Text;                      // 거래처코드

            string sQuery = "EXEC SP_BAR_SUBJECT_C @PARTNUMBER, @REVISION, @UNIT, @BOXQUANTITY, @SILOTNO";
            SqlParameter[] sPrm = new SqlParameter[5]
            {
                  new SqlParameter("@PARTNUMBER", partNumber)
                , new SqlParameter("@REVISION", revision)
                , new SqlParameter("@UNIT", unit)
                , new SqlParameter("@BOXQUANTITY", boxQuantity)
                , new SqlParameter("@SILOTNO", sILotNo)
            };

            int resultCode = db.NonQueryParams(sQuery, sPrm);
            if(resultCode == 0)
            {
                MessageBox.Show("정상 등록 되었습니다.");
            }
            else
            {
                MessageBox.Show("품목이 등록되지 않았습니다. 관리자에게 문의하세요");
            }

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Cancel.Focus();
            this.Close();
        }

        #region  유효성 검사
        private void txt_PartNumber_Leave(object sender, EventArgs e)
        {
            if(btn_Cancel.Focused)
            {
                return;
            }
            Regex regex = new Regex(@"^[0-9A-Z]+$");
            Boolean ismatch = regex.IsMatch(txt_PartNumber.Text);
            if (!ismatch)
            {
                MessageBox.Show("Part Number는 대문자, 숫자만 입력 가능합니다.");
                txt_PartNumber.Focus();
                txt_PartNumber.SelectAll();
            }
        }

        private void txt_Revision_Leave(object sender, EventArgs e)
        {
            if (btn_Cancel.Focused)
            {
                return;
            }
            Regex regex = new Regex(@"^[A-Z]+$");
            Boolean ismatch = regex.IsMatch(txt_Revision.Text);
            if (!ismatch)
            {
                MessageBox.Show("Revision은 대문자만 입력 가능합니다.");
                txt_Revision.Focus();
                txt_Revision.SelectAll();
            }
        }

        private void txt_BoxQuantity_Leave(object sender, EventArgs e)
        {
            if (btn_Cancel.Focused)
            {
                return;
            }
            Regex regex = new Regex(@"^[0-9]+$");
            Boolean ismatch = regex.IsMatch(txt_BoxQuantity.Text);
            if (!ismatch)
            {
                MessageBox.Show("Box Quantity는 숫자만 입력 가능합니다.");
                txt_Revision.Focus();
                txt_Revision.SelectAll();
            }
        }        

        private void txt_SILotNo_Leave(object sender, EventArgs e)
        {
            if (btn_Cancel.Focused)
            {
                return;
            }
            Regex regex = new Regex(@"^[A-Z0-9]+$");
            Boolean ismatch = regex.IsMatch(txt_SILotNo.Text);
            if (!ismatch)
            {
                MessageBox.Show("Supplier Interal Lot NO는 대문자, 숫자만 입력 가능합니다.");
                txt_SILotNo.Focus();
                txt_SILotNo.SelectAll();
            }
        }

        /// <summary>
        /// TextBox 빈 값 검증
        /// </summary>
        /// <param name="textBox"> TextBox </param>
        /// <param name="inputValue"> TextBox 입력 값 </param>
        /// <param name="labelName"> TextBox 해당 Label 입력 값 </param>
        /// <returns></returns>
        private bool CheckTextBox(TextBox textBox, string inputValue, string labelName)
        {
            if (string.IsNullOrEmpty(inputValue))
            {
                MessageBox.Show($"{labelName}항목을 입력해주세요.");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
