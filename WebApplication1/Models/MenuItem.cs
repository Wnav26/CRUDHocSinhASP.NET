﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class MenuItem
    {
        public int Id { get; set; }//Item id
        public string Name { get; set; } //Item name
        public string Link { get; set; } //Item label
    }
}
