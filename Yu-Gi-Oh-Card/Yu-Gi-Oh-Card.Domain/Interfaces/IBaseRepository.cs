using System;
using System.Collections.Generic;
using System.Text;
using Yu_Gi_Oh_Card.Domain.Entities;

namespace Yu_Gi_Oh_Card.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        IList<TEntity> Select();

        TEntity Select(int id);
    }
}
