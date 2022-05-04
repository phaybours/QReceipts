using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QReceipts.Data
{
    public class ReceiptItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Recipt")]
        public int ReceiptId { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal LineTotal { get; set; }

    }
}
