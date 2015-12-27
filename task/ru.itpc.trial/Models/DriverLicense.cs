using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Models
{
    public interface DriverLicense : Identified<int>
    {
        string Class { get; set; }
        DateTime Issued { get; set; }
        DateTime Expires { get; set; }
        string OwnerFirstName { get; set; }
        string OwnerLastName { get; set; }
        DateTime OwnerBirthDate { get; set; }
    }

    public class DriverLicenseRecord : DriverLicense
    {
        string licenseClass;
        DateTime issued;
        DateTime expires;
        PersonRecord person;
        int id;

        public DriverLicenseRecord(int id, string licenseClass, DateTime expiration, PersonRecord person, DateTime issued)
        {
            this.id = id;
            this.licenseClass = licenseClass;
            this.expires = expiration;
            this.issued = issued;
            this.person = person;
        }

        public DriverLicenseRecord(int id, string licenseClass, DateTime expiration, PersonRecord person)
            : this(id, licenseClass, expiration, person, DateTime.Now)
        {

        }

        public string Class
        {
            get { return licenseClass; }
            set { licenseClass = value; }
        }

        public DateTime Issued
        {
            get { return issued; }
            set { issued = value; }
        }

        public DateTime Expires
        {
            get { return expires; }
            set { expires = value; }
        }

        public string OwnerFirstName
        {
            get { return person.FirstName; }
            set { person.FirstName = value; }
        }

        public string OwnerLastName
        {
            get { return person.LastName; }
            set { person.LastName = value; }
        }

        public DateTime OwnerBirthDate
        {
            get { return person.BirthDate; }
            set { person.BirthDate = value; }
        }

        public int Id
        {
            get { return id; }
        }
    }
}
