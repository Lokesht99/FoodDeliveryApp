using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.Models
{
    public class FoodCustomerDetails
    {
        public CustomerPersonalInfo customerPersonal { get; set; }
        public FoodPreferences foodPreferences { get; set; }
        public OtherDetails otherDetails { get; set; }
    }
}