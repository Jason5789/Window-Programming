namespace h34101096_practice_5_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.Label();
            this.wrongTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(282, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "猜單字遊戲\r\n6次猜錯機會";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(333, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入要猜的單字:";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answer.Location = new System.Drawing.Point(336, 213);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(145, 28);
            this.answer.TabIndex = 2;
            this.answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answer_KeyPress);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(336, 287);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(145, 64);
            this.start.TabIndex = 3;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Enabled = false;
            this.time.Location = new System.Drawing.Point(667, 76);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 15);
            this.time.TabIndex = 4;
            this.time.Text = "時間:";
            this.time.Visible = false;
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Enabled = false;
            this.wrong.Location = new System.Drawing.Point(667, 107);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(71, 15);
            this.wrong.TabIndex = 5;
            this.wrong.Text = "猜錯次數:";
            this.wrong.Visible = false;
            // 
            // guess
            // 
            this.guess.Enabled = false;
            this.guess.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guess.Location = new System.Drawing.Point(87, 306);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(636, 74);
            this.guess.TabIndex = 6;
            this.guess.Text = "label5";
            this.guess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guess.Visible = false;
            // 
            // wrongTime
            // 
            this.wrongTime.AutoSize = true;
            this.wrongTime.Enabled = false;
            this.wrongTime.Location = new System.Drawing.Point(744, 107);
            this.wrongTime.Name = "wrongTime";
            this.wrongTime.Size = new System.Drawing.Size(14, 15);
            this.wrongTime.TabIndex = 7;
            this.wrongTime.Text = "0";
            this.wrongTime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeNum
            // 
            this.timeNum.AutoSize = true;
            this.timeNum.Enabled = false;
            this.timeNum.Location = new System.Drawing.Point(711, 76);
            this.timeNum.Name = "timeNum";
            this.timeNum.Size = new System.Drawing.Size(14, 15);
            this.timeNum.TabIndex = 8;
            this.timeNum.Text = "0";
            this.timeNum.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeNum);
            this.Controls.Add(this.wrongTime);
            this.Controls.Add(this.start);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.time);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label guess;
        private System.Windows.Forms.Label wrongTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeNum;
    }
}

