using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int BlogId { get; set; }

        public int PersonId { get; set; }

        [Column(TypeName ="date")]
        public DateTime Date { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        public Person Person { get; set; }

        public Blog Blog { get; set; }
    }
}