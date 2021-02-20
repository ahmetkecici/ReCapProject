using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utitilies
{
    public class ErrorResult:Result,IResult
    {
        public ErrorResult(string message) : base(message, false)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
