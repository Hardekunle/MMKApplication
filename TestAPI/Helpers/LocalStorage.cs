using TestAPI.Models.DatabaseModels;

namespace TestAPI.Helpers
{
    public class LocalStorage
    {
        public static Dictionary<string,Account> GetAccounts()
        {
            var dummydata= new Dictionary<string,Account>();

            dummydata.Add("azr1", new Account { Id = 1, Username = "azr1", Auth_Id = "20S0KPNOIM" });
            dummydata.Add("azr2", new Account { Id = 1, Username = "azr2", Auth_Id = "54P2EOKQ47" });
            dummydata.Add("azr3", new Account { Id = 1, Username = "azr3", Auth_Id = "9LLV6I4ZWI" });
            dummydata.Add("azr4", new Account { Id = 1, Username = "azr4", Auth_Id = "YHWE3HDLPQ" });
            dummydata.Add("azr5", new Account { Id = 1, Username = "azr5", Auth_Id = "6DLH8A25XZ" });


            return dummydata;

        }

        public static Dictionary<int, PhoneBook> GetPhoneNumbers()
        {
            var dummydata= new Dictionary<int, PhoneBook>();

            dummydata.Add(1, new PhoneBook {Id=1, Account_Id=1, Number= "4924195509198" });
            dummydata.Add(2, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509196" });
            dummydata.Add(3, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509196" });
            dummydata.Add(4, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509195" });
            dummydata.Add(5, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509049" });
            dummydata.Add(6, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509012" });
            dummydata.Add(7, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509193" });
            dummydata.Add(8, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509029" });
            dummydata.Add(9, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509192" });
            dummydata.Add(10, new PhoneBook { Id = 1, Account_Id = 1, Number = "4924195509194" });
            dummydata.Add(11, new PhoneBook { Id = 1, Account_Id = 1, Number = "31297728125" });
            dummydata.Add(12, new PhoneBook { Id = 1, Account_Id = 1, Number = "3253280312" });
            dummydata.Add(13, new PhoneBook { Id = 1, Account_Id = 1, Number = "3253280311" });
            dummydata.Add(14, new PhoneBook { Id = 1, Account_Id = 1, Number = "3253280315" });
            dummydata.Add(15, new PhoneBook { Id = 1, Account_Id = 1, Number = "3253280313" });
            dummydata.Add(16, new PhoneBook { Id = 1, Account_Id = 1, Number = "3253280329" });
            dummydata.Add(17, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224459508" });
            dummydata.Add(18, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224980086" });
            dummydata.Add(19, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224980087" });
            dummydata.Add(20, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224980096" });
            dummydata.Add(21, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224980098" });
            dummydata.Add(22, new PhoneBook { Id = 1, Account_Id = 1, Number = "441224980099" });
            dummydata.Add(23, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980100" });
            dummydata.Add(24, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980094" });
            dummydata.Add(25, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459426" });
            dummydata.Add(26, new PhoneBook { Id = 1, Account_Id = 2, Number = "13605917249" });
            dummydata.Add(27, new PhoneBook { Id = 1, Account_Id = 2 , Number = "441224459548" });
            dummydata.Add(28, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459571" });
            dummydata.Add(29, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459598" });
            dummydata.Add(30, new PhoneBook { Id = 1, Account_Id = 2, Number = "13605895047" });
            dummydata.Add(31, new PhoneBook { Id = 1, Account_Id = 2, Number = "14433600975" });
            dummydata.Add(32, new PhoneBook { Id = 1, Account_Id = 2, Number = "16052299352" });
            dummydata.Add(33, new PhoneBook { Id = 1, Account_Id = 2, Number = "13602092244" });
            dummydata.Add(34, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459590" });
            dummydata.Add(35, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459620" });
            dummydata.Add(36, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459660" });
            dummydata.Add(37, new PhoneBook { Id = 1, Account_Id = 2, Number = "234568266473" });
            dummydata.Add(38, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980091" });
            dummydata.Add(39, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980092" });
            dummydata.Add(40, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980089" });
            dummydata.Add(41, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224459482" });
            dummydata.Add(42, new PhoneBook { Id = 1, Account_Id = 2, Number = "441224980093" });
            dummydata.Add(43, new PhoneBook { Id = 1, Account_Id = 2, Number = "441887480051" });
            dummydata.Add(44, new PhoneBook { Id = 1, Account_Id = 2, Number = "441873440028" });
            dummydata.Add(45, new PhoneBook { Id = 1, Account_Id = 3, Number = "441873440017" });
            dummydata.Add(46, new PhoneBook { Id = 1, Account_Id = 3, Number = "441970450009" });
            dummydata.Add(47, new PhoneBook { Id = 1, Account_Id = 3, Number = "441235330075" });
            dummydata.Add(48, new PhoneBook { Id = 1, Account_Id = 3, Number = "441235330053" });
            dummydata.Add(49, new PhoneBook { Id = 1, Account_Id = 3, Number = "441235330044" });
            dummydata.Add(50, new PhoneBook { Id = 1, Account_Id = 3, Number = "441235330078" });
            dummydata.Add(51, new PhoneBook { Id = 1, Account_Id = 3, Number = "34881254103" });
            dummydata.Add(52, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112946" });
            dummydata.Add(53, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112915" });
            dummydata.Add(54, new PhoneBook { Id = 1, Account_Id = 3, Number = "61881666904" });
            dummydata.Add(55, new PhoneBook { Id = 1, Account_Id = 3, Number = "61881666939" });
            dummydata.Add(56, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112913" });
            dummydata.Add(57, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112901" });
            dummydata.Add(58, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112938" });
            dummydata.Add(59, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112934" });
            dummydata.Add(60, new PhoneBook { Id = 1, Account_Id = 3, Number = "61871112902" });
            dummydata.Add(61, new PhoneBook { Id = 1, Account_Id = 4, Number = "61881666926" });
            dummydata.Add(62, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871705936" });
            dummydata.Add(63, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871112920" });
            dummydata.Add(64, new PhoneBook { Id = 1, Account_Id = 4, Number = "61881666923" });
            dummydata.Add(65, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871112947" });
            dummydata.Add(66, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871112948" });
            dummydata.Add(67, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871112921" });
            dummydata.Add(68, new PhoneBook { Id = 1, Account_Id = 4, Number = "61881666914" });
            dummydata.Add(69, new PhoneBook { Id = 1, Account_Id = 4, Number = "61881666942" });
            dummydata.Add(70, new PhoneBook { Id = 1, Account_Id = 4, Number = "61871112922" });
            dummydata.Add(71, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871232393" });
            dummydata.Add(72, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112916" });
            dummydata.Add(73, new PhoneBook { Id = 1, Account_Id = 5, Number = "61881666921" });
            dummydata.Add(74, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112905" });
            dummydata.Add(75, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112937" });
            dummydata.Add(76, new PhoneBook { Id = 1, Account_Id = 5, Number = "61361220301" });
            dummydata.Add(77, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112931" });
            dummydata.Add(78, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112939" });
            dummydata.Add(79, new PhoneBook { Id = 1, Account_Id = 5, Number = "61871112940" });
           

            return dummydata;
        }
    }
}
