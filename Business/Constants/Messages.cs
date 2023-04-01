using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "ÜRÜN EKLENDİ..";
		public static string ProductNameInvalid = "ÜRÜN İSMİ GEÇERSİZ.";
		public static string MaintenanceTime = "SİSTEM BAKIMDA.";
		public static string ProductsListed = "ÜRÜNLER LİSTELENDİ.";
		public static string ProductCountOfCategoryError = "Kategori Limitini Aştınız.";
		public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün mevcut";
		public static string CategoryLimitExceded = "Kategori Limiti Aşıldı. Yeni Ürün Eklenemiyor.";
		public static string AuthorizationDenied = "Yetkiniz Yok";
		public static string UserListed ="Kullanıcılar Listelendi";
		public static string UserDeleted = "KULLANICI SİLİNDİ.";
		public static string UserFinded = "Kullanıcı Bulundu";
		public static string UserNotFound = "Kullanıcı Bulunamadı.";
	}
}
