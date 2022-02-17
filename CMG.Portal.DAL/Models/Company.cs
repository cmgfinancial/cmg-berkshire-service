namespace CMG.Portal.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Company
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string BrandCode { get; set; }

        public string LogoURL { get; set; }

        public string NMLS { get; set; }

        public string ShareAppLink { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string TTData { get; set; }

        public bool IsWholesale { get; set; }
        public bool IsCorrespondent { get; set; }
        public bool AddBusinessName { get; set; }
        public bool IsNewsHeader { get; set; }
        public bool IsPartnersHeader { get; set; }
        public bool IsTPOHeader { get; set; }
        public string CloudinaryBaseUrl { get; set; }

        public string PortalSettingsJson { get; set; }
        public string CMSBrandCode { get; set; }
        public bool IsJv { get; set; }
        public string Urls { get; set; }
    }
}
