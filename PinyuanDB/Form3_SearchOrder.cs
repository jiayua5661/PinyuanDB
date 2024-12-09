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
    public partial class Form3_SearchOrder : Form
    {
        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);
        DataTable dt = new DataTable();

        public Form3_SearchOrder()
        {
            InitializeComponent();
        }

        private void Form3_SearchOrder_Load(object sender, EventArgs e)
        {
            // combobox 讀取
            dt = pinyuanDB.Select("select * from Client");
            cbbCompanyName.DataSource = dt;
            cbbCompanyName.DisplayMember = "CompanyName";
            cbbCompanyName.ValueMember = "ClientID";
            cbbCompanyName.SelectedIndex = -1;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            // 變數 key value 要給sqlcmd 放變數
            Dictionary<string, string> dc = new Dictionary<string, string>();
            string sql = "select c.CompanyName as '客戶名稱', o.OrderDate as '訂單日期', o.QuoteNumber as '估價單號碼', od.ProductName as '產品名稱', od.Amount as '數量', od.Price as '單價' from Client as c " +
                "left join Orders as o on c.ClientID = o.CompanyID " +
                "left join Order_Detail as od on o.OrderID = od.OrderID " +
                "where o.OrderDate between @OrderDateBegin and @OrderDateEnd ";
            dc.Add("@OrderDateBegin", dateOrderDateBegin.Value.Date.ToString("yyyy-MM-dd"));
            dc.Add("@OrderDateEnd", dateOrderDateEnd.Value.Date.ToString("yyyy-MM-dd"));

            if (cbbCompanyName.SelectedIndex != -1)
            {
                sql += "and c.ClientID = @ClientID ";
                dc.Add("@ClientID", cbbCompanyName.SelectedValue.ToString());
            }
            if (!string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                sql += "and od.ProductName like @ProductName ";
                dc.Add("@ProductName", $"%{txtProductName.Text.Trim()}%");
            }
            if (!string.IsNullOrWhiteSpace(txtQuoteNumber.Text))
            {
                sql += "and o.QuoteNumber like @QuoteNumber";
                dc.Add("@QuoteNumber", $"%{txtQuoteNumber.Text.Trim()}%");
            }
            dataGridView1.DataSource = pinyuanDB.Select(sql, dc);
        }

        // 輸入公司名 combobox 自動搜尋
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCompanyName.SelectedIndex = -1;
            txtQuoteNumber.Clear();
            txtProductName.Clear();
            dateOrderDateBegin.Value = DateTime.Now;
            dateOrderDateEnd.Value = DateTime.Now;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuoteNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入數字（0-9）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止輸入
            }
        }
    }
}
