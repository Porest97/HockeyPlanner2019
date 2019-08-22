using System.ComponentModel.DataAnnotations;

namespace HockeyPlanner2019.Models.DataModels
{
    public class GameCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string GameCategoryName { get; set; }
    }
}