﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Services
{
    public abstract class GeneralAdminService<TEntity>
            where TEntity : class
    {

        public abstract void Save(TEntity model);

        protected abstract void Create();

        protected abstract void Update(TEntity model);

        public abstract void Delete(int id);

        public abstract void Dispose();
    }
}