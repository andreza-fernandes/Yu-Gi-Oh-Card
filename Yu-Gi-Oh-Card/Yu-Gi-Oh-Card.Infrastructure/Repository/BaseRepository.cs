using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yu_Gi_Oh_Card.Domain.Entities;
using Yu_Gi_Oh_Card.Domain.Interfaces;
using Yu_Gi_Oh_Card.Infrastructure.Context;

namespace Yu_Gi_Oh_Card.Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Yu_Gi_Oh_CardContex _yu_Gi_Oh_CardContex;

        public BaseRepository(Yu_Gi_Oh_CardContex yu_Gi_Oh_CardContex)
        {
            _yu_Gi_Oh_CardContex = yu_Gi_Oh_CardContex;
        }

        public void Insert(TEntity obj)
        {
            _yu_Gi_Oh_CardContex.Set<TEntity>().Add(obj);
            _yu_Gi_Oh_CardContex.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _yu_Gi_Oh_CardContex.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _yu_Gi_Oh_CardContex.SaveChanges();
        }

        public void Delete(int id)
        {
            _yu_Gi_Oh_CardContex.Set<TEntity>().Remove(Select(id));
            _yu_Gi_Oh_CardContex.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _yu_Gi_Oh_CardContex.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _yu_Gi_Oh_CardContex.Set<TEntity>().Find(id);

    }
}
