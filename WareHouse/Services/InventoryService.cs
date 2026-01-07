using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Exceptions;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Services
{
    public class InventoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InventoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }

        public bool DecreaseStock(Guid productId, int quantity)
        {
            if (quantity <= 0)
            {
                MessageBox.Show($"The quantity cannot be negative or zero");
                return false;
            }
            var product = _unitOfWork.product.GetById(productId);
            if(product.Quantity <  quantity)
            {
                MessageBox.Show($"The Quantity {product.ProductName} in warehouse not enough");
                return false;
            }
            product.Quantity -= quantity;
            _unitOfWork.product.Update(product);
            return true;
        }
    }
}
