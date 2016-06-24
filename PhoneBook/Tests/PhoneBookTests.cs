using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Contracts.Repository;

namespace Tests
{
    [TestClass]
    public class PhoneBookTests
    {
        [TestMethod]
        public void CanListPhoneNumber()
        {
            Mock<IPhoneBookRepository> mock = new Mock<IPhoneBookRepository>();
        }
    }
}
