using Bll.Services;
using Bll;
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
using AForge.Video.DirectShow;
using ZXing;

namespace Pll
{
    public partial class FormNewLoan : Form
    {
        private readonly UnitOfWork _unitOfWork;
        VideoCaptureDevice videoCaptureDevice;
        FilterInfoCollection filterInfoCollection;
        public FormNewLoan()
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

        private void FormLoans_Load(object sender, EventArgs e)
        {
            RefreshLiteratures();
            RefreshMemberships();
        }

        private void RefreshMemberships()
        {
            dataGridViewMemberships.DataSource = null;
            dataGridViewMemberships.DataSource = _unitOfWork.Memberships.GetAllMemberships().Where(x => (DateTime.Compare(x.DateTo, DateTime.Now) > 0)).ToList();
        }

        private void RefreshLiteratures()
        {
            dataGridViewLiteratures.DataSource = null;
            dataGridViewLiteratures.DataSource = _unitOfWork.Literatures.GetAllLiteratures();
        }

        private void buttonLoanBook_Click(object sender, EventArgs e)
        {
            Membership membership = dataGridViewMemberships.CurrentRow.DataBoundItem as Membership;
            User user = membership.User;

            var literature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
            LoanABook(user, literature);
            this.Close();
        }

        private void buttonLateLoansList_Click(object sender, EventArgs e)
        {
            FormLateLoansList newForm = new FormLateLoansList();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#13-nova-posudba-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#13-nova-posudba-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonScanMember_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice == null || !videoCaptureDevice.IsRunning)
            {
                TurnOnCamera();
            }
        }
        public void TurnOnCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            int memberID = 0;
            Membership member;
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var readerResult = reader.Decode(bitmap);
            if (readerResult != null)
            {
                videoCaptureDevice.SignalToStop();
                if (int.TryParse(readerResult.ToString(), out memberID))
                {
                    member = _unitOfWork.Memberships.GetById(memberID);

                    if(member != null)
                    {
                        User user = member.User;

                        var literature = dataGridViewLiteratures.CurrentRow.DataBoundItem as Literature;
                        LoanABook(user, literature);
                        MessageBox.Show("Iskaznica je skenirana");
                    }
                }
            }
        }
        private void LoanABook(User user, Literature literature) 
        {
            bool started = true;
            if (_unitOfWork.Literatures.IsLoaned(literature.Id))
            {
                started = false;
            }
            Loan loan = new Loan(user, DateTime.Now, DateTime.Now.AddDays(30), started, false);

            loan.LoanItem.Add(new LoanItem
            {
                Literature = literature,
            });
            _unitOfWork.Loans.Add(loan);
            _unitOfWork.Complete();
        }

        private void FormNewLoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
            }
        }
    }
}
