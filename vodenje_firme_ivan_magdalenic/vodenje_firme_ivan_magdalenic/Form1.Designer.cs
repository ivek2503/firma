namespace vodenje_firme_ivan_magdalenic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            odabir_firme = new ComboBox();
            dodaj_firmu = new TextBox();
            btn_dodaj_firmu = new Button();
            groupBox1 = new GroupBox();
            odlazak_kraj = new DateTimePicker();
            odlazak_start = new DateTimePicker();
            dolazak_kraj = new DateTimePicker();
            dolazak_start = new DateTimePicker();
            id_firme = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelica = new Label();
            groupBox2 = new GroupBox();
            firma = new ComboBox();
            dodaj_radnika = new Button();
            label10 = new Label();
            ime = new TextBox();
            label9 = new Label();
            prezime = new TextBox();
            label8 = new Label();
            OIB = new TextBox();
            odabir_radnika = new ComboBox();
            dolazak = new Button();
            odlazak = new Button();
            nedovoljni = new Button();
            groupBox3 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            kasnili = new Button();
            labelTrenutnoVrijeme = new Label();
            button1 = new Button();
            label11 = new Label();
            label14 = new Label();
            button2 = new Button();
            label15 = new Label();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // odabir_firme
            // 
            odabir_firme.FormattingEnabled = true;
            odabir_firme.Location = new Point(15, 42);
            odabir_firme.Name = "odabir_firme";
            odabir_firme.Size = new Size(312, 28);
            odabir_firme.TabIndex = 0;
            odabir_firme.SelectedIndexChanged += odabir_firme_SelectedIndexChanged;
            // 
            // dodaj_firmu
            // 
            dodaj_firmu.Location = new Point(200, 37);
            dodaj_firmu.Name = "dodaj_firmu";
            dodaj_firmu.Size = new Size(151, 27);
            dodaj_firmu.TabIndex = 1;
            // 
            // btn_dodaj_firmu
            // 
            btn_dodaj_firmu.Location = new Point(107, 209);
            btn_dodaj_firmu.Name = "btn_dodaj_firmu";
            btn_dodaj_firmu.Size = new Size(151, 29);
            btn_dodaj_firmu.TabIndex = 2;
            btn_dodaj_firmu.Text = "DODAJ FIRMU";
            btn_dodaj_firmu.UseVisualStyleBackColor = true;
            btn_dodaj_firmu.Click += btn_dodaj_firmu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(odlazak_kraj);
            groupBox1.Controls.Add(odlazak_start);
            groupBox1.Controls.Add(dolazak_kraj);
            groupBox1.Controls.Add(dolazak_start);
            groupBox1.Controls.Add(id_firme);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dodaj_firmu);
            groupBox1.Controls.Add(btn_dodaj_firmu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labelica);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 273);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "FIRMA";
            // 
            // odlazak_kraj
            // 
            odlazak_kraj.Location = new Point(200, 162);
            odlazak_kraj.Name = "odlazak_kraj";
            odlazak_kraj.Size = new Size(156, 27);
            odlazak_kraj.TabIndex = 29;
            // 
            // odlazak_start
            // 
            odlazak_start.Location = new Point(6, 162);
            odlazak_start.Name = "odlazak_start";
            odlazak_start.Size = new Size(156, 27);
            odlazak_start.TabIndex = 28;
            // 
            // dolazak_kraj
            // 
            dolazak_kraj.Location = new Point(200, 99);
            dolazak_kraj.Name = "dolazak_kraj";
            dolazak_kraj.Size = new Size(156, 27);
            dolazak_kraj.TabIndex = 27;
            // 
            // dolazak_start
            // 
            dolazak_start.Location = new Point(6, 99);
            dolazak_start.Name = "dolazak_start";
            dolazak_start.Size = new Size(156, 27);
            dolazak_start.TabIndex = 26;
            // 
            // id_firme
            // 
            id_firme.Location = new Point(16, 38);
            id_firme.MaxLength = 3;
            id_firme.Name = "id_firme";
            id_firme.Size = new Size(151, 27);
            id_firme.TabIndex = 24;
            id_firme.KeyPress += id_firme_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 164);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 21;
            label4.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(119, 139);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 20;
            label5.Text = "vrijeme odlaska";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 101);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 13;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(119, 76);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 12;
            label2.Text = "vrijeme doalska";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(200, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "NAZIV FIRME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 119);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 22;
            label6.Text = "_______________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 56);
            label7.Name = "label7";
            label7.Size = new Size(231, 20);
            label7.TabIndex = 23;
            label7.Text = "_____________________________________";
            // 
            // labelica
            // 
            labelica.AutoSize = true;
            labelica.BackColor = Color.Transparent;
            labelica.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelica.Location = new Point(16, 15);
            labelica.Name = "labelica";
            labelica.Size = new Size(74, 20);
            labelica.TabIndex = 25;
            labelica.Text = "ID FIRME";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(firma);
            groupBox2.Controls.Add(dodaj_radnika);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(ime);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(prezime);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(OIB);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 241);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "RADNICI";
            // 
            // firma
            // 
            firma.FormattingEnabled = true;
            firma.Location = new Point(16, 29);
            firma.Name = "firma";
            firma.Size = new Size(151, 28);
            firma.TabIndex = 35;
            // 
            // dodaj_radnika
            // 
            dodaj_radnika.Location = new Point(195, 80);
            dodaj_radnika.Name = "dodaj_radnika";
            dodaj_radnika.Size = new Size(128, 76);
            dodaj_radnika.TabIndex = 6;
            dodaj_radnika.Text = "DODAJ RADNIKA";
            dodaj_radnika.UseVisualStyleBackColor = true;
            dodaj_radnika.Click += dodaj_radnika_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(16, 182);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 5;
            label10.Text = "PREZIME";
            // 
            // ime
            // 
            ime.Location = new Point(16, 143);
            ime.MaxLength = 11;
            ime.Name = "ime";
            ime.Size = new Size(151, 27);
            ime.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(16, 120);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 4;
            label9.Text = "IME";
            // 
            // prezime
            // 
            prezime.Location = new Point(16, 205);
            prezime.MaxLength = 11;
            prezime.Name = "prezime";
            prezime.Size = new Size(151, 27);
            prezime.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(16, 60);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 1;
            label8.Text = "OIB";
            // 
            // OIB
            // 
            OIB.Location = new Point(16, 83);
            OIB.MaxLength = 9;
            OIB.Name = "OIB";
            OIB.Size = new Size(151, 27);
            OIB.TabIndex = 0;
            OIB.KeyPress += OIB_KeyPress;
            // 
            // odabir_radnika
            // 
            odabir_radnika.FormattingEnabled = true;
            odabir_radnika.Location = new Point(433, 332);
            odabir_radnika.Name = "odabir_radnika";
            odabir_radnika.Size = new Size(312, 28);
            odabir_radnika.TabIndex = 24;
            // 
            // dolazak
            // 
            dolazak.Location = new Point(44, 147);
            dolazak.Name = "dolazak";
            dolazak.Size = new Size(256, 75);
            dolazak.TabIndex = 29;
            dolazak.Text = "DOLAZAK";
            dolazak.UseVisualStyleBackColor = true;
            dolazak.Click += dolazak_Click;
            // 
            // odlazak
            // 
            odlazak.Location = new Point(44, 246);
            odlazak.Name = "odlazak";
            odlazak.Size = new Size(256, 79);
            odlazak.TabIndex = 30;
            odlazak.Text = "ODLAZAK";
            odlazak.UseVisualStyleBackColor = true;
            odlazak.Click += odlazak_Click;
            // 
            // nedovoljni
            // 
            nedovoljni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nedovoljni.Location = new Point(12, 538);
            nedovoljni.Name = "nedovoljni";
            nedovoljni.Size = new Size(368, 87);
            nedovoljni.TabIndex = 31;
            nedovoljni.Text = "ISPIS RADNIKA S NEDOVOLJNO RADNIH SATI";
            nedovoljni.UseVisualStyleBackColor = true;
            nedovoljni.Click += nedovoljni_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(dolazak);
            groupBox3.Controls.Add(odlazak);
            groupBox3.Controls.Add(odabir_firme);
            groupBox3.Location = new Point(418, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(346, 346);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "EVIDENCIJA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label13.Location = new Point(15, 73);
            label13.Name = "label13";
            label13.Size = new Size(157, 20);
            label13.TabIndex = 32;
            label13.Text = "ODABERI RADNIKA: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.Location = new Point(15, 19);
            label12.Name = "label12";
            label12.Size = new Size(135, 20);
            label12.TabIndex = 31;
            label12.Text = "ODABERI FIRMU: ";
            // 
            // kasnili
            // 
            kasnili.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kasnili.Location = new Point(12, 631);
            kasnili.Name = "kasnili";
            kasnili.Size = new Size(368, 87);
            kasnili.TabIndex = 33;
            kasnili.Text = "ISPIS RADNIKA KOJI SU DOŠLI/OTIŠLI IZVAN RADNOG VREMENA";
            kasnili.UseVisualStyleBackColor = true;
            kasnili.Click += kasnili_Click;
            // 
            // labelTrenutnoVrijeme
            // 
            labelTrenutnoVrijeme.AutoSize = true;
            labelTrenutnoVrijeme.Location = new Point(497, 777);
            labelTrenutnoVrijeme.Name = "labelTrenutnoVrijeme";
            labelTrenutnoVrijeme.Size = new Size(0, 20);
            labelTrenutnoVrijeme.TabIndex = 35;
            // 
            // button1
            // 
            button1.Location = new Point(670, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(418, 37);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 37;
            label11.Text = "label11";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(497, 674);
            label14.Name = "label14";
            label14.Size = new Size(13, 20);
            label14.TabIndex = 38;
            label14.Text = " ";
            // 
            // button2
            // 
            button2.Location = new Point(604, 115);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 39;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(436, 139);
            label15.Name = "label15";
            label15.Size = new Size(50, 20);
            label15.TabIndex = 40;
            label15.Text = "labela";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(518, 90);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 41;
            label16.Text = "label16";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 731);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(button2);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(labelTrenutnoVrijeme);
            Controls.Add(kasnili);
            Controls.Add(nedovoljni);
            Controls.Add(odabir_radnika);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox odabir_firme;
        private TextBox dodaj_firmu;
        private Button btn_dodaj_firmu;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox OIB;
        private Label label8;
        private TextBox prezime;
        private TextBox ime;
        private Label label10;
        private Label label9;
        private Button dodaj_radnika;
        private Label labelica;
        private TextBox id_firme;
        private ComboBox odabir_radnika;
        private Button dolazak;
        private Button odlazak;
        private Button nedovoljni;
        private GroupBox groupBox3;
        private Button kasnili;
        private ComboBox firma;
        private Label labelTrenutnoVrijeme;
        private DateTimePicker dolazak_start;
        private DateTimePicker odlazak_kraj;
        private DateTimePicker odlazak_start;
        private DateTimePicker dolazak_kraj;
        private Label label13;
        private Label label12;
        private Button button1;
        private Label label11;
        private Label label14;
        private Button button2;
        private Label label15;
        private Label label16;
    }
}
