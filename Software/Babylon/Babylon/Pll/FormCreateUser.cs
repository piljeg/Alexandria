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
    public partial class FormCreateUser : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public FormCreateUser()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshRoles()
        {
            comboBoxRoles.DataSource = _unitOfWork.Roles.GetAll();
            comboBoxRoles.DisplayMember = "Name";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string firstname = this.textBoxName.Text;
            string surname = this.textBoxSurname.Text;
            string username = this.textBoxUserName.Text;
            string password = this.textBoxPassword.Text;
            string email = this.textBoxEmail.Text;
            string phoneNumber = this.textBoxPhoneNumber.Text;
            DateTime BirthDate = this.dateTimePickerBirthDate.Value;
            Role role = comboBoxRoles.SelectedItem as Role;

            if(!ValidationService.AssertEmail(email) || !ValidationService.IsPhoneNumberValid(phoneNumber)
                || !ValidationService.AssertStringLenght(firstname, 3) || !ValidationService.AssertStringLenght(surname, 3)
                || !ValidationService.AssertStringLenght(password, 3))
            {
                MessageBox.Show("Unesite ispravne podatke");
                return;
            }

            User newUser = new User
            {
                FirstName = firstname,
                LastName = surname,
                UserName = username,
                Password = password,
                EMail = email,
                PhoneNumber = phoneNumber,
                DateOfBirth = BirthDate,
                Role = role
            };

            _unitOfWork.Users.Add(newUser);
            _unitOfWork.Complete();
            this.Close();
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            RefreshRoles();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#10-kreiraj-korisnika-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#10-kreiraj-korisnika-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
