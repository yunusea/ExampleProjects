using Contracts.Repository;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PhoneBookBusiness
    {
        IPhoneBookRepository _phonebookRepository;

        public PhoneBookBusiness(IPhoneBookRepository PhoneBookRepository)
        {
            _phonebookRepository = PhoneBookRepository;
        }

        public IEnumerable<PhoneBook> GetPhoneBookAllNumber()
        {
            return _phonebookRepository.GetPhoneNumberList();
        }

        public bool NewPhoneNumberAdd(PhoneBook obj)
        {
           return _phonebookRepository.AddPhoneNumber(obj);
        }
    }
}
