using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utitilies
{
    public class SuccesResult:Result,IResult
    {
        public SuccesResult(string message):base(message,true)
        {

        }
        public SuccesResult() : base( true)
        {

        }
    }
}
