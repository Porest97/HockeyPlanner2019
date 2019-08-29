using System.ComponentModel.DataAnnotations;

namespace HockeyPlanner2019.Models.DataModels
{
    public class ReceiptStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ReceiptStatusName { get; set; }
    }
}