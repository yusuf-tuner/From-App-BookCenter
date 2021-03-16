namespace BookCenter
{
	partial class FrmBookList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookList));
			this.listViewBook = new System.Windows.Forms.ListView();
			this.ımageListBook = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.ReleaseDate = new System.Windows.Forms.MaskedTextBox();
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
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewBook
			// 
			this.listViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listViewBook.BackColor = System.Drawing.Color.Lavender;
			this.listViewBook.HideSelection = false;
			this.listViewBook.LargeImageList = this.ımageListBook;
			this.listViewBook.Location = new System.Drawing.Point(2, 2);
			this.listViewBook.Name = "listViewBook";
			this.listViewBook.Size = new System.Drawing.Size(607, 413);
			this.listViewBook.TabIndex = 1;
			this.listViewBook.UseCompatibleStateImageBehavior = false;
			this.listViewBook.DoubleClick += new System.EventHandler(this.listViewBook_DoubleClick);
			// 
			// ımageListBook
			// 
			this.ımageListBook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListBook.ImageStream")));
			this.ımageListBook.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageListBook.Images.SetKeyName(0, "book.png");
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtStock);
			this.groupBox1.Controls.Add(this.ReleaseDate);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCategory);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPublisher);
			this.groupBox1.Controls.Add(this.txtWriterName);
			this.groupBox1.Controls.Add(this.txtBookName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(615, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(301, 413);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kitap Bilgileri";
			// 
			// txtStock
			// 
			this.txtStock.Enabled = false;
			this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtStock.Location = new System.Drawing.Point(100, 203);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(190, 22);
			this.txtStock.TabIndex = 62;
			// 
			// ReleaseDate
			// 
			this.ReleaseDate.Enabled = false;
			this.ReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ReleaseDate.Location = new System.Drawing.Point(100, 166);
			this.ReleaseDate.Name = "ReleaseDate";
			this.ReleaseDate.Size = new System.Drawing.Size(190, 22);
			this.ReleaseDate.TabIndex = 61;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(54, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 18);
			this.label6.TabIndex = 60;
			this.label6.Text = "Stok :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 18);
			this.label5.TabIndex = 59;
			this.label5.Text = "Yayın Tarihi :";
			// 
			// txtCategory
			// 
			this.txtCategory.Enabled = false;
			this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCategory.Location = new System.Drawing.Point(100, 130);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(190, 22);
			this.txtCategory.TabIndex = 58;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(29, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 18);
			this.label1.TabIndex = 57;
			this.label1.Text = "Kategori :";
			// 
			// txtPublisher
			// 
			this.txtPublisher.Enabled = false;
			this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPublisher.Location = new System.Drawing.Point(100, 98);
			this.txtPublisher.Name = "txtPublisher";
			this.txtPublisher.Size = new System.Drawing.Size(190, 22);
			this.txtPublisher.TabIndex = 56;
			// 
			// txtWriterName
			// 
			this.txtWriterName.Enabled = false;
			this.txtWriterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtWriterName.Location = new System.Drawing.Point(100, 64);
			this.txtWriterName.Name = "txtWriterName";
			this.txtWriterName.Size = new System.Drawing.Size(190, 22);
			this.txtWriterName.TabIndex = 55;
			// 
			// txtBookName
			// 
			this.txtBookName.Enabled = false;
			this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBookName.Location = new System.Drawing.Point(100, 33);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(190, 22);
			this.txtBookName.TabIndex = 54;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(27, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 18);
			this.label4.TabIndex = 53;
			this.label4.Text = "Yayın Evi :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(23, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 18);
			this.label3.TabIndex = 52;
			this.label3.Text = "Yazar Adı :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(24, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 18);
			this.label2.TabIndex = 51;
			this.label2.Text = "Kitap Adı :";
			// 
			// FrmBookList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(919, 420);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listViewBook);
			this.Name = "FrmBookList";
			this.Text = "FrmBookList";
			this.Load += new System.EventHandler(this.FrmBookList_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewBook;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList ımageListBook;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.MaskedTextBox ReleaseDate;
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
	}
}