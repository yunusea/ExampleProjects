using Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data.DataContext;

namespace Repository
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly PhoneBookDataContext db = new PhoneBookDataContext();

        public bool AddPhoneNumber(PhoneBook obj)
        {
            try
            {
                db.PhoneBook.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception hata)
            {
                return false;
            }
        }

        public IEnumerable<PhoneBook> GetPhoneNumberList()
        {
            return db.PhoneBook.ToList();
        }
    }
}
