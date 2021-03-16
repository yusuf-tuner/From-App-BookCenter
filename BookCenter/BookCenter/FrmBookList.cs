using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class FrmBookList : Form
	{
		private string bookName = "";
		public FrmBookList()
		{
			InitializeComponent();
		}

		private void Listele()
		{
			// Öğrencilerimizi görsel olarak  listeletiyoruz.
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				listViewBook.Items.Clear();
				int i = 0;
				foreach (var item in db.TBLBookList.ToList())
				{
					listViewBook.Items.Add(item.Name);
					listViewBook.Items[i].ImageKey = item.Images;
					i++;
				}
			}

		}

		private void FrmBookList_Load(object sender, EventArgs e)
		{
			Listele();
		}

		private void listViewBook_DoubleClick(object sender, EventArgs e)
		{

			if (listViewBook.SelectedItems.Count != 0)
			{
				bookName = listViewBook.SelectedItems[0].Text;
			}
			else
			{
				bookName = "";
			}

			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				string chooseBook = listViewBook.SelectedItems[0].Text;
				var data = db.TBLBookList.Where(x => x.Name == chooseBook).FirstOrDefault();

				if (db.TBLBookList.Any(x => x.ID == data.ID))
				{
					foreach (var item in db.TBLBookList.Where(x => x.Name == bookName && x.ID == data.ID).ToList())
					{
						txtBookName.Text = item.Name;
						txtWriterName.Text = item.WriterName;
						txtPublisher.Text = item.Publisher;
						txtCategory.Text = item.Category;
						ReleaseDate.Text = item.ReleaseDate.ToString();
						txtStock.Text = item.Stock.ToString();
					}
				}
			}
		}
	}
}
