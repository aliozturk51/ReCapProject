using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{

    //Sürekli newlememek için static yapıyorum
    public static class Messages
    {

        //Car
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarDetails = "Arabanın detaylı özellikleri listelendi.";
        public static string CarDailyPriceInvalid = "Araba fiyatı geçersiz";


        //Brand (Marka)



        public static string BrandAdded = "Marka ismi eklendi.";
        internal static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";


        //Color

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renkler silindi";
        public static string ColorUpdated = "Renkler güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";
        
    }
}
