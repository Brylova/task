using System;
using NUnit.Framework;
using ru.itpc.trial.Models;

namespace ru.itpc.trial.test.Models
{
    [TestFixture]
    public class ValidDataTest
    {
        [Test]
        public void Model_is_valid_test()
        {
            PersonRecord record = new PersonRecord("Keith", "Richards");
            record.BirthDate = new DateTime(1943, 12, 18);
            Assert.IsTrue(record.IsValid);
        }

        [Test]
        public void Model_is_invalid_test()
        {
            PersonRecord record = new PersonRecord("A", "Mozes");
            Assert.IsFalse(record.IsValid);
        }
    }
}
