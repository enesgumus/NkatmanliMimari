namespace NkatmanliMimari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.BTN_LISTELE = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gorev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(118, 177);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(300, 36);
            this.txt_id.TabIndex = 2;
            // 
            // BTN_LISTELE
            // 
            this.BTN_LISTELE.BackColor = System.Drawing.Color.Salmon;
            this.BTN_LISTELE.Location = new System.Drawing.Point(508, 177);
            this.BTN_LISTELE.Name = "BTN_LISTELE";
            this.BTN_LISTELE.Size = new System.Drawing.Size(156, 56);
            this.BTN_LISTELE.TabIndex = 3;
            this.BTN_LISTELE.Text = "LİSTELE";
            this.BTN_LISTELE.UseVisualStyleBackColor = false;
            this.BTN_LISTELE.Click += new System.EventHandler(this.BTN_LISTELE_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(118, 219);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(300, 36);
            this.txt_ad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(118, 261);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(300, 36);
            this.txt_soyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD:";
            // 
            // txt_sehir
            // 
            this.txt_sehir.Location = new System.Drawing.Point(118, 303);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(300, 36);
            this.txt_sehir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "ŞEHİR:";
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(118, 345);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(300, 36);
            this.txt_maas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "GÖREV:";
            // 
            // txt_gorev
            // 
            this.txt_gorev.Location = new System.Drawing.Point(118, 387);
            this.txt_gorev.Name = "txt_gorev";
            this.txt_gorev.Size = new System.Drawing.Size(300, 36);
            this.txt_gorev.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "MAAŞ:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1072, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 21);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Salmon;
            this.btn_ekle.Location = new System.Drawing.Point(508, 241);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(156, 56);
            this.btn_ekle.TabIndex = 15;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Salmon;
            this.btn_sil.Location = new System.Drawing.Point(508, 303);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(156, 56);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Salmon;
            this.btn_guncelle.Location = new System.Drawing.Point(508, 367);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(156, 56);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-2, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1019, 58);
            this.label7.TabIndex = 18;
            this.label7.Text = "N KATMANLI MİMARİ KULLANARAK PERSONEL PROJESİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 65);
            this.label8.TabIndex = 19;
            this.label8.Text = "OOP İLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 783);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_gorev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_LISTELE);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Personel Bilgi Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button BTN_LISTELE;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gorev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

