namespace BookCenter
{
	partial class FrmStudenList
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudenList));
			this.listViewStudent = new System.Windows.Forms.ListView();
			this.ımageListStudent = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.txtTC = new System.Windows.Forms.MaskedTextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtClasNo = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.BirthDate = new System.Windows.Forms.MaskedTextBox();
			this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
			this.txtAdress = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewStudent
			// 
			this.listViewStudent.BackColor = System.Drawing.Color.Lavender;
			this.listViewStudent.HideSelection = false;
			this.listViewStudent.LargeImageList = this.ımageListStudent;
			this.listViewStudent.Location = new System.Drawing.Point(3, 3);
			this.listViewStudent.Name = "listViewStudent";
			this.listViewStudent.Size = new System.Drawing.Size(561, 483);
			this.listViewStudent.TabIndex = 0;
			this.listViewStudent.UseCompatibleStateImageBehavior = false;
			this.listViewStudent.DoubleClick += new System.EventHandler(this.listViewStudent_DoubleClick);
			// 
			// ımageListStudent
			// 
			this.ımageListStudent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListStudent.ImageStream")));
			this.ımageListStudent.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageListStudent.Images.SetKeyName(0, "Personel.png");
			this.ımageListStudent.Images.SetKeyName(1, "Student.png");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmbGender);
			this.groupBox1.Controls.Add(this.txtTC);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtClasNo);
			this.groupBox1.Controls.Add(this.txtSurname);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.BirthDate);
			this.groupBox1.Controls.Add(this.txtTelephone);
			this.groupBox1.Controls.Add(this.txtAdress);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(570, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(314, 483);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci Bilgileri";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(57, 310);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 18);
			this.label9.TabIndex = 61;
			this.label9.Text = "Adres : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(53, 244);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 18);
			this.label7.TabIndex = 60;
			this.label7.Text = "Eposta :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(31, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 18);
			this.label6.TabIndex = 59;
			this.label6.Text = "Telefon No :";
			// 
			// cmbGender
			// 
			this.cmbGender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cmbGender.Enabled = false;
			this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbGender.ForeColor = System.Drawing.Color.Black;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Location = new System.Drawing.Point(114, 204);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(166, 24);
			this.cmbGender.TabIndex = 58;
			// 
			// txtTC
			// 
			this.txtTC.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtTC.Enabled = false;
			this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTC.ForeColor = System.Drawing.Color.Black;
			this.txtTC.Location = new System.Drawing.Point(114, 42);
			this.txtTC.Mask = "00000000000";
			this.txtTC.Name = "txtTC";
			this.txtTC.Size = new System.Drawing.Size(166, 22);
			this.txtTC.TabIndex = 57;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtEmail.Enabled = false;
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.Location = new System.Drawing.Point(114, 242);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(166, 22);
			this.txtEmail.TabIndex = 56;
			// 
			// txtClasNo
			// 
			this.txtClasNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtClasNo.Enabled = false;
			this.txtClasNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtClasNo.ForeColor = System.Drawing.Color.Black;
			this.txtClasNo.Location = new System.Drawing.Point(114, 138);
			this.txtClasNo.Name = "txtClasNo";
			this.txtClasNo.Size = new System.Drawing.Size(166, 22);
			this.txtClasNo.TabIndex = 55;
			// 
			// txtSurname
			// 
			this.txtSurname.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtSurname.Enabled = false;
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSurname.ForeColor = System.Drawing.Color.Black;
			this.txtSurname.Location = new System.Drawing.Point(114, 104);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(166, 22);
			this.txtSurname.TabIndex = 54;
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtName.Enabled = false;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtName.ForeColor = System.Drawing.Color.Black;
			this.txtName.Location = new System.Drawing.Point(114, 73);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(166, 22);
			this.txtName.TabIndex = 53;
			// 
			// BirthDate
			// 
			this.BirthDate.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BirthDate.Enabled = false;
			this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BirthDate.ForeColor = System.Drawing.Color.Black;
			this.BirthDate.Location = new System.Drawing.Point(114, 171);
			this.BirthDate.Name = "BirthDate";
			this.BirthDate.Size = new System.Drawing.Size(166, 22);
			this.BirthDate.TabIndex = 52;
			this.BirthDate.ValidatingType = typeof(System.DateTime);
			// 
			// txtTelephone
			// 
			this.txtTelephone.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtTelephone.Enabled = false;
			this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTelephone.ForeColor = System.Drawing.Color.Black;
			this.txtTelephone.Location = new System.Drawing.Point(114, 272);
			this.txtTelephone.Mask = "(999) 000-0000";
			this.txtTelephone.Name = "txtTelephone";
			this.txtTelephone.Size = new System.Drawing.Size(166, 22);
			this.txtTelephone.TabIndex = 51;
			// 
			// txtAdress
			// 
			this.txtAdress.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtAdress.Enabled = false;
			this.txtAdress.ForeColor = System.Drawing.Color.Black;
			this.txtAdress.Location = new System.Drawing.Point(114, 310);
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(166, 66);
			this.txtAdress.TabIndex = 50;
			this.txtAdress.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(43, 206);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 18);
			this.label8.TabIndex = 49;
			this.label8.Text = "Cinsiyet : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(12, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 18);
			this.label5.TabIndex = 48;
			this.label5.Text = "Doğum Tarihi :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(48, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 18);
			this.label4.TabIndex = 47;
			this.label4.Text = "Sınıf No :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(48, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 18);
			this.label3.TabIndex = 46;
			this.label3.Text = "Soyisim :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(68, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 18);
			this.label2.TabIndex = 45;
			this.label2.Text = "İsim :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(73, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 18);
			this.label1.TabIndex = 44;
			this.label1.Text = "T.C. :";
			// 
			// FrmStudenList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(886, 487);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listViewStudent);
			this.MaximizeBox = false;
			this.Name = "FrmStudenList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmStudenList";
			this.Load += new System.EventHandler(this.FrmStudenList_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewStudent;
		private System.Windows.Forms.ImageList ımageListStudent;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.MaskedTextBox txtTC;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtClasNo;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.MaskedTextBox BirthDate;
		private System.Windows.Forms.MaskedTextBox txtTelephone;
		private System.Windows.Forms.RichTextBox txtAdress;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
	}
}