using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Infrastructure.Storage;

namespace WareHouse.Interfaces.IRepository
{
    public interface IUnitOfWork
    {
        CategoryRepository category { get; }
        ProductRepository product { get; }
        BillRepository bill { get; }
        UserRepository user { get; }
    }
}
