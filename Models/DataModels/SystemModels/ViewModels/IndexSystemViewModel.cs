using HockeyPlanner2019.Models.DataModels.TSMModels.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyPlanner2019.Models.DataModels.SystemModels.ViewModels
{
    public class IndexSystemViewModel
    {
        public List<City> Cities { get; set; }

        public List<Country> Countries { get; set; }

        public List<Covenant> Covenants { get; set; }

        public List<District> Districts { get; set; }

    }
}
