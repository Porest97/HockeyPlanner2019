using System.ComponentModel.DataAnnotations;

namespace HockeyPlanner2019.Models.DataModels.AccountingModels.DataModels
{
    public class FeeCategory
    {
        public int Id { get; set; }

        [Display(Name ="Fee Category")]
        public string FeeCategoryName { get; set; }
    }
}