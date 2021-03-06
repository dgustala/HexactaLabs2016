﻿using System.Collections.Generic;
using System.ComponentModel;
using CapacitacionMVC.Entities;

namespace CapacitacionMVC.FrontEnd.Models
{
    public class GenresViewModel
    {
        public IList<Genre> Genres { get; set; }
        
        [DisplayName("Search genre")]
        public string SearchValue { get; set; }
    }
}