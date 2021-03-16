namespace BookCenter
{
	partial class SafetyBookPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.GridSafetyBook = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDeleteBook = new System.Windows.Forms.Button();
			this.btnUpdateBook = new System.Windows.Forms.Button();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSafetyDate = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbStudent = new System.Windows.Forms.ComboBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridSafetyBook)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridSafetyBook
			// 
			this.GridSafetyBook.AllowUserToAddRows = false;
			this.GridSafetyBook.AllowUserToDeleteRows = false;
			this.GridSafetyBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.GridSafetyBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridSafetyBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.GridSafetyBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridSafetyBook.Location = new System.Drawing.Point(12, 22);
			this.GridSafetyBook.Name = "GridSafetyBook";
			this.GridSafetyBook.ReadOnly = true;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GridSafetyBook.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.GridSafetyBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridSafetyBook.Size = new System.Drawing.Size(565, 293);
			this.GridSafetyBook.TabIndex = 0;
			this.GridSafetyBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSafetyBook_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDeleteBook);
			this.groupBox1.Controls.Add(this.btnUpdateBook);
			this.groupBox1.Controls.Add(this.btnAddBook);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtSafetyDate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbStudent);
			this.groupBox1.Controls.Add(this.txtBookName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(584, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(329, 293);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Emanet Kitap İşlemleri";
			// 
			// btnDeleteBook
			// 
			this.btnDeleteBook.BackColor = System.Drawing.Color.Gainsboro;
			this.btnDeleteBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDeleteBook.FlatAppearance.BorderSize = 2;
			this.btnDeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteBook.Image = global::BookCenter.Properties.Resources.remove_24;
			this.btnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteBook.Location = new System.Drawing.Point(257, 251);
			this.btnDeleteBook.Name = "btnDeleteBook";
			this.btnDeleteBook.Size = new System.Drawing.Size(66, 36);
			this.btnDeleteBook.TabIndex = 8;
			this.btnDeleteBook.Text = "SİL";
			this.btnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDeleteBook.UseVisualStyleBackColor = false;
			this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
			// 
			// btnUpdateBook
			// 
			this.btnUpdateBook.BackColor = System.Drawing.Color.Gainsboro;
			this.btnUpdateBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnUpdateBook.FlatAppearance.BorderSize = 2;
			this.btnUpdateBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateBook.Image = global::BookCenter.Properties.Resources.updated_24;
			this.btnUpdateBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdateBook.Location = new System.Drawing.Point(123, 251);
			this.btnUpdateBook.Name = "btnUpdateBook";
			this.btnUpdateBook.Size = new System.Drawing.Size(100, 36);
			this.btnUpdateBook.TabIndex = 7;
			this.btnUpdateBook.Text = "GÜNCELLE";
			this.btnUpdateBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdateBook.UseVisualStyleBackColor = false;
			this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.Color.Gainsboro;
			this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAddBook.FlatAppearance.BorderSize = 2;
			this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddBook.Image = global::BookCenter.Properties.Resources.plus_24;
			this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddBook.Location = new System.Drawing.Point(9, 251);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(78, 36);
			this.btnAddBook.TabIndex = 6;
			this.btnAddBook.Text = "EKLE";
			this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(6, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Teslim Verilen Tarih :";
			// 
			// txtSafetyDate
			// 
			this.txtSafetyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSafetyDate.Location = new System.Drawing.Point(6, 154);
			this.txtSafetyDate.Name = "txtSafetyDate";
			this.txtSafetyDate.Size = new System.Drawing.Size(317, 22);
			this.txtSafetyDate.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(6, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kitap Adı :";
			// 
			// cmbStudent
			// 
			this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbStudent.FormattingEnabled = true;
			this.cmbStudent.Location = new System.Drawing.Point(6, 44);
			this.cmbStudent.Name = "cmbStudent";
			this.cmbStudent.Size = new System.Drawing.Size(317, 24);
			this.cmbStudent.TabIndex = 2;
			// 
			// txtBookName
			// 
			this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBookName.Location = new System.Drawing.Point(6, 100);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(317, 22);
			this.txtBookName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Öğrenci Ad :";
			// 
			// SafetyBookPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(925, 325);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.GridSafetyBook);
			this.Name = "SafetyBookPage";
			this.Text = "SafetyBookPage";
			this.Load += new System.EventHandler(this.SafetyBookPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridSafetyBook)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GridSafetyBook;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbStudent;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDeleteBook;
		private System.Windows.Forms.Button btnUpdateBook;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSafetyDate;
	}
}