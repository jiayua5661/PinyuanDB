namespace PinyuanDB
{
    partial class Form6_InsertClient
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
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(90, 48);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(175, 94);
            this.btnNewClient.TabIndex = 2;
            this.btnNewClient.Text = "新增客戶";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(614, 48);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(175, 94);
            this.btnBackToMain.TabIndex = 4;
            this.btnBackToMain.Text = "回主畫面";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "客戶名稱 : ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(179, 202);
            this.txtClientName.MaxLength = 30;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(601, 35);
            this.txtClientName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "電話 : ";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(179, 270);
            this.txtTel.MaxLength = 20;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(601, 35);
            this.txtTel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "傳真 : ";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(179, 338);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(601, 35);
            this.txtFax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "地址 : ";
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(179, 406);
            this.txtTaxID.MaxLength = 8;
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(601, 35);
            this.txtTaxID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "統編 : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 474);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(601, 35);
            this.txtAddress.TabIndex = 6;
            // 
            // Form6_InsertClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnBackToMain);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6_InsertClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6_InsertClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
    }
}