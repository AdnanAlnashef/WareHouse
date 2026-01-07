using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Infrastructure.Storage
{
    public class UnitOfWork : IUnitOfWork
    {
        public CategoryRepository category { get; private set; }
        public ProductRepository product { get; private set; }
        public BillRepository bill { get; private set; }
        public UserRepository user { get; private set; }

        public UnitOfWork()
        {
            category = new CategoryRepository();
            product = new ProductRepository();
            bill = new BillRepository();
            user = new UserRepository();
        }
    }
}
