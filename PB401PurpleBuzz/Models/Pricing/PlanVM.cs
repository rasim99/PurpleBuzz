﻿namespace PB401PurpleBuzz.Models.Pricing
{
    public class PlanVM
    {
        public string PlanType { get; set; }
        public string Price { get; set; }
        public string UserCount { get; set; }
        public decimal Capacity { get; set; }
        public string Source { get; set; }
        public string Support { get; set; }
        public string? Addition { get; set; }

    }
}