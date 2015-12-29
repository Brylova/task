using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ru.itpc.trial.Models
{
    public interface Person : Identified<string>
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime BirthDate { get; }
    }

    public interface PersonSetter : Person
    {
        new string FirstName { set; }
        new string LastName { set; }
        new DateTime BirthDate { set; }
    }

    public class PersonRecord : PersonSetter
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

        new public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Id
        {
            get { return id; }
        }
    }
}
