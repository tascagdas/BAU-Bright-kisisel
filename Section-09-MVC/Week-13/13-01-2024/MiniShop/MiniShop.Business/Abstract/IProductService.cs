using System;
using MiniShop.Core.ViewModels;
using MiniShop.Entity;

namespace MiniShop.Business.Abstract
{
	public interface IProductService
	{
		//CRUD işlemlerini gerçekleştirecek metot imzalarımızı yazacağız.
		void Create(ProductViewModel model);                                            //			C	create

		List<ProductViewModel> GetAll(bool? isHome = null, bool? isActive = null, bool? isDeleted = null);   //			R	read
		ProductViewModel GetById(int id);
		void Update(ProductViewModel model);                                            //			U	update
		void HardDelete(int id);                                                        //			D	delete
		void SoftDelete(int id);


	}
}

