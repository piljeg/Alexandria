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
    public partial class FormLoans : Form
    {
        private readonly UnitOfWork _unitOfWork;

        public FormLoans()
        {
            _unitOfWork = new UnitOfWork(new AppDbContext());
            InitializeComponent();
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

        private void FormLoans_Load(object sender, EventArgs e)
        {
            textBoxLiteratureTitle.ReadOnly = true;
            RefreshLoans();
        }

        private void RefreshLoans()
        {
            loanBindingSource.DataSource = _unitOfWork.Loans.GetAllLoans();
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            FormNewLoan newForm = new FormNewLoan();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
            RefreshLoans();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#12-posudbe-");

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/pi21-tskobic-lbojka-piljeg/wiki/Korisni%C4%8Dka-dokumentacija#12-posudbe-");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonLateLoansList_Click(object sender, EventArgs e)
        {
            FormLateLoansList newForm = new FormLateLoansList();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Loan selectedLoan = dataGridViewLoans.CurrentRow.DataBoundItem as Loan;
            if(selectedLoan.Finished == false) 
            {
                selectedLoan.Finished = true;

                _unitOfWork.Loans.Update(selectedLoan, selectedLoan.Id);

                if(DateTime.Compare(selectedLoan.DateTo, DateTime.Now) <= 0)
                {
                    User user = selectedLoan.User;
                    User employee = UserManager.LoggedUser;

                    Receipt receipt = new Receipt(user, employee);

                    double dueAmount = (DateTime.Now - selectedLoan.DateTo).TotalDays * 15;

                    receipt.ReceiptItem.Add(new ReceiptItem
                    {
                        Loan = selectedLoan,
                        Money = dueAmount
                    });

                    _unitOfWork.Receipts.Add(receipt);

                    MessageBox.Show("Knjižna građa vraćena i račun izdan.");
                } else {
                    MessageBox.Show("Knjižna građa vraćena.");

                }

                _unitOfWork.Complete();

                int literatureId = selectedLoan.LoanItem.First().LiteratureId;
                Loan reservation = null;

                List<LoanItem> loanItems = _unitOfWork.LoanItems.GetAllLoanItems().Where(x => x.Literature.Id == literatureId).ToList();
                List<LoanItem> reservations = loanItems.Where(x => x.Loan.Started == false).ToList();
                LoanItem reservationItems = null;

                if(reservations.Count > 0)
                {
                    DateTime lowestDateTime;
                    if(reservations.Count > 1)
                    {
                        lowestDateTime = reservations.Min(x => x.Loan.DateFrom);

                    } else
                    {
                        lowestDateTime = reservations.First().Loan.DateFrom;
                    }
                    reservationItems = reservations.Find(x => x.Loan.DateFrom == lowestDateTime);
                    reservation = reservationItems.Loan;
                }

                if(reservation != null)
                {
                    var smtpClient = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential("alexandria.knjiznica@gmail.com", "alexandria123"),
                        EnableSsl = true,
                    };


                    smtpClient.Send("alexandria.knjiznica@gmail.com", reservation.User.EMail, "Rezervacija Knjižnica Alexandria", $"Poštovani rezervirana knjiga {reservationItems.Literature.Title} je slobodna za posudbu.");
                    MessageBox.Show($"Član {reservation.User.UserName} obaviješten o slobodnoj knjižnoj građi");
                }

                RefreshLoans();
            }
        }

        private void loanBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            loanItemBindingSource.DataSource = _unitOfWork.Loans.GetAllLoanItems(loanBindingSource.Current as Loan);
        }

        private void dataGridViewLoanItems_SelectionChanged(object sender, EventArgs e)
        {
            int literatureId = 0;
            if (dataGridViewLoanItems.Rows.Count > 0)
            {
                literatureId = (int)dataGridViewLoanItems.CurrentRow.Cells[2].Value;
            }
            if (literatureId != 0)
            {
                textBoxLiteratureTitle.Text = _unitOfWork.Literatures.GetById(literatureId).Title;
            }
        }

        private void buttonReceipts_Click(object sender, EventArgs e)
        {
            FormReceipts newForm = new FormReceipts();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }
    }
}
