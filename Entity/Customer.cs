using System.ComponentModel.DataAnnotations;

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

        public Customer(int Id, string Name, string Email, int Age, string City, string Country)
            : this(Name, Email, Age, City, Country)
        {
            this.Id = Id;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
