namespace h34101096_practice_4_1
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.going = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.Control;
            this.start.Location = new System.Drawing.Point(570, 70);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 46);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // going
            // 
            this.going.BackColor = System.Drawing.SystemColors.Control;
            this.going.Enabled = false;
            this.going.Location = new System.Drawing.Point(570, 180);
            this.going.Name = "going";
            this.going.Size = new System.Drawing.Size(103, 46);
            this.going.TabIndex = 1;
            this.going.Text = "繼續";
            this.going.UseVisualStyleBackColor = false;
            this.going.Click += new System.EventHandler(this.going_Click);
            // 
            // leave
            // 
            this.leave.BackColor = System.Drawing.SystemColors.Control;
            this.leave.Location = new System.Drawing.Point(570, 290);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(103, 46);
            this.leave.TabIndex = 2;
            this.leave.Text = "離開遊戲";
            this.leave.UseVisualStyleBackColor = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "翻牌小遊戲";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.going);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button going;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Label label1;
    }
}

