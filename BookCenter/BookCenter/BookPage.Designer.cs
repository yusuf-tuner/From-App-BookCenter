namespace BookCenter
{
	partial class BookPage
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
			this.groupBoxBook = new System.Windows.Forms.GroupBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.mtxtReleaseDate = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPublisher = new System.Windows.Forms.TextBox();
			this.txtWriterName = new System.Windows.Forms.TextBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gridBookPageView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGüncelle = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.groupBoxBook.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBookPageView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxBook
			// 
			this.groupBoxBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxBook.Controls.Add(this.txtStock);
			this.groupBoxBook.Controls.Add(this.mtxtReleaseDate);
			this.groupBoxBook.Controls.Add(this.label6);
			this.groupBoxBook.Controls.Add(this.label5);
			this.groupBoxBook.Controls.Add(this.txtCategory);
			this.groupBoxBook.Controls.Add(this.label1);
			this.groupBoxBook.Controls.Add(this.txtPublisher);
			this.groupBoxBook.Controls.Add(this.txtWriterName);
			this.groupBoxBook.Controls.Add(this.txtBookName);
			this.groupBoxBook.Controls.Add(this.label4);
			this.groupBoxBook.Controls.Add(this.label3);
			this.groupBoxBook.Controls.Add(this.label2);
			this.groupBoxBook.Location = new System.Drawing.Point(0, 0);
			this.groupBoxBook.Name = "groupBoxBook";
			this.groupBoxBook.Size = new System.Drawing.Size(523, 250);
			this.groupBoxBook.TabIndex = 0;
			this.groupBoxBook.TabStop = false;
			this.groupBoxBook.Text = "Kitap Bilgileri";
			// 
			// txtStock
			// 
			this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtStock.Location = new System.Drawing.Point(104, 212);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(190, 22);
			this.txtStock.TabIndex = 50;
			// 
			// mtxtReleaseDate
			// 
			this.mtxtReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mtxtReleaseDate.Location = new System.Drawing.Point(104, 175);
			this.mtxtReleaseDate.Name = "mtxtReleaseDate";
			this.mtxtReleaseDate.Size = new System.Drawing.Size(190, 22);
			this.mtxtReleaseDate.TabIndex = 49;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(58, 214);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 18);
			this.label6.TabIndex = 48;
			this.label6.Text = "Stok :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(12, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 18);
			this.label5.TabIndex = 47;
			this.label5.Text = "Yayın Tarihi :";
			// 
			// txtCategory
			// 
			this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategory.Location = new System.Drawing.Point(104, 139);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(190, 22);
			this.txtCategory.TabIndex = 46;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(33, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 18);
			this.label1.TabIndex = 45;
			this.label1.Text = "Kategori :";
			// 
			// txtPublisher
			// 
			this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPublisher.Location = new System.Drawing.Point(104, 107);
			this.txtPublisher.Name = "txtPublisher";
			this.txtPublisher.Size = new System.Drawing.Size(190, 22);
			this.txtPublisher.TabIndex = 44;
			// 
			// txtWriterName
			// 
			this.txtWriterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtWriterName.Location = new System.Drawing.Point(104, 73);
			this.txtWriterName.Name = "txtWriterName";
			this.txtWriterName.Size = new System.Drawing.Size(190, 22);
			this.txtWriterName.TabIndex = 43;
			// 
			// txtBookName
			// 
			this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBookName.Location = new System.Drawing.Point(104, 42);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(190, 22);
			this.txtBookName.TabIndex = 42;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(31, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 18);
			this.label4.TabIndex = 41;
			this.label4.Text = "Yayın Evi :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(27, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 18);
			this.label3.TabIndex = 40;
			this.label3.Text = "Yazar Adı :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(28, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 18);
			this.label2.TabIndex = 39;
			this.label2.Text = "Kitap Adı :";
			// 
			// gridBookPageView
			// 
			this.gridBookPageView.AllowUserToAddRows = false;
			this.gridBookPageView.AllowUserToDeleteRows = false;
			this.gridBookPageView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridBookPageView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridBookPageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBookPageView.Location = new System.Drawing.Point(0, 257);
			this.gridBookPageView.Name = "gridBookPageView";
			this.gridBookPageView.ReadOnly = true;
			this.gridBookPageView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBookPageView.Size = new System.Drawing.Size(663, 290);
			this.gridBookPageView.TabIndex = 1;
			this.gridBookPageView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookPageView_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGüncelle);
			this.groupBox1.Controls.Add(this.btnKaydet);
			this.groupBox1.Location = new System.Drawing.Point(529, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(134, 250);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "İşlemler";
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSil.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnSil.FlatAppearance.BorderSize = 2;
			this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSil.Image = global::BookCenter.Properties.Resources.remove_24;
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSil.Location = new System.Drawing.Point(6, 208);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(121, 35);
			this.btnSil.TabIndex = 30;
			this.btnSil.Text = "SİL";
			this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGüncelle
			// 
			this.btnGüncelle.BackColor = System.Drawing.Color.Gainsboro;
			this.btnGüncelle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnGüncelle.FlatAppearance.BorderSize = 2;
			this.btnGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGüncelle.Image = global::BookCenter.Properties.Resources.updated_24;
			this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGüncelle.Location = new System.Drawing.Point(6, 167);
			this.btnGüncelle.Name = "btnGüncelle";
			this.btnGüncelle.Size = new System.Drawing.Size(121, 35);
			this.btnGüncelle.TabIndex = 29;
			this.btnGüncelle.Text = "GÜNCELLE";
			this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGüncelle.UseVisualStyleBackColor = false;
			this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.Color.Gainsboro;
			this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnKaydet.FlatAppearance.BorderSize = 2;
			this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKaydet.Image = global::BookCenter.Properties.Resources.plus_24;
			this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKaydet.Location = new System.Drawing.Point(6, 126);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(121, 35);
			this.btnKaydet.TabIndex = 28;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// BookPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(667, 559);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridBookPageView);
			this.Controls.Add(this.groupBoxBook);
			this.Name = "BookPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookPage";
			this.Load += new System.EventHandler(this.BookPage_Load);
			this.groupBoxBook.ResumeLayout(false);
			this.groupBoxBook.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBookPageView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxBook;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.MaskedTextBox mtxtReleaseDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPublisher;
		private System.Windows.Forms.TextBox txtWriterName;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gridBookPageView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGüncelle;
		private System.Windows.Forms.Button btnKaydet;
	}
}