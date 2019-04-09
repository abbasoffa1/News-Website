using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Models
{
    public class Author
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Video { get; set; }

        [Column(TypeName ="ntext")]
        public string About { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Photo { get; set; }

        [StringLength(100)]
        public string Job { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}