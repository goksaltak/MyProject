using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
