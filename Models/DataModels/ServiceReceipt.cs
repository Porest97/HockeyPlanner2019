using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyPlanner2019.Models.DataModels
{
    public class ServiceReceipt
    {
        public int Id { get; set; }

        
        //Person providing the service !
        [Display(Name = "Bill From:")]
        public int? PersonId { get; set; }
        [Display(Name = "Bill From:")]
        [ForeignKey("PersonId")]
        public Person ServiceProvider { get; set; }

        //Service !
        [Display(Name = "Service")]
        public int? ServiceId { get; set; }
        [Display(Name = "Service")]
        [ForeignKey("ServiceId")]
        public Service Service { get; set; }


        // Payment Props !
        
        [Display(Name = "Qty")]
        public double Quantity { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public double TotalPayment { get; set; }

        [Display(Name = "Bill To:")]
        public int? CompanyId { get; set; }
        [Display(Name = "Bill To:")]
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Display(Name = "Total Amount Paid")]
        [DataType(DataType.Currency)]
        public double TotalAmountPaid { get; set; }

        [Display(Name = "Total Amount To Pay")]
        [DataType(DataType.Currency)]
        public double TotalAmountToPay { get; set; }

        [Display(Name = "Status")]
        public int? ReceiptStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ReceiptStatusId")]
        public ReceiptStatus ReceiptStatus { get; set; }
    }
}
