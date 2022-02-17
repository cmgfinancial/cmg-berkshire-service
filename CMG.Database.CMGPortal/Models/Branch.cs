using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMG.Database.CMGPortal.Models
{  
    [Table("Branches")]
    public class Branch
    {
        public int ID { get; set; }
        public int BranchType { get; set; }
        public int CompanyID { get; set; }
        public int DivisionID { get; set; }
        public string ByteBranchCode { get; set; }
        public string Name { get; set; }
        public string NMLS { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        //public float? Latitude { get; set; }
        //public float? Longitude { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int? BranchManager1ID { get; set; }
        public int? BranchManager2ID { get; set; }
        public string CostCenter { get; set; }
        public bool ActiveStatus { get; set; }
        public string StatesLicensed { get; set; }
        public int ByteOrganizationID { get; set; }

       // #region -- Navigation Properties --
       // [InverseProperty("Branch")]
       //// public virtual ICollection<MemberBranch> MemberBranches { get; set; }
       // #endregion
    }
}
