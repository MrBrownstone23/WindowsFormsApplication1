using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApplication1.Enums;

namespace WindowsFormsApplication1.EFModels
{
    [Table("Transaction")]
    public partial class Transaction
    {
        public Transaction()
        {

        }

        public int TransactionID { get; set; }

        public int QuickID { get; set; }

        public int TechID { get; set; }

        public EnumTransactionType? TransactionType { get; set; }
        
        public int Quantity { get; set; }

        public string Destination { get; set; }

        public string Reason { get; set; }

        public DateTime? TimeStamp { get; set; }





    }
}
