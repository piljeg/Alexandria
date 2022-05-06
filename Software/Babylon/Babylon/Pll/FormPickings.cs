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
    public partial class FormPickings : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormPickings()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void FormPickings_Load(object sender, EventArgs e)
        {
            textBoxLiteratureTitle.ReadOnly = true;
            RefreshPickingsIn();
            RefreshPickingsOut();
        }

        private void RefreshPickingsOut()
        {
            dataGridViewPickingsOut.DataSource = null;
            dataGridViewPickingsOut.DataSource = _unitOfWork.PickingOuts.GetAll();
        }

        private void RefreshPickingsIn()
        {
            pickingInBindingSource.DataSource = _unitOfWork.PickingIns.GetAllPickingsIn();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#8-primke-i-otpremnice-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#8-primke-i-otpremnice-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pickingInBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            pickingInItemBindingSource.DataSource = _unitOfWork.PickingIns.GetAllPickingInItems(pickingInBindingSource.Current as PickingIn);
        }

        private void dataGridViewPickingInItems_SelectionChanged(object sender, EventArgs e)
        {
            int literatureId = 0;
            if(dataGridViewPickingInItems.Rows.Count > 0) 
            {
                literatureId = (int)dataGridViewPickingInItems.CurrentRow.Cells[1].Value;
            }
            if(literatureId != 0) 
            {
                textBoxLiteratureTitle.Text = _unitOfWork.Literatures.GetById(literatureId).Title;
            }
        }
    }
}
