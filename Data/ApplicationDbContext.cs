using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HockeyPlanner2019.Models.DataModels;
using HockeyPlanner2019.Models.DataModels.TSMModels.DataModels;
using HockeyPlanner2019.Models.DataModels.AccountingModels.DataModels;

namespace HockeyPlanner2019.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HockeyPlanner2019.Models.DataModels.Person> Person { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.Company> Company { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.Club> Club { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.Arena> Arena { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.PersonType> PersonType { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.Game> Game { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.GameCategory> GameCategory { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.GameStatus> GameStatus { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.GameReceipt> GameReceipt { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.ReceiptStatus> ReceiptStatus { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.ServiceReceipt> ServiceReceipt { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.Service> Service { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.TSMModels.DataModels.TSMClub> TSMClub { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.TSMModels.DataModels.City> City { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.TSMModels.DataModels.Country> Country { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.TSMModels.DataModels.Covenant> Covenant { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.TSMModels.DataModels.District> District { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.AccountingModels.DataModels.RefFee> RefFee { get; set; }
        public DbSet<HockeyPlanner2019.Models.DataModels.AccountingModels.DataModels.FeeCategory> FeeCategory { get; set; }
    }
}
