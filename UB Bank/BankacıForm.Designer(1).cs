namespace UB_Bank
{
    partial class BankacıForm
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
            this.bankacıSifreBtn = new System.Windows.Forms.Button();
            this.Lable = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.sifreKontrolTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bankacıSifreBtn
            // 
            this.bankacıSifreBtn.Location = new System.Drawing.Point(717, 160);
            this.bankacıSifreBtn.Name = "bankacıSifreBtn";
            this.bankacıSifreBtn.Size = new System.Drawing.Size(152, 31);
            this.bankacıSifreBtn.TabIndex = 1;
            this.bankacıSifreBtn.Text = "Giriş";
            this.bankacıSifreBtn.UseVisualStyleBackColor = true;
            this.bankacıSifreBtn.Click += new System.EventHandler(this.bankacıSifreBtn_Click);
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.BackColor = System.Drawing.Color.White;
            this.Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lable.Location = new System.Drawing.Point(12, 54);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(570, 25);
            this.Lable.TabIndex = 4;
            this.Lable.Text = "Lütfen admin paneline giriş yapmanızı sağlayacak şifrenizi giriniz.\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(760, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sifreKontrolTxt
            // 
            this.sifreKontrolTxt.Location = new System.Drawing.Point(727, 54);
            this.sifreKontrolTxt.Multiline = true;
            this.sifreKontrolTxt.Name = "sifreKontrolTxt";
            this.sifreKontrolTxt.PasswordChar = '*';
            this.sifreKontrolTxt.Size = new System.Drawing.Size(142, 25);
            this.sifreKontrolTxt.TabIndex = 7;
            // 
            // BankacıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(922, 272);
            this.Controls.Add(this.sifreKontrolTxt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.bankacıSifreBtn);
            this.Name = "BankacıForm";
            this.Text = "Bankacı Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bankacıSifreBtn;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox sifreKontrolTxt;
    }
}