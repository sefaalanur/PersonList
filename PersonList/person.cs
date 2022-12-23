using System;

namespace PersonList
{
    class person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public person(int id, string name, string surname, string phone, string email, DateTime birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.Email = email;
            this.Birthday = birthday;
        }
    }
}
