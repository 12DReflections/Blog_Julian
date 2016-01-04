using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Julian.Models {
    public class Blog {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public string BlogPost { get; set; }
    }
}