using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utitilies
{
    public interface IDataResult<TData>:IResult
    {
            TData Data { get; }
    }
}
