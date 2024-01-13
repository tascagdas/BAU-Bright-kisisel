using MiniShop.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Data.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        //Temel veri tabanı işlemlerimizi barındıracağız. (CRUD)
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void HardDelete(TEntity entity);
        void SoftDelete(TEntity entity);
    }
}


