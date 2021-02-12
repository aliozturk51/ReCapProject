using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>: DataResult<T>
    {

        //Tüm bilgiler
        public SuccessDataResult(T data, string message):base(data, true, message)
        {
            
        }

        //Sadece data
        public SuccessDataResult(T data):base(data, true)
        {

        }

        //Default data
        public SuccessDataResult(string message):base(default, true, message)
        {
                
        }

  
        public SuccessDataResult():base(default, true)
        {

        }
    }
}
