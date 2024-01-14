using MiniShop.Core.ViewModels;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        //CRUD işlemlerini gerçekleştirecek metot imzalarımızı yazacağız.
        void Create(ProductViewModel model);                                    // (C)reate
        List<ProductViewModel> GetAll(bool? isHome = null, bool? isActive= null, bool? isDelete=null);  // (R)ead
        ProductViewModel GetById(int id);
        void Update(ProductViewModel model);                                     // (U)pdate
        void HardDelete(int id);                                                  // (D)elete
        void SoftDelete(int id);

    }
}
