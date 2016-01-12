using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ru.itpc.trial.Models
{
    public interface Person : Identified<string>
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
    }

    public class PersonRecord : Controller, Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string id;

        public PersonRecord(string firstName, string lastName, DateTime birthDate, string id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.id = id;
        }

        public PersonRecord(string firstName, string lastName)
            : this(firstName, lastName, DateTime.Now, "1")
        {

        }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Incorrect Firstname length")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [Range(typeof(DateTime), "1/1/1900", "1/1/5000", ErrorMessage = "Incorrect BirthDate")]
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Id
        {
            get { return id; }
        }

        public bool IsValid
        {
            get
            {
                if (firstName.Length < 2 || firstName.Length > 100)
                    ModelState.AddModelError("FirstName", "Incorrect Firstname length");
                if (birthDate < new DateTime(1900, 01, 01))
                    ModelState.AddModelError("BirthDate", "Incorrect BirthDate");
                return ModelState.IsValid;
            }
        }
    }
}
