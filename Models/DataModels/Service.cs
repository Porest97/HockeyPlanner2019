using System.ComponentModel.DataAnnotations;

namespace HockeyPlanner2019.Models.DataModels
{
    public class Service
    {
        public int Id { get; set; }

        [Display(Name="Service")]
        public string ServiceName { get; set; }
    }
}