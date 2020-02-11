namespace DataLayerCassandra
{
    partial class ClientForm
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
			this.imeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.prezimeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.jmbgTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.brojDanaTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// imeTextBox
			// 
			this.imeTextBox.Location = new System.Drawing.Point(85, 22);
			this.imeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.imeTextBox.Name = "imeTextBox";
			this.imeTextBox.Size = new System.Drawing.Size(115, 20);
			this.imeTextBox.TabIndex = 0;
			// 
			// prezimeTextBox
			// 
			this.prezimeTextBox.Location = new System.Drawing.Point(85, 80);
			this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.prezimeTextBox.Name = "prezimeTextBox";
			this.prezimeTextBox.Size = new System.Drawing.Size(115, 20);
			this.prezimeTextBox.TabIndex = 1;
			// 
			// jmbgTextBox
			// 
			this.jmbgTextBox.Location = new System.Drawing.Point(85, 136);
			this.jmbgTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.jmbgTextBox.Mask = "0000000000000";
			this.jmbgTextBox.Name = "jmbgTextBox";
			this.jmbgTextBox.Size = new System.Drawing.Size(115, 20);
			this.jmbgTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ime";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 82);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Prezime";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 136);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "JMBG";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(17, 229);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "DODAJ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Broj dana iznajmljivanja vozila";
			// 
			// brojDanaTextBox
			// 
			this.brojDanaTextBox.Location = new System.Drawing.Point(40, 194);
			this.brojDanaTextBox.Mask = "000";
			this.brojDanaTextBox.Name = "brojDanaTextBox";
			this.brojDanaTextBox.Size = new System.Drawing.Size(115, 20);
			this.brojDanaTextBox.TabIndex = 8;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 268);
			this.Controls.Add(this.brojDanaTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.jmbgTextBox);
			this.Controls.Add(this.prezimeTextBox);
			this.Controls.Add(this.imeTextBox);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ClientForm";
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox imeTextBox;
        private System.Windows.Forms.MaskedTextBox prezimeTextBox;
        private System.Windows.Forms.MaskedTextBox jmbgTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox brojDanaTextBox;
	}
}