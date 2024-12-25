using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinyuanDB
{
    public partial class Form2_InsertOrder : Form
    {
        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);
        DataTable dt = new DataTable();
        public Form2_InsertOrder()
        {
            InitializeComponent();
        }

        #region 初始化
        private void InitInsertForm()
        {
            // 開啟畫面控制項 初始化
            btnSaveOrder.Enabled = true;
            cbbCompanyName.Enabled = true;
            txtQuoteNumber.Enabled = true;
            dateOrderDate.Enabled = true;
            cbbCompanyName.SelectedIndex = -1;
            txtQuoteNumber.Text = string.Empty;
            dateOrderDate.Value = DateTime.Now; // 預設為今天

            // 初始化 dataGridView1
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ProductName", "產品名稱");
            dataGridView1.Columns["ProductName"].FillWeight = 3;
            dataGridView1.Columns.Add("Amount", "數量");
            dataGridView1.Columns["Amount"].FillWeight = 1;
            dataGridView1.Columns.Add("Price", "單價");
            dataGridView1.Columns["Price"].FillWeight = 1;
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
        }
        #endregion

        #region 限制輸入
        private void txtQuoteNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入數字（0-9）
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 阻止輸入
            }
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // 確定是 "Amount" 列時進行處理
            // 確定當前編輯的是 "Amount" 列
            if (dataGridView1.CurrentCell != null &&
                dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Amount"].Index)
            {
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress -= TextBox_KeyPress;
                    textBox.TextChanged -= TextBox_TextChanged;

                    textBox.KeyPress += TextBox_KeyPress; // 只限制數字
                    textBox.TextChanged += TextBox_TextChanged; // 只限制位數
                }
            }
            else
            {
                // 其他列移除限制
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress -= TextBox_KeyPress;
                    textBox.TextChanged -= TextBox_TextChanged;
                }
            }
        }

        // 限制只能輸入數字（以及可選的退格鍵）
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 禁止非數字輸入
            }
        }

        // 限制輸入位數為 5
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text.Length > 4)
            {
                // 截取前 5 位
                textBox.Text = textBox.Text.Substring(0, 4);

                // 將光標移到最後
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        #endregion

        // 畫面載入
        private void Form2_InsertOrder_Load(object sender, EventArgs e)
        {
            // 畫面初始化
            btnSaveOrder.Enabled = false;
            cbbCompanyName.Enabled = false;
            txtQuoteNumber.Enabled = false;
            dateOrderDate.Enabled = false;

            // combobox 讀取
            dt = pinyuanDB.Select("select * from Client");
            cbbCompanyName.DataSource = dt;
            cbbCompanyName.DisplayMember = "CompanyName";
            cbbCompanyName.ValueMember = "ClientID";
            cbbCompanyName.SelectedIndex = -1;
        }

        // 儲存訂單
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if(cbbCompanyName.SelectedValue == null)
            {
                MessageBox.Show("請選擇客戶");
            }
            else
            {
                string companyID = cbbCompanyName.SelectedValue.ToString();
                string quoteNumber = txtQuoteNumber.Text;
                string orderDate = dateOrderDate.Value.Date.ToString("yyyy-MM-dd");

                // 最少要有一筆資料
                int dataExit = 0;
                // 檢查有沒有空的 沒填到的地方
                int emptyCnt = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // 跳過未填寫的列（因為 AllowUserToAddRows 會自動添加一空行）
                    if (row.IsNewRow) continue;

                    // 取得 DataGridView 中的資料
                    string productName = row.Cells["ProductName"].Value?.ToString();
                    string amount = row.Cells["Amount"].Value?.ToString();
                    string price = row.Cells["Price"].Value?.ToString();

                    // 如果手動刪除整行資料 不會是newrow 所以要判斷跳過
                    if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(amount) && string.IsNullOrEmpty(price)) continue;

                    if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(price))
                    {
                        emptyCnt++;
                    }

                    // 最少有一筆完整資料
                    if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(amount) && !string.IsNullOrEmpty(price))
                        dataExit = 1;
                }

                // 確定儲存 詢問
                DialogResult saveData = MessageBox.Show("確定儲存新訂單 ?", "新增訂單提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (saveData == DialogResult.OK) // msgBox 確定
                {
                    // 填寫完整 才insert
                    if (quoteNumber != "" && emptyCnt == 0 && dataExit == 1)
                    {
                        string sql = "INSERT INTO Orders (CompanyID, OrderDate, QuoteNumber) VALUES (@CompanyID, @OrderDate, @QuoteNumber);SELECT SCOPE_IDENTITY();"; // 獲取當前insert後的ID
                                                                                                                                                                                // insert 要拿insert orders 資料表的identity欄位的值 來insert order_detail表
                        int ordersID = pinyuanDB.InsertGetInsertedID(sql, companyID, orderDate, quoteNumber);
                        int orderDetailCnt = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // 跳過未填寫的列（因為 AllowUserToAddRows 會自動添加一空行）
                            if (row.IsNewRow) continue;

                            // 取得 DataGridView 中的資料
                            string productName = row.Cells["ProductName"].Value?.ToString().Trim();
                            string amount = row.Cells["Amount"].Value?.ToString().Trim();
                            string price = row.Cells["Price"].Value?.ToString().Trim();

                            if (string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(amount) && string.IsNullOrEmpty(price)) continue;

                            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(price))
                            {
                                MessageBox.Show("請確認所有資料行已填寫！");
                                continue;
                            }

                            // 插入資料的 SQL 語句
                            sql = "INSERT INTO Order_Detail (OrderID, ProductName, Amount, Price) VALUES (@OrderID, @ProductName, @Amount, @Price)";
                            orderDetailCnt += pinyuanDB.Insert(sql, ordersID.ToString(), productName, amount, price);
                        }
                        MessageBox.Show($"成功新增{orderDetailCnt}筆資料");
                        InitInsertForm();
                    }
                    else MessageBox.Show("資料填寫不完整");
                }
            }
        }

        // 新訂單
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            InitInsertForm();
        }

        // 回主畫面
        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
