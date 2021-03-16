using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class SafetyBookPage : Form
	{
		private int SafetyID = 0;
		public SafetyBookPage()
		{
			InitializeComponent();
		}

		private void ClearCell()
		{
			txtBookName.Text = null;
			txtSafetyDate.Text = null;
			cmbStudent.Text = null;
		}
		private void fill()
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				GridSafetyBook.Rows.Clear();
				GridSafetyBook.ColumnCount = 5;
				GridSafetyBook.Columns[0].Name = "ID";
				GridSafetyBook.Columns[0].Width = 40;
				GridSafetyBook.Columns[1].Name = "Öğrenci Adı";
				GridSafetyBook.Columns[2].Name = "Emanet Kitap Adı";
				GridSafetyBook.Columns[3].Name = "Emanet Tarihi";
				GridSafetyBook.Columns[4].Name = "Personel";
				

				foreach (var item in db.TBLSafetyBook.ToList())
				{
					string ogrAd = db.TBLReaderStudent.Where(x => x.ID == item.ReaderStuID).FirstOrDefault().Name;
					string[] results=new string[] {item.ID.ToString(),ogrAd,item.BookName,item.SafetyDate.ToString(),item.PersonelID.ToString()};
					GridSafetyBook.Rows.Add(results);
				}
			}
		}
		private void SafetyBookPage_Load(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				cmbStudent.DataSource = db.TBLReaderStudent.ToList();
				cmbStudent.DisplayMember = "Name";
				cmbStudent.ValueMember = "ID";
			}
			cmbStudent.Text = null;
			fill();

		}

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			if (txtBookName.Text != "" && cmbStudent.Text != "")
			{
				using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
				{
					TBLSafetyBook book = new TBLSafetyBook();
					book.BookName = txtBookName.Text;
					book.SafetyDate = Convert.ToDateTime(txtSafetyDate.Text);
					book.ReaderStuID = int.Parse(cmbStudent.SelectedValue.ToString());
					book.PersonelID = 0;
					db.TBLSafetyBook.Add(book);
					db.SaveChanges();
					MessageBox.Show("Ekleme işlemi Başarılıdır.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Boş Kayıt Girilemez.");
			}
			fill();
		}

		private void GridSafetyBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// tıklama ile hücreleri dolduruyoruz ve ıd tutuyoruz.

			if (e.RowIndex >-1)
			{
				txtBookName.Text = GridSafetyBook.Rows[e.RowIndex].Cells[2].Value.ToString();
				cmbStudent.Text = GridSafetyBook.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtSafetyDate.Text = GridSafetyBook.Rows[e.RowIndex].Cells[3].Value.ToString();
				SafetyID = int.Parse(GridSafetyBook.Rows[e.RowIndex].Cells[0].Value.ToString());
			}
		}

		private void btnUpdateBook_Click(object sender, EventArgs e)
		{
			if (SafetyID!=0 && cmbStudent.Text!="")
			{
				using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
				{
					TBLSafetyBook bk = db.TBLSafetyBook.Find(SafetyID);
					bk.BookName = txtBookName.Text;
					bk.ReaderStuID = int.Parse(cmbStudent.SelectedValue.ToString());
					bk.SafetyDate = Convert.ToDateTime(txtSafetyDate.Text);
					bk.PersonelID = 0;
					db.SaveChanges();
					MessageBox.Show("Bilgiler Güncellendi.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Veri Seçmelisiniz.");
			}
			fill();
		}

		private void btnDeleteBook_Click(object sender, EventArgs e)
		{
			if (SafetyID != 0 && cmbStudent.Text!="")
			{
				using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
				{
					TBLSafetyBook dltbook = db.TBLSafetyBook.Find(SafetyID);
					db.TBLSafetyBook.Remove(dltbook);
					db.SaveChanges();
					SafetyID = 0;
					MessageBox.Show("Bilgiler Silinmiştir.");
					ClearCell();
				}
			}
			else
			{
				MessageBox.Show("Veri Seçmelisiniz.");
			}
			fill();
		}
	}
}
