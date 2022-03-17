namespace TestAPI.Models.DatabaseModels
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Auth_Id { get; set; }
        public List<PhoneBook> PhoneNumbers { get; set; }
    }
}
