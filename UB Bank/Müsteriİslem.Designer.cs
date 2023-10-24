namespace UB_Bank
{
    partial class MusteriForm
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
            this.hesapNumGrBtn = new System.Windows.Forms.Button();
            this.hesapNumGirisBtn = new System.Windows.Forms.TextBox();
            this.Lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapNumGrBtn
            // 
            this.hesapNumGrBtn.Location = new System.Drawing.Point(571, 119);
            this.hesapNumGrBtn.Name = "hesapNumGrBtn";
            this.hesapNumGrBtn.Size = new System.Drawing.Size(152, 31);
            this.hesapNumGrBtn.TabIndex = 0;
            this.hesapNumGrBtn.Text = "button1";
            this.hesapNumGrBtn.UseVisualStyleBackColor = true;
            this.hesapNumGrBtn.Click += new System.EventHandler(this.hesapNumGrBtn_Click);
            // 
            // hesapNumGirisBtn
            // 
            this.hesapNumGirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapNumGirisBtn.Location = new System.Drawing.Point(571, 60);
            this.hesapNumGirisBtn.Name = "hesapNumGirisBtn";
            this.hesapNumGirisBtn.Size = new System.Drawing.Size(152, 26);
            this.hesapNumGirisBtn.TabIndex = 1;
            this.hesapNumGirisBtn.TextChanged += new System.EventHandler(this.hesapNumGirisBtn_TextChanged);
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lable.Location = new System.Drawing.Point(12, 60);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(509, 25);
            this.Lable.TabIndex = 2;
            this.Lable.Text = "Lütfen İşlem Yapmak İstediğiniz Hesap Numarasını Giriniz";
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.hesapNumGirisBtn);
            this.Controls.Add(this.hesapNumGrBtn);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapNumGrBtn;
        private System.Windows.Forms.TextBox hesapNumGirisBtn;
        private System.Windows.Forms.Label Lable;
    }
}