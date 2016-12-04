using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsenalHistoryPostGenerator.Web.Models
{

    public class Paramters
    {
        public string Layout { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Categories { get; set; }
        public string ImagePath { get; set; }
        public string Video { get; set; }
        public string Summary { get; set; }
        public string Permalink { get; set; }
    }
}
