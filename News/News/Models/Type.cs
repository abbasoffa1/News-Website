using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace News.Models
{
    public class Type
    {

        public int Id { get; set; }

        public int CategoryId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public Category Category { get; set; }
    }
}