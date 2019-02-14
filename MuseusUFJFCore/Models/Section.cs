using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuseusUFJFCore.Models
{
    public class Section
    {
        [Display(Name = "Setor")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é necessário")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Responsável")]
        public string Responsible { get; set; }

        [Display(Name = "Unidade")]
        public Unit Unit { get; set; }

        [Display(Name = "Unidade do setor")]
        public int UnitId { get; set; }

        public ICollection<Collection> Collections { get; set; } = new List<Collection>();

        public Section()
        {

        }

        public Section(int unitId, string name, string responsible, Unit unit)
        {
            Id = unitId;
            Name = name;
            Responsible = responsible;
            Unit = unit;
        }
    }
}
