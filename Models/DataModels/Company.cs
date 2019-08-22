using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HockeyPlanner2019.Models.DataModels
{
    public class Company
    {
        public int Id { get; set; }

        public string ComanyName { get; set; }
               
        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

       

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

    }
}