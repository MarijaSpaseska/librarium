using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace librarium.Models
{
    public class Librarian
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
        [RegularExpression(@"^((\+389) [2] \d{4} \d{3})|^((\+389) [7][0125678] \d{3} \d{3})$|^((\+389) [4][2345678] \d{3} \d{3})$|^((\+389) [3][1234] \d{3} \d{3})$", ErrorMessage ="Please enter valid phone number!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Personal number is required!")]
        [Display(Name = "Personal number")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "Please enter valid personal number!")]
        public string PersonalNumber { get; set; }

        [Required(ErrorMessage = "Bank account number is required!")]
        [Display(Name = "Bank account number")]
        [RegularExpression(@"^\d{3}-\d{10}-\d{2}$", ErrorMessage ="Please enter valid bank account number!")]
        public string BankAccountNumber { get; set; }

        public string Education { get; set; }

        [Display(Name = "Date of employment")]
        public string DateOfEmployment { get; set; }
    }
}