namespace UB_Bank
{
    partial class HesapIslemForm
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
            this.musteriTabCont = new System.Windows.Forms.TabControl();
            this.paraCekTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.paraCekBtn = new System.Windows.Forms.Button();
            this.cekilecekTutarTxt = new System.Windows.Forms.MaskedTextBox();
            this.paraYatırTab = new System.Windows.Forms.TabPage();
            this.paraYatırBtn = new System.Windows.Forms.Button();
            this.paraYatırTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.havaleYapTab = new System.Windows.Forms.TabPage();
            this.havaleBtn = new System.Windows.Forms.Button();
            this.havaleTutarTxt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.havaleHesapNoTxt = new System.Windows.Forms.MaskedTextBox();
            this.hesapOzetTab = new System.Windows.Forms.TabPage();
            this.hesapOzetDgw = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uBBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.musteriTabCont.SuspendLayout();
            this.paraCekTab.SuspendLayout();
            this.paraYatırTab.SuspendLayout();
            this.havaleYapTab.SuspendLayout();
            this.hesapOzetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapOzetDgw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriTabCont
            // 
            this.musteriTabCont.Controls.Add(this.paraCekTab);
            this.musteriTabCont.Controls.Add(this.paraYatırTab);
            this.musteriTabCont.Controls.Add(this.havaleYapTab);
            this.musteriTabCont.Controls.Add(this.hesapOzetTab);
            this.musteriTabCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTabCont.Location = new System.Drawing.Point(12, 59);
            this.musteriTabCont.Name = "musteriTabCont";
            this.musteriTabCont.SelectedIndex = 0;
            this.musteriTabCont.Size = new System.Drawing.Size(666, 225);
            this.musteriTabCont.TabIndex = 0;
            // 
            // paraCekTab
            // 
            this.paraCekTab.Controls.Add(this.label2);
            this.paraCekTab.Controls.Add(this.paraCekBtn);
            this.paraCekTab.Controls.Add(this.cekilecekTutarTxt);
            this.paraCekTab.Location = new System.Drawing.Point(4, 29);
            this.paraCekTab.Name = "paraCekTab";
            this.paraCekTab.Padding = new System.Windows.Forms.Padding(3);
            this.paraCekTab.Size = new System.Drawing.Size(658, 232);
            this.paraCekTab.TabIndex = 0;
            this.paraCekTab.Text = "Para Çek";
            this.paraCekTab.UseVisualStyleBackColor = true;
            this.paraCekTab.Click += new System.EventHandler(this.paraCekTab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çekilmek istenen tutar:";
            // 
            // paraCekBtn
            // 
            this.paraCekBtn.Location = new System.Drawing.Point(498, 56);
            this.paraCekBtn.Name = "paraCekBtn";
            this.paraCekBtn.Size = new System.Drawing.Size(105, 31);
            this.paraCekBtn.TabIndex = 1;
            this.paraCekBtn.Text = "Para Çek";
            this.paraCekBtn.UseVisualStyleBackColor = true;
            this.paraCekBtn.Click += new System.EventHandler(this.paraCekBtn_Click);
            // 
            // cekilecekTutarTxt
            // 
            this.cekilecekTutarTxt.Location = new System.Drawing.Point(339, 61);
            this.cekilecekTutarTxt.Mask = "00000";
            this.cekilecekTutarTxt.Name = "cekilecekTutarTxt";
            this.cekilecekTutarTxt.Size = new System.Drawing.Size(100, 26);
            this.cekilecekTutarTxt.TabIndex = 0;
            this.cekilecekTutarTxt.ValidatingType = typeof(int);
            // 
            // paraYatırTab
            // 
            this.paraYatırTab.Controls.Add(this.paraYatırBtn);
            this.paraYatırTab.Controls.Add(this.paraYatırTxt);
            this.paraYatırTab.Controls.Add(this.label4);
            this.paraYatırTab.Location = new System.Drawing.Point(4, 29);
            this.paraYatırTab.Name = "paraYatırTab";
            this.paraYatırTab.Padding = new System.Windows.Forms.Padding(3);
            this.paraYatırTab.Size = new System.Drawing.Size(658, 232);
            this.paraYatırTab.TabIndex = 1;
            this.paraYatırTab.Text = "Para Yatır";
            this.paraYatırTab.UseVisualStyleBackColor = true;
            // 
            // paraYatırBtn
            // 
            this.paraYatırBtn.Location = new System.Drawing.Point(521, 55);
            this.paraYatırBtn.Name = "paraYatırBtn";
            this.paraYatırBtn.Size = new System.Drawing.Size(105, 31);
            this.paraYatırBtn.TabIndex = 8;
            this.paraYatırBtn.Text = "Para Yatır";
            this.paraYatırBtn.UseVisualStyleBackColor = true;
            this.paraYatırBtn.Click += new System.EventHandler(this.paraYatırBtn_Click);
            // 
            // paraYatırTxt
            // 
            this.paraYatırTxt.Location = new System.Drawing.Point(345, 55);
            this.paraYatırTxt.Mask = "00000";
            this.paraYatırTxt.Name = "paraYatırTxt";
            this.paraYatırTxt.Size = new System.Drawing.Size(100, 26);
            this.paraYatırTxt.TabIndex = 7;
            this.paraYatırTxt.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yatırılmak istenen tutar:";
            // 
            // havaleYapTab
            // 
            this.havaleYapTab.Controls.Add(this.havaleBtn);
            this.havaleYapTab.Controls.Add(this.havaleTutarTxt);
            this.havaleYapTab.Controls.Add(this.label8);
            this.havaleYapTab.Controls.Add(this.label7);
            this.havaleYapTab.Controls.Add(this.havaleHesapNoTxt);
            this.havaleYapTab.Location = new System.Drawing.Point(4, 29);
            this.havaleYapTab.Name = "havaleYapTab";
            this.havaleYapTab.Padding = new System.Windows.Forms.Padding(3);
            this.havaleYapTab.Size = new System.Drawing.Size(658, 232);
            this.havaleYapTab.TabIndex = 2;
            this.havaleYapTab.Text = "Havale Yap";
            this.havaleYapTab.UseVisualStyleBackColor = true;
            // 
            // havaleBtn
            // 
            this.havaleBtn.Location = new System.Drawing.Point(481, 111);
            this.havaleBtn.Name = "havaleBtn";
            this.havaleBtn.Size = new System.Drawing.Size(105, 31);
            this.havaleBtn.TabIndex = 14;
            this.havaleBtn.Text = "Havale Et";
            this.havaleBtn.UseVisualStyleBackColor = true;
            this.havaleBtn.Click += new System.EventHandler(this.havaleBtn_Click);
            // 
            // havaleTutarTxt
            // 
            this.havaleTutarTxt.Location = new System.Drawing.Point(346, 111);
            this.havaleTutarTxt.Mask = "00000";
            this.havaleTutarTxt.Name = "havaleTutarTxt";
            this.havaleTutarTxt.Size = new System.Drawing.Size(100, 26);
            this.havaleTutarTxt.TabIndex = 13;
            this.havaleTutarTxt.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Havale edilmek istenen tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Havale yapılacak hesap numarası:";
            // 
            // havaleHesapNoTxt
            // 
            this.havaleHesapNoTxt.Location = new System.Drawing.Point(434, 43);
            this.havaleHesapNoTxt.Name = "havaleHesapNoTxt";
            this.havaleHesapNoTxt.Size = new System.Drawing.Size(175, 26);
            this.havaleHesapNoTxt.TabIndex = 8;
            // 
            // hesapOzetTab
            // 
            this.hesapOzetTab.Controls.Add(this.hesapOzetDgw);
            this.hesapOzetTab.Location = new System.Drawing.Point(4, 29);
            this.hesapOzetTab.Name = "hesapOzetTab";
            this.hesapOzetTab.Padding = new System.Windows.Forms.Padding(3);
            this.hesapOzetTab.Size = new System.Drawing.Size(658, 192);
            this.hesapOzetTab.TabIndex = 3;
            this.hesapOzetTab.Text = "Hesap Özeti";
            this.hesapOzetTab.UseVisualStyleBackColor = true;
            this.hesapOzetTab.Click += new System.EventHandler(this.hesapOzetTab_Click);
            // 
            // hesapOzetDgw
            // 
            this.hesapOzetDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hesapOzetDgw.Location = new System.Drawing.Point(7, 7);
            this.hesapOzetDgw.Name = "hesapOzetDgw";
            this.hesapOzetDgw.RowHeadersWidth = 51;
            this.hesapOzetDgw.RowTemplate.Height = 24;
            this.hesapOzetDgw.Size = new System.Drawing.Size(645, 179);
            this.hesapOzetDgw.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uBBankToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.uBBankToolStripMenuItem.Click += new System.EventHandler(this.uBBankToolStripMenuItem_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Özeti Çıkar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HesapIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musteriTabCont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HesapIslemForm";
            this.Text = "Hesap İşlem";
            this.musteriTabCont.ResumeLayout(false);
            this.paraCekTab.ResumeLayout(false);
            this.paraCekTab.PerformLayout();
            this.paraYatırTab.ResumeLayout(false);
            this.paraYatırTab.PerformLayout();
            this.havaleYapTab.ResumeLayout(false);
            this.havaleYapTab.PerformLayout();
            this.hesapOzetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hesapOzetDgw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl musteriTabCont;
        private System.Windows.Forms.TabPage paraCekTab;
        private System.Windows.Forms.TabPage paraYatırTab;
        private System.Windows.Forms.TabPage havaleYapTab;
        private System.Windows.Forms.TabPage hesapOzetTab;
        private System.Windows.Forms.MaskedTextBox cekilecekTutarTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paraCekBtn;
        private System.Windows.Forms.Button paraYatırBtn;
        private System.Windows.Forms.MaskedTextBox paraYatırTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button havaleBtn;
        private System.Windows.Forms.MaskedTextBox havaleTutarTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox havaleHesapNoTxt;
        private System.Windows.Forms.DataGridView hesapOzetDgw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uBBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}