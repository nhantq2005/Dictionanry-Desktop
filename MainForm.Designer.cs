namespace Dictionary_Desktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdVNtoEN = new System.Windows.Forms.RadioButton();
            this.rdENtoVN = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateBtn = new System.Windows.Forms.Button();
            this.tệpHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tệpMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.output.Location = new System.Drawing.Point(49, 222);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(535, 55);
            this.output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nghĩa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdVNtoEN);
            this.groupBox1.Controls.Add(this.rdENtoVN);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15F);
            this.groupBox1.Location = new System.Drawing.Point(60, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // rdVNtoEN
            // 
            this.rdVNtoEN.AutoSize = true;
            this.rdVNtoEN.Location = new System.Drawing.Point(289, 48);
            this.rdVNtoEN.Name = "rdVNtoEN";
            this.rdVNtoEN.Size = new System.Drawing.Size(161, 32);
            this.rdVNtoEN.TabIndex = 0;
            this.rdVNtoEN.Text = "Việt → Anh";
            this.rdVNtoEN.UseVisualStyleBackColor = true;
            // 
            // rdENtoVN
            // 
            this.rdENtoVN.AutoSize = true;
            this.rdENtoVN.Checked = true;
            this.rdENtoVN.Location = new System.Drawing.Point(44, 48);
            this.rdENtoVN.Name = "rdENtoVN";
            this.rdENtoVN.Size = new System.Drawing.Size(161, 32);
            this.rdENtoVN.TabIndex = 0;
            this.rdENtoVN.TabStop = true;
            this.rdENtoVN.Text = "Anh → Việt";
            this.rdENtoVN.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dữLiệuToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataItem,
            this.showDataItem,
            this.exportDataItem});
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            // 
            // importDataItem
            // 
            this.importDataItem.Image = global::Dictionary_Desktop.Properties.Resources.import;
            this.importDataItem.Name = "importDataItem";
            this.importDataItem.Size = new System.Drawing.Size(224, 26);
            this.importDataItem.Text = "Nhập dữ liệu";
            this.importDataItem.Click += new System.EventHandler(this.importData_Click);
            // 
            // showDataItem
            // 
            this.showDataItem.Image = global::Dictionary_Desktop.Properties.Resources.list;
            this.showDataItem.Name = "showDataItem";
            this.showDataItem.Size = new System.Drawing.Size(224, 26);
            this.showDataItem.Text = "Xem dữ liệu";
            this.showDataItem.Click += new System.EventHandler(this.showDataItem_Click);
            // 
            // exportDataItem
            // 
            this.exportDataItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tệpHiệnTạiToolStripMenuItem,
            this.tệpMớiToolStripMenuItem});
            this.exportDataItem.Image = global::Dictionary_Desktop.Properties.Resources.export;
            this.exportDataItem.Name = "exportDataItem";
            this.exportDataItem.Size = new System.Drawing.Size(224, 26);
            this.exportDataItem.Text = "Xuất dữ liệu";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataItem});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // editDataItem
            // 
            this.editDataItem.Image = global::Dictionary_Desktop.Properties.Resources.pen;
            this.editDataItem.Name = "editDataItem";
            this.editDataItem.Size = new System.Drawing.Size(224, 26);
            this.editDataItem.Text = "Dữ liệu";
            this.editDataItem.Click += new System.EventHandler(this.editDataItem_Click_1);
            // 
            // translateBtn
            // 
            this.translateBtn.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.translateBtn.Image = global::Dictionary_Desktop.Properties.Resources.translate;
            this.translateBtn.Location = new System.Drawing.Point(136, 418);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(344, 55);
            this.translateBtn.TabIndex = 6;
            this.translateBtn.Text = "Dịch";
            this.translateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.translateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.translateBtn.UseVisualStyleBackColor = true;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // tệpHiệnTạiToolStripMenuItem
            // 
            this.tệpHiệnTạiToolStripMenuItem.Name = "tệpHiệnTạiToolStripMenuItem";
            this.tệpHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tệpHiệnTạiToolStripMenuItem.Text = "Tệp hiện tại";
            // 
            // tệpMớiToolStripMenuItem
            // 
            this.tệpMớiToolStripMenuItem.Name = "tệpMớiToolStripMenuItem";
            this.tệpMớiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tệpMớiToolStripMenuItem.Text = "Tệp mới";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
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
        private System.Windows.Forms.RadioButton rdVNtoEN;
        private System.Windows.Forms.RadioButton rdENtoVN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataItem;
        private System.Windows.Forms.ToolStripMenuItem showDataItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataItem;
        private System.Windows.Forms.ToolStripMenuItem tệpHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tệpMớiToolStripMenuItem;
    }
}

