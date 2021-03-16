namespace BookCenter
{
	partial class StudentAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAdd));
			this.StudentPageView = new System.Windows.Forms.DataGridView();
			this.btnOgrGuncelle = new System.Windows.Forms.Button();
			this.btnOgrSil = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.mtxtNational = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtClass = new System.Windows.Forms.TextBox();
			this.txtSurnameS = new System.Windows.Forms.TextBox();
			this.txtNameStudent = new System.Windows.Forms.TextBox();
			this.mskDateBirth = new System.Windows.Forms.MaskedTextBox();
			this.txtNumber = new System.Windows.Forms.MaskedTextBox();
			this.txtAdress = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOgrKaydet = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.StudentPageView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// StudentPageView
			// 
			this.StudentPageView.AllowUserToAddRows = false;
			this.StudentPageView.AllowUserToDeleteRows = false;
			this.StudentPageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StudentPageView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.StudentPageView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.StudentPageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StudentPageView.Location = new System.Drawing.Point(12, 246);
			this.StudentPageView.Name = "StudentPageView";
			this.StudentPageView.ReadOnly = true;
			this.StudentPageView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.StudentPageView.Size = new System.Drawing.Size(754, 245);
			this.StudentPageView.TabIndex = 22;
			this.StudentPageView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentPageView_CellDoubleClick);
			// 
			// btnOgrGuncelle
			// 
			this.btnOgrGuncelle.BackColor = System.Drawing.Color.Gainsboro;
			this.btnOgrGuncelle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOgrGuncelle.FlatAppearance.BorderSize = 2;
			this.btnOgrGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOgrGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOgrGuncelle.Image = global::BookCenter.Properties.Resources.updated_24;
			this.btnOgrGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOgrGuncelle.Location = new System.Drawing.Point(103, 19);
			this.btnOgrGuncelle.Name = "btnOgrGuncelle";
			this.btnOgrGuncelle.Size = new System.Drawing.Size(103, 35);
			this.btnOgrGuncelle.TabIndex = 23;
			this.btnOgrGuncelle.Text = "GÜNCELLE";
			this.btnOgrGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOgrGuncelle.UseVisualStyleBackColor = false;
			this.btnOgrGuncelle.Click += new System.EventHandler(this.btnOgrGuncelle_Click);
			// 
			// btnOgrSil
			// 
			this.btnOgrSil.BackColor = System.Drawing.Color.Gainsboro;
			this.btnOgrSil.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOgrSil.FlatAppearance.BorderSize = 2;
			this.btnOgrSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOgrSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOgrSil.Image = global::BookCenter.Properties.Resources.remove_24;
			this.btnOgrSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOgrSil.Location = new System.Drawing.Point(212, 19);
			this.btnOgrSil.Name = "btnOgrSil";
			this.btnOgrSil.Size = new System.Drawing.Size(63, 35);
			this.btnOgrSil.TabIndex = 24;
			this.btnOgrSil.Text = "SİL";
			this.btnOgrSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOgrSil.UseVisualStyleBackColor = false;
			this.btnOgrSil.Click += new System.EventHandler(this.btnOgrSil_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cmbGender);
			this.groupBox1.Controls.Add(this.mtxtNational);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtClass);
			this.groupBox1.Controls.Add(this.txtSurnameS);
			this.groupBox1.Controls.Add(this.txtNameStudent);
			this.groupBox1.Controls.Add(this.mskDateBirth);
			this.groupBox1.Controls.Add(this.txtNumber);
			this.groupBox1.Controls.Add(this.txtAdress);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(754, 228);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci Bilgileri";
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
			this.cmbGender.Location = new System.Drawing.Point(106, 180);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(166, 24);
			this.cmbGender.TabIndex = 43;
			// 
			// mtxtNational
			// 
			this.mtxtNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mtxtNational.Location = new System.Drawing.Point(106, 18);
			this.mtxtNational.Mask = "00000000000";
			this.mtxtNational.Name = "mtxtNational";
			this.mtxtNational.Size = new System.Drawing.Size(166, 22);
			this.mtxtNational.TabIndex = 42;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.Location = new System.Drawing.Point(414, 18);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(166, 22);
			this.txtEmail.TabIndex = 39;
			// 
			// txtClass
			// 
			this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtClass.Location = new System.Drawing.Point(106, 114);
			this.txtClass.Name = "txtClass";
			this.txtClass.Size = new System.Drawing.Size(166, 22);
			this.txtClass.TabIndex = 38;
			// 
			// txtSurnameS
			// 
			this.txtSurnameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSurnameS.Location = new System.Drawing.Point(106, 80);
			this.txtSurnameS.Name = "txtSurnameS";
			this.txtSurnameS.Size = new System.Drawing.Size(166, 22);
			this.txtSurnameS.TabIndex = 37;
			// 
			// txtNameStudent
			// 
			this.txtNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtNameStudent.Location = new System.Drawing.Point(106, 49);
			this.txtNameStudent.Name = "txtNameStudent";
			this.txtNameStudent.Size = new System.Drawing.Size(166, 22);
			this.txtNameStudent.TabIndex = 36;
			// 
			// mskDateBirth
			// 
			this.mskDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskDateBirth.Location = new System.Drawing.Point(106, 147);
			this.mskDateBirth.Name = "mskDateBirth";
			this.mskDateBirth.Size = new System.Drawing.Size(166, 22);
			this.mskDateBirth.TabIndex = 34;
			this.mskDateBirth.ValidatingType = typeof(System.DateTime);
			// 
			// txtNumber
			// 
			this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtNumber.Location = new System.Drawing.Point(414, 51);
			this.txtNumber.Mask = "(999) 000-0000";
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(166, 22);
			this.txtNumber.TabIndex = 32;
			// 
			// txtAdress
			// 
			this.txtAdress.Location = new System.Drawing.Point(414, 81);
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(166, 54);
			this.txtAdress.TabIndex = 30;
			this.txtAdress.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(357, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 18);
			this.label9.TabIndex = 29;
			this.label9.Text = "Adres : ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(35, 182);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 18);
			this.label8.TabIndex = 28;
			this.label8.Text = "Cinsiyet : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(353, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 18);
			this.label7.TabIndex = 27;
			this.label7.Text = "Eposta :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(331, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 18);
			this.label6.TabIndex = 26;
			this.label6.Text = "Telefon No :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(4, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 18);
			this.label5.TabIndex = 25;
			this.label5.Text = "Doğum Tarihi :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(40, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 18);
			this.label4.TabIndex = 24;
			this.label4.Text = "Sınıf No :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(40, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 23;
			this.label3.Text = "Soyisim :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(60, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 18);
			this.label2.TabIndex = 22;
			this.label2.Text = "İsim :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(65, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 18);
			this.label1.TabIndex = 21;
			this.label1.Text = "T.C. :";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox2.Controls.Add(this.btnOgrKaydet);
			this.groupBox2.Controls.Add(this.btnOgrGuncelle);
			this.groupBox2.Controls.Add(this.btnOgrSil);
			this.groupBox2.Location = new System.Drawing.Point(231, 513);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 73);
			this.groupBox2.TabIndex = 26;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "İşlem";
			// 
			// btnOgrKaydet
			// 
			this.btnOgrKaydet.BackColor = System.Drawing.Color.Gainsboro;
			this.btnOgrKaydet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOgrKaydet.FlatAppearance.BorderSize = 2;
			this.btnOgrKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOgrKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOgrKaydet.Image = global::BookCenter.Properties.Resources.plus_24;
			this.btnOgrKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOgrKaydet.Location = new System.Drawing.Point(6, 19);
			this.btnOgrKaydet.Name = "btnOgrKaydet";
			this.btnOgrKaydet.Size = new System.Drawing.Size(91, 35);
			this.btnOgrKaydet.TabIndex = 21;
			this.btnOgrKaydet.Text = "KAYDET";
			this.btnOgrKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOgrKaydet.UseVisualStyleBackColor = false;
			this.btnOgrKaydet.Click += new System.EventHandler(this.btnOgrKaydet_Click);
			// 
			// StudentAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(788, 621);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.StudentPageView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StudentAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentAdd";
			this.Load += new System.EventHandler(this.StudentAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.StudentPageView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnOgrKaydet;
		private System.Windows.Forms.DataGridView StudentPageView;
		private System.Windows.Forms.Button btnOgrGuncelle;
		private System.Windows.Forms.Button btnOgrSil;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtClass;
		private System.Windows.Forms.TextBox txtSurnameS;
		private System.Windows.Forms.TextBox txtNameStudent;
		private System.Windows.Forms.MaskedTextBox mskDateBirth;
		private System.Windows.Forms.MaskedTextBox txtNumber;
		private System.Windows.Forms.RichTextBox txtAdress;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MaskedTextBox mtxtNational;
		private System.Windows.Forms.ComboBox cmbGender;
	}
}