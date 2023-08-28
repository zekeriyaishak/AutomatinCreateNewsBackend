using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class Messages
    {
        #region Users Messages
        public static string UserAdded = "Kullanıcı eklenmiştir";
        public static string UserDeleted = "Kullanıcı silinmiştir";
        public static string UserListed = "Kullanıcılar listelenmiştir";
        public static string UserUpdate = "Kullanıcı güncellenmiştir";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        #endregion

        #region Auth Messages
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessLogin = "Sisteme giriş başarılı";
        #endregion 

        #region News Messages
        public static string NewsAdded = "Haber eklenmiştir";
        public static string NewsDeleted = "Haber Silinmiştir";
        public static string NewsUpdated = "Haber Güncellenmiştir";
        public static string NewsListed = "Haber listelenmiştir";
        #endregion

        #region Categories Messages
        public static string CategoriesAdded = "Kategori Eklenmiştir";
        public static string CategoriesDeleted = "Kategori Silinmiştir";
        public static string CategoriesUpdated = "Kategori Güncellenmiştir";
        public static string CategoriesListed = "Kategori Listelenmiştir";
        #endregion


    }
}
