using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class BookPage : Form
	{
		private int BookID = 0; // her metotdan erişebilmek için tanımlandı.
		public BookPage()
		{
			InitializeComponent();
		}

		private void UpdateHomePage()
		{
			BookStorageHome page = (BookStorageHome)Application.OpenForms["BookStorageHome"];
			if (page != null)
			{
				page.BooksDataFill();
			}
		}

		private void complateData()
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				gridBookPageView.Rows.Clear();                  // yeni veri eklendiğinde üstüne ekleme yapmaması için clear kullanıyoruz.
				gridBookPageView.ColumnCount = 7;
				gridBookPageView.Columns[0].Name = "ID";
				gridBookPageView.Columns[0].Width = 30;
				gridBookPageView.Columns[1].Name = "Kitap Adı";
				gridBookPageView.Columns[2].Name = "Yazar Adı";
				gridBookPageView.Columns[3].Name = "Yayın Evi";
				gridBookPageView.Columns[4].Name = "Kategori";
				gridBookPageView.Columns[5].Name = "Yayın Tarihi";
				gridBookPageView.Columns[6].Name = "Stok";
				gridBookPageView.Columns[6].Width = 40;

				foreach (var item in db.TBLBookList.ToList())
				{
					string[] bookStrings = new string[] { item.ID.ToString(),  item.Name, item.WriterName, item.Publisher, item.Category, item.ReleaseDate.ToString(), item.Stock.ToString() };
					gridBookPageView.Rows.Add(bookStrings);
				}
			}

		}

		private void ClearBookCells()
		{
			txtCategory.Text = null;
			txtBookName.Text = null;
			txtPublisher.Text = null;
			txtStock.Text = null;
			mtxtReleaseDate.Text = null;
			txtWriterName.Text = null;
		}

		private void BookPage_Load(object sender, EventArgs e)
		{
			complateData();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (txtBookName.Text !="" && txtWriterName.Text!= "")
			{
				using (BookCenterDBEntities1 dbEntities = new BookCenterDBEntities1())
				{
					TBLBookList bookList = new TBLBookList();
					bookList.Name = txtBookName.Text;
					bookList.WriterName = txtWriterName.Text;
					bookList.Publisher = txtPublisher.Text;
					bookList.Category = txtCategory.Text;
					bookList.Stock = int.Parse(txtStock.Text);
					bookList.ReleaseDate = DateTime.Parse(mtxtReleaseDate.Text);
					bookList.Images = "book.png";
					dbEntities.TBLBookList.Add(bookList);
					dbEntities.SaveChanges();
					MessageBox.Show("Kayıt Gerçekleştirildi.");
					ClearBookCells();
					UpdateHomePage();
				}
			}
			else
			{
				MessageBox.Show("Boş Kayıt Girilemez.");
			}
		
			complateData();
			
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 dbEntities = new BookCenterDBEntities1())
			{
				if (BookID != 0)
				{
					TBLBookList valueChangeBookList = dbEntities.TBLBookList.Find(BookID);
					valueChangeBookList.Name = txtBookName.Text;
					valueChangeBookList.Publisher = txtPublisher.Text;
					valueChangeBookList.Category = txtCategory.Text;
					valueChangeBookList.Stock = int.Parse(txtStock.Text);
					valueChangeBookList.ReleaseDate = DateTime.Parse(mtxtReleaseDate.Text);
					dbEntities.SaveChanges();
					MessageBox.Show("İşlem başarılı.");
					ClearBookCells();
					UpdateHomePage();
				}
				else
					MessageBox.Show("Veri Seçiniz.");
			}

			complateData();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				if (BookID != 0)
				{
					TBLBookList deleteBook = db.TBLBookList.Find(BookID);
					db.TBLBookList.Remove(deleteBook);
					db.SaveChanges();
					BookID = 0;
					MessageBox.Show("İşlem Başarılı.");
					ClearBookCells();
					UpdateHomePage();
				}
				else
				{
					MessageBox.Show("Veri Seçmediniz.");
				}
			}
			complateData();
		}

		private void gridBookPageView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >-1)
			{
				txtBookName.Text = gridBookPageView.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtWriterName.Text = gridBookPageView.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtPublisher.Text = gridBookPageView.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtCategory.Text = gridBookPageView.Rows[e.RowIndex].Cells[4].Value.ToString();
				mtxtReleaseDate.Text = gridBookPageView.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtStock.Text = gridBookPageView.Rows[e.RowIndex].Cells[6].Value.ToString();
				BookID = int.Parse(gridBookPageView.Rows[e.RowIndex].Cells[0].Value.ToString());
			}
			}
	}
}
