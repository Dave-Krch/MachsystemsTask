namespace MachsystemsTask.Entity
{
    public class Customer
    {
        public Customer(string Name, string Email, int Age, string City, string Country)
        {
            this.Name = Name;
            this.Email = Email;
            this.Age = Age;
            this.City = City;
            this.Country = Country;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
