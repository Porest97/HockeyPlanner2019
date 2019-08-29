using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyPlanner2019.Models.DataModels.TSMModels.DataModels
{
    public class TSMClub
    {
        public int Id { get; set; }

        public int TSMClubNO { get; set; }

        public string TSMClubName { get; set; }

        public string ShortName { get; set; }


        //Address Props !
        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }
        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

        [Display(Name = "Country")]
        public int? CountryId { get; set; }
        [Display(Name = "Country")]
        [ForeignKey("CountryId")]
        public Country Country { get; set; }



        //Contact Props !
        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }

        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Location Props!
        [Display(Name = "District")]
        public int? DistrictId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [Display(Name = "Covenant")]
        public int? CovenantId { get; set; }
        [Display(Name = "District")]
        [ForeignKey("CovenantId")]
        public Covenant Covenant { get; set; }

        [Display(Name = "Home arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Home arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }
    }
}
