﻿namespace CarShop.Models.Response.Vehicle
{
    public class VehicleResponseModel
    {
        public long Id { get; set; }

        public string Owner { get; set; }

        public string PicturePath { get; set; }

        public string VehicleType { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string PlateNumber { get; set; }

        public long IssueCount { get; set; }
    }
}