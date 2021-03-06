﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
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

        //User
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi.";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";


        //Rental
        public static string RentalError = "Araç teslimi yapılmamıştır.";
        public static string RentalAdded  = "Kiralama işlemi gerçekleştirilmiştir.";
        public static string RentalDeleted = "Kiralama bilgisi silindi.";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi.";
        public static string RentalListed = "Kiralanan araçlar listelendi.";
        public static string RentalDetails = "Kiralama detayları";

        //İmage
        public static string CarImageLimitExceeded = "Bir araç için en fazla 5 resim eklenebilir.";



        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        internal static List<Car> MaintenanceTime;
    }
}
