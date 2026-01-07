using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Classes
{
    public class Representative
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TradetionalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CarNumber { get; set; }

        public Representative() => Id = Guid.NewGuid();

        public Representative(string name, string number, string phone, string email, string carNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            TradetionalNumber = number;
            PhoneNumber = phone;
            Email = email;
            CarNumber = carNumber;
        }
    }
}
