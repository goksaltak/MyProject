using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımdadır";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfcategoryError = "Kategori için belirlenen ürün sayısı aştınız.";
        public static string ProductNameAlreadyExists = "aynı isimde ürün tanımlanamaz";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığından yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered = "Kullanıcı kayıt oldu.";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Şifre hatalı";
        internal static string SuccessfulLogin = "Giriş başarılı";
        internal static string UserAlreadyExists = "Kullanıcı kayıtlı";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
