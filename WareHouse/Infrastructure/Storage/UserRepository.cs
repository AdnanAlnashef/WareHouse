using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Confing;
using WareHouse.Models;

namespace WareHouse.Infrastructure.Storage
{
    public class UserRepository : JsonRepository<User>
    {
        public UserRepository() : base(PathConfing.UserFile)
        {
        }
    }
}
