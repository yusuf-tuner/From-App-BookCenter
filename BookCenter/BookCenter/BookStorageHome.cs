using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class BookStorageHome : Form
	{
		public BookStorageHome()
		{
			InitializeComponent();
		}

		public void studentDataFill()
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				gridStudentView.Rows.Clear();
				gridStudentView.ColumnCount = 11;
				gridStudentView.Columns[0].Name = "ID";
				gridStudentView.Columns[0].Width = 40;
				gridStudentView.Columns[1].Name = "T.C Kimlik";
				gridStudentView.Columns[1].Width = 90;
				gridStudentView.Columns[2].Name = "İsim";
				gridStudentView.Columns[3].Name = "Soyisim";
				gridStudentView.Columns[4].Name = "Sınıf No";
				gridStudentView.Columns[4].Width = 60;
				gridStudentView.Columns[5].Name = "Doğum Tarihi";
				gridStudentView.Columns[6].Name = "Telefon";
				gridStudentView.Columns[6].Width = 90;
				gridStudentView.Columns[7].Name = "Eposta";
				gridStudentView.Columns[8].Name = "Üyelik Tarihi";
				gridStudentView.Columns[9].Name = "Cinsiyet";
				gridStudentView.Columns[10].Name = "Adres";
				foreach (var x in db.TBLReaderStudent.ToList())
				{
					string[] students = new string[]
					{
						x.ID.ToString(), x.NationalNo, x.Name, x.Surname,x.ClassNo ,x.DateBirth.ToString(), x.Telephone,
						x.Email,x.MembershipDate.ToString(),x.Gender,x.Address
					};

					gridStudentView.Rows.Add(students);
				}


			}
		}

		public void BooksDataFill()
		{
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				gridBooksView.Rows.Clear();                  // yeni veri eklendiğinde üstüne ekleme yapmaması için clear kullanıyoruz.
				gridBooksView.ColumnCount = 7;
				gridBooksView.Columns[0].Name = "ID";
				gridBooksView.Columns[0].Width = 30;
				gridBooksView.Columns[1].Name = "Kitap Adı";
				gridBooksView.Columns[2].Name = "Yazar Adı";
				gridBooksView.Columns[3].Name = "Yayın Evi";
				gridBooksView.Columns[4].Name = "Kategori";
				gridBooksView.Columns[5].Name = "Yayın Tarihi";
				gridBooksView.Columns[6].Name = "Stok";
				gridBooksView.Columns[6].Width = 50;

				foreach (var item in db.TBLBookList.ToList())
				{
					string[] books = new string[] { item.ID.ToString(), item.Name, item.WriterName, item.Publisher, item.Category, item.ReleaseDate.ToString(), item.Stock.ToString() };
					gridBooksView.Rows.Add(books);
				}
			}
		}

		private void BtnStudentAdd_Click(object sender, EventArgs e)
		{
			StudentAdd student = new StudentAdd();
			student.Show();

		}

		private void BtnBookAdd_Click(object sender, EventArgs e)
		{
			BookPage book = new BookPage();
			book.Show();
		}

		private void BookStorageHome_Load(object sender, EventArgs e)
		{
			studentDataFill();
			BooksDataFill();
		}

		private void BtnSafetyBook_Click(object sender, EventArgs e)
		{
			SafetyBookPage frm = new SafetyBookPage();
			frm.Show();
		}

		private void BtnStudentList_Click(object sender, EventArgs e)
		{
			FrmStudenList frm = new FrmStudenList();
			frm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BookRentalPage frm = new BookRentalPage();
			frm.Show();
		}

		private void BtnBookList_Click(object sender, EventArgs e)
		{
			FrmBookList frm = new FrmBookList();
			frm.Show();
		}
	}
}
