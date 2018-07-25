using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GojsGraph.Models
{
    public class Vertice
    {
        public int EdgeId { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}