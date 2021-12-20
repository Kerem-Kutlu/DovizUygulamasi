
using System;

namespace DövizUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.veriguncelleme = new System.Windows.Forms.Label();
            this.guncellemebasarili = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 36);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dolar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // veriguncelleme
            // 
            this.veriguncelleme.AutoSize = true;
            this.veriguncelleme.Location = new System.Drawing.Point(231, 191);
            this.veriguncelleme.Name = "veriguncelleme";
            this.veriguncelleme.Size = new System.Drawing.Size(453, 29);
            this.veriguncelleme.TabIndex = 4;
            this.veriguncelleme.Text = "Veriler güncelleniyor lütfen bekleyiniz...";
            this.veriguncelleme.Visible = false;
            // 
            // guncellemebasarili
            // 
            this.guncellemebasarili.AutoSize = true;
            this.guncellemebasarili.Location = new System.Drawing.Point(279, 191);
            this.guncellemebasarili.Name = "guncellemebasarili";
            this.guncellemebasarili.Size = new System.Drawing.Size(338, 29);
            this.guncellemebasarili.TabIndex = 5;
            this.guncellemebasarili.Text = "Veriler başarıyla güncellendi.";
            this.guncellemebasarili.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 404);
            this.Controls.Add(this.guncellemebasarili);
            this.Controls.Add(this.veriguncelleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label veriguncelleme;
        private System.Windows.Forms.Label guncellemebasarili;
    }
}

