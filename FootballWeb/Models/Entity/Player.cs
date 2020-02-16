using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballWeb.Models.Entity
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ім'я") ]
        public string FirstName { get; set; }
        [Display(Name = "Прізвище")]
        public string LastName { get; set; }
        [Display(Name = "Вік")]
        public int Age { get; set; }
        [Display(Name = "Національність")]
        public string Nationality { get; set; }
        [Display(Name = "Роль")]
        public string Role { get; set; }
        [Display(Name = "Короткий опис")]
        public string Description { get; set; }
        public int TeamId { get; set; }
        [Display(Name = "Команда")]
        public Team Team { get; set; }
    }
}
