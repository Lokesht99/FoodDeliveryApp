using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodDeliveryApp.Models
{
    public class OtherDetails
    {
        [JsonProperty("Ease and convenient")]
        public string EaseAndConvenient { get; set; }

        [JsonProperty("Time saving")]
        public string TimeSaving { get; set; }

        [JsonProperty("More restaurant choices")]
        public string MoreRestaurantChoices { get; set; }

        [JsonProperty("Easy Payment option")]
        public string EasyPaymentOption { get; set; }

        [JsonProperty("More Offers and Discount")]
        public string MoreOffersAndDiscount { get; set; }

        [JsonProperty("Good Food quality")]
        public string GoodFoodQuality { get; set; }

        [JsonProperty("Good Tracking system")]
        public string GoodTrackingSystem { get; set; }

        [JsonProperty("Self Cooking")]
        public string SelfCooking { get; set; }

        [JsonProperty("Health Concern")]
        public string HealthConcern { get; set; }

        [JsonProperty("Late Delivery")]
        public string LateDelivery { get; set; }

        [JsonProperty("Poor Hygiene")]
        public string PoorHygiene { get; set; }

        [JsonProperty("Bad past experience")]
        public string BadPastExperience { get; set; }
        public string Unavailability { get; set; }
        public string Unaffordable { get; set; }

        [JsonProperty("Long delivery time")]
        public string LongDeliveryTime { get; set; }

        [JsonProperty("Delay of delivery person getting assigned")]
        public string DelayOfDeliveryPersonGettingAssigned { get; set; }

        [JsonProperty("Delay of delivery person picking up food")]
        public string DelayOfDeliveryPersonPickingUpFood { get; set; }

        [JsonProperty("Wrong order delivered")]
        public string WrongOrderDelivered { get; set; }

        [JsonProperty("Missing item")]
        public string MissingItem { get; set; }

        [JsonProperty("Order placed by mistake")]
        public string OrderPlacedByMistake { get; set; }

        [JsonProperty("Influence of time")]
        public string InfluenceOfTime { get; set; }

        [JsonProperty("Order Time")]
        public string OrderTime { get; set; }

        [JsonProperty("Maximum wait time")]
        public string MaximumWaitTime { get; set; }

        [JsonProperty("Residence in busy location")]
        public string ResidenceInBusyLocation { get; set; }

        [JsonProperty("Google Maps Accuracy")]
        public string GoogleMapsAccuracy { get; set; }

        [JsonProperty("Good Road Condition")]
        public string GoodRoadCondition { get; set; }

        [JsonProperty("Low quantity low time")]
        public string LowQuantityLowTime { get; set; }

        [JsonProperty("Delivery person ability")]
        public string DeliveryPersonAbility { get; set; }

        [JsonProperty("Influence of rating")]
        public string InfluenceOfRating { get; set; }

        [JsonProperty("Less Delivery time")]
        public string LessDeliveryTime { get; set; }

        [JsonProperty("High Quality of package")]
        public string HighQualityOfPackage { get; set; }

        [JsonProperty("Number of calls")]
        public string NumberOfCalls { get; set; }
        public string Politeness { get; set; }

        [JsonProperty("Freshness ")]
        public string Freshness { get; set; }
        public string Temperature { get; set; }

        [JsonProperty("Good Taste ")]
        public string GoodTaste { get; set; }

        [JsonProperty("Good Quantity")]
        public string GoodQuantity { get; set; }
        public string Output { get; set; }
        public string Reviews { get; set; }
    }
}