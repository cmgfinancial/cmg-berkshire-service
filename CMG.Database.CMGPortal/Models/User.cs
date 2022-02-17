using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMG.Database.CMGPortal.Models
{
    [Table("Users", Schema = "dbo")]
    
    public class User
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //public string Name { get; set; }
        public string UserType { get; set; }
        public string CostCenterCode { get; set; }
        public string CostCenterName { get; set; }
        public int CompanyID { get; set; }
        public int ChannelID { get; set; }
        public int? DivisionID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeStatus { get; set; }
        public string CorporateEmail { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PortraitURL { get; set; }
        public string CustomTitle { get; set; }
        public string CustomFullName { get; set; }
        public string CustomEmail { get; set; }
        public string CustomOfficePhone { get; set; }
        public string CustomMobilePhone { get; set; }
        public string CustomFaxPhone { get; set; }
        public string CustomStreetAddress { get; set; }
        public string CustomStreetAddress2 { get; set; }
        public string CustomCity { get; set; }
        public string CustomState { get; set; }
        public string CustomZipCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string SupervisorEmployeeID { get; set; }
        public string Role { get; set; }

        // SOCIAL MEDIA LINKS, MySites table --> To be created in this table.
        public string SocialFacebookUrl { get; set; }
        public string SocialInstagramUrl { get; set; }
        public string SocialLinkedinUrl { get; set; }
        public string SocialTwitterUrl { get; set; }
       // public virtual List<UserBadges> Badges { get; set; }
       // public virtual Member Member { get; set; }
       // public virtual ICollection<UserCms> UserCms { get; set; }
        public bool IsCorrespondent { get; set; }
        public bool IsWholesale { get; set; }
    }
}
