namespace PickDriveForm
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
			this.DodajVozilo = new System.Windows.Forms.Button();
			this.DeleteVozilo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.GetVozila = new System.Windows.Forms.Button();
			this.GetRadnik = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.DeleteRadnik = new System.Windows.Forms.Button();
			this.AddRadnik = new System.Windows.Forms.Button();
			this.RentVozilo = new System.Windows.Forms.Button();
			this.id_vozila_txt = new System.Windows.Forms.MaskedTextBox();
			this.tip_txt = new System.Windows.Forms.MaskedTextBox();
			this.naziv_vozila_txt = new System.Windows.Forms.MaskedTextBox();
			this.model_vozila_txt = new System.Windows.Forms.MaskedTextBox();
			this.id_radnik_txt = new System.Windows.Forms.MaskedTextBox();
			this.ime_radnik_txt = new System.Windows.Forms.MaskedTextBox();
			this.prezime_radnik_txt = new System.Windows.Forms.MaskedTextBox();
			this.id_vozilaDel_txt = new System.Windows.Forms.MaskedTextBox();
			this.id_radnikDel_txt = new System.Windows.Forms.MaskedTextBox();
			this.notReturnedBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DodajVozilo
			// 
			this.DodajVozilo.Location = new System.Drawing.Point(12, 162);
			this.DodajVozilo.Margin = new System.Windows.Forms.Padding(2);
			this.DodajVozilo.Name = "DodajVozilo";
			this.DodajVozilo.Size = new System.Drawing.Size(143, 30);
			this.DodajVozilo.TabIndex = 0;
			this.DodajVozilo.Text = "Dodaj vozilo";
			this.DodajVozilo.UseVisualStyleBackColor = true;
			this.DodajVozilo.Click += new System.EventHandler(this.DodajVozilo_click);
			// 
			// DeleteVozilo
			// 
			this.DeleteVozilo.Location = new System.Drawing.Point(12, 249);
			this.DeleteVozilo.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteVozilo.Name = "DeleteVozilo";
			this.DeleteVozilo.Size = new System.Drawing.Size(142, 34);
			this.DeleteVozilo.TabIndex = 6;
			this.DeleteVozilo.Text = "Obrisi vozilo";
			this.DeleteVozilo.UseVisualStyleBackColor = true;
			this.DeleteVozilo.Click += new System.EventHandler(this.DeleteVozilo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Id vozila:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tip vozila:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 119);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Naziv vozila:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 142);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Model vozila:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 229);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Id vozila";
			// 
			// GetVozila
			// 
			this.GetVozila.Location = new System.Drawing.Point(12, 9);
			this.GetVozila.Margin = new System.Windows.Forms.Padding(2);
			this.GetVozila.Name = "GetVozila";
			this.GetVozila.Size = new System.Drawing.Size(143, 28);
			this.GetVozila.TabIndex = 12;
			this.GetVozila.Text = "Prikazi vozila";
			this.GetVozila.UseVisualStyleBackColor = true;
			this.GetVozila.Click += new System.EventHandler(this.GetVozila_Click);
			// 
			// GetRadnik
			// 
			this.GetRadnik.Location = new System.Drawing.Point(186, 9);
			this.GetRadnik.Margin = new System.Windows.Forms.Padding(2);
			this.GetRadnik.Name = "GetRadnik";
			this.GetRadnik.Size = new System.Drawing.Size(162, 28);
			this.GetRadnik.TabIndex = 13;
			this.GetRadnik.Text = "Prikazi radnike";
			this.GetRadnik.UseVisualStyleBackColor = true;
			this.GetRadnik.Click += new System.EventHandler(this.GetRadnik_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(183, 229);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Id radnika";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(183, 119);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Prezime radnika:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(184, 97);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "Ime radnika:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(184, 74);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Id radnika:";
			// 
			// DeleteRadnik
			// 
			this.DeleteRadnik.Location = new System.Drawing.Point(186, 249);
			this.DeleteRadnik.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteRadnik.Name = "DeleteRadnik";
			this.DeleteRadnik.Size = new System.Drawing.Size(162, 34);
			this.DeleteRadnik.TabIndex = 20;
			this.DeleteRadnik.Text = "Obrisi radnika";
			this.DeleteRadnik.UseVisualStyleBackColor = true;
			this.DeleteRadnik.Click += new System.EventHandler(this.DeleteRadnik_Click);
			// 
			// AddRadnik
			// 
			this.AddRadnik.Location = new System.Drawing.Point(186, 162);
			this.AddRadnik.Margin = new System.Windows.Forms.Padding(2);
			this.AddRadnik.Name = "AddRadnik";
			this.AddRadnik.Size = new System.Drawing.Size(162, 30);
			this.AddRadnik.TabIndex = 14;
			this.AddRadnik.Text = "Dodaj radnika";
			this.AddRadnik.UseVisualStyleBackColor = true;
			this.AddRadnik.Click += new System.EventHandler(this.AddRadnik_Click);
			// 
			// RentVozilo
			// 
			this.RentVozilo.BackColor = System.Drawing.SystemColors.ControlDark;
			this.RentVozilo.FlatAppearance.BorderSize = 3;
			this.RentVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RentVozilo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RentVozilo.Location = new System.Drawing.Point(13, 347);
			this.RentVozilo.Margin = new System.Windows.Forms.Padding(2);
			this.RentVozilo.Name = "RentVozilo";
			this.RentVozilo.Size = new System.Drawing.Size(336, 67);
			this.RentVozilo.TabIndex = 26;
			this.RentVozilo.Text = "IZNAJMI VOZILO";
			this.RentVozilo.UseVisualStyleBackColor = false;
			this.RentVozilo.Click += new System.EventHandler(this.RentVozilo_Click);
			// 
			// id_vozila_txt
			// 
			this.id_vozila_txt.Location = new System.Drawing.Point(79, 70);
			this.id_vozila_txt.Margin = new System.Windows.Forms.Padding(2);
			this.id_vozila_txt.Mask = "00000000";
			this.id_vozila_txt.Name = "id_vozila_txt";
			this.id_vozila_txt.Size = new System.Drawing.Size(76, 20);
			this.id_vozila_txt.TabIndex = 27;
			// 
			// tip_txt
			// 
			this.tip_txt.Location = new System.Drawing.Point(79, 94);
			this.tip_txt.Margin = new System.Windows.Forms.Padding(2);
			this.tip_txt.Mask = "LLLLLL??????";
			this.tip_txt.Name = "tip_txt";
			this.tip_txt.Size = new System.Drawing.Size(76, 20);
			this.tip_txt.TabIndex = 28;
			// 
			// naziv_vozila_txt
			// 
			this.naziv_vozila_txt.Location = new System.Drawing.Point(79, 117);
			this.naziv_vozila_txt.Margin = new System.Windows.Forms.Padding(2);
			this.naziv_vozila_txt.Mask = "LLLLLLLLLLLLL";
			this.naziv_vozila_txt.Name = "naziv_vozila_txt";
			this.naziv_vozila_txt.Size = new System.Drawing.Size(76, 20);
			this.naziv_vozila_txt.TabIndex = 29;
			// 
			// model_vozila_txt
			// 
			this.model_vozila_txt.Location = new System.Drawing.Point(79, 140);
			this.model_vozila_txt.Margin = new System.Windows.Forms.Padding(2);
			this.model_vozila_txt.Name = "model_vozila_txt";
			this.model_vozila_txt.Size = new System.Drawing.Size(76, 20);
			this.model_vozila_txt.TabIndex = 30;
			// 
			// id_radnik_txt
			// 
			this.id_radnik_txt.Location = new System.Drawing.Point(273, 71);
			this.id_radnik_txt.Margin = new System.Windows.Forms.Padding(2);
			this.id_radnik_txt.Mask = "00000000";
			this.id_radnik_txt.Name = "id_radnik_txt";
			this.id_radnik_txt.Size = new System.Drawing.Size(76, 20);
			this.id_radnik_txt.TabIndex = 31;
			// 
			// ime_radnik_txt
			// 
			this.ime_radnik_txt.Location = new System.Drawing.Point(273, 94);
			this.ime_radnik_txt.Margin = new System.Windows.Forms.Padding(2);
			this.ime_radnik_txt.Mask = "LLLLLL???????????????";
			this.ime_radnik_txt.Name = "ime_radnik_txt";
			this.ime_radnik_txt.Size = new System.Drawing.Size(76, 20);
			this.ime_radnik_txt.TabIndex = 32;
			// 
			// prezime_radnik_txt
			// 
			this.prezime_radnik_txt.Location = new System.Drawing.Point(273, 119);
			this.prezime_radnik_txt.Margin = new System.Windows.Forms.Padding(2);
			this.prezime_radnik_txt.Mask = "LLLLLL???????????????";
			this.prezime_radnik_txt.Name = "prezime_radnik_txt";
			this.prezime_radnik_txt.Size = new System.Drawing.Size(76, 20);
			this.prezime_radnik_txt.TabIndex = 33;
			// 
			// id_vozilaDel_txt
			// 
			this.id_vozilaDel_txt.Location = new System.Drawing.Point(58, 227);
			this.id_vozilaDel_txt.Margin = new System.Windows.Forms.Padding(2);
			this.id_vozilaDel_txt.Mask = "00000000";
			this.id_vozilaDel_txt.Name = "id_vozilaDel_txt";
			this.id_vozilaDel_txt.Size = new System.Drawing.Size(98, 20);
			this.id_vozilaDel_txt.TabIndex = 34;
			// 
			// id_radnikDel_txt
			// 
			this.id_radnikDel_txt.Location = new System.Drawing.Point(247, 227);
			this.id_radnikDel_txt.Margin = new System.Windows.Forms.Padding(2);
			this.id_radnikDel_txt.Mask = "00000000";
			this.id_radnikDel_txt.Name = "id_radnikDel_txt";
			this.id_radnikDel_txt.Size = new System.Drawing.Size(102, 20);
			this.id_radnikDel_txt.TabIndex = 35;
			// 
			// notReturnedBtn
			// 
			this.notReturnedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.notReturnedBtn.Location = new System.Drawing.Point(12, 298);
			this.notReturnedBtn.Name = "notReturnedBtn";
			this.notReturnedBtn.Size = new System.Drawing.Size(336, 33);
			this.notReturnedBtn.TabIndex = 36;
			this.notReturnedBtn.Text = "Klijenti koji nisu vratili vozilo";
			this.notReturnedBtn.UseVisualStyleBackColor = true;
			this.notReturnedBtn.Click += new System.EventHandler(this.notReturnedBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 421);
			this.Controls.Add(this.notReturnedBtn);
			this.Controls.Add(this.id_radnikDel_txt);
			this.Controls.Add(this.id_vozilaDel_txt);
			this.Controls.Add(this.prezime_radnik_txt);
			this.Controls.Add(this.ime_radnik_txt);
			this.Controls.Add(this.id_radnik_txt);
			this.Controls.Add(this.model_vozila_txt);
			this.Controls.Add(this.naziv_vozila_txt);
			this.Controls.Add(this.tip_txt);
			this.Controls.Add(this.id_vozila_txt);
			this.Controls.Add(this.RentVozilo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.DeleteRadnik);
			this.Controls.Add(this.AddRadnik);
			this.Controls.Add(this.GetRadnik);
			this.Controls.Add(this.GetVozila);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DeleteVozilo);
			this.Controls.Add(this.DodajVozilo);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "RentACar";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajVozilo;
        private System.Windows.Forms.Button DeleteVozilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetVozila;
        private System.Windows.Forms.Button GetRadnik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteRadnik;
        private System.Windows.Forms.Button AddRadnik;
        private System.Windows.Forms.Button RentVozilo;
        private System.Windows.Forms.MaskedTextBox id_vozila_txt;
        private System.Windows.Forms.MaskedTextBox tip_txt;
        private System.Windows.Forms.MaskedTextBox naziv_vozila_txt;
        private System.Windows.Forms.MaskedTextBox model_vozila_txt;
        private System.Windows.Forms.MaskedTextBox id_radnik_txt;
        private System.Windows.Forms.MaskedTextBox ime_radnik_txt;
        private System.Windows.Forms.MaskedTextBox prezime_radnik_txt;
        private System.Windows.Forms.MaskedTextBox id_vozilaDel_txt;
        private System.Windows.Forms.MaskedTextBox id_radnikDel_txt;
		private System.Windows.Forms.Button notReturnedBtn;
	}
}

