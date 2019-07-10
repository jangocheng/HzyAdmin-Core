﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DbFrame.Core.Interface
{
    using DbFrame.BaseClass;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IDelete<T>
    {

        int Execute();
        Task<int> ExecuteAsync();
        IDelete<T> Where(Expression<Func<HzyTuple<T>, bool>> Where);
        IDelete<T> WhereIF(bool IF, Expression<Func<HzyTuple<T>, bool>> Where);
        SQL ToSql();


    }
}
