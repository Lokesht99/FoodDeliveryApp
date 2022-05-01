using FoodDeliveryBusiness.DTO;
using FoodDeliveryBusiness.ImplementedClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodDeliveryApp.Controllers
{
    [Route("api/RestaurantAPI")]
    public class RestaurantAPIController : ApiController
    {
        [HttpGet]
        //[Route("GetGenderData")]
        public IHttpActionResult GetGenderData(string gender)
        {
            List<RestaurantDto> restaurantDet = GetRestaurantData();
            var genderDetails = restaurantDet.Where(x => x.Gender == gender).ToList();
            if (genderDetails.Any())
                return Ok(genderDetails);
            else
                return NotFound();
        }

        [HttpGet]
        //[Route("GetVegFoods")]
        public IHttpActionResult GetVegFoods(string gender)
        {
            List<RestaurantDto> restaurantDet = GetRestaurantData();
            string val1 = "Veg foods (Breakfast / Lunch / Dinner)";
            var vegFood = restaurantDet.Where(x => x.Gender == gender && (x.PerferenceP1 == val1 || x.PerferenceP2 == val1)).ToList();
            if(vegFood.Any())
                return Ok(vegFood.Count);
            else
                return NotFound();
        }

        private List<RestaurantDto> GetRestaurantData()
        {
            const string filePath = @"C:\Users\tunuguntla.lokesh\source\MVC Demos\OnlineDeliveryData.csv";
            FileRead fileRead = new FileRead();
            ConvertToJson convertToJson = new ConvertToJson();
            string[] lines = fileRead.ReadFile(filePath);
            var restaurantDet = convertToJson.ConvertJSON(lines);
            return restaurantDet;
        }
    }
}
