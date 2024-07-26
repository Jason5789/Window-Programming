namespace h34101096_practice_7_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newone = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.safe = new System.Windows.Forms.ToolStripMenuItem();
            this.savenew = new System.Windows.Forms.ToolStripMenuItem();
            this.leave = new System.Windows.Forms.ToolStripMenuItem();
            this.see = new System.Windows.Forms.ToolStripMenuItem();
            this.word = new System.Windows.Forms.ToolStripMenuItem();
            this.ok = new System.Windows.Forms.ToolStripMenuItem();
            this.nok = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.additemup = new System.Windows.Forms.ToolStripMenuItem();
            this.finishitemup = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteitemup = new System.Windows.Forms.ToolStripMenuItem();
            this.additem = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.finishitem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.see,
            this.edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newone,
            this.open,
            this.safe,
            this.savenew,
            this.leave});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(51, 24);
            this.file.Text = "檔案";
            // 
            // newone
            // 
            this.newone.Name = "newone";
            this.newone.Size = new System.Drawing.Size(144, 26);
            this.newone.Text = "新增";
            this.newone.Click += new System.EventHandler(this.newone_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(144, 26);
            this.open.Text = "開啟";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // safe
            // 
            this.safe.Name = "safe";
            this.safe.Size = new System.Drawing.Size(144, 26);
            this.safe.Text = "儲存";
            this.safe.Click += new System.EventHandler(this.safe_Click);
            // 
            // savenew
            // 
            this.savenew.Name = "savenew";
            this.savenew.Size = new System.Drawing.Size(144, 26);
            this.savenew.Text = "另存新檔";
            this.savenew.Click += new System.EventHandler(this.savenew_Click);
            // 
            // leave
            // 
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(144, 26);
            this.leave.Text = "離開";
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // see
            // 
            this.see.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.word,
            this.ok,
            this.nok});
            this.see.Name = "see";
            this.see.Size = new System.Drawing.Size(51, 24);
            this.see.Text = "檢視";
            // 
            // word
            // 
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(216, 26);
            this.word.Text = "字型大小";
            this.word.Click += new System.EventHandler(this.word_Click);
            // 
            // ok
            // 
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(216, 26);
            this.ok.Text = "顯示完成事項";
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // nok
            // 
            this.nok.Name = "nok";
            this.nok.Size = new System.Drawing.Size(216, 26);
            this.nok.Text = "隱藏完成事項";
            this.nok.Click += new System.EventHandler(this.nok_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find,
            this.additemup,
            this.finishitemup,
            this.deleteitemup});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(51, 24);
            this.edit.Text = "編輯";
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(216, 26);
            this.find.Text = "尋找";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // additemup
            // 
            this.additemup.Name = "additemup";
            this.additemup.Size = new System.Drawing.Size(216, 26);
            this.additemup.Text = "新增事項";
            this.additemup.Click += new System.EventHandler(this.additemup_Click);
            // 
            // finishitemup
            // 
            this.finishitemup.Name = "finishitemup";
            this.finishitemup.Size = new System.Drawing.Size(216, 26);
            this.finishitemup.Text = "完成事項";
            this.finishitemup.Click += new System.EventHandler(this.finishitemup_Click);
            // 
            // deleteitemup
            // 
            this.deleteitemup.Name = "deleteitemup";
            this.deleteitemup.Size = new System.Drawing.Size(216, 26);
            this.deleteitemup.Text = "刪除事項";
            this.deleteitemup.Click += new System.EventHandler(this.deleteitemup_Click);
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(674, 414);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(114, 33);
            this.additem.TabIndex = 3;
            this.additem.Text = "新增事項";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox.Location = new System.Drawing.Point(12, 39);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(776, 373);
            this.textBox.TabIndex = 4;
            // 
            // finishitem
            // 
            this.finishitem.Location = new System.Drawing.Point(554, 414);
            this.finishitem.Name = "finishitem";
            this.finishitem.Size = new System.Drawing.Size(114, 33);
            this.finishitem.TabIndex = 5;
            this.finishitem.Text = "完成事項";
            this.finishitem.UseVisualStyleBackColor = true;
            this.finishitem.Click += new System.EventHandler(this.finishitem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finishitem);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem newone;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem safe;
        private System.Windows.Forms.ToolStripMenuItem savenew;
        private System.Windows.Forms.ToolStripMenuItem leave;
        private System.Windows.Forms.ToolStripMenuItem see;
        private System.Windows.Forms.ToolStripMenuItem word;
        private System.Windows.Forms.Button additem;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem ok;
        private System.Windows.Forms.ToolStripMenuItem nok;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem additemup;
        private System.Windows.Forms.ToolStripMenuItem finishitemup;
        private System.Windows.Forms.ToolStripMenuItem deleteitemup;
        private System.Windows.Forms.Button finishitem;
    }
}

