namespace UB_Bank
{
    partial class girişForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.musteriGirisBtn = new System.Windows.Forms.Button();
            this.bankacıGirisBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 131);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "UB Bank\'a Hoşgeldiniz";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.musteriGirisBtn);
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 316);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(415, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 316);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.bankacıGirisBtn);
            this.panel4.Location = new System.Drawing.Point(410, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 316);
            this.panel4.TabIndex = 5;
            // 
            // musteriGirisBtn
            // 
            this.musteriGirisBtn.BackColor = System.Drawing.Color.Teal;
            this.musteriGirisBtn.Location = new System.Drawing.Point(102, 98);
            this.musteriGirisBtn.Name = "musteriGirisBtn";
            this.musteriGirisBtn.Size = new System.Drawing.Size(193, 62);
            this.musteriGirisBtn.TabIndex = 0;
            this.musteriGirisBtn.Text = "Müşteri Giriş";
            this.musteriGirisBtn.UseVisualStyleBackColor = false;
            this.musteriGirisBtn.Click += new System.EventHandler(this.musteriGirisBtn_Click);
            // 
            // bankacıGirisBtn
            // 
            this.bankacıGirisBtn.BackColor = System.Drawing.Color.Green;
            this.bankacıGirisBtn.Location = new System.Drawing.Point(109, 98);
            this.bankacıGirisBtn.Name = "bankacıGirisBtn";
            this.bankacıGirisBtn.Size = new System.Drawing.Size(193, 62);
            this.bankacıGirisBtn.TabIndex = 1;
            this.bankacıGirisBtn.Text = "Bankacı Giriş";
            this.bankacıGirisBtn.UseVisualStyleBackColor = false;
            this.bankacıGirisBtn.Click += new System.EventHandler(this.bankacıGirisBtn_Click);
            // 
            // girişForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "girişForm";
            this.Text = "UB Bank Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button musteriGirisBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bankacıGirisBtn;
    }
}

