﻿using System;


namespace TestModel
{
    public class Car
    {
        public String Name { get; set; }
        public decimal Price { get; set; }
        public double Length { get; set; }
        public bool Sold { get; set; }
        public DateTime Timestamp { get; set; }
        public String CarType { get; set; }
        public String EngineType { get; set; }
        public decimal? Weight { get; set; } 
    }
}
