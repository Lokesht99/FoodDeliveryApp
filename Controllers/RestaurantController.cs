using FoodDeliveryBusiness.DTO;
using FoodDeliveryBusiness.ImplementedClass;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FoodDeliveryApp.Controllers
{
    public class RestaurantController : Controller
    {
        private List<RestaurantDto> GetRestaurantData()
        {
            const string filePath = @"C:\Users\tunuguntla.lokesh\source\MVC Demos\OnlineDeliveryData.csv";
            FileRead fileRead = new FileRead();
            ConvertToJson convertToJson = new ConvertToJson();
            string[] lines = fileRead.ReadFile(filePath);
            var restaurantDet = convertToJson.ConvertJSON(lines);
            return restaurantDet;
        }
        // GET: Restaurant
        public ActionResult Index()
        {
            List<RestaurantDto> restaurantDet = GetRestaurantData();
            return View(restaurantDet);
        }


    }
}