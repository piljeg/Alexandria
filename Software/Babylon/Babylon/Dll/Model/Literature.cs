using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Literature
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
        public List<LoanItem> LoanItem { get; set; }
        public List<PickingInItem> PickingInItem { get; set; }

        [NotMapped]
        public string CategoryName
        {
            get
            {
                return Category.Name;
            }
        }

        [NotMapped]
        public string AuthorName
        {
            get
            {
                return Author.FullName;
            }
        }

        public Literature()
        {

        }
        public Literature(string title, Category category, Author author)
        {
            Title = title;
            Category = category;
            Author = author;
        }
    }
}
