using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CMG.Database.CMGPortal.Models
{
   
        [Table("MySites")]
        public class MySite
        {
            public int ID { get; set; }

            public int MemberID { get; set; }

            public bool IsPublished { get; set; }

            public string Subdomain { get; set; }

            public string CustomSiteURL { get; set; }

            #region -- MySite Integration --

            public string TestimonialTreeWidgetID { get; set; } //not needed?

            public string HomebotWidgetID { get; set; }
        /// <summary>
        /// The owner of the MySite that holds primary information like Channel, NMLS and address.
        /// </summary>
        public virtual Member Member { get; set; }



        public string PartnerOfficeIDs { get; set; } //separate table?

            #endregion

            #region -- Old MySite Data --

            public string VideoUrl { get; set; }

            public string Experience { get; set; }

            public string Biography { get; set; }

            public string PersonalQuote { get; set; }

            public string AboutUs { get; set; }

            public string MyPhilosophy { get; set; }

            public string Education { get; set; }

            public string Interests { get; set; }

            public string Community { get; set; }

            public string MiscContent { get; set; }
         
            #endregion

            public string AreaOfExpertise { get; set; }
       
    }
   
}
