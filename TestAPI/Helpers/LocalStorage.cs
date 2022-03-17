using TestAPI.Models.DatabaseModels;

namespace TestAPI.Helpers
{
    public class LocalStorage
    {
        public Dictionary<int,Account> GetAccounts()
        {
            var dummydata= new Dictionary<int,Account>();

            dummydata.Add(1, new Account());

            dummydata.Add(2, new Account());

            dummydata.Add(3, new Account());

            dummydata.Add(4, new Account());

            dummydata.Add(5, new Account());

            dummydata.Add(6, new Account());

            dummydata.Add(7, new Account());

            dummydata.Add(8, new Account());

            dummydata.Add(9, new Account());

            dummydata.Add(10, new Account());

            dummydata.Add(11, new Account());

            dummydata.Add(12, new Account());

            dummydata.Add(13, new Account());

            dummydata.Add(0, new Account());

            dummydata.Add(0, new Account());

            dummydata.Add(0, new Account());

            dummydata.Add(0, new Account());

            return dummydata;

        }

        public Dictionary<int, PhoneBook> GetPhoneNumbers()
        {
            var dummydata= new Dictionary<int, PhoneBook>();

            dummydata.Add(1, new PhoneBook());

            dummydata.Add(2, new PhoneBook());

            dummydata.Add(3, new PhoneBook());

            dummydata.Add(4, new PhoneBook());

            dummydata.Add(5, new PhoneBook());

            dummydata.Add(6, new PhoneBook());

            dummydata.Add(7, new PhoneBook());

            dummydata.Add(8, new PhoneBook());

            dummydata.Add(9, new PhoneBook());

            dummydata.Add(10, new PhoneBook());

            dummydata.Add(11, new PhoneBook());

            dummydata.Add(12, new PhoneBook());

            dummydata.Add(13, new PhoneBook());

            dummydata.Add(0, new PhoneBook());

            dummydata.Add(0, new PhoneBook());

            dummydata.Add(0, new PhoneBook());

            dummydata.Add(0, new PhoneBook());

            return dummydata;
        }
    }
}
