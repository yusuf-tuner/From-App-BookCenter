namespace BookCenter
{
	partial class BookStorageHome
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookStorageHome));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gridStudentView = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.gridBooksView = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnStudentAdd = new System.Windows.Forms.Button();
			this.BtnStudentList = new System.Windows.Forms.Button();
			this.BtnSafetyBook = new System.Windows.Forms.Button();
			this.BtnBookAdd = new System.Windows.Forms.Button();
			this.BtnBookList = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStudentView)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBooksView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(123, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(640, 79);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "KAYIT ARAMA";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox2.Location = new System.Drawing.Point(203, 46);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(170, 22);
			this.textBox2.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(200, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 18);
			this.label2.TabIndex = 26;
			this.label2.Text = "Kitap Adı :";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.Location = new System.Drawing.Point(9, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(170, 22);
			this.textBox1.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "Öğrenci Adı :";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.gridStudentView);
			this.groupBox2.Location = new System.Drawing.Point(123, 101);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(640, 201);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Öğrenci Bilgileri";
			// 
			// gridStudentView
			// 
			this.gridStudentView.AllowUserToAddRows = false;
			this.gridStudentView.AllowUserToDeleteRows = false;
			this.gridStudentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridStudentView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStudentView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStudentView.Location = new System.Drawing.Point(3, 16);
			this.gridStudentView.Name = "gridStudentView";
			this.gridStudentView.ReadOnly = true;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.gridStudentView.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridStudentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridStudentView.Size = new System.Drawing.Size(634, 182);
			this.gridStudentView.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.gridBooksView);
			this.groupBox4.Location = new System.Drawing.Point(123, 308);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(640, 244);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Kitap Bilgileri";
			// 
			// gridBooksView
			// 
			this.gridBooksView.AllowUserToAddRows = false;
			this.gridBooksView.AllowUserToDeleteRows = false;
			this.gridBooksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridBooksView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridBooksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBooksView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridBooksView.Location = new System.Drawing.Point(3, 16);
			this.gridBooksView.Name = "gridBooksView";
			this.gridBooksView.ReadOnly = true;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.gridBooksView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.gridBooksView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBooksView.Size = new System.Drawing.Size(634, 225);
			this.gridBooksView.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BookCenter.Properties.Resources.bookshelf;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// BtnStudentAdd
			// 
			this.BtnStudentAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnStudentAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnStudentAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnStudentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStudentAdd.Image = global::BookCenter.Properties.Resources.graduated_32x32;
			this.BtnStudentAdd.Location = new System.Drawing.Point(21, 135);
			this.BtnStudentAdd.Name = "BtnStudentAdd";
			this.BtnStudentAdd.Size = new System.Drawing.Size(70, 72);
			this.BtnStudentAdd.TabIndex = 18;
			this.BtnStudentAdd.Text = "Öğrenci Ekle";
			this.BtnStudentAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnStudentAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.BtnStudentAdd.UseVisualStyleBackColor = false;
			this.BtnStudentAdd.Click += new System.EventHandler(this.BtnStudentAdd_Click);
			// 
			// BtnStudentList
			// 
			this.BtnStudentList.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnStudentList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnStudentList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStudentList.Image = global::BookCenter.Properties.Resources._class;
			this.BtnStudentList.Location = new System.Drawing.Point(21, 213);
			this.BtnStudentList.Name = "BtnStudentList";
			this.BtnStudentList.Size = new System.Drawing.Size(70, 72);
			this.BtnStudentList.TabIndex = 19;
			this.BtnStudentList.Text = "Öğr. Listele";
			this.BtnStudentList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnStudentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.BtnStudentList.UseVisualStyleBackColor = false;
			this.BtnStudentList.Click += new System.EventHandler(this.BtnStudentList_Click);
			// 
			// BtnSafetyBook
			// 
			this.BtnSafetyBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnSafetyBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnSafetyBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnSafetyBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSafetyBook.Image = global::BookCenter.Properties.Resources.padlock;
			this.BtnSafetyBook.Location = new System.Drawing.Point(21, 447);
			this.BtnSafetyBook.Name = "BtnSafetyBook";
			this.BtnSafetyBook.Size = new System.Drawing.Size(70, 72);
			this.BtnSafetyBook.TabIndex = 22;
			this.BtnSafetyBook.Text = "Emanet Kitaplar";
			this.BtnSafetyBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnSafetyBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.BtnSafetyBook.UseVisualStyleBackColor = false;
			this.BtnSafetyBook.Click += new System.EventHandler(this.BtnSafetyBook_Click);
			// 
			// BtnBookAdd
			// 
			this.BtnBookAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnBookAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnBookAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBookAdd.Image = global::BookCenter.Properties.Resources.study;
			this.BtnBookAdd.Location = new System.Drawing.Point(21, 291);
			this.BtnBookAdd.Name = "BtnBookAdd";
			this.BtnBookAdd.Size = new System.Drawing.Size(70, 72);
			this.BtnBookAdd.TabIndex = 20;
			this.BtnBookAdd.Text = "Kitap Ekle";
			this.BtnBookAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.BtnBookAdd.UseVisualStyleBackColor = false;
			this.BtnBookAdd.Click += new System.EventHandler(this.BtnBookAdd_Click);
			// 
			// BtnBookList
			// 
			this.BtnBookList.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BtnBookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.BtnBookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.BtnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBookList.Image = global::BookCenter.Properties.Resources.study;
			this.BtnBookList.Location = new System.Drawing.Point(21, 369);
			this.BtnBookList.Name = "BtnBookList";
			this.BtnBookList.Size = new System.Drawing.Size(70, 72);
			this.BtnBookList.TabIndex = 21;
			this.BtnBookList.Text = "Kitap Listele";
			this.BtnBookList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.BtnBookList.UseVisualStyleBackColor = false;
			this.BtnBookList.Click += new System.EventHandler(this.BtnBookList_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::BookCenter.Properties.Resources.study;
			this.button1.Location = new System.Drawing.Point(21, 525);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 72);
			this.button1.TabIndex = 24;
			this.button1.Text = "Kitap Kirala";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BookStorageHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(775, 606);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BtnStudentAdd);
			this.Controls.Add(this.BtnStudentList);
			this.Controls.Add(this.BtnSafetyBook);
			this.Controls.Add(this.BtnBookAdd);
			this.Controls.Add(this.BtnBookList);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BookStorageHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookStorageHome";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BookStorageHome_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStudentView)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridBooksView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView gridStudentView;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView gridBooksView;
		private System.Windows.Forms.Button BtnStudentAdd;
		private System.Windows.Forms.Button BtnStudentList;
		private System.Windows.Forms.Button BtnSafetyBook;
		private System.Windows.Forms.Button BtnBookAdd;
		private System.Windows.Forms.Button BtnBookList;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}