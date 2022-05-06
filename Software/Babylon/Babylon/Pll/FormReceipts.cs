using Bll;
using Bll.Services;
using Dll.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pll
{
    public partial class FormReceipts : Form
    {
        private readonly UnitOfWork _unitOfWork;


        public FormReceipts()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
        }

        private void FormReceipts_Load(object sender, EventArgs e)
        {
            RefreshReceipts();
        }

        private void RefreshReceipts()
        {
            receiptBindingSource.DataSource = _unitOfWork.Receipts.GetAllReceipts();
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
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#15-ra%C4%8Duni-");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#15-ra%C4%8Duni-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void receiptBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            receiptItemBindingSource.DataSource = _unitOfWork.Receipts.GetAllReceiptItems(receiptBindingSource.Current as Receipt);
        }
    }
}
