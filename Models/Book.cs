using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Models
{
    public class Book
        //This class providesthe details about books like its ID, tittle, discription, price and Author id is a foreign key linked with Author_class table//

    {
        
        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }

        public string Discription { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
