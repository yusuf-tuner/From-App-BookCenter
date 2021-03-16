using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class FrmStudenList : Form
	{
		public string Ogrname = "";
		public FrmStudenList()
		{
			InitializeComponent();
		}

		private void Listele()
		{
			// Öğrencilerimizi görsel olarak  listeletiyoruz.
			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				listViewStudent.Items.Clear();
				int i = 0;
				foreach (var item in db.TBLReaderStudent.ToList())
				{
					listViewStudent.Items.Add(item.Name);
					listViewStudent.Items[i].ImageKey = item.Images;
					i++;
				}
			}
			
		}

		private void FrmStudenList_Load(object sender, EventArgs e)
		{
			Listele();
		}

		private void listViewStudent_DoubleClick(object sender, EventArgs e)
		{
			if (listViewStudent.SelectedItems.Count != 0)
			{
				Ogrname = listViewStudent.SelectedItems[0].Text;
			}
			else
			{
				Ogrname = "";
			}

			using (BookCenterDBEntities1 db = new BookCenterDBEntities1())
			{
				string chooseData = listViewStudent.SelectedItems[0].Text;
				var data = db.TBLReaderStudent.Where(x => x.Name == chooseData).FirstOrDefault();

				if (db.TBLReaderStudent.Any(x => x.ID ==data.ID))
				{
					foreach (var item in db.TBLReaderStudent.Where(x => x.Name == Ogrname && x.ID==data.ID).ToList())
					{
						txtName.Text = item.Name;
						txtSurname.Text = item.Surname;
						cmbGender.Text = item.Gender;
						txtAdress.Text = item.Address;
						BirthDate.Text = item.DateBirth.ToString();
						txtEmail.Text = item.Email;
						txtClasNo.Text = item.ClassNo;
						txtTC.Text = item.NationalNo;
						txtTelephone.Text = item.Telephone;
					}
				}
			}
			
		}
	}
}
