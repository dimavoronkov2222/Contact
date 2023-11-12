using System.Collections.Generic;
namespace Contact
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Contacts
    {
        private List<Person> people;
        public Contacts()
        {
            people = new List<Person>();
        }
        public void AddPerson(string name, string surname, string address, string phoneNumber)
        {
            var person = new Person
            {
                Name = name,
                Surname = surname,
                Address = address,
                PhoneNumber = phoneNumber
            };
            people.Add(person);
        }
        public List<Person> GetPeople()
        {
            return people;
        }
    }
}