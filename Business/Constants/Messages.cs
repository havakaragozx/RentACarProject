using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarDeleted = "Araba Silindi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarNameInvalid = "Araba ismi minimum 2 karakter uzunlugunda ve günlük fiyatı 0 dan büyük olmalıdır.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string CarsListed = "Arabalar Listelendi.";
        public static string CustomersListed = "Müşteriler Listelendi.";
        public static string RentalUpdated = "Kiralama Listesi Güncellendi";

        public static string RentalDeleted = "Kiralama Listesinden Müşteri Silindi";

        public static string RentalAdded = "Kiralama Listesine Yeni Müşteri Eklendi";

        public static string InvalidRental = "Kiralanacak Araba Başka Müşteride";
    }
}
