namespace Dictionary_Desktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.translateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabData = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Arial", 25F);
            this.input.Location = new System.Drawing.Point(50, 82);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(534, 55);
            this.input.TabIndex = 0;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Arial", 25F);
            this.output.Location = new System.Drawing.Point(49, 248);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(535, 55);
            this.output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateBtn
            // 
            this.translateBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBtn.Location = new System.Drawing.Point(130, 462);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(344, 55);
            this.translateBtn.TabIndex = 6;
            this.translateBtn.Text = "Dịch";
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nghĩa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(60, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(281, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 27);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Việt => Anh";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Anh => Việt";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabData,
            this.tabEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabEdit
            // 
            this.tabEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaDữLiệuToolStripMenuItem});
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(99, 23);
            this.tabEdit.Text = "Chỉnh sửa";
            // 
            // chỉnhSửaDữLiệuToolStripMenuItem
            // 
            this.chỉnhSửaDữLiệuToolStripMenuItem.Name = "chỉnhSửaDữLiệuToolStripMenuItem";
            this.chỉnhSửaDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chỉnhSửaDữLiệuToolStripMenuItem.Text = "Chỉnh sửa dữ liệu";
            // 
            // tabData
            // 
            this.tabData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuToolStripMenuItem,
            this.hiểnThịDữLiệuToolStripMenuItem,
            this.xuấtDữLiệuToolStripMenuItem});
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(76, 23);
            this.tabData.Text = "Dữ liệu";
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // xuấtDữLiệuToolStripMenuItem
            // 
            this.xuấtDữLiệuToolStripMenuItem.Name = "xuấtDữLiệuToolStripMenuItem";
            this.xuấtDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xuấtDữLiệuToolStripMenuItem.Text = "Xuất dữ liệu";
            // 
            // hiểnThịDữLiệuToolStripMenuItem
            // 
            this.hiểnThịDữLiệuToolStripMenuItem.Name = "hiểnThịDữLiệuToolStripMenuItem";
            this.hiểnThịDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiểnThịDữLiệuToolStripMenuItem.Text = "Hiển thị dữ liệu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 575);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Từ điển Anh-Việt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabData;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabEdit;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịDữLiệuToolStripMenuItem;
    }
}

