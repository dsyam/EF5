using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp_Model.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }

        public int NumberOfPages { get; set; }
        
        public double Weight { get; set; }

        public Book Book { get; set; } //One to one relationship with Book table, since the book table has the foregin key relation with BookDetail table
            //If we want to find the book by book details, we can use this property
    }
}
