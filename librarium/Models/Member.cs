using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace librarium.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required!")]
        public string Surname { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [Display(Name = "Phone number")]
        [RegularExpression(@"^((\+389) [2] \d{4} \d{3})|^((\+389) [7][0125678] \d{3} \d{3})$|^((\+389) [4][2345678] \d{3} \d{3})$|^((\+389) [3][1234] \d{3} \d{3})$", ErrorMessage = "Please enter valid phone number!")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Personal number")]
        [RegularExpression(@"^\d{13}$", ErrorMessage ="Please enter valid personal number!")]
        public string PersonalNumber { get; set; }

        [Required(ErrorMessage = "Membership card ID is required!")]
        [Display(Name="Membership card ID")]
        [RegularExpression(@"^\d{8}$", ErrorMessage ="Membership ID must be 8 digit number!")]
        public string MembershipCardId { get; set; }

    }
}