﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class DataBase
    {
        public static List<Product> Products { get; set; } = new List<Product>();
    }
}
