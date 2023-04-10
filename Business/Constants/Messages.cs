using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
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
        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır";
        
        
        public static string UserRegistered = "Kayıt başaralı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string PasswordError = "Parola hatalı";
        public static string UserAdded = "Kullanıcı eklendi";
    }
}
