using Bll;
using Bll.Enums;
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
    public partial class FormPickingIn : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private PickingIn NewPickingIn = new PickingIn();

        public FormPickingIn()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void buttonAddLiterature_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            Author selectedAuthor = comboBoxAuthor.SelectedItem as Author;
            Category selectedCategory = comboBoxCategory.SelectedItem as Category;
            Literature literature = new Literature(title, selectedCategory, selectedAuthor);
            var newLiterature = _unitOfWork.Literatures.Add(literature);
            _unitOfWork.Complete();

            NewPickingIn.PickingInItem.Add(new PickingInItem
               {
                    Literature = newLiterature
               });

            RefreshDataGrid();
        }

        private void RefreshAuthors()
        {
            comboBoxAuthor.DataSource = _unitOfWork.Authors.GetAll();
            comboBoxAuthor.DisplayMember = "FullName";
        }

        private void RefreshCategories()
        {
            comboBoxCategory.DataSource = _unitOfWork.Categories.GetAll();
            comboBoxCategory.DisplayMember = "Name";
        }

        public void RefreshDataGrid()
        {
            dataGridViewPickingInItem.DataSource = null;
            dataGridViewPickingInItem.DataSource = NewPickingIn.PickingInItem;
        }

        private void FormPickingIn_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            RefreshAuthors();
            RefreshCategories();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _unitOfWork.PickingIns.Add(NewPickingIn);
            _unitOfWork.Complete();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#5-dodaj-knji%C5%BEnu-gra%C4%91u-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#5-dodaj-knji%C5%BEnu-gra%C4%91u-");
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
