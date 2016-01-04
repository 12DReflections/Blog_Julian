using Blog_Julian.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_Julian.Context {
    public class BlogContext {
        public DbSet<Blog> Blog { get; set; }
    }
}