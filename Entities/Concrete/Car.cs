

using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {

        
        public int CarId { get; set; }

        public int BrandId { get; set; }
        
        public int ColorId  { get; set; }
 
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }

        //CarName
        public string Description { get; set; }
    }
}
