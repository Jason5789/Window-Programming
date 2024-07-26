namespace h34101096_practice_5_2
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
            this.start = new System.Windows.Forms.Button();
            this.now = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1a = new System.Windows.Forms.Button();
            this.p1b = new System.Windows.Forms.Button();
            this.p1c = new System.Windows.Forms.Button();
            this.p2a = new System.Windows.Forms.Button();
            this.p2b = new System.Windows.Forms.Button();
            this.p2c = new System.Windows.Forms.Button();
            this.attack1 = new System.Windows.Forms.Button();
            this.move1 = new System.Windows.Forms.Button();
            this.skill1 = new System.Windows.Forms.Button();
            this.wait1 = new System.Windows.Forms.Button();
            this.end1 = new System.Windows.Forms.Button();
            this.attack2 = new System.Windows.Forms.Button();
            this.move2 = new System.Windows.Forms.Button();
            this.skill2 = new System.Windows.Forms.Button();
            this.wait2 = new System.Windows.Forms.Button();
            this.end2 = new System.Windows.Forms.Button();
            this.p1_info = new System.Windows.Forms.Label();
            this.p2_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(361, 243);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 80);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // now
            // 
            this.now.AutoSize = true;
            this.now.Enabled = false;
            this.now.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.now.Location = new System.Drawing.Point(357, 9);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(124, 28);
            this.now.TabIndex = 1;
            this.now.Text = "準備階段";
            this.now.Visible = false;
            // 
            // time
            // 
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.time.Location = new System.Drawing.Point(382, 46);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(76, 28);
            this.time.TabIndex = 2;
            this.time.Text = "10";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.UseCompatibleTextRendering = true;
            this.time.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Enabled = false;
            this.p1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1.Location = new System.Drawing.Point(124, 93);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(40, 28);
            this.p1.TabIndex = 3;
            this.p1.Text = "P1";
            this.p1.Visible = false;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Enabled = false;
            this.p2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2.Location = new System.Drawing.Point(686, 93);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(40, 28);
            this.p2.TabIndex = 4;
            this.p2.Text = "P2";
            this.p2.Visible = false;
            // 
            // p1a
            // 
            this.p1a.Enabled = false;
            this.p1a.Location = new System.Drawing.Point(95, 195);
            this.p1a.Name = "p1a";
            this.p1a.Size = new System.Drawing.Size(91, 37);
            this.p1a.TabIndex = 5;
            this.p1a.Text = "戰士: 1顆";
            this.p1a.UseVisualStyleBackColor = true;
            this.p1a.Visible = false;
            this.p1a.Click += new System.EventHandler(this.p1a_Click);
            // 
            // p1b
            // 
            this.p1b.Enabled = false;
            this.p1b.Location = new System.Drawing.Point(95, 245);
            this.p1b.Name = "p1b";
            this.p1b.Size = new System.Drawing.Size(91, 37);
            this.p1b.TabIndex = 6;
            this.p1b.Text = "法師: 1顆";
            this.p1b.UseVisualStyleBackColor = true;
            this.p1b.Visible = false;
            this.p1b.Click += new System.EventHandler(this.p1b_Click);
            // 
            // p1c
            // 
            this.p1c.Enabled = false;
            this.p1c.Location = new System.Drawing.Point(95, 295);
            this.p1c.Name = "p1c";
            this.p1c.Size = new System.Drawing.Size(91, 37);
            this.p1c.TabIndex = 7;
            this.p1c.Text = "遊俠: 1顆";
            this.p1c.UseVisualStyleBackColor = true;
            this.p1c.Visible = false;
            this.p1c.Click += new System.EventHandler(this.p1c_Click);
            // 
            // p2a
            // 
            this.p2a.Enabled = false;
            this.p2a.Location = new System.Drawing.Point(655, 195);
            this.p2a.Name = "p2a";
            this.p2a.Size = new System.Drawing.Size(91, 37);
            this.p2a.TabIndex = 8;
            this.p2a.Text = "戰士: 1顆";
            this.p2a.UseVisualStyleBackColor = true;
            this.p2a.Visible = false;
            this.p2a.Click += new System.EventHandler(this.p2a_Click);
            // 
            // p2b
            // 
            this.p2b.Enabled = false;
            this.p2b.Location = new System.Drawing.Point(655, 245);
            this.p2b.Name = "p2b";
            this.p2b.Size = new System.Drawing.Size(91, 37);
            this.p2b.TabIndex = 9;
            this.p2b.Text = "法師: 1顆";
            this.p2b.UseVisualStyleBackColor = true;
            this.p2b.Visible = false;
            this.p2b.Click += new System.EventHandler(this.p2b_Click);
            // 
            // p2c
            // 
            this.p2c.Enabled = false;
            this.p2c.Location = new System.Drawing.Point(655, 295);
            this.p2c.Name = "p2c";
            this.p2c.Size = new System.Drawing.Size(91, 37);
            this.p2c.TabIndex = 10;
            this.p2c.Text = "遊俠: 1顆";
            this.p2c.UseVisualStyleBackColor = true;
            this.p2c.Visible = false;
            this.p2c.Click += new System.EventHandler(this.p2c_Click);
            // 
            // attack1
            // 
            this.attack1.Enabled = false;
            this.attack1.Location = new System.Drawing.Point(56, 372);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(74, 44);
            this.attack1.TabIndex = 11;
            this.attack1.Text = "攻擊";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Visible = false;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // move1
            // 
            this.move1.Enabled = false;
            this.move1.Location = new System.Drawing.Point(136, 372);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(74, 44);
            this.move1.TabIndex = 12;
            this.move1.Text = "移動";
            this.move1.UseVisualStyleBackColor = true;
            this.move1.Visible = false;
            this.move1.Click += new System.EventHandler(this.move1_Click);
            // 
            // skill1
            // 
            this.skill1.Enabled = false;
            this.skill1.Location = new System.Drawing.Point(56, 425);
            this.skill1.Name = "skill1";
            this.skill1.Size = new System.Drawing.Size(74, 44);
            this.skill1.TabIndex = 13;
            this.skill1.Text = "技能";
            this.skill1.UseVisualStyleBackColor = true;
            this.skill1.Visible = false;
            this.skill1.Click += new System.EventHandler(this.skill1_Click);
            // 
            // wait1
            // 
            this.wait1.Enabled = false;
            this.wait1.Location = new System.Drawing.Point(136, 425);
            this.wait1.Name = "wait1";
            this.wait1.Size = new System.Drawing.Size(74, 44);
            this.wait1.TabIndex = 14;
            this.wait1.Text = "待機";
            this.wait1.UseVisualStyleBackColor = true;
            this.wait1.Visible = false;
            this.wait1.Click += new System.EventHandler(this.wait1_Click);
            // 
            // end1
            // 
            this.end1.Enabled = false;
            this.end1.Location = new System.Drawing.Point(56, 478);
            this.end1.Name = "end1";
            this.end1.Size = new System.Drawing.Size(154, 63);
            this.end1.TabIndex = 15;
            this.end1.Text = "結束";
            this.end1.UseVisualStyleBackColor = true;
            this.end1.Visible = false;
            this.end1.Click += new System.EventHandler(this.end1_Click);
            // 
            // attack2
            // 
            this.attack2.Enabled = false;
            this.attack2.Location = new System.Drawing.Point(636, 372);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(74, 44);
            this.attack2.TabIndex = 16;
            this.attack2.Text = "攻擊";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Visible = false;
            this.attack2.Click += new System.EventHandler(this.attack2_Click);
            // 
            // move2
            // 
            this.move2.Enabled = false;
            this.move2.Location = new System.Drawing.Point(716, 372);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(74, 44);
            this.move2.TabIndex = 17;
            this.move2.Text = "移動";
            this.move2.UseVisualStyleBackColor = true;
            this.move2.Visible = false;
            this.move2.Click += new System.EventHandler(this.move2_Click);
            // 
            // skill2
            // 
            this.skill2.Enabled = false;
            this.skill2.Location = new System.Drawing.Point(636, 425);
            this.skill2.Name = "skill2";
            this.skill2.Size = new System.Drawing.Size(74, 44);
            this.skill2.TabIndex = 18;
            this.skill2.Text = "技能";
            this.skill2.UseVisualStyleBackColor = true;
            this.skill2.Visible = false;
            this.skill2.Click += new System.EventHandler(this.skill2_Click);
            // 
            // wait2
            // 
            this.wait2.Enabled = false;
            this.wait2.Location = new System.Drawing.Point(716, 425);
            this.wait2.Name = "wait2";
            this.wait2.Size = new System.Drawing.Size(74, 44);
            this.wait2.TabIndex = 19;
            this.wait2.Text = "待機";
            this.wait2.UseVisualStyleBackColor = true;
            this.wait2.Visible = false;
            this.wait2.Click += new System.EventHandler(this.wait2_Click);
            // 
            // end2
            // 
            this.end2.Enabled = false;
            this.end2.Location = new System.Drawing.Point(636, 478);
            this.end2.Name = "end2";
            this.end2.Size = new System.Drawing.Size(154, 63);
            this.end2.TabIndex = 20;
            this.end2.Text = "結束";
            this.end2.UseVisualStyleBackColor = true;
            this.end2.Visible = false;
            this.end2.Click += new System.EventHandler(this.end2_Click);
            // 
            // p1_info
            // 
            this.p1_info.Enabled = false;
            this.p1_info.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p1_info.Location = new System.Drawing.Point(56, 139);
            this.p1_info.Name = "p1_info";
            this.p1_info.Size = new System.Drawing.Size(145, 202);
            this.p1_info.TabIndex = 21;
            this.p1_info.Text = "label1";
            this.p1_info.Visible = false;
            // 
            // p2_info
            // 
            this.p2_info.Enabled = false;
            this.p2_info.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.p2_info.Location = new System.Drawing.Point(643, 139);
            this.p2_info.Name = "p2_info";
            this.p2_info.Size = new System.Drawing.Size(147, 202);
            this.p2_info.TabIndex = 22;
            this.p2_info.Text = "label2";
            this.p2_info.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 589);
            this.Controls.Add(this.end2);
            this.Controls.Add(this.wait2);
            this.Controls.Add(this.skill2);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.attack2);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.wait1);
            this.Controls.Add(this.skill1);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.p2c);
            this.Controls.Add(this.p2b);
            this.Controls.Add(this.p2a);
            this.Controls.Add(this.p1c);
            this.Controls.Add(this.p1b);
            this.Controls.Add(this.p1a);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.now);
            this.Controls.Add(this.start);
            this.Controls.Add(this.p1_info);
            this.Controls.Add(this.p2_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label now;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Button p1a;
        private System.Windows.Forms.Button p1b;
        private System.Windows.Forms.Button p1c;
        private System.Windows.Forms.Button p2a;
        private System.Windows.Forms.Button p2b;
        private System.Windows.Forms.Button p2c;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Button move1;
        private System.Windows.Forms.Button skill1;
        private System.Windows.Forms.Button wait1;
        private System.Windows.Forms.Button end1;
        private System.Windows.Forms.Button attack2;
        private System.Windows.Forms.Button move2;
        private System.Windows.Forms.Button skill2;
        private System.Windows.Forms.Button wait2;
        private System.Windows.Forms.Button end2;
        private System.Windows.Forms.Label p1_info;
        private System.Windows.Forms.Label p2_info;
    }
}

