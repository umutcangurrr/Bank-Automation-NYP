namespace UB_Bank
{
    partial class Musteriİslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.paraCekDgv = new System.Windows.Forms.DataGridView();
            this.paraCekBtn = new System.Windows.Forms.Button();
            this.cekilecekTutarTxt = new System.Windows.Forms.MaskedTextBox();
            this.paraYatırTab = new System.Windows.Forms.TabPage();
            this.paraYatırBtn = new System.Windows.Forms.Button();
            this.paraYatırTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paraYatırDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.havaleYapTab = new System.Windows.Forms.TabPage();
            this.havaleBtn = new System.Windows.Forms.Button();
            this.havaleTutarTxt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.havaleHesapNoTxt = new System.Windows.Forms.MaskedTextBox();
            this.havaleDgv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.hesapOzetTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriTabCont.SuspendLayout();
            this.paraCekTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paraCekDgv)).BeginInit();
            this.paraYatırTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paraYatırDgv)).BeginInit();
            this.havaleYapTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaleDgv)).BeginInit();
            this.hesapOzetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriTabCont
            // 
            this.musteriTabCont.Controls.Add(this.paraCekTab);
            this.musteriTabCont.Controls.Add(this.paraYatırTab);
            this.musteriTabCont.Controls.Add(this.havaleYapTab);
            this.musteriTabCont.Controls.Add(this.hesapOzetTab);
            this.musteriTabCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriTabCont.Location = new System.Drawing.Point(3, 12);
            this.musteriTabCont.Name = "musteriTabCont";
            this.musteriTabCont.SelectedIndex = 0;
            this.musteriTabCont.Size = new System.Drawing.Size(795, 436);
            this.musteriTabCont.TabIndex = 0;
            // 
            // paraCekTab
            // 
            this.paraCekTab.Controls.Add(this.label2);
            this.paraCekTab.Controls.Add(this.label1);
            this.paraCekTab.Controls.Add(this.paraCekDgv);
            this.paraCekTab.Controls.Add(this.paraCekBtn);
            this.paraCekTab.Controls.Add(this.cekilecekTutarTxt);
            this.paraCekTab.Location = new System.Drawing.Point(4, 29);
            this.paraCekTab.Name = "paraCekTab";
            this.paraCekTab.Padding = new System.Windows.Forms.Padding(3);
            this.paraCekTab.Size = new System.Drawing.Size(787, 403);
            this.paraCekTab.TabIndex = 0;
            this.paraCekTab.Text = "Para Çek";
            this.paraCekTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çekilmek istenen tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bakiye:";
            // 
            // paraCekDgv
            // 
            this.paraCekDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paraCekDgv.Location = new System.Drawing.Point(120, 23);
            this.paraCekDgv.Name = "paraCekDgv";
            this.paraCekDgv.RowHeadersWidth = 51;
            this.paraCekDgv.RowTemplate.Height = 24;
            this.paraCekDgv.Size = new System.Drawing.Size(175, 34);
            this.paraCekDgv.TabIndex = 2;
            // 
            // paraCekBtn
            // 
            this.paraCekBtn.Location = new System.Drawing.Point(478, 95);
            this.paraCekBtn.Name = "paraCekBtn";
            this.paraCekBtn.Size = new System.Drawing.Size(105, 31);
            this.paraCekBtn.TabIndex = 1;
            this.paraCekBtn.Text = "Para Çek";
            this.paraCekBtn.UseVisualStyleBackColor = true;
            // 
            // cekilecekTutarTxt
            // 
            this.cekilecekTutarTxt.Location = new System.Drawing.Point(317, 100);
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
            this.paraYatırTab.Controls.Add(this.paraYatırDgv);
            this.paraYatırTab.Controls.Add(this.label3);
            this.paraYatırTab.Location = new System.Drawing.Point(4, 29);
            this.paraYatırTab.Name = "paraYatırTab";
            this.paraYatırTab.Padding = new System.Windows.Forms.Padding(3);
            this.paraYatırTab.Size = new System.Drawing.Size(787, 403);
            this.paraYatırTab.TabIndex = 1;
            this.paraYatırTab.Text = "Para Yatır";
            this.paraYatırTab.UseVisualStyleBackColor = true;
            // 
            // paraYatırBtn
            // 
            this.paraYatırBtn.Location = new System.Drawing.Point(519, 106);
            this.paraYatırBtn.Name = "paraYatırBtn";
            this.paraYatırBtn.Size = new System.Drawing.Size(105, 31);
            this.paraYatırBtn.TabIndex = 8;
            this.paraYatırBtn.Text = "Para Yatır";
            this.paraYatırBtn.UseVisualStyleBackColor = true;
            // 
            // paraYatırTxt
            // 
            this.paraYatırTxt.Location = new System.Drawing.Point(343, 106);
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
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yatırılmak istenen tutar";
            // 
            // paraYatırDgv
            // 
            this.paraYatırDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paraYatırDgv.Location = new System.Drawing.Point(127, 25);
            this.paraYatırDgv.Name = "paraYatırDgv";
            this.paraYatırDgv.RowHeadersWidth = 51;
            this.paraYatırDgv.RowTemplate.Height = 24;
            this.paraYatırDgv.Size = new System.Drawing.Size(175, 34);
            this.paraYatırDgv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bakiye:";
            // 
            // havaleYapTab
            // 
            this.havaleYapTab.Controls.Add(this.havaleBtn);
            this.havaleYapTab.Controls.Add(this.havaleTutarTxt);
            this.havaleYapTab.Controls.Add(this.label8);
            this.havaleYapTab.Controls.Add(this.label7);
            this.havaleYapTab.Controls.Add(this.havaleHesapNoTxt);
            this.havaleYapTab.Controls.Add(this.havaleDgv);
            this.havaleYapTab.Controls.Add(this.label5);
            this.havaleYapTab.Location = new System.Drawing.Point(4, 29);
            this.havaleYapTab.Name = "havaleYapTab";
            this.havaleYapTab.Padding = new System.Windows.Forms.Padding(3);
            this.havaleYapTab.Size = new System.Drawing.Size(787, 403);
            this.havaleYapTab.TabIndex = 2;
            this.havaleYapTab.Text = "Havale Yap";
            this.havaleYapTab.UseVisualStyleBackColor = true;
            // 
            // havaleBtn
            // 
            this.havaleBtn.Location = new System.Drawing.Point(481, 160);
            this.havaleBtn.Name = "havaleBtn";
            this.havaleBtn.Size = new System.Drawing.Size(105, 31);
            this.havaleBtn.TabIndex = 14;
            this.havaleBtn.Text = "Havale Et";
            this.havaleBtn.UseVisualStyleBackColor = true;
            // 
            // havaleTutarTxt
            // 
            this.havaleTutarTxt.Location = new System.Drawing.Point(346, 160);
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
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Havale edilmek istenen tutar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Havale Yapılacak Hesap Numarası";
            // 
            // havaleHesapNoTxt
            // 
            this.havaleHesapNoTxt.Location = new System.Drawing.Point(434, 92);
            this.havaleHesapNoTxt.Name = "havaleHesapNoTxt";
            this.havaleHesapNoTxt.Size = new System.Drawing.Size(175, 26);
            this.havaleHesapNoTxt.TabIndex = 8;
            // 
            // havaleDgv
            // 
            this.havaleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.havaleDgv.Location = new System.Drawing.Point(129, 33);
            this.havaleDgv.Name = "havaleDgv";
            this.havaleDgv.RowHeadersWidth = 51;
            this.havaleDgv.RowTemplate.Height = 24;
            this.havaleDgv.Size = new System.Drawing.Size(175, 34);
            this.havaleDgv.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bakiye:";
            // 
            // hesapOzetTab
            // 
            this.hesapOzetTab.Controls.Add(this.dataGridView1);
            this.hesapOzetTab.Location = new System.Drawing.Point(4, 29);
            this.hesapOzetTab.Name = "hesapOzetTab";
            this.hesapOzetTab.Padding = new System.Windows.Forms.Padding(3);
            this.hesapOzetTab.Size = new System.Drawing.Size(787, 403);
            this.hesapOzetTab.TabIndex = 3;
            this.hesapOzetTab.Text = "Hesap Özeti";
            this.hesapOzetTab.UseVisualStyleBackColor = true;
            this.hesapOzetTab.Click += new System.EventHandler(this.hesapOzetTab_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // Musteriİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 335);
            this.Controls.Add(this.musteriTabCont);
            this.Name = "Musteriİslem";
            this.Text = "Müşteri İşlem";
            this.musteriTabCont.ResumeLayout(false);
            this.paraCekTab.ResumeLayout(false);
            this.paraCekTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paraCekDgv)).EndInit();
            this.paraYatırTab.ResumeLayout(false);
            this.paraYatırTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paraYatırDgv)).EndInit();
            this.havaleYapTab.ResumeLayout(false);
            this.havaleYapTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaleDgv)).EndInit();
            this.hesapOzetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl musteriTabCont;
        private System.Windows.Forms.TabPage paraCekTab;
        private System.Windows.Forms.TabPage paraYatırTab;
        private System.Windows.Forms.TabPage havaleYapTab;
        private System.Windows.Forms.TabPage hesapOzetTab;
        private System.Windows.Forms.MaskedTextBox cekilecekTutarTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paraCekDgv;
        private System.Windows.Forms.Button paraCekBtn;
        private System.Windows.Forms.DataGridView paraYatırDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button paraYatırBtn;
        private System.Windows.Forms.MaskedTextBox paraYatırTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView havaleDgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button havaleBtn;
        private System.Windows.Forms.MaskedTextBox havaleTutarTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox havaleHesapNoTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}