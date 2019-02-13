using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MuseusUFJFCore.Models
{
    public class Collection
    {
        [Display(Name = "Acervo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é necessário")]
        [Display(Name = "Nome do acervo")]
        public string Name { get; set; }

        public Section Section { get; set; }

        public int SectionId { get; set; }

        public Collection()
        {
        }

        public Collection(int unitId, string name)
        {
            Id = unitId;
            Name = name;
        }
    }
}
