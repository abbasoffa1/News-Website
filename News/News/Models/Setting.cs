using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace News.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Logo { get; set; }

        [StringLength(250)]
        public string Facebook { get; set; }

        [StringLength(250)]
        public string Instagram { get; set; }

        [StringLength(100)]
        public string Gmail { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

    }
}