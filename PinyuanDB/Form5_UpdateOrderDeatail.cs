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
    public partial class Form5_UpdateOrderDeatail : Form
    {
        #region 查詢訂單明細用
        private string oriCompanyID;
        private string oriOrderID;
        private string oriQuoteNum;
        private string oriOrderDate;
        #endregion

        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);
        DataTable dt = new DataTable();
        public Form5_UpdateOrderDeatail(string inputOrderID, string inputCompanyID, string inputQuoteNum, string inputOrderDate)
        {
            InitializeComponent();
            oriCompanyID = inputCompanyID;
            oriOrderID = inputOrderID;
            oriQuoteNum = inputQuoteNum;
            oriOrderDate = inputOrderDate;
        }

        private void Form5_UpdateOrderDeatail_Load(object sender, EventArgs e)
        {
            // 顯示點擊的該筆訂單
            txtresult.Text += $"ID : {oriOrderID}\r\n";
            txtresult.Text += $"故價單號 : {oriQuoteNum}\r\n";
            txtresult.Text += $"公司ID : {oriCompanyID}\r\n";
            txtresult.Text += $"日期 : {oriOrderDate}\r\n";

            // combobox 讀取
            int cnt = 0;
            dt = pinyuanDB.Select("select * from Client");
            cbbCompanyName.DataSource = dt;
            cbbCompanyName.DisplayMember = "CompanyName";
            cbbCompanyName.ValueMember = "ClientID";
            // 找原本的 客戶名稱
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ClientID"].ToString() == oriCompanyID)
                {
                    cnt = i;
                    break;
                }
            }
            cbbCompanyName.SelectedIndex = cnt;
            txtQuoteNumber.Text = oriQuoteNum;// 原本估價單號
            dateOrderDate.Text = oriOrderDate;// 原本訂單日期
            // 找訂單明細
            string sql = "select od.OrdeDetailID, od.ProductName as '產品名稱', od.Amount as '數量', od.Price as '單價' from Orders as o left join Order_Detail as od on o.OrderID = od.OrderID where o.OrderID = @OrderID order by od.OrdeDetailID";
            Dictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("@OrderID", oriOrderID);
            dataGridView1.DataSource = pinyuanDB.Select(sql, dc);
            dataGridView1.Columns["OrdeDetailID"].Visible = false; // 隱藏 不顯示在畫面上
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

        private void btnSearchOrder_Click(object sender, EventArgs e)// btnSaveOrderChange 儲存變更 orderDetails
        {
            if (txtQuoteNumber.Text.Length == 5)// 確定估價單號碼 長度正確
            {
                DialogResult saveOrder = MessageBox.Show("確定修改?", "修改訂單", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (saveOrder == DialogResult.OK)
                {
                    // 訂單明細 空的地方
                    int emptyCnt = 0;
                    // 訂單明細空值確認
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // 跳過未填寫的列（因為 AllowUserToAddRows 會自動添加一空行）
                        if (row.IsNewRow) continue;

                        // 取得 DataGridView 中的資料
                        string productName = row.Cells["產品名稱"].Value?.ToString();
                        string amount = row.Cells["數量"].Value?.ToString();
                        string price = row.Cells["單價"].Value?.ToString();
                        if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(price))
                        {
                            emptyCnt++;
                        }
                    }
                    DialogResult emptyDataMsg = DialogResult.OK;
                    if (emptyCnt > 0)// 有空格詢問
                    {
                        MessageBox.Show("訂單明細有空格，沒有資料，確定要儲存嗎?", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    if (emptyDataMsg == DialogResult.OK)
                    {
                        int ordersUpdateCnt = 0;
                        string newCompanyID = cbbCompanyName.SelectedValue.ToString();
                        string newQuoteNumber = txtQuoteNumber.Text;
                        string newOrderDate = dateOrderDate.Value.Date.ToString("yyyy-MM-dd");

                        // 更新orders 表
                        string sql = "update Orders set CompanyID = @CompanyID, OrderDate = @OrderDate, QuoteNumber = @QuoteNumber where OrderID = @OrderID";
                        Dictionary<string, string> dc = new Dictionary<string, string>();
                        dc.Add("@CompanyID", newCompanyID);
                        dc.Add("@QuoteNumber", newQuoteNumber);
                        dc.Add("@OrderDate", newOrderDate);
                        dc.Add("@OrderID", oriOrderID);
                        ordersUpdateCnt += pinyuanDB.Update(sql, dc);

                        int orderDetailUpdateCnt = 0;
                        // 更新 OrderDetail 
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // 跳過未填寫的列（因為 AllowUserToAddRows 會自動添加一空行）
                            if (row.IsNewRow) continue;

                            // 取得 DataGridView 中的資料
                            // oriOrderID 
                            string productName = row.Cells["產品名稱"].Value?.ToString();
                            string amount = row.Cells["數量"].Value?.ToString();
                            string price = row.Cells["單價"].Value?.ToString();
                            string orderDetailID = row.Cells["OrdeDetailID"].Value.ToString();

                            txtresult.Text += $"{productName}, {amount}, {price}\r\n";
                            sql = "update Order_Detail set OrderID = @OrderID, ProductName = @ProductName, Amount = @Amount, Price = @Price  where OrdeDetailID = @OrdeDetailID";
                            dc.Clear();
                            dc.Add("@OrderID", oriOrderID);
                            dc.Add("@ProductName", productName);
                            dc.Add("@Amount", amount);
                            dc.Add("@Price", price);
                            dc.Add("@OrdeDetailID", orderDetailID);

                            orderDetailUpdateCnt += pinyuanDB.Update(sql, dc);
                        }
                        MessageBox.Show($"成功更新{ordersUpdateCnt}筆訂單，{orderDetailUpdateCnt}筆訂單明細");
                        this.Close();// 儲存完 關閉表單
                    }
                }
            }
            else MessageBox.Show("估價單號長度錯誤");
        }

        private void txtQuoteNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入數字（0-9）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止輸入
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
