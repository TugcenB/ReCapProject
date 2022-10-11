using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Added";
        public static string Deleted = "Deleted";
        public static string Updated = "Updated";
        public static string CarAddedError = "Car has to be min 2 char and daily price has to be more than 0.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ErrorRentalAdded = "Araç kiralanamaz.";
        public static string CarIsNotEmpty;
        public static string ACarCanNotMoreThan5Images = "Araba fotoğrafları 5' ten fazla olamaz";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Başarılı login";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı kaydoldu";
        public static string AccessTokenCreated="Access Token başarıyla oluşturuldu.";
        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string CarUpdated="Car Updated";
    }
}
