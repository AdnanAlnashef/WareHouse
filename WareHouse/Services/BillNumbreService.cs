using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using WareHouse.Helpers.Session;
using WareHouse.Infrastructure.Storage;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Services
{
    public class BillNumbreService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BillNumbreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int GetNextInvoiceNumber()
        {
            var userId = AppSession.CurrentUser.Id;
            var bills = _unitOfWork.bill.GetAll()
                .Where(b => b.UserId == userId);
            if (!bills.Any())
                return 1;
            return bills.Max(b => b.Number) + 1;
        }
    }
}
