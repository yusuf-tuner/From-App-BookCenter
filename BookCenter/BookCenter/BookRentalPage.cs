using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class BookRentalPage : Form
	{
		private int bookID = 0;
		public BookRentalPage()
		{
			InitializeComponent();
		}

		private void ClearCell()
		{
			dtDeliveryDate.Text = null;
			dtRentalDate.Text = null;
			txtPrice.Text = null;
			cmbBookName.Text = null;
			cmbStudentName.Text = null;
		}

		private void Fill()
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				gridBookRental.Rows.Clear();
				gridBookRental.ColumnCount = 7;
				gridBookRental.Columns[0].Name = "ID";
				gridBookRental.Columns[0].Width = 40;
				gridBookRental.Columns[1].Name = "Kitap Adı";
				gridBookRental.Columns[2].Name = "Öğrenci Adı";
				gridBookRental.Columns[3].Name = "Kiralama Tarihi";
				gridBookRental.Columns[4].Name = "Teslim Tarihi";
				gridBookRental.Columns[5].Name = "Kitap Fiyatı";
				gridBookRental.Columns[6].Name = "Personel";

				foreach (var item in db.TBLBookRental.ToList())
				{
					string ogrAd = db.TBLReaderStudent.Where(x => x.ID == item.ReaderStuID).FirstOrDefault().Name;
					string bookname = db.TBLBookList.Where(x => x.ID == item.BookID).FirstOrDefault().Name;
					string price = Convert.ToDecimal(item.BookPrice).ToString("N");

					string[] results = new string[]
					{
						item.ID.ToString(),
						bookname,
						ogrAd,
						item.BookRentDay.ToString(),
						item.DeliveryDate.ToString(),
						price,
						item.PersonelID.ToString()
					};
					gridBookRental.Rows.Add(results);
				}
			}

		}

		private void BookRentalPage_Load(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				cmbBookName.DataSource = db.TBLBookList.ToList();
				cmbBookName.DisplayMember = "Name";
				cmbBookName.ValueMember = "ID";
				cmbStudentName.DataSource = db.TBLReaderStudent.ToList();
				cmbStudentName.DisplayMember = "Name";
				cmbStudentName.ValueMember = "ID";
			}
			cmbBookName.Text = null;
			cmbStudentName.Text = null;
			Fill();
		}

		private void btnAddRental_Click(object sender, EventArgs e)
		{
			if (cmbBookName.Text != "" && cmbStudentName.Text != "")
			{
				using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
				{
					TBLBookRental b = new TBLBookRental();
					b.BookID = int.Parse(cmbBookName.SelectedValue.ToString());
					b.ReaderStuID = int.Parse(cmbStudentName.SelectedValue.ToString());
					b.BookPrice = Convert.ToDecimal(txtPrice.Text);
					b.PersonelID = 0;
					b.BookRentDay = Convert.ToDateTime(dtRentalDate.Text);
					b.DeliveryDate = Convert.ToDateTime(dtDeliveryDate.Text);
					db.TBLBookRental.Add(b);
					db.SaveChanges();
					MessageBox.Show("Kayıt İşlemi Başarılı.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Alanları Boş Giremezsiniz.");
			}
			Fill();
		}

		private void btnUpdateRental_Click(object sender, EventArgs e)
		{
			if (bookID != 0 && cmbBookName.Text != "")
			{
				using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
				{
					TBLBookRental br = db.TBLBookRental.Find(bookID);
					br.BookID = int.Parse(cmbBookName.SelectedValue.ToString());
					br.ReaderStuID = int.Parse(cmbStudentName.SelectedValue.ToString());
					br.BookPrice = Convert.ToDecimal(txtPrice.Text);
					br.PersonelID = 0;
					br.BookRentDay = Convert.ToDateTime(dtRentalDate.Text);
					br.DeliveryDate = Convert.ToDateTime(dtDeliveryDate.Text);
					db.SaveChanges();
					MessageBox.Show("Güncelleme işlemi Başarılı.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Veri Seçmelisiniz.");
			}
			Fill();
		}

		private void gridBookRental_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				bookID = int.Parse(gridBookRental.Rows[e.RowIndex].Cells[0].Value.ToString());
				cmbBookName.Text = gridBookRental.Rows[e.RowIndex].Cells[1].Value.ToString();
				cmbStudentName.Text = gridBookRental.Rows[e.RowIndex].Cells[2].Value.ToString();
				dtRentalDate.Text = gridBookRental.Rows[e.RowIndex].Cells[3].Value.ToString();
				dtDeliveryDate.Text = gridBookRental.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtPrice.Text = Convert.ToDecimal(gridBookRental.Rows[e.RowIndex].Cells[5].Value).ToString("N");
			}
		}

		private void btnDeleteRental_Click(object sender, EventArgs e)
		{
			if (bookID != 0)
			{
				using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
				{
					TBLBookRental bkr = db.TBLBookRental.Find(bookID);
					db.TBLBookRental.Remove(bkr);
					db.SaveChanges();
					bookID = 0;
					MessageBox.Show("Kayıt Başarıyla Silindi.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Veri Seçmelisiniz.");
			}
		}
	}
}
