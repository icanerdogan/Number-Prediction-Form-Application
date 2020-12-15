namespace TahminApp
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
            this.ustAralik = new System.Windows.Forms.TextBox();
            this.altAralik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tahmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.sonTahmin = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.tahminDestek = new System.Windows.Forms.Label();
            this.sayiBelirle = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustAralik
            // 
            this.ustAralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.ustAralik.Location = new System.Drawing.Point(22, 89);
            this.ustAralik.Name = "ustAralik";
            this.ustAralik.Size = new System.Drawing.Size(185, 34);
            this.ustAralik.TabIndex = 0;
            // 
            // altAralik
            // 
            this.altAralik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.altAralik.Location = new System.Drawing.Point(22, 171);
            this.altAralik.Name = "altAralik";
            this.altAralik.Size = new System.Drawing.Size(185, 34);
            this.altAralik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üst Aralık Değeri";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alt Aralık Değeri";
            // 
            // tahmin
            // 
            this.tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.tahmin.Location = new System.Drawing.Point(111, 90);
            this.tahmin.Name = "tahmin";
            this.tahmin.Size = new System.Drawing.Size(228, 38);
            this.tahmin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label3.Location = new System.Drawing.Point(177, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tahmin";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btn.Location = new System.Drawing.Point(177, 145);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 46);
            this.btn.TabIndex = 7;
            this.btn.Text = "Tahmin";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // sonTahmin
            // 
            this.sonTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.sonTahmin.Location = new System.Drawing.Point(3, 305);
            this.sonTahmin.Name = "sonTahmin";
            this.sonTahmin.Size = new System.Drawing.Size(454, 62);
            this.sonTahmin.TabIndex = 8;
            this.sonTahmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.tahminDestek);
            this.pnl.Controls.Add(this.sonTahmin);
            this.pnl.Controls.Add(this.btn);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.tahmin);
            this.pnl.Location = new System.Drawing.Point(239, -1);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(457, 403);
            this.pnl.TabIndex = 8;
            // 
            // tahminDestek
            // 
            this.tahminDestek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.tahminDestek.Location = new System.Drawing.Point(3, 244);
            this.tahminDestek.Name = "tahminDestek";
            this.tahminDestek.Size = new System.Drawing.Size(454, 47);
            this.tahminDestek.TabIndex = 9;
            this.tahminDestek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sayiBelirle
            // 
            this.sayiBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.sayiBelirle.Location = new System.Drawing.Point(22, 233);
            this.sayiBelirle.Name = "sayiBelirle";
            this.sayiBelirle.Size = new System.Drawing.Size(124, 46);
            this.sayiBelirle.TabIndex = 9;
            this.sayiBelirle.Text = "Sayı Belirle";
            this.sayiBelirle.UseVisualStyleBackColor = true;
            this.sayiBelirle.Click += new System.EventHandler(this.sayiBelirle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 402);
            this.Controls.Add(this.sayiBelirle);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altAralik);
            this.Controls.Add(this.ustAralik);
            this.Name = "Form1";
            this.Text = "Number Prediction Application";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox altAralik;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button sayiBelirle;
        private System.Windows.Forms.Label sonTahmin;
        private System.Windows.Forms.TextBox tahmin;
        private System.Windows.Forms.Label tahminDestek;
        private System.Windows.Forms.TextBox ustAralik;

        #endregion
    }
}