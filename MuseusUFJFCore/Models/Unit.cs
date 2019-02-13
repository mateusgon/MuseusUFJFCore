using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuseusUFJFCore.Models
{
    public class Unit
    {
        [Key]
        [Display(Name = "Unidade")]
        public int UnitId { get; set; }

        [Required(ErrorMessage = "O campo é necessário")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo endereço é necessário")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }
    }
}
