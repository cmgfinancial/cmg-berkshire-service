namespace CMG.Portal.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        public int ID { get; set; }

        public int MemberType { get; set; }

        public int? ByteUserID { get; set; }

        public int? PrimaryBranchID { get; set; }

        public string CostCenter { get; set; }

        public int? ManagerID { get; set; }

        public int CompanyID { get; set; }

        public int ChannelID { get; set; }

        public int? DivisionID { get; set; }

        public string EmployeeID { get; set; }

        public string ByteUserName { get; set; }

        public string ByteUserNames { get; set; }

        public string CorporateEmail { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Title { get; set; }

        public string PrimaryByteRole { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string NMLS { get; set; }

        public string PortraitURL { get; set; }

        public bool ActiveStatus { get; set; }

        public string StatesLicensed { get; set; }

        public string DownloadAppLink { get; set; }

        public string ApplyOnlineURL { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public bool HasMySite { get; set; }

        public string BerkshireID { get; set; }

        public int? ProductionInUnits { get; set; }

        public decimal? ProductionInDollars { get; set; }

        public string ByteSecurityProfile { get; set; }

        public string CustomCity { get; set; }

        public string CustomEmail { get; set; }

        public string CustomPhone { get; set; }

        public string CustomState { get; set; }

        public string CustomTitle { get; set; }

        public string CustomZipCode { get; set; }

        public string CustomStreetAddress { get; set; }

        public string CustomFullName { get; set; }

        public string MySitePath { get; set; }
    }
}
