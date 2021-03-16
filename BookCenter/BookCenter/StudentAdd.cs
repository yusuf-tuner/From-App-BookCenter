using System;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;

namespace BookCenter
{
	public partial class StudentAdd : Form
	{
		private int studentID = 0;
		public StudentAdd()
		{
			InitializeComponent();
		}

		private void UpdateHomaPage()
		{
			BookStorageHome page = (BookStorageHome)Application.OpenForms["BookStorageHome"];
			if (page != null)
			{
				page.studentDataFill();
			}
		}

		private void StudentDataFill()
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				StudentPageView.Rows.Clear();
				StudentPageView.ColumnCount = 11;
				StudentPageView.Columns[0].Name = "ID";
				StudentPageView.Columns[0].Width = 50;
				StudentPageView.Columns[1].Name = "T.C Kimlik";
				StudentPageView.Columns[2].Name = "İsim";
				StudentPageView.Columns[3].Name = "Soyisim";
				StudentPageView.Columns[4].Name = "Sınıf No";
				StudentPageView.Columns[5].Name = "Doğum Tarihi";
				StudentPageView.Columns[6].Name = "Telefon";
				StudentPageView.Columns[7].Name = "Eposta";
				StudentPageView.Columns[8].Name = "Üyelik Tarihi";
				StudentPageView.Columns[9].Name = "Cinsiyet";
				StudentPageView.Columns[10].Name = "Adres";
				foreach (var x in db.TBLReaderStudent.ToList())
				{
					string[] student = new string[]
					{
						x.ID.ToString(), x.NationalNo, x.Name, x.Surname,x.ClassNo ,x.DateBirth.ToString(), x.Telephone,
						x.Email,x.MembershipDate.ToString(),x.Gender,x.Address
					};

					StudentPageView.Rows.Add(student);
				}
			}
		}

		private void StudentCellsClear()
		{
			txtClass.Text = null;
			txtAdress.Text = null;
			txtSurnameS.Text = null;
			txtNameStudent.Text = null;
			txtNumber.Text = null;
			txtEmail.Text = null;
			cmbGender.Text = null;
			mskDateBirth.Text = null;
			mtxtNational.Text = null;
		}

		private void StudentAdd_Load(object sender, EventArgs e)
		{
			StudentDataFill();
		}

		private void btnOgrKaydet_Click(object sender, EventArgs e)
		{
			if (txtNameStudent.Text!="" && txtSurnameS.Text!="")
			{
				using (BookCenterDBEntities1 dbEntities1 = new BookCenterDBEntities1())
				{
					TBLReaderStudent studentData = new TBLReaderStudent();
					studentData.NationalNo = mtxtNational.Text;
					studentData.Name = txtNameStudent.Text;
					studentData.Surname = txtSurnameS.Text;
					studentData.ClassNo = txtClass.Text;
					studentData.DateBirth = Convert.ToDateTime(mskDateBirth.Text);
					studentData.Telephone = txtNumber.Text;
					studentData.Email = txtEmail.Text;
					studentData.MembershipDate = DateTime.Today;
					studentData.Address = txtAdress.Text;
					studentData.Gender = cmbGender.Text;
					studentData.Images = "Student.png";
					dbEntities1.TBLReaderStudent.Add(studentData);
					dbEntities1.SaveChanges();
					MessageBox.Show("İşlem Başarılı.");
					StudentCellsClear();
					UpdateHomaPage();
				}
			}
			else
			{
				MessageBox.Show("Boş kayıt giremezsiniz.");
			}
			
			StudentDataFill();

		}

		private void btnOgrGuncelle_Click(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				if (studentID!=0)
				{
					TBLReaderStudent updateStudent = db.TBLReaderStudent.Find(studentID);
					updateStudent.NationalNo = mtxtNational.Text;
					updateStudent.Name = txtNameStudent.Text;
					updateStudent.Surname = txtSurnameS.Text;
					updateStudent.ClassNo = txtClass.Text;
					updateStudent.DateBirth = Convert.ToDateTime(mskDateBirth.Text);
					updateStudent.Telephone = txtNumber.Text;
					updateStudent.Email = txtEmail.Text;
					updateStudent.MembershipDate = DateTime.Today;
					updateStudent.Address = txtAdress.Text;
					updateStudent.Gender = cmbGender.Text;
					db.SaveChanges();
					MessageBox.Show("İşlem Başarılı");
					StudentCellsClear();
					UpdateHomaPage();
				}
				else
				{
					MessageBox.Show("Veri Seçmelisiniz.");
				}
			}
			StudentDataFill();
		}

		private void StudentPageView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			mtxtNational.Text = StudentPageView.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtNameStudent.Text = StudentPageView.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtSurnameS.Text = StudentPageView.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtClass.Text = StudentPageView.Rows[e.RowIndex].Cells[4].Value.ToString();
			mskDateBirth.Text = StudentPageView.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtNumber.Text = StudentPageView.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtEmail.Text = StudentPageView.Rows[e.RowIndex].Cells[7].Value.ToString();
			cmbGender.Text = StudentPageView.Rows[e.RowIndex].Cells[9].Value.ToString();
			txtAdress.Text = StudentPageView.Rows[e.RowIndex].Cells[10].Value.ToString();
			studentID = int.Parse(StudentPageView.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		private void btnOgrSil_Click(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				if (studentID!=0)
				{
					TBLReaderStudent deleteStudent = db.TBLReaderStudent.Find(studentID);
					db.TBLReaderStudent.Remove(deleteStudent);
					db.SaveChanges();
					studentID = 0;
					MessageBox.Show("İşlem Başarılı");
					UpdateHomaPage();
				}
				else
				{
					MessageBox.Show("Veri Seçmelisiniz.");
				}
			}
			StudentDataFill();
		}
	}
}
