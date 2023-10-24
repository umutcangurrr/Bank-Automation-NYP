namespace UB_Bank
{
    partial class Bankacıİslem
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
            this.bankacıTabCont = new System.Windows.Forms.TabControl();
            this.müsteriEklemeTab = new System.Windows.Forms.TabPage();
            this.bireyselMüşteriEkleBtn = new System.Windows.Forms.Button();
            this.ticariMusteriEkleBtn = new System.Windows.Forms.Button();
            this.musteriTcEkleTxt = new System.Windows.Forms.MaskedTextBox();
            this.musteriAdSoyadEkleTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapActırmaTab = new System.Windows.Forms.TabPage();
            this.hesapEkleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriNoKontrolTxt = new System.Windows.Forms.MaskedTextBox();
            this.hesapKapamaTab = new System.Windows.Forms.TabPage();
            this.hesapKapamaBtn = new System.Windows.Forms.Button();
            this.hesapKapamaTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bankaRaporTab = new System.Windows.Forms.TabPage();
            this.bankaGelirGiderBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaGelirTxt = new System.Windows.Forms.TextBox();
            this.toplamBakiyeTxt = new System.Windows.Forms.TextBox();
            this.bankaGiderTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bankacıTabCont.SuspendLayout();
            this.müsteriEklemeTab.SuspendLayout();
            this.hesapActırmaTab.SuspendLayout();
            this.hesapKapamaTab.SuspendLayout();
            this.bankaRaporTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankacıTabCont
            // 
            this.bankacıTabCont.Controls.Add(this.müsteriEklemeTab);
            this.bankacıTabCont.Controls.Add(this.hesapActırmaTab);
            this.bankacıTabCont.Controls.Add(this.hesapKapamaTab);
            this.bankacıTabCont.Controls.Add(this.bankaRaporTab);
            this.bankacıTabCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bankacıTabCont.Location = new System.Drawing.Point(0, 31);
            this.bankacıTabCont.Name = "bankacıTabCont";
            this.bankacıTabCont.SelectedIndex = 0;
            this.bankacıTabCont.Size = new System.Drawing.Size(801, 434);
            this.bankacıTabCont.TabIndex = 0;
            // 
            // müsteriEklemeTab
            // 
            this.müsteriEklemeTab.Controls.Add(this.bireyselMüşteriEkleBtn);
            this.müsteriEklemeTab.Controls.Add(this.ticariMusteriEkleBtn);
            this.müsteriEklemeTab.Controls.Add(this.musteriTcEkleTxt);
            this.müsteriEklemeTab.Controls.Add(this.musteriAdSoyadEkleTxt);
            this.müsteriEklemeTab.Controls.Add(this.label2);
            this.müsteriEklemeTab.Controls.Add(this.label1);
            this.müsteriEklemeTab.Location = new System.Drawing.Point(4, 29);
            this.müsteriEklemeTab.Name = "müsteriEklemeTab";
            this.müsteriEklemeTab.Padding = new System.Windows.Forms.Padding(3);
            this.müsteriEklemeTab.Size = new System.Drawing.Size(793, 401);
            this.müsteriEklemeTab.TabIndex = 0;
            this.müsteriEklemeTab.Text = "Müşteri Ekleme";
            this.müsteriEklemeTab.UseVisualStyleBackColor = true;
            this.müsteriEklemeTab.Click += new System.EventHandler(this.müsteriEklemeTab_Click);
            // 
            // bireyselMüşteriEkleBtn
            // 
            this.bireyselMüşteriEkleBtn.Location = new System.Drawing.Point(79, 186);
            this.bireyselMüşteriEkleBtn.Name = "bireyselMüşteriEkleBtn";
            this.bireyselMüşteriEkleBtn.Size = new System.Drawing.Size(232, 43);
            this.bireyselMüşteriEkleBtn.TabIndex = 6;
            this.bireyselMüşteriEkleBtn.Text = "Bireysel Müşteri Ekle";
            this.bireyselMüşteriEkleBtn.UseVisualStyleBackColor = true;
            this.bireyselMüşteriEkleBtn.Click += new System.EventHandler(this.bireyselMüşteriEkleBtn_Click);
            // 
            // ticariMusteriEkleBtn
            // 
            this.ticariMusteriEkleBtn.Location = new System.Drawing.Point(422, 186);
            this.ticariMusteriEkleBtn.Name = "ticariMusteriEkleBtn";
            this.ticariMusteriEkleBtn.Size = new System.Drawing.Size(225, 44);
            this.ticariMusteriEkleBtn.TabIndex = 5;
            this.ticariMusteriEkleBtn.Text = "Ticari Müşteri Ekle";
            this.ticariMusteriEkleBtn.UseVisualStyleBackColor = true;
            this.ticariMusteriEkleBtn.Click += new System.EventHandler(this.ticariMusteriEkleBtn_Click);
            // 
            // musteriTcEkleTxt
            // 
            this.musteriTcEkleTxt.Location = new System.Drawing.Point(227, 87);
            this.musteriTcEkleTxt.Name = "musteriTcEkleTxt";
            this.musteriTcEkleTxt.Size = new System.Drawing.Size(149, 26);
            this.musteriTcEkleTxt.TabIndex = 3;
            // 
            // musteriAdSoyadEkleTxt
            // 
            this.musteriAdSoyadEkleTxt.Location = new System.Drawing.Point(227, 41);
            this.musteriAdSoyadEkleTxt.Name = "musteriAdSoyadEkleTxt";
            this.musteriAdSoyadEkleTxt.Size = new System.Drawing.Size(149, 26);
            this.musteriAdSoyadEkleTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C Kimlik No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // hesapActırmaTab
            // 
            this.hesapActırmaTab.Controls.Add(this.hesapEkleBtn);
            this.hesapActırmaTab.Controls.Add(this.label5);
            this.hesapActırmaTab.Controls.Add(this.musteriNoKontrolTxt);
            this.hesapActırmaTab.Location = new System.Drawing.Point(4, 29);
            this.hesapActırmaTab.Name = "hesapActırmaTab";
            this.hesapActırmaTab.Padding = new System.Windows.Forms.Padding(3);
            this.hesapActırmaTab.Size = new System.Drawing.Size(793, 401);
            this.hesapActırmaTab.TabIndex = 1;
            this.hesapActırmaTab.Text = "Hesap Açtırma";
            this.hesapActırmaTab.UseVisualStyleBackColor = true;
            // 
            // hesapEkleBtn
            // 
            this.hesapEkleBtn.Location = new System.Drawing.Point(69, 148);
            this.hesapEkleBtn.Name = "hesapEkleBtn";
            this.hesapEkleBtn.Size = new System.Drawing.Size(265, 50);
            this.hesapEkleBtn.TabIndex = 9;
            this.hesapEkleBtn.Text = "Hesap Ekle";
            this.hesapEkleBtn.UseVisualStyleBackColor = true;
            this.hesapEkleBtn.Click += new System.EventHandler(this.hesapEkleBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri No:";
            // 
            // musteriNoKontrolTxt
            // 
            this.musteriNoKontrolTxt.Location = new System.Drawing.Point(185, 48);
            this.musteriNoKontrolTxt.Name = "musteriNoKontrolTxt";
            this.musteriNoKontrolTxt.Size = new System.Drawing.Size(149, 26);
            this.musteriNoKontrolTxt.TabIndex = 5;
            // 
            // hesapKapamaTab
            // 
            this.hesapKapamaTab.Controls.Add(this.hesapKapamaBtn);
            this.hesapKapamaTab.Controls.Add(this.hesapKapamaTxt);
            this.hesapKapamaTab.Controls.Add(this.label4);
            this.hesapKapamaTab.Location = new System.Drawing.Point(4, 29);
            this.hesapKapamaTab.Name = "hesapKapamaTab";
            this.hesapKapamaTab.Padding = new System.Windows.Forms.Padding(3);
            this.hesapKapamaTab.Size = new System.Drawing.Size(793, 401);
            this.hesapKapamaTab.TabIndex = 2;
            this.hesapKapamaTab.Text = "Hesap Kapama";
            this.hesapKapamaTab.UseVisualStyleBackColor = true;
            // 
            // hesapKapamaBtn
            // 
            this.hesapKapamaBtn.Location = new System.Drawing.Point(254, 209);
            this.hesapKapamaBtn.Name = "hesapKapamaBtn";
            this.hesapKapamaBtn.Size = new System.Drawing.Size(194, 40);
            this.hesapKapamaBtn.TabIndex = 7;
            this.hesapKapamaBtn.Text = "Hesabı Kapat";
            this.hesapKapamaBtn.UseVisualStyleBackColor = true;
            this.hesapKapamaBtn.Click += new System.EventHandler(this.hesapKapamaBtn_Click);
            // 
            // hesapKapamaTxt
            // 
            this.hesapKapamaTxt.Location = new System.Drawing.Point(299, 64);
            this.hesapKapamaTxt.Name = "hesapKapamaTxt";
            this.hesapKapamaTxt.Size = new System.Drawing.Size(149, 26);
            this.hesapKapamaTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kapatılacak Hesabın No";
            // 
            // bankaRaporTab
            // 
            this.bankaRaporTab.Controls.Add(this.label7);
            this.bankaRaporTab.Controls.Add(this.label6);
            this.bankaRaporTab.Controls.Add(this.label3);
            this.bankaRaporTab.Controls.Add(this.bankaGiderTxt);
            this.bankaRaporTab.Controls.Add(this.toplamBakiyeTxt);
            this.bankaRaporTab.Controls.Add(this.bankaGelirTxt);
            this.bankaRaporTab.Controls.Add(this.bankaGelirGiderBtn);
            this.bankaRaporTab.Location = new System.Drawing.Point(4, 29);
            this.bankaRaporTab.Name = "bankaRaporTab";
            this.bankaRaporTab.Padding = new System.Windows.Forms.Padding(3);
            this.bankaRaporTab.Size = new System.Drawing.Size(793, 401);
            this.bankaRaporTab.TabIndex = 3;
            this.bankaRaporTab.Text = "Banka Gelir/Gider Raporu";
            this.bankaRaporTab.UseVisualStyleBackColor = true;
            // 
            // bankaGelirGiderBtn
            // 
            this.bankaGelirGiderBtn.Location = new System.Drawing.Point(7, 286);
            this.bankaGelirGiderBtn.Name = "bankaGelirGiderBtn";
            this.bankaGelirGiderBtn.Size = new System.Drawing.Size(98, 30);
            this.bankaGelirGiderBtn.TabIndex = 1;
            this.bankaGelirGiderBtn.Text = "Göster";
            this.bankaGelirGiderBtn.UseVisualStyleBackColor = true;
            this.bankaGelirGiderBtn.Click += new System.EventHandler(this.bankaGelirGiderBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgiToolStripMenuItem,
            this.bilgiToolStripMenuItem1});
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.geriToolStripMenuItem.Text = "UB Bank";
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.bilgiToolStripMenuItem.Text = "Geri <--";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.bilgiToolStripMenuItem_Click);
            // 
            // bilgiToolStripMenuItem1
            // 
            this.bilgiToolStripMenuItem1.Name = "bilgiToolStripMenuItem1";
            this.bilgiToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.bilgiToolStripMenuItem1.Text = "Bilgi";
            // 
            // bankaGelirTxt
            // 
            this.bankaGelirTxt.Location = new System.Drawing.Point(153, 50);
            this.bankaGelirTxt.Multiline = true;
            this.bankaGelirTxt.Name = "bankaGelirTxt";
            this.bankaGelirTxt.Size = new System.Drawing.Size(176, 22);
            this.bankaGelirTxt.TabIndex = 2;
            // 
            // toplamBakiyeTxt
            // 
            this.toplamBakiyeTxt.Location = new System.Drawing.Point(153, 188);
            this.toplamBakiyeTxt.Multiline = true;
            this.toplamBakiyeTxt.Name = "toplamBakiyeTxt";
            this.toplamBakiyeTxt.Size = new System.Drawing.Size(176, 26);
            this.toplamBakiyeTxt.TabIndex = 3;
            // 
            // bankaGiderTxt
            // 
            this.bankaGiderTxt.Location = new System.Drawing.Point(153, 116);
            this.bankaGiderTxt.Multiline = true;
            this.bankaGiderTxt.Name = "bankaGiderTxt";
            this.bankaGiderTxt.Size = new System.Drawing.Size(176, 26);
            this.bankaGiderTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Banka Gelir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Banka Gider";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toplam Bakiye";
            // 
            // Bankacıİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.bankacıTabCont);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bankacıİslem";
            this.Text = "Bankacı İşlem";
            this.bankacıTabCont.ResumeLayout(false);
            this.müsteriEklemeTab.ResumeLayout(false);
            this.müsteriEklemeTab.PerformLayout();
            this.hesapActırmaTab.ResumeLayout(false);
            this.hesapActırmaTab.PerformLayout();
            this.hesapKapamaTab.ResumeLayout(false);
            this.hesapKapamaTab.PerformLayout();
            this.bankaRaporTab.ResumeLayout(false);
            this.bankaRaporTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl bankacıTabCont;
        private System.Windows.Forms.TabPage müsteriEklemeTab;
        private System.Windows.Forms.TabPage hesapActırmaTab;
        private System.Windows.Forms.TabPage hesapKapamaTab;
        private System.Windows.Forms.TabPage bankaRaporTab;
        private System.Windows.Forms.Button ticariMusteriEkleBtn;
        private System.Windows.Forms.MaskedTextBox musteriTcEkleTxt;
        private System.Windows.Forms.MaskedTextBox musteriAdSoyadEkleTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox hesapKapamaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hesapKapamaBtn;
        private System.Windows.Forms.Button bireyselMüşteriEkleBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hesapEkleBtn;
        private System.Windows.Forms.MaskedTextBox musteriNoKontrolTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem1;
        private System.Windows.Forms.Button bankaGelirGiderBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bankaGiderTxt;
        private System.Windows.Forms.TextBox toplamBakiyeTxt;
        private System.Windows.Forms.TextBox bankaGelirTxt;
    }
}