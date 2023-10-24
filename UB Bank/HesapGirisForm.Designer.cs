namespace UB_Bank
{
    partial class HesapGirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.hesapGirisTxt = new System.Windows.Forms.MaskedTextBox();
            this.hesapGirisBtn = new System.Windows.Forms.Button();
            this.hesaplarDgw = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.hesapListeleyiciBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uBBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hesaplarDgw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen işlem yapmak istediğiniz hesap numarasını giriniz:";
            // 
            // hesapGirisTxt
            // 
            this.hesapGirisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapGirisTxt.Location = new System.Drawing.Point(549, 55);
            this.hesapGirisTxt.Name = "hesapGirisTxt";
            this.hesapGirisTxt.Size = new System.Drawing.Size(142, 26);
            this.hesapGirisTxt.TabIndex = 1;
            // 
            // hesapGirisBtn
            // 
            this.hesapGirisBtn.Location = new System.Drawing.Point(549, 123);
            this.hesapGirisBtn.Name = "hesapGirisBtn";
            this.hesapGirisBtn.Size = new System.Drawing.Size(142, 39);
            this.hesapGirisBtn.TabIndex = 2;
            this.hesapGirisBtn.Text = "Giriş";
            this.hesapGirisBtn.UseVisualStyleBackColor = true;
            this.hesapGirisBtn.Click += new System.EventHandler(this.hesapGirisBtn_Click);
            // 
            // hesaplarDgw
            // 
            this.hesaplarDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hesaplarDgw.Location = new System.Drawing.Point(38, 250);
            this.hesaplarDgw.Name = "hesaplarDgw";
            this.hesaplarDgw.RowHeadersWidth = 51;
            this.hesaplarDgw.RowTemplate.Height = 24;
            this.hesaplarDgw.Size = new System.Drawing.Size(493, 150);
            this.hesaplarDgw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hesaplarınız";
            // 
            // hesapListeleyiciBtn
            // 
            this.hesapListeleyiciBtn.Location = new System.Drawing.Point(53, 407);
            this.hesapListeleyiciBtn.Name = "hesapListeleyiciBtn";
            this.hesapListeleyiciBtn.Size = new System.Drawing.Size(75, 23);
            this.hesapListeleyiciBtn.TabIndex = 5;
            this.hesapListeleyiciBtn.Text = "Listele";
            this.hesapListeleyiciBtn.UseVisualStyleBackColor = true;
            this.hesapListeleyiciBtn.Click += new System.EventHandler(this.hesapListeleyiciBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uBBankToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uBBankToolStripMenuItem
            // 
            this.uBBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriToolStripMenuItem,
            this.bilgiToolStripMenuItem});
            this.uBBankToolStripMenuItem.Name = "uBBankToolStripMenuItem";
            this.uBBankToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.uBBankToolStripMenuItem.Text = "UB Bank";
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.geriToolStripMenuItem.Text = "Geri <--";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            // 
            // HesapGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hesapListeleyiciBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hesaplarDgw);
            this.Controls.Add(this.hesapGirisBtn);
            this.Controls.Add(this.hesapGirisTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HesapGirisForm";
            this.Text = "HesapGirisForm";
            ((System.ComponentModel.ISupportInitialize)(this.hesaplarDgw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox hesapGirisTxt;
        private System.Windows.Forms.Button hesapGirisBtn;
        private System.Windows.Forms.DataGridView hesaplarDgw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hesapListeleyiciBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uBBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
    }
}