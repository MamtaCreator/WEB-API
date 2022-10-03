using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ContactsLib
{
    public class Contact
    {
        [Required]
        [Range(1001, Int32.MaxValue, ErrorMessage = "Contact ID is mandatory and should be greater than 1000")]
        public int ContactId { get; set; }
        [StringLength(maximumLength: 30, MinimumLength = 4, ErrorMessage = "Contact Name should be more than 4 and upto 30 ")]
        public String ContactName { get; set; }
        public String City { get; set; }
        [StringLength(10, ErrorMessage = "Cell number should exactly be of 10 digits")]
        public String CellNo { get; set; }     
    }
}
