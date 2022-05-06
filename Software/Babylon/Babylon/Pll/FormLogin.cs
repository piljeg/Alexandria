using Bll.Enums;
using Bll;
using Bll.Services;
using Dll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pll
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var result = LoginResult.Null;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidationService.IsNotEmpty(username) || ValidationService.IsNotEmpty(password))
            {
                result = UserManager.LogInUser(username, password);

                if (result != LoginResult.Succesful)
                {
                    textBoxPassword.Clear();
                    MessageBox.Show("Prijava neuspješna!");
                }
                else if (UserManager.LoggedUser.Role.Name != "member")
                {

                    FormMain form = new FormMain()
                    {
                        Owner = this
                    };

                    this.Hide();
                    form.ShowDialog();
                    UserManager.LogOut();
                    this.Show();



                }
                else
                {
                    MessageBox.Show("Prijava neuspješna!");
                }

                textBoxUsername.Clear();
                textBoxPassword.Clear();

            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#2-prijava");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#2-prijava");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
