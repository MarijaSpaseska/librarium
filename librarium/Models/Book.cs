using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace librarium.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Picture")]
        public string PictureURL { get; set; }

        [Required(ErrorMessage = "Book title is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Book author is required!")]
        public string Author { get; set; }

        public string Category { get; set; }

        public string Language { get; set; }

        [Required(ErrorMessage ="ISBN is required!")]
        [Display(Name = "ISBN")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "Please enter valid ISBN!")]
        public string Isbn { get; set; }

        public string Publisher { get; set; }

        [Display(Name = "Publication year")]
        [RegularExpression(@"^\d{4}$", ErrorMessage ="Please enter valid year!")]
        public int PublicationYear { get; set; }

        [Display(Name = "Number of pages")]
        [Range(1,int.MaxValue,ErrorMessage ="Number of pages must be greater than 0!")]
        public int NumberOfPages { get; set; }
    }
}