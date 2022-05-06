using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Receipt
    {
        public int Id { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int User_Id { get; set; }
        public int Employee_Id { get; set; }
        public User User { get; set; }
        public User Employee { get; set; }
        public List<ReceiptItem> ReceiptItem { get; set; }

        [NotMapped]
        public string Username
        {
            get
            {
                return User.UserName;
            }
        }

        [NotMapped]
        public string EmployeeName
        {
            get
            {
                return Employee.UserName;
            }
        }

        public Receipt()
        {
            ReceiptItem = new List<ReceiptItem>();
        }


        public Receipt(User user, User employee)
        {
            ReceiptItem = new List<ReceiptItem>();
            DateOfIssue = DateTime.Now;
            User = user;
            Employee = employee;
        }
    }
}
