using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plamadeala_Maria_Lab8.Models
{
    public class Category
    {
        public int ID { set; get; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories{ get; set; }

    }
}
