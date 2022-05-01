using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.Models
{
    public class CustomerPersonalInfo
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string MonthlyIncome { get; set; }
        public string EducationalQualifications { get; set; }
        public int FamilySize { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int PinCode { get; set; }
    }
}