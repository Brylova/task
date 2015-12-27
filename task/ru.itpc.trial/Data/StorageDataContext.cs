using ru.itpc.trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ru.itpc.trial.Data
{
    public class StorageDataContext:DataContext
    {
        public List<PersonRecord> PersonRecords { get; set; }
        public List<DriverLicenseRecord> DriversLicensesRecords { get; set; }
        public List<string> Strings { get; set; }
        public List<int> Integers { get; set; }
        public DateTime LastChange { get; set; }

        public StorageDataContext()
        {
            this.PersonRecords = new List<PersonRecord>();
            this.DriversLicensesRecords = new List<DriverLicenseRecord>();
            this.Strings = new List<string>();
            this.Integers = new List<int>();
            this.LastChange = DateTime.Now;
        }

        public T Get<T>()
        {
            if (typeof(T) == typeof(List<DriverLicenseRecord>))
                return (T)Convert.ChangeType(DriversLicensesRecords, typeof(T));
            if (typeof(T) == typeof(List<string>))
                return (T)Convert.ChangeType(Strings, typeof(T));
            if (typeof(T) == typeof(List<int>))
                return (T)Convert.ChangeType(Integers, typeof(T));
            if (typeof(T) == typeof(DateTime))
                return (T)Convert.ChangeType(LastChange, typeof(T));
            return default(T);
        }
    }

    public class DefaultDataContext
    {
        static StorageDataContext data = new StorageDataContext();

        public static DataContext Instance
        {
            get { return data; }
        }
    }
}
