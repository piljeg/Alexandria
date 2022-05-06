using Bll.Services;
using Bll;
using System;
using Dll.Model;
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
    public partial class FormUsers : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormUsers()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser form = new FormCreateUser();
            this.Hide();
            form.ShowDialog();
            this.Show();
            RefreshUsers();
            RefreshMemberships();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateMembership_Click(object sender, EventArgs e)
        {
            FormCreateMembership newForm= new FormCreateMembership();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            RefreshUsers();
            RefreshMemberships();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            RefreshUsers();
            RefreshMemberships();
        }

        private void RefreshUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = _unitOfWork.Users.GetAllUsers();
        }

        private void RefreshMemberships()
        {
            dataGridViewMemberships.DataSource = null;
            dataGridViewMemberships.DataSource = _unitOfWork.Memberships.GetAll();
        }

        private void buttonActivateDeactivate_Click(object sender, EventArgs e)
        {
            User selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            if (selectedUser.Locked == true)
            {
                selectedUser.Locked = false;
            }
            else
            {
                selectedUser.Locked = true;
            }

            _unitOfWork.Users.Update(selectedUser, selectedUser.Id);
            _unitOfWork.Complete();

            RefreshUsers();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            User selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as User;
            _unitOfWork.Users.Delete(selectedUser);
            _unitOfWork.Complete();

            RefreshUsers();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#9-korisnici-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#9-korisnici-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
    }
}
