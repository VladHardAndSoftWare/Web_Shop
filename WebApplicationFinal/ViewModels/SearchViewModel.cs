﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinal.Data.Models;
using WebApplicationFinal.ViewComponents;

namespace WebApplicationFinal.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Product> getAllSearchCars { get; set; }
        public string SearchValue { get; set; }
        public ShopCartViewModel ShopCartViewModel { get; set; }

    }
}
