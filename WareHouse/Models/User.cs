using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string TradetionalNumber { get; set; }
        public string PhoneNumber { get; set; }

        public User () => Id = Guid.NewGuid ();

        public User(string name, string password, string tradetional, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
            TradetionalNumber = tradetional;
            PhoneNumber = phoneNumber;
        }
    }
}
