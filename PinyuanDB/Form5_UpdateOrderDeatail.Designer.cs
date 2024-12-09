namespace PinyuanDB
{
    partial class Form5_UpdateOrderDeatail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtresult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbCompanyName = new System.Windows.Forms.ComboBox();
            this.dateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuoteNumber = new System.Windows.Forms.TextBox();
            this.btnSaveOrderChange = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(663, 31);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtresult.Size = new System.Drawing.Size(196, 234);
            this.txtresult.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(864, 297);
            this.dataGridView1.TabIndex = 31;
            // 
            // cbbCompanyName
            // 
            this.cbbCompanyName.FormattingEnabled = true;
            this.cbbCompanyName.Location = new System.Drawing.Point(175, 133);
            this.cbbCompanyName.Name = "cbbCompanyName";
            this.cbbCompanyName.Size = new System.Drawing.Size(440, 31);
            this.cbbCompanyName.TabIndex = 30;
            this.cbbCompanyName.TextUpdate += new System.EventHandler(this.cbbCompanyName_TextUpdate);
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.Location = new System.Drawing.Point(175, 223);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Size = new System.Drawing.Size(440, 35);
            this.dateOrderDate.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "估價單號碼 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "訂單日期 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "客戶名稱 :";
            // 
            // txtQuoteNumber
            // 
            this.txtQuoteNumber.Location = new System.Drawing.Point(175, 182);
            this.txtQuoteNumber.MaxLength = 5;
            this.txtQuoteNumber.Name = "txtQuoteNumber";
            this.txtQuoteNumber.Size = new System.Drawing.Size(440, 35);
            this.txtQuoteNumber.TabIndex = 23;
            this.txtQuoteNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuoteNumber_KeyPress);
            // 
            // btnSaveOrderChange
            // 
            this.btnSaveOrderChange.Location = new System.Drawing.Point(25, 18);
            this.btnSaveOrderChange.Name = "btnSaveOrderChange";
            this.btnSaveOrderChange.Size = new System.Drawing.Size(175, 94);
            this.btnSaveOrderChange.TabIndex = 20;
            this.btnSaveOrderChange.Text = "儲存修改";
            this.btnSaveOrderChange.UseVisualStyleBackColor = true;
            this.btnSaveOrderChange.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(446, 18);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(175, 94);
            this.btnBackToMain.TabIndex = 22;
            this.btnBackToMain.Text = "回上一頁\r\n(查詢訂單)";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // Form5_UpdateOrderDeatail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbCompanyName);
            this.Controls.Add(this.dateOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuoteNumber);
            this.Controls.Add(this.btnSaveOrderChange);
            this.Controls.Add(this.btnBackToMain);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5_UpdateOrderDeatail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5_UpdateOrderDeatail";
            this.Load += new System.EventHandler(this.Form5_UpdateOrderDeatail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbCompanyName;
        private System.Windows.Forms.DateTimePicker dateOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuoteNumber;
        private System.Windows.Forms.Button btnSaveOrderChange;
        private System.Windows.Forms.Button btnBackToMain;
    }
}