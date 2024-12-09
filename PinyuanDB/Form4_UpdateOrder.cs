using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinyuanDB
{
    public partial class Form4_UpdateOrder : Form
    {
        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);
        DataTable dt = new DataTable();
        public Form4_UpdateOrder()
        {
            InitializeComponent();
        }

        private void searchOrderClick()
        {
            string sql = "select o.OrderID, o.CompanyID, c.CompanyName as '客戶名稱', o.QuoteNumber as '估價單號碼', o.OrderDate as '訂單日期' from Client as c left join Orders as o on c.ClientID = o.CompanyID where o.OrderDate between @OrderDateBegin and @OrderDateEnd ";
            Dictionary<string, string> paradc = new Dictionary<string, string>();
            paradc.Add("@OrderDateBegin", dateOrderDateBegin.Value.Date.ToString("yyyy-MM-dd"));
            paradc.Add("@OrderDateEnd", dateOrderdateEnd.Value.Date.ToString("yyyy-MM-dd"));

            if (cbbCompanyName.SelectedIndex != -1)
            {
                sql += "and c.ClientID = @ClientID ";
                paradc.Add("@ClientID", cbbCompanyName.SelectedValue.ToString());
            }

            if (!string.IsNullOrWhiteSpace(txtQuoteNumber.Text))
            {
                sql += "and o.QuoteNumber like @QuoteNumber ";
                paradc.Add("@QuoteNumber", $"%{txtQuoteNumber.Text.Trim()}%");
            }

            sql += "order by c.ClientID, o.OrderDate";

            dataGridView1.DataSource = pinyuanDB.Select(sql, paradc);
            dataGridView1.Columns["OrderID"].Visible = false; // 隱藏 不顯示在畫面上
            dataGridView1.Columns["CompanyID"].Visible = false; // 隱藏 不顯示在畫面上
        }

        private void Form4_UpdateOrder_Load(object sender, EventArgs e)
        {
            // combobox 讀取
            dt = pinyuanDB.Select("select * from Client");
            cbbCompanyName.DataSource = dt;
            cbbCompanyName.DisplayMember = "CompanyName";
            cbbCompanyName.ValueMember = "ClientID";
            cbbCompanyName.SelectedIndex = -1;
        }

        private void cbbCompanyName_TextUpdate(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string userInput = cb.Text;

            DataTable temp_dt = dt.Clone();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["CompanyName"].ToString().Contains(userInput))
                {
                    temp_dt.ImportRow(dr);
                }
            }

            try
            {
                // 改選項 為 有關鍵字的
                cb.DataSource = temp_dt;
                cb.DisplayMember = "CompanyName";
                cb.ValueMember = "ClientID";
                // 開下拉
                cb.DroppedDown = true;
                // 預設不選
                cb.SelectedIndex = -1;
                // 設為原本輸入
                cbbCompanyName.TextUpdate -= cbbCompanyName_TextUpdate;
                cb.Text = userInput;
                cbbCompanyName.TextUpdate += cbbCompanyName_TextUpdate;
                // 把輸入位置 放到原本的地方 不然會跑到最左
                cb.SelectionStart = cb.Text.Length;
                Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            searchOrderClick();
        }

        // 雙擊訂單 顯示訂單明細 修改該筆訂單
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 獲取被雙擊的行號和列號
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex >= 0 && !dataGridView1.Rows[rowIndex].IsNewRow) // 確保點擊的不是表頭 跟 新一行
            {
                string companyID = dataGridView1.Rows[rowIndex].Cells["CompanyID"].Value.ToString();
                string orderID = dataGridView1.Rows[rowIndex].Cells["OrderID"].Value.ToString();
                string quoteNum = dataGridView1.Rows[rowIndex].Cells["估價單號碼"].Value.ToString();
                string orderDate = dataGridView1.Rows[rowIndex].Cells["訂單日期"].Value.ToString();
                Form5_UpdateOrderDeatail form5_UpdateOrderDeatail = new Form5_UpdateOrderDeatail(orderID, companyID, quoteNum, orderDate);
                form5_UpdateOrderDeatail.ShowDialog(this);

                searchOrderClick();
            }
        }
        // 估價單號碼 限制只能數字
        private void txtQuoteNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入數字（0-9）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止輸入
            }
        }
        // 上一頁
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
