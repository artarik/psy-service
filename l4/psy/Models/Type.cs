using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace psy.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Display(Name = "Категория услуги")]
        [Required]
        public string TypeName { get; set; }
        public ICollection<Service> Services { get; set; }
        public Type()
        {
            Services = new List<Service>();
        }
    }
}