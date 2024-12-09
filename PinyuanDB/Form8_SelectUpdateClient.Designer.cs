namespace PinyuanDB
{
    partial class Form8_SelectUpdateClient
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
            this.cbbCompanyName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCompanyName
            // 
            this.cbbCompanyName.FormattingEnabled = true;
            this.cbbCompanyName.Location = new System.Drawing.Point(207, 165);
            this.cbbCompanyName.Name = "cbbCompanyName";
            this.cbbCompanyName.Size = new System.Drawing.Size(601, 31);
            this.cbbCompanyName.TabIndex = 21;
            this.cbbCompanyName.TextUpdate += new System.EventHandler(this.cbbCompanyName_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "搜尋客戶資料 :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(207, 510);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(601, 35);
            this.txtAddress.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "統編 : ";
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(207, 442);
            this.txtTaxID.MaxLength = 8;
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.ReadOnly = true;
            this.txtTaxID.Size = new System.Drawing.Size(601, 35);
            this.txtTaxID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "地址 : ";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(207, 374);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(601, 35);
            this.txtFax.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "傳真 : ";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(207, 306);
            this.txtTel.MaxLength = 20;
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(601, 35);
            this.txtTel.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "電話 : ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(207, 238);
            this.txtClientName.MaxLength = 30;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(601, 35);
            this.txtClientName.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "客戶名稱 : ";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(685, 34);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(175, 94);
            this.btnBackToMain.TabIndex = 32;
            this.btnBackToMain.Text = "回主畫面";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(57, 34);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(175, 94);
            this.btnEditClient.TabIndex = 32;
            this.btnEditClient.Text = "編輯資料";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(271, 34);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(175, 94);
            this.btnUpdateClient.TabIndex = 32;
            this.btnUpdateClient.Text = "儲存變更";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // Form8_SelectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbCompanyName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8_SelectClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8_SelectClient";
            this.Load += new System.EventHandler(this.Form8_SelectClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnUpdateClient;
    }
}