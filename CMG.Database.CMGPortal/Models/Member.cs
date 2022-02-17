using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMG.Database.CMGPortal.Models
{
    [Table("Members")]
    public class Member
    {
      
        public int ID { get; set; }
        public int MemberType { get; set; }
        public int? ByteUserID { get; set; }
        public string ByteUserName { get; set; }
        public string ByteUserNames { get; set; }
        public string ByteSecurityProfile { get; set; }
        public int? PrimaryBranchID { get; set; }
        public string PrimaryByteRole { get; set; }
        public string NMLS { get; set; }
        public bool ActiveStatus { get; set; }
        public string StatesLicensed { get; set; }
        public string DownloadAppLink { get; set; }
        public string ApplyOnlineURL { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool HasMySite { get; set; }
        public string BerkshireID { get; set; }
        public int? ProductionInUnits { get; set; }
        public decimal? ProductionInDollars { get; set; }
        public string MySitePath { get; set; }
        public string TeamBioDescription { get; set; }
        public int? UserId { get; set; }

       
    }
}
