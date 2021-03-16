namespace BookCenter
{
	partial class BookRentalPage
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
			this.gridBookRental = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDeleteRental = new System.Windows.Forms.Button();
			this.dtRentalDate = new System.Windows.Forms.DateTimePicker();
			this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbStudentName = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbBookName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdateRental = new System.Windows.Forms.Button();
			this.btnAddRental = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridBookRental)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridBookRental
			// 
			this.gridBookRental.AllowUserToAddRows = false;
			this.gridBookRental.AllowUserToDeleteRows = false;
			this.gridBookRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridBookRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridBookRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridBookRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBookRental.Location = new System.Drawing.Point(2, 208);
			this.gridBookRental.Name = "gridBookRental";
			this.gridBookRental.ReadOnly = true;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.gridBookRental.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridBookRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBookRental.Size = new System.Drawing.Size(912, 317);
			this.gridBookRental.TabIndex = 0;
			this.gridBookRental.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBookRental_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnDeleteRental);
			this.groupBox1.Controls.Add(this.dtRentalDate);
			this.groupBox1.Controls.Add(this.dtDeliveryDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbStudentName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbBookName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnUpdateRental);
			this.groupBox1.Controls.Add(this.btnAddRental);
			this.groupBox1.Location = new System.Drawing.Point(2, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(912, 190);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kitap Kiralama Sayfası";
			// 
			// btnDeleteRental
			// 
			this.btnDeleteRental.BackColor = System.Drawing.Color.Gainsboro;
			this.btnDeleteRental.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDeleteRental.FlatAppearance.BorderSize = 2;
			this.btnDeleteRental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnDeleteRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteRental.Image = global::BookCenter.Properties.Resources.remove_24;
			this.btnDeleteRental.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDeleteRental.Location = new System.Drawing.Point(810, 149);
			this.btnDeleteRental.Name = "btnDeleteRental";
			this.btnDeleteRental.Size = new System.Drawing.Size(95, 35);
			this.btnDeleteRental.TabIndex = 12;
			this.btnDeleteRental.Text = "Kayıt Sil";
			this.btnDeleteRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteRental.UseVisualStyleBackColor = false;
			this.btnDeleteRental.Click += new System.EventHandler(this.btnDeleteRental_Click);
			// 
			// dtRentalDate
			// 
			this.dtRentalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtRentalDate.Location = new System.Drawing.Point(533, 24);
			this.dtRentalDate.Name = "dtRentalDate";
			this.dtRentalDate.Size = new System.Drawing.Size(209, 22);
			this.dtRentalDate.TabIndex = 11;
			// 
			// dtDeliveryDate
			// 
			this.dtDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtDeliveryDate.Location = new System.Drawing.Point(533, 63);
			this.dtDeliveryDate.Name = "dtDeliveryDate";
			this.dtDeliveryDate.Size = new System.Drawing.Size(209, 22);
			this.dtDeliveryDate.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(360, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Teslim Alınacak Tarih :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(371, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Teslim Verilen Tarih :";
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPrice.Location = new System.Drawing.Point(110, 102);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(212, 22);
			this.txtPrice.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(15, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kitap Fiyat :";
			// 
			// cmbStudentName
			// 
			this.cmbStudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbStudentName.FormattingEnabled = true;
			this.cmbStudentName.Location = new System.Drawing.Point(110, 62);
			this.cmbStudentName.Name = "cmbStudentName";
			this.cmbStudentName.Size = new System.Drawing.Size(212, 24);
			this.cmbStudentName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(7, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Öğrenci Adı :";
			// 
			// cmbBookName
			// 
			this.cmbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbBookName.FormattingEnabled = true;
			this.cmbBookName.Location = new System.Drawing.Point(110, 23);
			this.cmbBookName.Name = "cmbBookName";
			this.cmbBookName.Size = new System.Drawing.Size(212, 24);
			this.cmbBookName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(26, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kitap Adı :";
			// 
			// btnUpdateRental
			// 
			this.btnUpdateRental.BackColor = System.Drawing.Color.Gainsboro;
			this.btnUpdateRental.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnUpdateRental.FlatAppearance.BorderSize = 2;
			this.btnUpdateRental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnUpdateRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateRental.Image = global::BookCenter.Properties.Resources.updated_24;
			this.btnUpdateRental.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdateRental.Location = new System.Drawing.Point(709, 149);
			this.btnUpdateRental.Name = "btnUpdateRental";
			this.btnUpdateRental.Size = new System.Drawing.Size(95, 35);
			this.btnUpdateRental.TabIndex = 1;
			this.btnUpdateRental.Text = "Güncelle";
			this.btnUpdateRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdateRental.UseVisualStyleBackColor = false;
			this.btnUpdateRental.Click += new System.EventHandler(this.btnUpdateRental_Click);
			// 
			// btnAddRental
			// 
			this.btnAddRental.BackColor = System.Drawing.Color.Gainsboro;
			this.btnAddRental.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAddRental.FlatAppearance.BorderSize = 2;
			this.btnAddRental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddRental.Image = global::BookCenter.Properties.Resources.plus_24;
			this.btnAddRental.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddRental.Location = new System.Drawing.Point(608, 149);
			this.btnAddRental.Name = "btnAddRental";
			this.btnAddRental.Size = new System.Drawing.Size(95, 35);
			this.btnAddRental.TabIndex = 0;
			this.btnAddRental.Text = "Kayıt Ekle";
			this.btnAddRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddRental.UseVisualStyleBackColor = false;
			this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
			// 
			// BookRentalPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(916, 529);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridBookRental);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BookRentalPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookRentalPage";
			this.Load += new System.EventHandler(this.BookRentalPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridBookRental)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridBookRental;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDeleteRental;
		private System.Windows.Forms.DateTimePicker dtRentalDate;
		private System.Windows.Forms.DateTimePicker dtDeliveryDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbStudentName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbBookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateRental;
		private System.Windows.Forms.Button btnAddRental;
	}
}