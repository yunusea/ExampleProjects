using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repository
{
    public interface IPhoneBookRepository
    {
        IEnumerable<PhoneBook> GetPhoneNumberList();
        bool AddPhoneNumber(PhoneBook obj);
    }
}
