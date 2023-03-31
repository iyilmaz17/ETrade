using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";


        public static string ProductCodeAlreadyExists = "Bu ürün kodunda bir ürün zaten mevcut";


        public static string ProductImagesAdded = "Ürün resmi başarıyla eklendi";
        public static string ProductImagesNotAdded = "Bir ürüne en fazla 5 adet resim eklenebilir.";
        public static string ProductImagesUpdated = "Ürün resmi başarıyla güncellendi";
        public static string ProductImagesDeleted = "Ürün resmi başarıyla silindi";
    }
}
