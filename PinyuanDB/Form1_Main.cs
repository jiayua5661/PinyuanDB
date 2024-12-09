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
    public partial class Form1_Main : Form
    {

        public Form1_Main()
        {
            InitializeComponent();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            Form2_InsertOrder form2_InsertOrder = new Form2_InsertOrder();
            form2_InsertOrder.ShowDialog(); // 這邊有回傳值  回傳enum DialogResult   OK,Cancel  之類的 可以拿來判斷
            // 在開啟的form 用 this.DialogResult = DialogResult.Cancel 來設定
            // 如果有資料需要傳回這個form 在開啟的form 設定public屬性 來設定值, 取值
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Form4_UpdateOrder form4_UpdateOrder = new Form4_UpdateOrder();
            form4_UpdateOrder.ShowDialog();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            Form3_SearchOrder form3_SearchOrder = new Form3_SearchOrder();
            form3_SearchOrder.ShowDialog();
        }

        private void btnSearchUpdateClient_Click(object sender, EventArgs e)
        {
            Form8_SelectUpdateClient form8_SelectUpdateClient = new Form8_SelectUpdateClient();
            form8_SelectUpdateClient.ShowDialog();
        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            Form6_InsertClient form6_InsertClient = new Form6_InsertClient();
            form6_InsertClient.ShowDialog();
        }
    }
}
