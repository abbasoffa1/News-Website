using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace News.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName ="date")]
        public DateTime Date { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [Column(TypeName = "ntext")]
        public string Quote { get; set; }

        public bool Promoted { get; set; }

        public Category Category { get; set; }

        public Author Author { get; set; }

        public List<Slider> Sliders { get; set; }


    }
}