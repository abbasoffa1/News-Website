using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace News.Models
{
    public class Slider
    {

        public int Id { get; set; }

        [StringLength(250)]
        public string Photo { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}