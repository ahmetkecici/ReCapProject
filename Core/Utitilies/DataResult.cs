using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utitilies
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        public TData Data { get; }
        public DataResult(TData data ,bool success,string message):base(message,success)
        {
            Data = data;
        }
        public DataResult(TData data,bool success):base(success)
        {
            Data = data;
        }

    }
}
