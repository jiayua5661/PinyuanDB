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
    public partial class Form8_SelectUpdateClient : Form
    {
        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);
        DataTable dt = new DataTable();

        public Form8_SelectUpdateClient()
        {
            InitializeComponent();
        }

        private void TxtReadOnlyEmpty()
        {
            txtClientName.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtTaxID.ReadOnly = true;
            txtClientName.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtTaxID.Text = string.Empty;
        }

        private void InitCbb()
        {
            // combobox 讀取
            cbbCompanyName.SelectedIndexChanged -= cbbCompanyName_SelectedIndexChanged;
            dt = pinyuanDB.Select("select * from Client");
            cbbCompanyName.DataSource = dt;
            cbbCompanyName.DisplayMember = "CompanyName";
            cbbCompanyName.ValueMember = "ClientID";
            cbbCompanyName.SelectedIndex = -1;
            cbbCompanyName.SelectedIndexChanged += cbbCompanyName_SelectedIndexChanged;
            TxtReadOnlyEmpty();
            btnUpdateClient.Enabled = false;
            btnEditClient.Enabled = false;
        }

        private void Form8_SelectClient_Load(object sender, EventArgs e)
        {
            InitCbb();
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

        private void cbbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectClientID = cbbCompanyName.SelectedValue.ToString();
            string sql = "select CompanyName as '客戶名稱', Tel as '電話', Fax as '傳真', Address as '地址', TaxIDNumber as '統編' from Client where ClientID = @ClientID";
            Dictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("@ClientID", selectClientID);
            dt = pinyuanDB.Select(sql, dc);
            txtClientName.Text = dt.Rows[0]["客戶名稱"].ToString();
            txtTel.Text = dt.Rows[0]["電話"].ToString();
            txtFax.Text = dt.Rows[0]["傳真"].ToString();
            txtAddress.Text = dt.Rows[0]["地址"].ToString();
            txtTaxID.Text = dt.Rows[0]["統編"].ToString();
            btnEditClient.Enabled = true;
        }

        // 開啟編輯狀態
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            txtClientName.ReadOnly = false;
            txtTel.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtTaxID.ReadOnly = false;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            DialogResult updateClient = MessageBox.Show("確定更新客戶資料?", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (updateClient == DialogResult.OK)
            {
                string selectClientID = cbbCompanyName.SelectedValue.ToString();
                string sql = "update Client set CompanyName = @CompanyName, Tel = @Tel, Fax = @Fax, Address = @Address, TaxIDNumber = @TaxIDNumber where ClientID = @ClientID";
                Dictionary<string, string> dc = new Dictionary<string, string>();
                dc.Add("@CompanyName", txtClientName.Text.Trim());
                dc.Add("@Tel", txtTel.Text.Trim());
                dc.Add("@Fax", txtFax.Text.Trim());
                dc.Add("@Address", txtAddress.Text.Trim());
                dc.Add("@TaxIDNumber", txtTaxID.Text.Trim());
                dc.Add("@ClientID", selectClientID);
                int cnt = pinyuanDB.Update(sql, dc);
                MessageBox.Show($"成功更新{cnt}筆客戶資料");
                InitCbb();
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
