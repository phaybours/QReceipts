using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QReceipts.Data
{
    public class Receipt
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public string BillToName { get; set; }
        public string BillToCountry { get; set; }
        public string BillToCity { get; set; }
        public string BillToAddress { get; set; }
        public string BillToState { get; set; }
        public string BillToZipCode { get; set; }
        public string BillToPhone { get; set; }
        public string BillToEmail { get; set; }

        public string ShipToName { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToContact { get; set; }
        public string Client { get; set; }
        public string Notes { get; set; }
        public ICollection<ReceiptItem> ReceiptItems { get; set; }

        public string GetBillingAddress()
        {
            return $"{BillToAddress},\n{ BillToCity}\n{BillToState}\n{BillToCountry} ";
        }
        public string GetShippingAddress()
        {
            return $"{ShipToAddress},\n{ShipToCity}\n{ShipToState}\n{ShipToCountry} ";
        }

    }
}
