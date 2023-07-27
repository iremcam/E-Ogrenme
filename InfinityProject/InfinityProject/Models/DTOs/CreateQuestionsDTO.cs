using InfinityProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfinityProject.Models.DTOs
{
    public class CreateQuestionsDTO
    {
        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(200)]
        public string Contents { get; set; }


        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(20)]
        public string SubCaregory { get; set; }


        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(20)]
        public Questions_Type questionsType { get; set; }

        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(10)]
       public string chic_a { get; set; }

        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(10)]
        public string chic_b { get; set; }


        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(10)]
        public string chic_c { get; set; }


        [Required(ErrorMessage = "bu alan boş bırakılamaz")]

        [MinLength(3), MaxLength(10)]
        public string chic_d { get; set; }
    }
}
