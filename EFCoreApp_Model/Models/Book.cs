using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp_Model.Models
{
    public class Book
    {
        [Key]
        public int Book_Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(15)]
        public string ISBN { get; set; }

        [Required]
        public double Price { get; set; }

        [NotMapped]
        public string PriceRange { get; set; }

        //[ForeignKey("Category")]
        //public int Category_Id { get; set; }

        //public Category Category { get; set; }

        //One to one relationship with Books table and BookDetails table
        [ForeignKey("BookDetail")] //Navigation property
        public int BookDetail_Id { get; set; }

        public BookDetail BookDetail { get; set; }

        //One to many relationship with books table and publishers table
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }

        //Many to many relationship with Books table and Authors table
        public ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
