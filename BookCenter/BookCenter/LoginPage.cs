using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookCenter.DataBase;
namespace BookCenter
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			using (BookCenterDBEntities1 db=new BookCenterDBEntities1())
			{
				if (db.TBLUserLog.Any(x=>x.Username==textUsername.Text && x.Password==textPassword.Text))
				{
					var UserData = db.TBLUserLog
						.Where(x => x.Username == textUsername.Text && x.Password == textPassword.Text)
						.FirstOrDefault();

					Properties.Settings.Default.UserAutho = UserData.Authorize;
					Properties.Settings.Default.Save();
					BookStorageHome bookStorageHome = new BookStorageHome();
					bookStorageHome.Show();
					this.Hide();
				}
				else
				{
					textUsername.BackColor=Color.Firebrick;
					textUsername.ForeColor=Color.AliceBlue;
					textPassword.BackColor = Color.Firebrick;
					textPassword.ForeColor = Color.AliceBlue;
					MessageBox.Show("Giriş İşlemi Başarısız. Tekrar Deneyin");
				}
			}

			
		}

		private void LoginPage_Load(object sender, EventArgs e)
		{

		}
	}
}
