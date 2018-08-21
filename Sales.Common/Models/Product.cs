

namespace Sales.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Product
    {
        [Key]
        //Agregar referencia data.anottations a Key
        
        public int ProducId { get; set; }

        [Required]
        public string Descripction { get; set; }
        public Decimal Price { get; set; }

        public bool IsAvalaible { get; set; }

        public DateTime PublishOn { get; set; }
    }
}
