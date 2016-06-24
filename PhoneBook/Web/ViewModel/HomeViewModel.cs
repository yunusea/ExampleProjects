using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<PhoneBook> PhoneBookList { get; set; }
        public PhoneBook PhoneNumber { get; set; }
    }
}