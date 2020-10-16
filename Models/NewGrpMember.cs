using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_Eclair.Models
{
    public class NewGrpMember
    {
        [Key]
        public int MemberID { get; set; }

        [Required(ErrorMessage = "Enter Member Name")]
        [Display(Name = "Member Name")]
        public string MemberName { get; set; }

        [Required(ErrorMessage = "Enter Student Number")]
        [Display(Name = "Student Number")]
        public int StudentNo { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Display(Name = "Age")]
        [Range(15, 80)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Member Name")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
