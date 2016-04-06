using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapacitacionMVC.FrontEnd.Models
{
    public class GenresViewModel
    {
        public List<string> Genres { get; set; }

        public string NameFilter { get; set; }
    }
}