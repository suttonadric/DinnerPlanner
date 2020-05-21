using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerPlanner.Data.Models
{
    class Recipie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CuisineType Type { get; set; }
        public string Directions { get; set; }
    }
}
