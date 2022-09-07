using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string MaintenanceTime= "Sistem Bakımda";
    }
}
