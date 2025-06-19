namespace ClientDataAnalysis.Domain
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge() => DateTime.Today.Year - BirthDate.Year;    
    }
}
