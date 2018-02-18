namespace CalibrationBath
{
    partial class SettingsWindow
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
            this.tabUstawienia = new System.Windows.Forms.TabControl();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboStop = new System.Windows.Forms.ComboBox();
            this.comboDane = new System.Windows.Forms.ComboBox();
            this.comboOdd = new System.Windows.Forms.ComboBox();
            this.comboInterval = new System.Windows.Forms.ComboBox();
            this.ComboPort = new System.Windows.Forms.ComboBox();
            this.tabJednostka = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnitValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMid = new System.Windows.Forms.TextBox();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.comboTemp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSkan = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScanValue = new System.Windows.Forms.Label();
            this.infoScan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IntervalScan = new System.Windows.Forms.TextBox();
            this.ComboScan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabVernier = new System.Windows.Forms.TabPage();
            this.vernier = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabUstawienia.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.tabJednostka.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSkan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabVernier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUstawienia
            // 
            this.tabUstawienia.Controls.Add(this.tabSerial);
            this.tabUstawienia.Controls.Add(this.tabJednostka);
            this.tabUstawienia.Controls.Add(this.tabSkan);
            this.tabUstawienia.Controls.Add(this.tabVernier);
            this.tabUstawienia.Location = new System.Drawing.Point(12, 12);
            this.tabUstawienia.Name = "tabUstawienia";
            this.tabUstawienia.SelectedIndex = 0;
            this.tabUstawienia.Size = new System.Drawing.Size(267, 188);
            this.tabUstawienia.TabIndex = 0;
            // 
            // tabSerial
            // 
            this.tabSerial.Controls.Add(this.label9);
            this.tabSerial.Controls.Add(this.label8);
            this.tabSerial.Controls.Add(this.label7);
            this.tabSerial.Controls.Add(this.label6);
            this.tabSerial.Controls.Add(this.label5);
            this.tabSerial.Controls.Add(this.comboStop);
            this.tabSerial.Controls.Add(this.comboDane);
            this.tabSerial.Controls.Add(this.comboOdd);
            this.tabSerial.Controls.Add(this.comboInterval);
            this.tabSerial.Controls.Add(this.ComboPort);
            this.tabSerial.Location = new System.Drawing.Point(4, 22);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerial.Size = new System.Drawing.Size(259, 162);
            this.tabSerial.TabIndex = 0;
            this.tabSerial.Text = "Połączenie";
            this.tabSerial.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bity stopu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bity danych";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Parzystość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Liczba bitów na sekundę";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port szeregowy (COM)";
            // 
            // comboStop
            // 
            this.comboStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStop.FormattingEnabled = true;
            this.comboStop.Location = new System.Drawing.Point(169, 127);
            this.comboStop.Name = "comboStop";
            this.comboStop.Size = new System.Drawing.Size(75, 21);
            this.comboStop.TabIndex = 4;
            // 
            // comboDane
            // 
            this.comboDane.FormattingEnabled = true;
            this.comboDane.Location = new System.Drawing.Point(169, 99);
            this.comboDane.Name = "comboDane";
            this.comboDane.Size = new System.Drawing.Size(75, 21);
            this.comboDane.TabIndex = 3;
            // 
            // comboParzystosc
            // 
            this.comboOdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdd.FormattingEnabled = true;
            this.comboOdd.Location = new System.Drawing.Point(169, 71);
            this.comboOdd.Name = "comboParzystosc";
            this.comboOdd.Size = new System.Drawing.Size(75, 21);
            this.comboOdd.TabIndex = 2;
            // 
            // comboSzybkosc
            // 
            this.comboInterval.FormattingEnabled = true;
            this.comboInterval.Location = new System.Drawing.Point(169, 43);
            this.comboInterval.Name = "comboSzybkosc";
            this.comboInterval.Size = new System.Drawing.Size(75, 21);
            this.comboInterval.TabIndex = 1;
            // 
            // comboPort
            // 
            this.ComboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPort.FormattingEnabled = true;
            this.ComboPort.Location = new System.Drawing.Point(169, 15);
            this.ComboPort.Name = "comboPort";
            this.ComboPort.Size = new System.Drawing.Size(75, 21);
            this.ComboPort.TabIndex = 0;
            // 
            // tabJednostka
            // 
            this.tabJednostka.Controls.Add(this.groupBox1);
            this.tabJednostka.Controls.Add(this.comboTemp);
            this.tabJednostka.Controls.Add(this.label1);
            this.tabJednostka.Location = new System.Drawing.Point(4, 22);
            this.tabJednostka.Name = "tabJednostka";
            this.tabJednostka.Padding = new System.Windows.Forms.Padding(3);
            this.tabJednostka.Size = new System.Drawing.Size(259, 162);
            this.tabJednostka.TabIndex = 1;
            this.tabJednostka.Text = "Jednostki";
            this.tabJednostka.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnitValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textMid);
            this.groupBox1.Controls.Add(this.textMin);
            this.groupBox1.Controls.Add(this.textMax);
            this.groupBox1.Location = new System.Drawing.Point(6, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura";
            // 
            // wartJednostki
            // 
            this.UnitValue.AutoSize = true;
            this.UnitValue.Location = new System.Drawing.Point(166, 24);
            this.UnitValue.Name = "wartJednostki";
            this.UnitValue.Size = new System.Drawing.Size(58, 13);
            this.UnitValue.TabIndex = 6;
            this.UnitValue.Text = "Wartość w";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Domyślna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimalna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maksymalna";
            // 
            // textMid
            // 
            this.textMid.Location = new System.Drawing.Point(166, 97);
            this.textMid.Name = "textMid";
            this.textMid.Size = new System.Drawing.Size(75, 20);
            this.textMid.TabIndex = 2;
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(166, 70);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(75, 20);
            this.textMin.TabIndex = 1;
            this.textMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMin_KeyPress);
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(166, 43);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(75, 20);
            this.textMax.TabIndex = 0;
            this.textMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMax_KeyPress);
            // 
            // comboTemp
            // 
            this.comboTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemp.FormattingEnabled = true;
            this.comboTemp.Location = new System.Drawing.Point(128, 7);
            this.comboTemp.Name = "comboTemp";
            this.comboTemp.Size = new System.Drawing.Size(121, 21);
            this.comboTemp.TabIndex = 1;
            this.comboTemp.SelectedIndexChanged += new System.EventHandler(this.comboTemp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jednostka temperatury";
            // 
            // tabSkan
            // 
            this.tabSkan.Controls.Add(this.groupBox2);
            this.tabSkan.Controls.Add(this.ComboScan);
            this.tabSkan.Controls.Add(this.label10);
            this.tabSkan.Location = new System.Drawing.Point(4, 22);
            this.tabSkan.Name = "tabSkan";
            this.tabSkan.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkan.Size = new System.Drawing.Size(259, 162);
            this.tabSkan.TabIndex = 2;
            this.tabSkan.Text = "Skanowanie";
            this.tabSkan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScanValue);
            this.groupBox2.Controls.Add(this.infoScan);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.IntervalScan);
            this.groupBox2.Location = new System.Drawing.Point(6, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia skanowania";
            // 
            // wartSkanowanie
            // 
            this.ScanValue.AutoSize = true;
            this.ScanValue.Location = new System.Drawing.Point(123, 25);
            this.ScanValue.Name = "wartSkanowanie";
            this.ScanValue.Size = new System.Drawing.Size(61, 13);
            this.ScanValue.TabIndex = 3;
            this.ScanValue.Text = "Wartość w ";
            // 
            // infoScan
            // 
            this.infoScan.AutoSize = true;
            this.infoScan.Location = new System.Drawing.Point(4, 68);
            this.infoScan.Name = "infoScan";
            this.infoScan.Size = new System.Drawing.Size(27, 13);
            this.infoScan.TabIndex = 2;
            this.infoScan.Text = "Cođ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Szybkość skanowania";
            // 
            // szybkoscScan
            // 
            this.IntervalScan.Location = new System.Drawing.Point(123, 43);
            this.IntervalScan.Name = "szybkoscScan";
            this.IntervalScan.Size = new System.Drawing.Size(115, 20);
            this.IntervalScan.TabIndex = 0;
            this.IntervalScan.TextChanged += new System.EventHandler(this.Interval_TextChanged);
            this.IntervalScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Interval_KeyPress);
            // 
            // comboScan
            // 
            this.ComboScan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScan.FormattingEnabled = true;
            this.ComboScan.Location = new System.Drawing.Point(132, 13);
            this.ComboScan.Name = "comboScan";
            this.ComboScan.Size = new System.Drawing.Size(121, 21);
            this.ComboScan.TabIndex = 1;
            this.ComboScan.SelectedIndexChanged += new System.EventHandler(this.ComboScan_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Status skanowania";
            // 
            // tabVernier
            // 
            this.tabVernier.Controls.Add(this.vernier);
            this.tabVernier.Controls.Add(this.label12);
            this.tabVernier.Location = new System.Drawing.Point(4, 22);
            this.tabVernier.Name = "tabVernier";
            this.tabVernier.Padding = new System.Windows.Forms.Padding(3);
            this.tabVernier.Size = new System.Drawing.Size(259, 162);
            this.tabVernier.TabIndex = 3;
            this.tabVernier.Text = "Noniusz";
            this.tabVernier.UseVisualStyleBackColor = true;
            // 
            // vernier
            // 
            this.vernier.Location = new System.Drawing.Point(144, 14);
            this.vernier.Name = "vernier";
            this.vernier.Size = new System.Drawing.Size(100, 20);
            this.vernier.TabIndex = 1;
            this.vernier.TextChanged += new System.EventHandler(this.Vernier_TextChanged);
            this.vernier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vernier_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Wartość Noniusza";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(204, 206);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 240);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabUstawienia);
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ustawienia_FormClosing);
            this.tabUstawienia.ResumeLayout(false);
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            this.tabJednostka.ResumeLayout(false);
            this.tabJednostka.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSkan.ResumeLayout(false);
            this.tabSkan.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabVernier.ResumeLayout(false);
            this.tabVernier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUstawienia;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.TabPage tabJednostka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMid;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.ComboBox comboTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboStop;
        private System.Windows.Forms.ComboBox comboDane;
        private System.Windows.Forms.ComboBox comboOdd;
        private System.Windows.Forms.ComboBox comboInterval;
        private System.Windows.Forms.ComboBox ComboPort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TabPage tabSkan;
        private System.Windows.Forms.TabPage tabVernier;
        private System.Windows.Forms.ComboBox ComboScan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label infoScan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IntervalScan;
        private System.Windows.Forms.TextBox vernier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label UnitValue;
        private System.Windows.Forms.Label ScanValue;
    }
}