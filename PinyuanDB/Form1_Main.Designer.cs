namespace PinyuanDB
{
    partial class Form1_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnSearchUpdateClient = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(98, 225);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(175, 94);
            this.btnInsertOrder.TabIndex = 0;
            this.btnInsertOrder.Text = "新增訂單";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.Location = new System.Drawing.Point(98, 365);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(175, 94);
            this.btnInsertClient.TabIndex = 0;
            this.btnInsertClient.Text = "新增客戶";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(360, 225);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(175, 94);
            this.btnUpdateOrder.TabIndex = 0;
            this.btnUpdateOrder.Text = "修改訂單";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnSearchUpdateClient
            // 
            this.btnSearchUpdateClient.Location = new System.Drawing.Point(360, 365);
            this.btnSearchUpdateClient.Name = "btnSearchUpdateClient";
            this.btnSearchUpdateClient.Size = new System.Drawing.Size(175, 94);
            this.btnSearchUpdateClient.TabIndex = 0;
            this.btnSearchUpdateClient.Text = "查詢/編輯客戶資料";
            this.btnSearchUpdateClient.UseVisualStyleBackColor = true;
            this.btnSearchUpdateClient.Click += new System.EventHandler(this.btnSearchUpdateClient_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(622, 226);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(175, 94);
            this.btnSearchOrder.TabIndex = 0;
            this.btnSearchOrder.Text = "查詢訂單明細";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.btnSearchUpdateClient);
            this.Controls.Add(this.btnSearchOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnInsertClient);
            this.Controls.Add(this.btnInsertOrder);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主頁面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Button btnInsertClient;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnSearchUpdateClient;
        private System.Windows.Forms.Button btnSearchOrder;
    }
}

