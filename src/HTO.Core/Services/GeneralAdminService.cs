using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Services
{
    public abstract class GeneralAdminService<TEntity, UEntity>
            where TEntity : class
            where UEntity : class
    {
        public abstract IEnumerable<UEntity> GetTableViewModels();

        public abstract void Save(TEntity model);

        public abstract void Create(TEntity model);

        public abstract void Update(TEntity model);

        public abstract void Delete(int id);

        public abstract void Dispose();
    }
}
