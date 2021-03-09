using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Models
    //This class is about publication details where it tells about publication id, books copies and has a foreign key that is linked with Publisher_detailsClass tabel with its publisher id//
{
    public class Publication
    {
        
        public int Id { get; set; }
        [Required]
        public string Books_Copies { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }


        
    }
}
