﻿using System;
namespace InterfaceDemo
{
    public class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture()
        {
            Color = "white";
            Material = "wood";
        }

        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
