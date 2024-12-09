namespace PinyuanDB
{
    partial class Form2_InsertOrder
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
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuoteNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cbbCompanyName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(446, 24);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(175, 94);
            this.btnBackToMain.TabIndex = 1;
            this.btnBackToMain.Text = "回主畫面";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(239, 24);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(175, 94);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "確定新增";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(25, 24);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(175, 94);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "開啟新訂單";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "客戶名稱 :";
            // 
            // txtQuoteNumber
            // 
            this.txtQuoteNumber.Location = new System.Drawing.Point(175, 188);
            this.txtQuoteNumber.MaxLength = 5;
            this.txtQuoteNumber.Name = "txtQuoteNumber";
            this.txtQuoteNumber.Size = new System.Drawing.Size(440, 35);
            this.txtQuoteNumber.TabIndex = 2;
            this.txtQuoteNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuoteNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "估價單號碼 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "訂單日期 :";
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.Location = new System.Drawing.Point(175, 243);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Size = new System.Drawing.Size(440, 35);
            this.dateOrderDate.TabIndex = 4;
            // 
            // cbbCompanyName
            // 
            this.cbbCompanyName.FormattingEnabled = true;
            this.cbbCompanyName.Location = new System.Drawing.Point(175, 139);
            this.cbbCompanyName.Name = "cbbCompanyName";
            this.cbbCompanyName.Size = new System.Drawing.Size(440, 31);
            this.cbbCompanyName.TabIndex = 6;
            this.cbbCompanyName.TextUpdate += new System.EventHandler(this.cbbCompanyName_TextUpdate);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(864, 297);
            this.dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(196, 234);
            this.textBox1.TabIndex = 8;
            // 
            // Form2_InsertOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbCompanyName);
            this.Controls.Add(this.dateOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuoteNumber);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnBackToMain);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2_InsertOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增訂單";
            this.Load += new System.EventHandler(this.Form2_InsertOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuoteNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOrderDate;
        private System.Windows.Forms.ComboBox cbbCompanyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}