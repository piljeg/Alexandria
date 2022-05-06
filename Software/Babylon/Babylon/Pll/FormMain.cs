using Bll.Services;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if (UserManager.LoggedUser.Role.Name == "user")
            {
                buttonUsers.Enabled = false;
            }

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormUsers newForm = new FormUsers();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            UserManager.LogOut();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FormLogin")
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }

            }
        }

        private void buttonLiterature_Click(object sender, EventArgs e)
        {
            FormLiteratures newForm = new FormLiteratures();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }


        private void buttonLoans_Click(object sender, EventArgs e)
        {
            FormLoans newForm = new FormLoans();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#3-po%C4%8Detna-stranica");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#3-po%C4%8Detna-stranica");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics newForm = new FormStatistics();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

    }
}
