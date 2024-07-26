namespace h34101096_practice_3_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.risk = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(90, 46);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(578, 25);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(690, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 30);
            this.search.TabIndex = 3;
            this.search.Text = "搜尋";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // risk
            // 
            this.risk.Location = new System.Drawing.Point(37, 85);
            this.risk.Name = "risk";
            this.risk.Size = new System.Drawing.Size(728, 30);
            this.risk.TabIndex = 4;
            this.risk.Text = "風險帳號";
            this.risk.UseVisualStyleBackColor = true;
            this.risk.Click += new System.EventHandler(this.risk_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(593, 125);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(172, 30);
            this.change.TabIndex = 5;
            this.change.Text = "新增或刪除";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "搜尋結果";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.result.Location = new System.Drawing.Point(34, 180);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(731, 261);
            this.result.TabIndex = 7;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(184, 200);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(422, 23);
            this.state.TabIndex = 8;
            this.state.Text = "我是狀態列";
            this.state.Visible = false;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(184, 250);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(37, 15);
            this.address.TabIndex = 9;
            this.address.Text = "連結";
            this.address.Visible = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Enabled = false;
            this.name.Location = new System.Drawing.Point(184, 300);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(52, 15);
            this.name.TabIndex = 10;
            this.name.Text = "使用者";
            this.name.Visible = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(184, 350);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(37, 15);
            this.password.TabIndex = 11;
            this.password.Text = "密碼";
            this.password.Visible = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(264, 247);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(342, 25);
            this.txtaddress.TabIndex = 12;
            this.txtaddress.Visible = false;
            // 
            // txtuser
            // 
            this.txtuser.Enabled = false;
            this.txtuser.Location = new System.Drawing.Point(264, 297);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(342, 25);
            this.txtuser.TabIndex = 13;
            this.txtuser.Visible = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(264, 347);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(342, 25);
            this.txtpassword.TabIndex = 14;
            this.txtpassword.Visible = false;
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(434, 387);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 15;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(531, 387);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.state);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.change);
            this.Controls.Add(this.risk);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button risk;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
    }
}

