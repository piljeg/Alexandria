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
    public partial class FormLiteratures : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormLiteratures()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPickingIn_Click(object sender, EventArgs e)
        {
            FormPickingIn form = new FormPickingIn();
            this.Hide();
            form.ShowDialog();
            this.Show();
            RefreshLiteratures();

        }

        private void FormLiteratures_Load(object sender, EventArgs e)
        {
            RefreshLiteratures();
        }

        private void RefreshLiteratures()
        {
            dataGridViewLiteratures.DataSource = null;
            dataGridViewLiteratures.DataSource = _unitOfWork.Literatures.GetAllLiteratures();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            FormAddAuthor form = new FormAddAuthor();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonPickingOut_Click(object sender, EventArgs e)
        {
            Literature selectedLiterature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
            if(_unitOfWork.Literatures.IsLoaned(selectedLiterature.Id))
            {
                MessageBox.Show("Knjiga je posuđena!");
                return;
            }
            if(selectedLiterature != null)
            {

                PickingOut newPickingOut = new PickingOut { 
                    Description = $"Razdužena knjižna građa, ID = {selectedLiterature.Id}, Naslov = {selectedLiterature.Title}"
                };

                _unitOfWork.PickingOuts.Add(newPickingOut);
                _unitOfWork.Literatures.Delete(selectedLiterature);
                _unitOfWork.Complete();

                RefreshLiteratures();
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#4-knji%C5%BEne-gra%C4%91e-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#4-knji%C5%BEne-gra%C4%91e-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonPickings_Click(object sender, EventArgs e)
        {
            FormPickings form = new FormPickings();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
