using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {

        //Temel void işlemlerini yapar
        bool Success { get; }
        string Message { get; }
    }
}
