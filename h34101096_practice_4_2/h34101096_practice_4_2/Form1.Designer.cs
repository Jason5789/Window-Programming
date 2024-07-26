namespace h34101096_practice_4_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.userName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.Button();
            this.again = new System.Windows.Forms.Button();
            this.going = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.page2 = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "翻牌小遊戲";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page1);
            this.tabControl1.Controls.Add(this.page2);
            this.tabControl1.Location = new System.Drawing.Point(17, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 490);
            this.tabControl1.TabIndex = 1;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.userName);
            this.page1.Controls.Add(this.name);
            this.page1.Controls.Add(this.point);
            this.page1.Controls.Add(this.label2);
            this.page1.Controls.Add(this.leave);
            this.page1.Controls.Add(this.again);
            this.page1.Controls.Add(this.going);
            this.page1.Controls.Add(this.start);
            this.page1.Location = new System.Drawing.Point(4, 25);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(753, 461);
            this.page1.TabIndex = 0;
            this.page1.Text = "遊玩區";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userName.Location = new System.Drawing.Point(185, 10);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(160, 29);
            this.userName.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(125, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 19);
            this.name.TabIndex = 6;
            this.name.Text = "名稱：";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.point.Location = new System.Drawing.Point(70, 16);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(36, 19);
            this.point.TabIndex = 5;
            this.point.Text = "100";
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "分數：";
            // 
            // leave
            // 
            this.leave.Location = new System.Drawing.Point(614, 361);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(103, 46);
            this.leave.TabIndex = 3;
            this.leave.Text = "離開遊戲";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // again
            // 
            this.again.Location = new System.Drawing.Point(614, 199);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(103, 46);
            this.again.TabIndex = 2;
            this.again.Text = "重新開始";
            this.again.UseVisualStyleBackColor = true;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // going
            // 
            this.going.Enabled = false;
            this.going.Location = new System.Drawing.Point(614, 129);
            this.going.Name = "going";
            this.going.Size = new System.Drawing.Size(103, 46);
            this.going.TabIndex = 1;
            this.going.Text = "繼續";
            this.going.UseVisualStyleBackColor = true;
            this.going.Click += new System.EventHandler(this.going_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(614, 59);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 46);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // page2
            // 
            this.page2.Controls.Add(this.history);
            this.page2.Location = new System.Drawing.Point(4, 25);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(753, 461);
            this.page2.TabIndex = 1;
            this.page2.Text = "歷史紀錄區";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.history.Cursor = System.Windows.Forms.Cursors.Default;
            this.history.Location = new System.Drawing.Point(19, 13);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(715, 432);
            this.history.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button again;
        private System.Windows.Forms.Button going;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Button start;
    }
}

