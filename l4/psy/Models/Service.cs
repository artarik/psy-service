using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace psy.Models
{
    public class Service
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название услуги должно быть в пределах от 3 до 50 символов")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Название услуги")]
        public string Name { get; set; }

        [Range(1000,5000, ErrorMessage = "Введите стоимость в пределах 1000-5000")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Некорретный ввод стоимости") ]
        [Display(Name = "Стоимость услуги")]
        public int Price { get; set; }
        [Display(Name = "Категория услуги")]
        public int? TypeId { get; set; }
        [RegularExpression(@"[0-2][0-4]:[0-5][0-9]:[0-5][0-9]", ErrorMessage ="Некорректный ввод времени")]
        [Display(Name = "Длительность услуги")]
        public TimeSpan Duration { get; set; }
        public Type Type { get; set; }

    }
}