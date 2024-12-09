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
    public partial class Form6_InsertClient : Form
    {
        DB_Helper pinyuanDB = new DB_Helper(PinyuanDB.Properties.Settings.Default.PinyuanDB);

        public Form6_InsertClient()
        {
            InitializeComponent();
        }

        // 清空textbox 內容
        private void ClearAllTextBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    // 如果是 TextBox，清空內容
                    textBox.Text = string.Empty;
                }
                else if (control.Controls.Count > 0)
                {
                    // 如果是容器（例如 Panel、GroupBox），遞迴呼叫
                    ClearAllTextBox(control);
                }
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            // 先找有沒有重複名字的
            int existCompanyName;
            Dictionary<string, string> dc = new Dictionary<string, string>();
            string sql = "select count(*) from Client where CompanyName = @CompanyName";
            dc.Add("@CompanyName", txtClientName.Text.Trim());
            existCompanyName = Convert.ToInt32(pinyuanDB.SelectExecuteScalar(sql, dc).ToString());

            if (existCompanyName == 0 && !string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                sql = "INSERT INTO Client (CompanyName, Tel, Fax, Address, TaxIDNumber) VALUES (@CompanyName, @Tel, @Fax, @Address, @TaxIDNumber)";
                string companyName = txtClientName.Text.Trim();
                string tel = txtTel.Text.Trim();
                string fax = txtFax.Text.Trim();
                string address = txtAddress.Text.Trim();
                string taxIDNumber = txtTaxID.Text.Trim();
                int cnt = pinyuanDB.Insert(sql, companyName, tel, fax, address, taxIDNumber);
                MessageBox.Show($"成功新增{cnt}筆客戶資料");
                ClearAllTextBox(this);
            }
            else if (string.IsNullOrWhiteSpace(txtClientName.Text))
            { MessageBox.Show("客戶名稱不能空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else MessageBox.Show("已有相同名稱公司", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
