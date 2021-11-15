
namespace CovidTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtGeburtsdatum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSVNR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonnummer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPLZOrt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStrasse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHausnummer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(12, 27);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(497, 23);
            this.txtVorname.TabIndex = 0;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(11, 70);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(498, 23);
            this.txtNachname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Testort";
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(12, 389);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(498, 23);
            this.cbxLocation.TabIndex = 4;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(11, 430);
            this.cbxDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(498, 23);
            this.cbxDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(496, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test reservieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(11, 503);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 8;
            // 
            // txtGeburtsdatum
            // 
            this.txtGeburtsdatum.Location = new System.Drawing.Point(11, 111);
            this.txtGeburtsdatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGeburtsdatum.Name = "txtGeburtsdatum";
            this.txtGeburtsdatum.Size = new System.Drawing.Size(498, 23);
            this.txtGeburtsdatum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Geburtsdatum";
            // 
            // txtSVNR
            // 
            this.txtSVNR.Location = new System.Drawing.Point(11, 154);
            this.txtSVNR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSVNR.Name = "txtSVNR";
            this.txtSVNR.Size = new System.Drawing.Size(498, 23);
            this.txtSVNR.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sozialvericherungsnummer (10-Stellig)";
            // 
            // txtTelefonnummer
            // 
            this.txtTelefonnummer.Location = new System.Drawing.Point(11, 197);
            this.txtTelefonnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonnummer.Name = "txtTelefonnummer";
            this.txtTelefonnummer.Size = new System.Drawing.Size(498, 23);
            this.txtTelefonnummer.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefonnummer (mit Vorwahl: +43....)";
            // 
            // txtPLZOrt
            // 
            this.txtPLZOrt.Location = new System.Drawing.Point(11, 243);
            this.txtPLZOrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPLZOrt.Name = "txtPLZOrt";
            this.txtPLZOrt.Size = new System.Drawing.Size(498, 23);
            this.txtPLZOrt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "PLZ + Ort";
            // 
            // txtStrasse
            // 
            this.txtStrasse.Location = new System.Drawing.Point(11, 289);
            this.txtStrasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStrasse.Name = "txtStrasse";
            this.txtStrasse.Size = new System.Drawing.Size(498, 23);
            this.txtStrasse.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Straße";
            // 
            // txtHausnummer
            // 
            this.txtHausnummer.Location = new System.Drawing.Point(11, 336);
            this.txtHausnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHausnummer.Name = "txtHausnummer";
            this.txtHausnummer.Size = new System.Drawing.Size(498, 23);
            this.txtHausnummer.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hausnummer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 536);
            this.Controls.Add(this.txtHausnummer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStrasse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPLZOrt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefonnummer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSVNR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGeburtsdatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.ComboBox cbxDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtGeburtsdatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSVNR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonnummer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPLZOrt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStrasse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHausnummer;
        private System.Windows.Forms.Label label10;
    }
}

