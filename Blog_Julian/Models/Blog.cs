using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Julian.Models {
    public class Blog {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        [UIHint("tinymce_jquery_full"), AllowHtml]
        public string BlogPost { get; set; }
    }
}