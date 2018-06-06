namespace TugasBesar
{
    partial class Update
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.cbFakultas = new System.Windows.Forms.ComboBox();
            this.tbAlamat = new System.Windows.Forms.RichTextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.cbKelamin = new System.Windows.Forms.ComboBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(257, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(108, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(108, 335);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(100, 20);
            this.tbNo.TabIndex = 27;
            // 
            // cbFakultas
            // 
            this.cbFakultas.FormattingEnabled = true;
            this.cbFakultas.Items.AddRange(new object[] {
            "FITB",
            "FTIE",
            "FH",
            "FT",
            "FP"});
            this.cbFakultas.Location = new System.Drawing.Point(108, 188);
            this.cbFakultas.Name = "cbFakultas";
            this.cbFakultas.Size = new System.Drawing.Size(72, 21);
            this.cbFakultas.TabIndex = 26;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(108, 226);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(143, 96);
            this.tbAlamat.TabIndex = 25;
            this.tbAlamat.Text = "";
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(108, 150);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(100, 20);
            this.tbProdi.TabIndex = 24;
            // 
            // cbKelamin
            // 
            this.cbKelamin.FormattingEnabled = true;
            this.cbKelamin.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cbKelamin.Location = new System.Drawing.Point(108, 119);
            this.cbKelamin.Name = "cbKelamin";
            this.cbKelamin.Size = new System.Drawing.Size(39, 21);
            this.cbKelamin.TabIndex = 23;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(108, 85);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(125, 20);
            this.tbNama.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "No HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fakultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Update Informasi Anggota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(108, 52);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(31, 20);
            this.tbId.TabIndex = 31;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 454);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.cbFakultas);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbProdi);
            this.Controls.Add(this.cbKelamin);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.ComboBox cbFakultas;
        private System.Windows.Forms.RichTextBox tbAlamat;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.ComboBox cbKelamin;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
    }
}