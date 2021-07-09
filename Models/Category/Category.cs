using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OmniCore.Models.Category
{
    public class Category
    {

       public int CategoryId { get; set; }
        public string Categorys { get; set; }

       // [DataType(DataType.Date)]
       // public DateTime ReleaseDate { get; set; }
        public string CategoryCode { get; set; }
        public int UserId { get; set; }
        public int Active { get; set; }

    }

   
}
