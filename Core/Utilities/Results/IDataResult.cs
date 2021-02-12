using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    //Hem işlem sonucunu, hem mesajı, hem de datayı döndürebilir.
   public interface IDataResult<T>: IResult 
    {
        

        //IResult ile implemente etme sebebim mesaj ve işlem sonucunu içermesi.

        T Data { get;}

    }
}
