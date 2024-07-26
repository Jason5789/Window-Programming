namespace h34101096_practice_3_2
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
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.homeAction = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Label();
            this.b4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Button();
            this.gameAction = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(36, 100);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(44, 15);
            this.a1.TabIndex = 5;
            this.a1.Text = "堆疊1";
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Location = new System.Drawing.Point(36, 155);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(44, 15);
            this.a2.TabIndex = 6;
            this.a2.Text = "堆疊2";
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Location = new System.Drawing.Point(36, 210);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(44, 15);
            this.a3.TabIndex = 7;
            this.a3.Text = "堆疊3";
            // 
            // a4
            // 
            this.a4.AutoSize = true;
            this.a4.Location = new System.Drawing.Point(36, 265);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(44, 15);
            this.a4.TabIndex = 8;
            this.a4.Text = "堆疊4";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(95, 95);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(291, 25);
            this.text1.TabIndex = 9;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(95, 150);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(291, 25);
            this.text2.TabIndex = 10;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(95, 205);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(291, 25);
            this.text3.TabIndex = 11;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(95, 260);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(291, 25);
            this.text4.TabIndex = 12;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(153, 305);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 29);
            this.start.TabIndex = 13;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // homeAction
            // 
            this.homeAction.BackColor = System.Drawing.SystemColors.Control;
            this.homeAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeAction.Location = new System.Drawing.Point(68, 28);
            this.homeAction.Name = "homeAction";
            this.homeAction.Size = new System.Drawing.Size(318, 37);
            this.homeAction.TabIndex = 4;
            this.homeAction.Text = "請輸入測資";
            this.homeAction.Click += new System.EventHandler(this.label5_Click);
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Enabled = false;
            this.b1.Location = new System.Drawing.Point(43, 50);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(44, 15);
            this.b1.TabIndex = 14;
            this.b1.Text = "堆疊1";
            this.b1.Visible = false;
            // 
            // b2
            // 
            this.b2.AutoSize = true;
            this.b2.Enabled = false;
            this.b2.Location = new System.Drawing.Point(147, 50);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(44, 15);
            this.b2.TabIndex = 15;
            this.b2.Text = "堆疊2";
            this.b2.Visible = false;
            // 
            // b3
            // 
            this.b3.AutoSize = true;
            this.b3.Enabled = false;
            this.b3.Location = new System.Drawing.Point(250, 50);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(44, 15);
            this.b3.TabIndex = 16;
            this.b3.Text = "堆疊3";
            this.b3.Visible = false;
            // 
            // b4
            // 
            this.b4.AutoSize = true;
            this.b4.Enabled = false;
            this.b4.Location = new System.Drawing.Point(353, 50);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(44, 15);
            this.b4.TabIndex = 17;
            this.b4.Text = "堆疊4";
            this.b4.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(36, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 321);
            this.label1.TabIndex = 18;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(139, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 321);
            this.label2.TabIndex = 19;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(242, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 321);
            this.label3.TabIndex = 20;
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(345, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 321);
            this.label4.TabIndex = 21;
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Visible = false;
            // 
            // p1
            // 
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(36, 420);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(54, 28);
            this.p1.TabIndex = 22;
            this.p1.Text = "選取";
            this.p1.UseVisualStyleBackColor = true;
            this.p1.Visible = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p2
            // 
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(139, 420);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(54, 28);
            this.p2.TabIndex = 23;
            this.p2.Text = "選取";
            this.p2.UseVisualStyleBackColor = true;
            this.p2.Visible = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p3
            // 
            this.p3.Enabled = false;
            this.p3.Location = new System.Drawing.Point(242, 420);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(54, 28);
            this.p3.TabIndex = 24;
            this.p3.Text = "選取";
            this.p3.UseVisualStyleBackColor = true;
            this.p3.Visible = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p4
            // 
            this.p4.Enabled = false;
            this.p4.Location = new System.Drawing.Point(345, 420);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(54, 28);
            this.p4.TabIndex = 25;
            this.p4.Text = "選取";
            this.p4.UseVisualStyleBackColor = true;
            this.p4.Visible = false;
            this.p4.Click += new System.EventHandler(this.p4_Click);
            // 
            // gameAction
            // 
            this.gameAction.BackColor = System.Drawing.SystemColors.Control;
            this.gameAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameAction.Enabled = false;
            this.gameAction.Location = new System.Drawing.Point(36, 468);
            this.gameAction.Name = "gameAction";
            this.gameAction.Size = new System.Drawing.Size(181, 45);
            this.gameAction.TabIndex = 26;
            this.gameAction.Text = "...";
            this.gameAction.Visible = false;
            // 
            // back
            // 
            this.back.Enabled = false;
            this.back.Location = new System.Drawing.Point(242, 474);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 39);
            this.back.TabIndex = 27;
            this.back.Text = "回主畫面";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gameAction);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.homeAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label a4;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label homeAction;
        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Label b2;
        private System.Windows.Forms.Label b3;
        private System.Windows.Forms.Label b4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button p1;
        private System.Windows.Forms.Button p2;
        private System.Windows.Forms.Button p3;
        private System.Windows.Forms.Button p4;
        private System.Windows.Forms.Label gameAction;
        private System.Windows.Forms.Button back;
    }
}

